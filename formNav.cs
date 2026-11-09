using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class formNav : Form
    {
        // Menyimpan referensi form child agar tidak membuat form yang sama berulang kali.
        FormDashboard dashboard;
        FormPesan pesan;
        FormRiwayat riwayat;

        // Penanda agar aplikasi tidak langsung keluar ketika pengguna hanya melakukan logout.
        bool keluarAkun = false;
        Timer timerCekStatus = new Timer();
        long idPesananSudahDinotifikasi = 0;

        // Menyiapkan MDI Parent dan aturan saat form utama ditutup.
        public formNav()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => { if (!keluarAkun) Application.Exit(); };

            // Mengecek status pesanan secara berkala tanpa mengganggu tampilan utama.
            timerCekStatus.Interval = 5000;
            timerCekStatus.Tick += timerCekStatus_Tick;
        }

        private void formNav_Load(object sender, EventArgs e)
        {
            // Menampilkan nama pengguna yang sedang login dan membuka dashboard pertama kali.
            lblUserGreeting.Text = "Halo, " + koneksi_db.NamaUser;
            BukaDashboard();
            timerCekStatus.Start();
        }

        private void timerCekStatus_Tick(object sender, EventArgs e)
        {
            CekPesananSiap();
        }

        private void CekPesananSiap()
        {
            if (koneksi_db.UserId <= 0)
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = new koneksi_db().GetConnection())
                {
                    conn.Open();

                    // Ambil pesanan terbaru milik pengguna yang sudah selesai dibuat.
                    string query = @"SELECT id_pemesanan, no_antrian
                                     FROM pemesanan
                                     WHERE id_user = @idUser AND status = 'selesai'
                                     ORDER BY id_pemesanan DESC
                                     LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idUser", koneksi_db.UserId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                long idPesanan = Convert.ToInt64(reader["id_pemesanan"]);

                                // Notifikasi hanya ditampilkan satu kali untuk pesanan yang sama.
                                if (idPesanan != idPesananSudahDinotifikasi)
                                {
                                    idPesananSudahDinotifikasi = idPesanan;
                                    string noAntrian = reader["no_antrian"].ToString();
                                    FormStatus status = new FormStatus(noAntrian);
                                    status.Show(this);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Kegagalan pengecekan tidak menghentikan aplikasi utama.
                Console.WriteLine("Gagal mengecek status pesanan: " + ex.Message);
            }
        }

        public void BukaDashboard()
        {
            // Jika dashboard belum ada, buat sebagai child MDI baru.
            if (dashboard == null)
            {
                dashboard = new FormDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                // Jika sudah ada, segarkan datanya lalu aktifkan form tersebut.
                dashboard.TampilData();
                dashboard.Activate();
            }
        }

        public void BukaPesan()
        {
            // Membuka halaman pemesanan sebagai child MDI.
            if (pesan == null)
            {
                pesan = new FormPesan();
                pesan.FormClosed += Pesan_FormClosed;
                pesan.MdiParent = this;
                pesan.Dock = DockStyle.Fill;
                pesan.Show();
            }
            else
            {
                pesan.TampilMenu();
                pesan.Activate();
            }
        }

        public void BukaRiwayat()
        {
            // Membuka riwayat pesanan sebagai child MDI.
            if (riwayat == null)
            {
                riwayat = new FormRiwayat();
                riwayat.FormClosed += Riwayat_FormClosed;
                riwayat.MdiParent = this;
                riwayat.Dock = DockStyle.Fill;
                riwayat.Show();
            }
            else
            {
                riwayat.TampilRiwayat();
                riwayat.Activate();
            }
        }

        private void lblNavDashboard_Click(object sender, EventArgs e)
        {
            // Navigasi dashboard dipusatkan melalui satu method agar tidak terjadi duplikasi form.
            BukaDashboard();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Mengosongkan referensi agar dashboard bisa dibuat kembali jika dibutuhkan.
            dashboard = null;
        }

        private void lblNavPesan_Click(object sender, EventArgs e)
        {
            BukaPesan();
        }

        private void Pesan_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menandai bahwa form pemesanan sudah ditutup.
            pesan = null;
        }

        private void lblNavRiwayat_Click(object sender, EventArgs e)
        {
            BukaRiwayat();
        }

        private void Riwayat_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menandai bahwa form riwayat sudah ditutup.
            riwayat = null;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Logout membuka kembali form login dan menutup MDI Parent saat ini.
            keluarAkun = true;
            Formlogin login = new Formlogin();
            login.Show();
            this.Close();
        }
    }
}
