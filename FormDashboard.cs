using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormDashboard : Form
    {
        koneksi_db db = new koneksi_db();

        public FormDashboard()
        {
            InitializeComponent();

            btnPesanSekarang.Click += btnPesanSekarang_Click;
            btnLihatRiwayat.Click += btnLihatRiwayat_Click;

            TampilData();
        }

        public void TampilData()
        {
            dgvPesananKamu.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Hitung pesanan aktif milik pembeli
                    MySqlCommand cmdAktif = new MySqlCommand("SELECT COUNT(*) FROM pemesanan WHERE id_user = @uid AND status != 'selesai'", conn);
                    cmdAktif.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                    lblPesananAktif.Text = cmdAktif.ExecuteScalar().ToString();

                    // Hitung total pesanan
                    MySqlCommand cmdTotal = new MySqlCommand("SELECT COUNT(*) FROM pemesanan WHERE id_user = @uid", conn);
                    cmdTotal.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                    lblTotalPesanan.Text = cmdTotal.ExecuteScalar().ToString();

                    // Hitung total belanja
                    MySqlCommand cmdBelanja = new MySqlCommand("SELECT COALESCE(SUM(total_bayar), 0) FROM pemesanan WHERE id_user = @uid", conn);
                    cmdBelanja.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                    lblTotalBelanja.Text = "Rp " + Convert.ToDecimal(cmdBelanja.ExecuteScalar()).ToString("N0");

                    // Tampilkan pesanan ke tabel
                    string query = @"SELECT pr.nama_produk, k.nama_kategori, dp.subtotal 
                                     FROM pemesanan pm
                                     JOIN detail_pesanan dp ON dp.id_pesanan = pm.id_pemesanan
                                     JOIN produk pr ON dp.id_produk = pr.id_produk
                                     LEFT JOIN kategori k ON pr.id_kategori = k.id_kategori
                                     WHERE pm.id_user = @uid
                                     ORDER BY pm.id_pemesanan DESC";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@uid", koneksi_db.UserId);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvPesananKamu.Rows.Add(
                            reader["nama_produk"],
                            reader["nama_kategori"],
                            "Rp " + Convert.ToDecimal(reader["subtotal"]).ToString("N0")
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPesanSekarang_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is formNav nav)
            {
                nav.BukaPesan();
            }
        }

        private void btnLihatRiwayat_Click(object sender, EventArgs e)
        {
            if (this.MdiParent is formNav nav)
            {
                nav.BukaRiwayat();
            }
        }
    }
}
