using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class dashboardPenjual : Form
    {
        koneksi_db db = new koneksi_db();
        string noAntrianTerpilih = "";

        public dashboardPenjual()
        {
            InitializeComponent();

            dgvPesananMasuk.CellClick += dgvPesananMasuk_CellClick;
            btnProses.Click += btnProses_Click;
            btnSelesai.Click += btnSelesai_Click;
            btnTolak.Click += btnTolak_Click;

            TampilData();
        }

        public void TampilData()
        {
            dgvPesananMasuk.Rows.Clear();
            noAntrianTerpilih = "";

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Hitung total pesanan masuk
                    MySqlCommand cmdPesanan = new MySqlCommand("SELECT COUNT(*) FROM pemesanan", conn);
                    string jmlPesanan = cmdPesanan.ExecuteScalar().ToString();
                    lblPesananMasuk.Text = jmlPesanan;
                    lblFooterKiri.Text = jmlPesanan + " pesanan hari ini";

                    // Hitung pendapatan hari ini
                    MySqlCommand cmdPendapatan = new MySqlCommand("SELECT COALESCE(SUM(total_bayar), 0) FROM pemesanan WHERE DATE(tanggal) = CURDATE()", conn);
                    lblPendapatanHariIni.Text = "Rp" + Convert.ToDecimal(cmdPendapatan.ExecuteScalar()).ToString("N0");

                    // Hitung total porsi terjual
                    MySqlCommand cmdTerjual = new MySqlCommand("SELECT COALESCE(SUM(jumlah), 0) FROM detail_pesanan", conn);
                    lblMenuTerjual.Text = cmdTerjual.ExecuteScalar().ToString();

                    // Cari menu terlaris
                    string qTerlaris = @"SELECT pr.nama_produk FROM detail_pesanan dp 
                                         JOIN produk pr ON dp.id_produk = pr.id_produk 
                                         GROUP BY dp.id_produk ORDER BY SUM(dp.jumlah) DESC LIMIT 1";
                    MySqlCommand cmdTerlaris = new MySqlCommand(qTerlaris, conn);
                    object hasilTerlaris = cmdTerlaris.ExecuteScalar();
                    lblMenuTerlaris.Text = hasilTerlaris != null ? hasilTerlaris.ToString() : "-";

                    // Tampilkan daftar pesanan masuk ke tabel
                    string queryTabel = @"SELECT pm.no_antrian, COALESCE(u.nama_lengkap, 'Tamu') AS pelanggan, 
                                          CONCAT(pr.nama_produk, IF(t.nama_toping IS NOT NULL, CONCAT(' + ', t.nama_toping), '')) AS info_menu, 
                                          pm.total_bayar, pm.status 
                                          FROM pemesanan pm
                                          LEFT JOIN users u ON pm.id_user = u.id
                                          LEFT JOIN detail_pesanan dp ON dp.id_pesanan = pm.id_pemesanan
                                          LEFT JOIN produk pr ON dp.id_produk = pr.id_produk
                                          LEFT JOIN detail_toping dt ON dt.id_detail = dp.id_detail
                                          LEFT JOIN toping t ON dt.id_toping = t.id_toping
                                          ORDER BY pm.id_pemesanan DESC";
                    MySqlCommand cmdTabel = new MySqlCommand(queryTabel, conn);
                    MySqlDataReader reader = cmdTabel.ExecuteReader();

                    while (reader.Read())
                    {
                        dgvPesananMasuk.Rows.Add(
                            reader["no_antrian"],
                            reader["pelanggan"],
                            reader["info_menu"],
                            "Rp" + Convert.ToDecimal(reader["total_bayar"]).ToString("N0"),
                            reader["status"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvPesananMasuk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPesananMasuk.Rows[e.RowIndex].Cells[0].Value != null)
            {
                noAntrianTerpilih = dgvPesananMasuk.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void UbahStatusPesanan(string statusBaru)
        {
            if (noAntrianTerpilih == "" && dgvPesananMasuk.CurrentRow != null && dgvPesananMasuk.CurrentRow.Cells[0].Value != null)
            {
                noAntrianTerpilih = dgvPesananMasuk.CurrentRow.Cells[0].Value.ToString();
            }

            if (noAntrianTerpilih == "")
            {
                MessageBox.Show("Pilih baris pesanan di tabel terlebih dahulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE pemesanan SET status = @status WHERE no_antrian = @no";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@status", statusBaru);
                    cmd.Parameters.AddWithValue("@no", noAntrianTerpilih);
                    cmd.ExecuteNonQuery();

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
            UbahStatusPesanan("diproses");
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            UbahStatusPesanan("selesai");
        }

        private void btnTolak_Click(object sender, EventArgs e)
        {
            if (noAntrianTerpilih == "" && dgvPesananMasuk.CurrentRow != null && dgvPesananMasuk.CurrentRow.Cells[0].Value != null)
            {
                noAntrianTerpilih = dgvPesananMasuk.CurrentRow.Cells[0].Value.ToString();
            }

            if (noAntrianTerpilih == "")
            {
                MessageBox.Show("Pilih baris pesanan yang ingin dibatalkan!");
                return;
            }

            DialogResult tanya = MessageBox.Show("Yakin ingin membatalkan pesanan " + noAntrianTerpilih + "?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (tanya == DialogResult.Yes)
            {
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
