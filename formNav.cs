using System;
using System.Windows.Forms;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class formNav : Form
    {
        // Menyimpan form anak agar navigasi tidak membuat form yang sama berkali-kali.
        FormDashboard dashboard;
        FormPesan pesan;
        FormRiwayat riwayat;

        // Membedakan logout dari penutupan aplikasi melalui tombol X.
        bool keluarAkun = false;

        public formNav()
        {
            InitializeComponent();
            // Jika jendela utama ditutup tanpa logout, akhiri seluruh aplikasi.
            this.FormClosed += (s, e) => { if (!keluarAkun) Application.Exit(); };
        }

        private void formNav_Load(object sender, EventArgs e)
        {
            // Tampilkan nama akun yang tersimpan saat proses login.
            lblUserGreeting.Text = "Halo, " + koneksi_db.NamaUser;
            BukaDashboard();
        }

        // Membuka dashboard sekali; jika sudah terbuka, muat ulang data dan fokuskan form.
        public void BukaDashboard()
        {
            if (dashboard == null)
            {
                dashboard = new FormDashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                // MDI membuat dashboard tampil di dalam area form navigasi.
                dashboard.MdiParent = this;
                dashboard.Dock = DockStyle.Fill;
                dashboard.Show();
            }
            else
            {
                dashboard.TampilData();
                dashboard.Activate();
            }
        }

        // Membuka halaman pemesanan atau memperbarui menu pada halaman yang sudah terbuka.
        public void BukaPesan()
        {
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

        // Membuka riwayat pesanan atau mengambil data terbaru sebelum menampilkannya kembali.
        public void BukaRiwayat()
        {
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
            BukaDashboard();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Hapus referensi agar klik navigasi berikutnya membuat dashboard baru.
            dashboard = null;
        }

        private void lblNavPesan_Click(object sender, EventArgs e)
        {
            BukaPesan();
        }

        private void Pesan_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Tandai form pemesanan sudah ditutup.
            pesan = null;
        }

        private void lblNavRiwayat_Click(object sender, EventArgs e)
        {
            BukaRiwayat();
        }

        private void Riwayat_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Tandai form riwayat sudah ditutup.
            riwayat = null;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Tandai bahwa penutupan ini adalah logout agar aplikasi tidak ikut berhenti.
            keluarAkun = true;
            Formlogin login = new Formlogin();
            login.Show();
            this.Close();
        }
    }
}
