using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormRiwayat : Form
    {
        koneksi_db db = new koneksi_db();

        public FormRiwayat()
        {
            InitializeComponent();

            cmbFilterStatus.Items.Clear();
            cmbFilterStatus.Items.AddRange(new object[] { "Semua", "baru", "diproses", "selesai" });
            cmbFilterStatus.SelectedIndex = 0;

            btnCari.Click += btnCari_Click;

            TampilRiwayat();
        }

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

                    if (cmbFilterStatus.Text != "Semua" && cmbFilterStatus.Text != "")
                    {
                        query += " AND pm.status = @status";
                    }

                    query += " ORDER BY pm.id_pemesanan DESC";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                    cmd.Parameters.AddWithValue("@status", cmbFilterStatus.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
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
            TampilRiwayat();
        }
    }
}
