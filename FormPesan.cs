using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormPesan : Form
    {
        // Koneksi database dan variabel untuk menyimpan menu yang sedang dipilih.
        koneksi_db db = new koneksi_db();

        int idProdukDipilih = 0;
        string namaProdukDipilih = "";
        decimal hargaProdukDipilih = 0;
        decimal totalBayar = 0;

        // Menyiapkan kontrol pemesanan dan menghubungkan event setiap kontrol.
        public FormPesan()
        {
            InitializeComponent();

            numJumlah.Minimum = 1;
            numJumlah.Value = 1;

            dgvMenu.CellClick += dgvMenu_CellClick;
            numJumlah.ValueChanged += (s, e) => HitungSubtotal();
            rbTelur.CheckedChanged += (s, e) => HitungSubtotal();
            rbPilus.CheckedChanged += (s, e) => HitungSubtotal();

            btnTambahPesanan.Click += btnTambahPesanan_Click;
            btnHapusItem.Click += btnHapusItem_Click;
            btnCheckout.Click += btnCheckout_Click;

            TampilMenu();
        }

        public void TampilMenu()
        {
            // Memuat menu yang stoknya masih tersedia ke dalam tabel.
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
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int idx = dgvMenu.Rows.Add(
                            reader["nama_produk"],
                            reader["nama_kategori"],
                            reader["harga"]
                        );
                        dgvMenu.Rows[idx].Tag = reader["id_produk"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Menyimpan informasi menu ketika pengguna memilih salah satu baris.
            if (e.RowIndex >= 0 && dgvMenu.Rows[e.RowIndex].Cells[0].Value != null)
            {
                DataGridViewRow row = dgvMenu.Rows[e.RowIndex];
                idProdukDipilih = Convert.ToInt32(row.Tag);
                namaProdukDipilih = row.Cells[0].Value.ToString();
                hargaProdukDipilih = Convert.ToDecimal(row.Cells[2].Value);

                HitungSubtotal();
            }
        }

        private decimal HitungSubtotal()
        {
            // Menghitung harga menu, toping, dan jumlah pesanan.
            decimal hargaToping = 0;
            if (rbTelur.Checked) hargaToping = 3000;
            if (rbPilus.Checked) hargaToping = 2000;

            decimal subtotal = (hargaProdukDipilih + hargaToping) * numJumlah.Value;
            lblSubtotal.Text = "Rp " + subtotal.ToString("N0");
            return subtotal;
        }

        private void btnTambahPesanan_Click(object sender, EventArgs e)
        {
            // Menambahkan menu yang dipilih ke keranjang belanja.
            if (idProdukDipilih == 0)
            {
                MessageBox.Show("Pilih menu mie di tabel atas dulu!");
                return;
            }

            string toping = "Tanpa Toping";
            if (rbTelur.Checked) toping = "Telur";
            if (rbPilus.Checked) toping = "Pilus";

            int jumlah = (int)numJumlah.Value;
            decimal subtotal = HitungSubtotal();

            int idx = dgvKeranjang.Rows.Add(namaProdukDipilih, toping, jumlah, subtotal);
            dgvKeranjang.Rows[idx].Tag = idProdukDipilih;

            totalBayar += subtotal;
            lblTotalBayar.Text = "Rp " + totalBayar.ToString("N0");
        }

        private void btnHapusItem_Click(object sender, EventArgs e)
        {
            // Menghapus item terpilih dari keranjang dan mengurangi total pembayaran.
            if (dgvKeranjang.CurrentRow != null && dgvKeranjang.Rows.Count > 0)
            {
                decimal sub = Convert.ToDecimal(dgvKeranjang.CurrentRow.Cells[3].Value);
                totalBayar -= sub;
                lblTotalBayar.Text = "Rp " + totalBayar.ToString("N0");

                dgvKeranjang.Rows.RemoveAt(dgvKeranjang.CurrentRow.Index);
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // Menyimpan pesanan, detail pesanan, toping, dan mengurangi stok produk.
            if (dgvKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang pesanan masih kosong!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    MySqlCommand cmdNext = new MySqlCommand("SELECT COALESCE(MAX(id_pemesanan), 0) + 1 FROM pemesanan", conn);
                    int urut = Convert.ToInt32(cmdNext.ExecuteScalar());
                    string noAntrian = "M-" + urut;

                    // Menyimpan informasi utama pesanan terlebih dahulu.
                    string qPemesanan = "INSERT INTO pemesanan (no_antrian, id_user, tanggal, total_bayar, status) VALUES (@no, @uid, NOW(), @total, 'baru')";
                    MySqlCommand cmdPesan = new MySqlCommand(qPemesanan, conn);
                    cmdPesan.Parameters.AddWithValue("@no", noAntrian);
                    cmdPesan.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                    cmdPesan.Parameters.AddWithValue("@total", totalBayar);
                    cmdPesan.ExecuteNonQuery();

                    long idPesananBaru = cmdPesan.LastInsertedId;

                    // Menyimpan setiap item keranjang ke detail pesanan dan mengurangi stok.
                    foreach (DataGridViewRow row in dgvKeranjang.Rows)
                    {
                        if (row.Cells[0].Value == null) continue;

                        int idProd = Convert.ToInt32(row.Tag);
                        string namaTop = row.Cells[1].Value.ToString();
                        int jml = Convert.ToInt32(row.Cells[2].Value);
                        decimal sub = Convert.ToDecimal(row.Cells[3].Value);

                        string qDetail = "INSERT INTO detail_pesanan (id_pesanan, id_produk, jumlah, subtotal) VALUES (@idPesan, @idProd, @jml, @sub)";
                        MySqlCommand cmdDetail = new MySqlCommand(qDetail, conn);
                        cmdDetail.Parameters.AddWithValue("@idPesan", idPesananBaru);
                        cmdDetail.Parameters.AddWithValue("@idProd", idProd);
                        cmdDetail.Parameters.AddWithValue("@jml", jml);
                        cmdDetail.Parameters.AddWithValue("@sub", sub);
                        cmdDetail.ExecuteNonQuery();

                        long idDetailBaru = cmdDetail.LastInsertedId;

                        // Mencari ID toping berdasarkan nama agar sesuai dengan data database.
                        if (namaTop != "Tanap Toping" && namaTop != "Tanpa Toping")
                        {
                            // Mengambil ID dan harga toping yang sebenarnya.
                            string qCariToping = "SELECT id_toping, harga FROM toping WHERE nama_toping = @namaTop";
                            MySqlCommand cmdCariTop = new MySqlCommand(qCariToping, conn);
                            cmdCariTop.Parameters.AddWithValue("@namaTop", namaTop);

                            using (MySqlDataReader rTop = cmdCariTop.ExecuteReader())
                            {
                                if (rTop.Read())
                                {
                                    int idTop = Convert.ToInt32(rTop["id_toping"]);
                                    decimal hrgTop = Convert.ToDecimal(rTop["harga"]);
                                    rTop.Close(); // Tutup reader sebelum eksekusi command lain

                                    // Menyimpan toping yang dipilih ke detail pesanan.
                                    string qTop = "INSERT INTO detail_toping (id_detail, id_toping, harga) VALUES (@idDet, @idTop, @hrg)";
                                    MySqlCommand cmdTop = new MySqlCommand(qTop, conn);
                                    cmdTop.Parameters.AddWithValue("@idDet", idDetailBaru);
                                    cmdTop.Parameters.AddWithValue("@idTop", idTop);
                                    cmdTop.Parameters.AddWithValue("@hrg", hrgTop);
                                    cmdTop.ExecuteNonQuery();
                                }
                            }
                        }

                        // Stok dikurangi sesuai jumlah produk yang dibeli.
                        MySqlCommand cmdStok = new MySqlCommand("UPDATE produk SET stok = stok - @jml WHERE id_produk = @idProd", conn);
                        cmdStok.Parameters.AddWithValue("@jml", jml);
                        cmdStok.Parameters.AddWithValue("@idProd", idProd);
                        cmdStok.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pesanan berhasil dibuat! No Antrean: " + noAntrian);

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

        private void rbTelur_CheckedChanged(object sender, EventArgs e)
        {
            // Perubahan toping dihitung melalui event CheckedChanged yang didaftarkan di constructor.
        }
    }
}