using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormRiwayat : Form
    {
        // Digunakan untuk mengambil riwayat milik pengguna yang sedang login.
        private readonly koneksi_db db = new koneksi_db();

        public FormRiwayat()
        {
            InitializeComponent();

            // Pilihan status digunakan untuk menyaring riwayat yang ditampilkan.
            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.AddRange(new object[] { "Semua", "baru", "diproses", "selesai" });
            cmbFilterStatus.SelectedIndex = 0;

            btnCari.Click += btnCari_Click;

            // Tampilkan seluruh riwayat pertama kali, karena pilihan awal adalah "Semua".
            TampilRiwayat();
        }

        // Mengambil riwayat pesanan pengguna dan menghitung total dari baris yang ditampilkan.
        public void TampilRiwayat()
        {
            dgvRiwayat.Rows.Clear();
            decimal totalBelanja = 0;

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = @"SELECT pm.no_antrian, pm.tanggal, pr.nama_produk, dp.subtotal, pm.status 
                                     FROM pemesanan pm
                                     LEFT JOIN detail_pesanan dp ON dp.id_pesanan = pm.id_pemesanan
                                     LEFT JOIN produk pr ON dp.id_produk = pr.id_produk
                                     WHERE pm.id_user = @uid";

                    // Simpan pilihan ini agar query dan parameter status menggunakan kondisi yang sama.
                    bool pakaiFilterStatus = cmbFilterStatus.Text != "Semua" && cmbFilterStatus.Text != "";

                    // Tambahkan filter status hanya jika pengguna memilih status tertentu.
                    if (pakaiFilterStatus)
                    {
                        query += " AND pm.status = @status";
                    }

                    query += " ORDER BY pm.id_pemesanan DESC";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", koneksi_db.UserId);

                        // Parameter status hanya digunakan ketika filter bukan "Semua".
                        if (pakaiFilterStatus)
                        {
                            cmd.Parameters.AddWithValue("@status", cmbFilterStatus.Text);
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // LEFT JOIN dapat menghasilkan subtotal kosong, sehingga nilainya dianggap nol.
                                decimal sub = reader["subtotal"] != DBNull.Value ? Convert.ToDecimal(reader["subtotal"]) : 0;
                                totalBelanja += sub;

                                dgvRiwayat.Rows.Add(
                                    reader["no_antrian"],
                                    reader["tanggal"],
                                    reader["nama_produk"],
                                    "Rp " + sub.ToString("N0"),
                                    reader["status"]
                                );
                            }
                        }
                    }

                    // Tampilkan jumlah subtotal dari riwayat yang sedang terlihat.
                    lblTotalBelanja.Text = "Rp " + totalBelanja.ToString("N0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // Muat ulang data setelah pengguna memilih filter status.
            TampilRiwayat();
        }
    }
}
