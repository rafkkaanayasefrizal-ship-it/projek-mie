using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormPesan : Form
    {
        // Dipakai untuk membaca menu dan menyimpan pesanan ke database.
        private readonly koneksi_db db = new koneksi_db();

        // Menyimpan informasi menu terpilih untuk perhitungan dan isi keranjang.
        private int idProdukDipilih = 0;
        private string namaProdukDipilih = "";
        private decimal hargaProdukDipilih = 0;

        // Menyimpan akumulasi subtotal semua item yang ada di keranjang.
        private decimal totalBayar = 0;

        public FormPesan()
        {
            InitializeComponent();

            // Samakan tampilan label dengan total awal sebelum ada item di keranjang.
            lblTotalBayar.Text = "Rp 0";

            // Jumlah pesanan minimal satu porsi.
            numJumlah.Minimum = 1;
            numJumlah.Value = 1;

            dgvMenu.CellClick += dgvMenu_CellClick;
            numJumlah.ValueChanged += (s, e) => HitungSubtotal();
            rbTelur.CheckedChanged += (s, e) => HitungSubtotal();
            rbPilus.CheckedChanged += (s, e) => HitungSubtotal();

            btnTambahPesanan.Click += btnTambahPesanan_Click;
            btnHapusItem.Click += btnHapusItem_Click;
            btnCheckout.Click += btnCheckout_Click;

            // Tampilkan menu yang masih memiliki stok untuk dipesan.
            TampilMenu();
        }

        // Mengambil menu yang stoknya masih tersedia untuk ditampilkan kepada pembeli.
        public void TampilMenu()
        {
            dgvMenu.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT p.id_produk, p.nama_produk, k.nama_kategori, p.harga 
                                     FROM produk p 
                                     LEFT JOIN kategori k ON p.id_kategori = k.id_kategori
                                     WHERE p.stok > 0";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idx = dgvMenu.Rows.Add(
                                    reader["nama_produk"],
                                    reader["nama_kategori"],
                                    reader["harga"]
                                );
                                // Tag menyimpan ID produk tanpa perlu menambah kolom yang terlihat di tabel.
                                dgvMenu.Rows[idx].Tag = reader["id_produk"];
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Menyimpan pilihan menu dari tabel untuk dipakai saat menghitung subtotal.
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik pada header atau baris kosong karena bukan data menu.
            if (e.RowIndex >= 0 && dgvMenu.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                idProdukDipilih = Convert.ToInt32(row.Tag);
                namaProdukDipilih = row.Cells[0].Value.ToString();
                hargaProdukDipilih = Convert.ToDecimal(row.Cells[2].Value);

                HitungSubtotal();
            }
        }

        // Menghitung harga menu dan topping dikalikan jumlah porsi yang dipilih.
        private decimal HitungSubtotal()
        {
            decimal hargaToping = 0;
            // Harga topping mengikuti pilihan radio button yang aktif.
            if (rbTelur.Checked) hargaToping = 3000;
            if (rbPilus.Checked) hargaToping = 2000;

            decimal subtotal = (hargaProdukDipilih + hargaToping) * numJumlah.Value;
            lblSubtotal.Text = "Rp " + subtotal.ToString("N0");
            return subtotal;
        }

        // Menambahkan menu terpilih beserta pilihan topping ke keranjang sementara.
        private void btnTambahPesanan_Click(object sender, EventArgs e)
        {
            if (idProdukDipilih == 0)
            {
                MessageBox.Show("Pilih menu mie di tabel atas dulu!");
                return;
            }

            string toping = "Tanpa Toping";
            // Simpan nama topping sebagai label keranjang agar bisa ditampilkan dan diproses saat checkout.
            if (rbTelur.Checked) toping = "Telur";
            if (rbPilus.Checked) toping = "Pilus";

            int jumlah = (int)numJumlah.Value;
            decimal subtotal = HitungSubtotal();

            int idx = dgvKeranjang.Rows.Add(namaProdukDipilih, toping, jumlah, subtotal);
            // Simpan ID produk pada Tag karena ID tidak ditampilkan sebagai kolom keranjang.
            dgvKeranjang.Rows[idx].Tag = idProdukDipilih;

            // Tambahkan subtotal item baru ke total keseluruhan keranjang.
            totalBayar += subtotal;
            lblTotalBayar.Text = "Rp " + totalBayar.ToString("N0");
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            // Kurangi total hanya jika ada baris item yang dipilih untuk dihapus.
            if (dgvKeranjang.CurrentRow != null && dgvKeranjang.Rows.Count > 0)
            {
                decimal sub = Convert.ToDecimal(dgvKeranjang.CurrentRow.Cells[3].Value);
                totalBayar -= sub;
                lblTotalBayar.Text = "Rp " + totalBayar.ToString("N0");

                dgvKeranjang.Rows.RemoveAt(dgvKeranjang.CurrentRow.Index);
            }
        }

        // Menyimpan pesanan utama, detail item, topping, lalu memperbarui stok produk.
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvKeranjang.Rows.Count == 0)
            {
                // Checkout tidak dapat dilakukan jika belum ada item yang dipesan.
                MessageBox.Show("Keranjang pesanan masih kosong!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Buat nomor antrean dari ID pesanan terbesar yang sudah tersimpan.
                    int urut;
                    using (MySqlCommand cmdNext = new MySqlCommand("SELECT COALESCE(MAX(id_pemesanan), 0) + 1 FROM pemesanan", conn))
                    {
                        urut = Convert.ToInt32(cmdNext.ExecuteScalar());
                    }

                    string noAntrian = "M-" + urut;

                    // Langkah 1: simpan data utama pesanan dan ambil ID yang dibuat database.
                    string qPemesanan = "INSERT INTO pemesanan (no_antrian, id_user, tanggal, total_bayar, status) VALUES (@no, @uid, NOW(), @total, 'baru')";
                    long idPesananBaru;
                    using (MySqlCommand cmdPesan = new MySqlCommand(qPemesanan, conn))
                    {
                        cmdPesan.Parameters.AddWithValue("@no", noAntrian);
                        cmdPesan.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                        cmdPesan.Parameters.AddWithValue("@total", totalBayar);
                        cmdPesan.ExecuteNonQuery();
                        idPesananBaru = cmdPesan.LastInsertedId;
                    }

                    // Langkah 2: simpan setiap item keranjang sebagai detail dari pesanan utama.
                    foreach (DataGridViewRow row in dgvKeranjang.Rows)
                    {
                        // Abaikan baris kosong otomatis yang disediakan DataGridView.
                        if (row.Cells[0].Value == null) continue;

                        int idProd = Convert.ToInt32(row.Tag);
                        string namaTop = row.Cells[1].Value.ToString();
                        int jml = Convert.ToInt32(row.Cells[2].Value);
                        decimal sub = Convert.ToDecimal(row.Cells[3].Value);

                        string qDetail = "INSERT INTO detail_pesanan (id_pesanan, id_produk, jumlah, subtotal) VALUES (@idPesan, @idProd, @jml, @sub)";
                        long idDetailBaru;
                        using (MySqlCommand cmdDetail = new MySqlCommand(qDetail, conn))
                        {
                            cmdDetail.Parameters.AddWithValue("@idPesan", idPesananBaru);
                            cmdDetail.Parameters.AddWithValue("@idProd", idProd);
                            cmdDetail.Parameters.AddWithValue("@jml", jml);
                            cmdDetail.Parameters.AddWithValue("@sub", sub);
                            cmdDetail.ExecuteNonQuery();
                            idDetailBaru = cmdDetail.LastInsertedId;
                        }

                        if (namaTop == "Telur" || namaTop == "Pilus")
                        {
                            // ID dan harga dipilih berdasarkan jenis topping yang disimpan di keranjang.
                            int idTop = namaTop == "Telur" ? 1 : 2;
                            decimal hrgTop = namaTop == "Telur" ? 3000 : 2000;
                            using (MySqlCommand cmdTop = new MySqlCommand("INSERT INTO detail_toping (id_detail, id_toping, harga) VALUES (@idDet, @idTop, @hrg)", conn))
                            {
                                cmdTop.Parameters.AddWithValue("@idDet", idDetailBaru);
                                cmdTop.Parameters.AddWithValue("@idTop", idTop);
                                cmdTop.Parameters.AddWithValue("@hrg", hrgTop);
                                cmdTop.ExecuteNonQuery();
                            }
                        }

                        // Kurangi stok sesuai jumlah porsi yang masuk ke detail pesanan.
                        using (MySqlCommand cmdStok = new MySqlCommand("UPDATE produk SET stok = stok - @jml WHERE id_produk = @idProd", conn))
                        {
                            cmdStok.Parameters.AddWithValue("@jml", jml);
                            cmdStok.Parameters.AddWithValue("@idProd", idProd);
                            cmdStok.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Pesanan berhasil dibuat! No Antrean: " + noAntrian);

                    // Kosongkan keranjang dan perbarui menu setelah checkout berhasil.
                    dgvKeranjang.Rows.Clear();
                    totalBayar = 0;
                    lblTotalBayar.Text = "Rp 0";
                    TampilMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checkout: " + ex.Message);
            }
        }
    }
}
