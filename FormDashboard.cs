using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormDashboard : Form
    {
        // Digunakan untuk mengambil data pesanan milik pengguna yang sedang login.
        private readonly koneksi_db db = new koneksi_db();

        public FormDashboard()
        {
            InitializeComponent();

            // Hubungkan tombol dashboard dengan navigasi ke pemesanan dan riwayat.
            btnPesanSekarang.Click += btnPesanSekarang_Click;
            btnLihatRiwayat.Click += btnLihatRiwayat_Click;

            // Tampilkan ringkasan dan daftar pesanan saat dashboard dibuat.
            TampilData();
        }

        // Memuat ringkasan belanja dan daftar produk yang pernah dipesan pengguna.
        public void TampilData()
        {
            dgvPesananKamu.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Pesanan aktif adalah pesanan pengguna yang statusnya belum selesai.
                    using (MySqlCommand cmdAktif = new MySqlCommand("SELECT COUNT(*) FROM pemesanan WHERE id_user = @uid AND status != 'selesai'", conn))
                    {
                        cmdAktif.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                        lblPesananAktif.Text = cmdAktif.ExecuteScalar().ToString();
                    }

                    // Hitung semua pesanan yang pernah dibuat oleh pengguna ini.
                    using (MySqlCommand cmdTotal = new MySqlCommand("SELECT COUNT(*) FROM pemesanan WHERE id_user = @uid", conn))
                    {
                        cmdTotal.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                        lblTotalPesanan.Text = cmdTotal.ExecuteScalar().ToString();
                    }

                    // COALESCE menampilkan nol jika pengguna belum memiliki transaksi.
                    using (MySqlCommand cmdBelanja = new MySqlCommand("SELECT COALESCE(SUM(total_bayar), 0) FROM pemesanan WHERE id_user = @uid", conn))
                    {
                        cmdBelanja.Parameters.AddWithValue("@uid", koneksi_db.UserId);
                        lblTotalBelanja.Text = "Rp " + Convert.ToDecimal(cmdBelanja.ExecuteScalar()).ToString("N0");
                    }

                    // Gabungkan detail pesanan dengan produk dan kategori untuk menampilkan nama yang mudah dikenali.
                    string query = @"SELECT pr.nama_produk, k.nama_kategori, dp.subtotal 
                                     FROM pemesanan pm
                                     JOIN detail_pesanan dp ON dp.id_pesanan = pm.id_pemesanan
                                     JOIN produk pr ON dp.id_produk = pr.id_produk
                                     LEFT JOIN kategori k ON pr.id_kategori = k.id_kategori
                                     WHERE pm.id_user = @uid
                                     ORDER BY pm.id_pemesanan DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", koneksi_db.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnPesanSekarang_Click(object sender, EventArgs e)
        {
            // Pastikan dashboard dibuka di dalam navigasi pembeli sebelum berpindah halaman.
            if (this.MdiParent is formNav nav)
            {
                nav.BukaPesan();
            }
        }

        private void btnLihatRiwayat_Click(object sender, EventArgs e)
        {
            // Gunakan form navigasi induk untuk menampilkan halaman riwayat.
            if (this.MdiParent is formNav nav)
            {
                nav.BukaRiwayat();
            }
        }
    }
}
