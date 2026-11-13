using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class dashboardPenjual : Form
    {
        // Dipakai untuk membaca dan memperbarui data pesanan di database.
        private readonly koneksi_db db = new koneksi_db();

        // Menyimpan nomor antrean yang dipilih untuk proses atau pembatalan.
        private string noAntrianTerpilih = "";

        // Menyimpan data pesanan sementara setelah dibaca dari tabel pemesanan.
        private class DataPesanan
        {
            public int IdPesanan { get; set; }
            public int? IdUser { get; set; }
            public string NoAntrian { get; set; }
            public decimal TotalBayar { get; set; }
            public string Status { get; set; }
        }

        // Menyimpan ID detail dan produk agar nama produk bisa dicari setelah reader ditutup.
        private class DataDetailPesanan
        {
            public int IdDetail { get; set; }
            public int IdProduk { get; set; }
        }

        public dashboardPenjual()
        {
            InitializeComponent();

            // Hubungkan tabel dan tombol dengan proses pengelolaan pesanan.
            dgvPesananMasuk.CellClick += dgvPesananMasuk_CellClick;
            btnProses.Click += btnProses_Click;
            btnSelesai.Click += btnSelesai_Click;
            btnTolak.Click += btnTolak_Click;

            // Tampilkan statistik dan pesanan saat dashboard dibuka.
            TampilData();
        }

        // Memuat ulang statistik penjualan dan daftar pesanan yang masuk.
        public void TampilData()
        {
            dgvPesananMasuk.Rows.Clear();
            // Pilihan lama dihapus karena isi tabel akan diganti dengan hasil terbaru.
            noAntrianTerpilih = "";

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Hitung jumlah seluruh pesanan yang tersimpan untuk ringkasan dashboard.
                    string jmlPesanan;
                    using (MySqlCommand cmdPesanan = new MySqlCommand("SELECT COUNT(*) FROM pemesanan", conn))
                    {
                        jmlPesanan = cmdPesanan.ExecuteScalar().ToString();
                    }

                    lblPesananMasuk.Text = jmlPesanan;
                    lblFooterKiri.Text = jmlPesanan + " pesanan hari ini";

                    // Jumlahkan pembayaran dari transaksi yang tanggalnya sama dengan hari ini.
                    object hasilPendapatan;
                    using (MySqlCommand cmdPendapatan = new MySqlCommand("SELECT SUM(total_bayar) FROM pemesanan WHERE DATE(tanggal) = CURDATE()", conn))
                    {
                        hasilPendapatan = cmdPendapatan.ExecuteScalar();
                    }
                    decimal pendapatan = hasilPendapatan == DBNull.Value ? 0 : Convert.ToDecimal(hasilPendapatan);
                    lblPendapatanHariIni.Text = "Rp" + pendapatan.ToString("N0");

                    // Jumlah porsi dihitung dari kolom jumlah pada seluruh detail pesanan.
                    object hasilJumlahTerjual;
                    using (MySqlCommand cmdTerjual = new MySqlCommand("SELECT SUM(jumlah) FROM detail_pesanan", conn))
                    {
                        hasilJumlahTerjual = cmdTerjual.ExecuteScalar();
                    }
                    lblMenuTerjual.Text = hasilJumlahTerjual == DBNull.Value ? "0" : hasilJumlahTerjual.ToString();

                    // Urutkan produk berdasarkan total jumlah terjual dan ambil produk paling atas.
                    string qTerlaris = @"SELECT pr.nama_produk FROM detail_pesanan dp 
                                         JOIN produk pr ON dp.id_produk = pr.id_produk 
                                         GROUP BY dp.id_produk ORDER BY SUM(dp.jumlah) DESC LIMIT 1";
                    object hasilTerlaris;
                    using (MySqlCommand cmdTerlaris = new MySqlCommand(qTerlaris, conn))
                    {
                        hasilTerlaris = cmdTerlaris.ExecuteScalar();
                    }

                    // Tanda strip digunakan jika belum ada produk yang pernah terjual.
                    lblMenuTerlaris.Text = hasilTerlaris != null ? hasilTerlaris.ToString() : "-";

                    // Ambil kolom yang memang tersedia langsung di tabel pemesanan.
                    string queryTabel = @"SELECT id_pemesanan, id_user, no_antrian, total_bayar, status
                                          FROM pemesanan
                                          ORDER BY id_pemesanan DESC";
                    List<DataPesanan> daftarPesanan = new List<DataPesanan>();

                    using (MySqlCommand cmdTabel = new MySqlCommand(queryTabel, conn))
                    {
                        using (MySqlDataReader reader = cmdTabel.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Simpan hasil query dulu agar reader bisa ditutup sebelum query detail dijalankan.
                                daftarPesanan.Add(new DataPesanan
                                {
                                    IdPesanan = Convert.ToInt32(reader["id_pemesanan"]),
                                    IdUser = reader["id_user"] == DBNull.Value
                                        ? (int?)null
                                        : Convert.ToInt32(reader["id_user"]),
                                    NoAntrian = reader["no_antrian"].ToString(),
                                    TotalBayar = Convert.ToDecimal(reader["total_bayar"]),
                                    Status = reader["status"].ToString()
                                });
                            }
                        }
                    }

                    // Ambil nama pelanggan dan menu dengan SELECT sederhana tanpa JOIN.
                    foreach (DataPesanan pesanan in daftarPesanan)
                    {
                        string namaPelanggan = AmbilNamaPelanggan(conn, pesanan.IdUser);
                        string infoMenu = AmbilInfoMenu(conn, pesanan.IdPesanan);

                        dgvPesananMasuk.Rows.Add(
                            pesanan.NoAntrian,
                            namaPelanggan,
                            infoMenu,
                            "Rp" + pesanan.TotalBayar.ToString("N0"),
                            pesanan.Status
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengambil nama pelanggan; pesanan tanpa akun ditampilkan sebagai "Tamu".
        private string AmbilNamaPelanggan(MySqlConnection conn, int? idUser)
        {
            if (!idUser.HasValue)
            {
                return "Tamu";
            }

            const string query = "SELECT nama_lengkap FROM users WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idUser.Value);
                object hasil = cmd.ExecuteScalar();
                return hasil == null || hasil == DBNull.Value ? "Tamu" : hasil.ToString();
            }
        }

        // Mengambil nama menu dan topping untuk satu pesanan.
        private string AmbilInfoMenu(MySqlConnection conn, int idPesanan)
        {
            List<DataDetailPesanan> daftarDetail = new List<DataDetailPesanan>();
            const string query = "SELECT id_detail, id_produk FROM detail_pesanan WHERE id_pesanan = @idPesanan";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idPesanan", idPesanan);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        daftarDetail.Add(new DataDetailPesanan
                        {
                            IdDetail = Convert.ToInt32(reader["id_detail"]),
                            IdProduk = Convert.ToInt32(reader["id_produk"])
                        });
                    }
                }
            }

            List<string> daftarNamaMenu = new List<string>();
            foreach (DataDetailPesanan detail in daftarDetail)
            {
                string namaProduk = AmbilNamaProduk(conn, detail.IdProduk);
                string namaToping = AmbilNamaToping(conn, detail.IdDetail);

                if (namaToping != "")
                {
                    namaProduk += " + " + namaToping;
                }

                daftarNamaMenu.Add(namaProduk);
            }

            return daftarNamaMenu.Count == 0 ? "-" : string.Join(", ", daftarNamaMenu);
        }

        // Mengambil nama produk berdasarkan ID yang tersimpan di detail pesanan.
        private string AmbilNamaProduk(MySqlConnection conn, int idProduk)
        {
            const string query = "SELECT nama_produk FROM produk WHERE id_produk = @idProduk";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@idProduk", idProduk);
                object hasil = cmd.ExecuteScalar();
                return hasil == null || hasil == DBNull.Value ? "Menu tidak ditemukan" : hasil.ToString();
            }
        }

        // Mengambil nama topping; string kosong berarti menu tidak memakai topping.
        private string AmbilNamaToping(MySqlConnection conn, int idDetail)
        {
            const string queryIdToping = "SELECT id_toping FROM detail_toping WHERE id_detail = @idDetail";
            object hasilIdToping;

            using (MySqlCommand cmd = new MySqlCommand(queryIdToping, conn))
            {
                cmd.Parameters.AddWithValue("@idDetail", idDetail);
                hasilIdToping = cmd.ExecuteScalar();
            }

            if (hasilIdToping == null || hasilIdToping == DBNull.Value)
            {
                return "";
            }

            const string queryNamaToping = "SELECT nama_toping FROM toping WHERE id_toping = @idToping";
            using (MySqlCommand cmd = new MySqlCommand(queryNamaToping, conn))
            {
                cmd.Parameters.AddWithValue("@idToping", hasilIdToping);
                object namaToping = cmd.ExecuteScalar();
                return namaToping == null || namaToping == DBNull.Value ? "" : namaToping.ToString();
            }
        }

        private void dgvPesananMasuk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik header atau baris kosong karena tidak memiliki nomor antrean.
            if (e.RowIndex >= 0 && dgvPesananMasuk.Rows[e.RowIndex].Cells[0].Value != null)
            {
                noAntrianTerpilih = dgvPesananMasuk.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void UbahStatusPesanan(string statusBaru)
        {
            // Jika belum ada pilihan dari event klik, gunakan baris yang sedang aktif di tabel.
            if (noAntrianTerpilih == "" && dgvPesananMasuk.CurrentRow != null && dgvPesananMasuk.CurrentRow.Cells[0].Value != null)
            {
                noAntrianTerpilih = dgvPesananMasuk.CurrentRow.Cells[0].Value.ToString();
            }

            if (noAntrianTerpilih == "")
            {
                // Jangan mengirim perubahan status tanpa target pesanan yang jelas.
                MessageBox.Show("Pilih baris pesanan di tabel terlebih dahulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE pemesanan SET status = @status WHERE no_antrian = @no";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", statusBaru);
                        cmd.Parameters.AddWithValue("@no", noAntrianTerpilih);
                        cmd.ExecuteNonQuery();
                    }

                    // Muat ulang dashboard agar status terbaru langsung terlihat.
                    TampilData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            // Ubah status pesanan menjadi sedang diproses.
            UbahStatusPesanan("diproses");
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            // Tandai pesanan sebagai selesai.
            UbahStatusPesanan("selesai");
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            // Ambil nomor antrean dari baris aktif jika belum dipilih lewat klik tabel.
            if (noAntrianTerpilih == "" && dgvPesananMasuk.CurrentRow != null && dgvPesananMasuk.CurrentRow.Cells[0].Value != null)
            {
                noAntrianTerpilih = dgvPesananMasuk.CurrentRow.Cells[0].Value.ToString();
            }

            if (noAntrianTerpilih == "")
            {
                // Pembatalan harus memiliki pesanan yang dipilih sebagai target.
                MessageBox.Show("Pilih baris pesanan yang ingin dibatalkan!");
                return;
            }

            DialogResult tanya = MessageBox.Show("Yakin ingin membatalkan pesanan " + noAntrianTerpilih + "?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
                // Hapus pesanan hanya setelah pengguna menyetujui dialog konfirmasi.
                try
                {
                    using (MySqlConnection conn = db.GetConnection())
                    {
                        conn.Open();
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM pemesanan WHERE no_antrian = @no", conn);
                        cmd.Parameters.AddWithValue("@no", noAntrianTerpilih);
                        cmd.ExecuteNonQuery();
                    }
                    TampilData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
