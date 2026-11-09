using System;
using System.Windows.Forms;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormNavpenjual : Form
    {
        // Referensi child MDI untuk setiap menu yang tersedia bagi penjual.
        dashboardPenjual dashboard;
        FormKategori kategori;
        FormProduk produk;
        FormTopings toping;

        // Menandai proses logout agar penutupan form tidak dianggap sebagai keluar aplikasi.
        bool keluarAkun = false;

        // Menyiapkan MDI Parent penjual dan event penutupan form.
        public FormNavpenjual()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => { if (!keluarAkun) Application.Exit(); };
        }

        private void FormNavpenjual_Load(object sender, EventArgs e)
        {
            // Menampilkan nama penjual dan membuka dashboard secara otomatis.
            lblUserGreeting.Text = "Halo, " + koneksi_db.NamaUser;
            lblNavDashboard_Click(sender, e);
        }

        private void lblNavDashboard_Click(object sender, EventArgs e)
        {
            // Membuka atau mengaktifkan kembali dashboard penjual.
            if (dashboard == null)
            {
                dashboard = new dashboardPenjual();
                dashboard.FormClosed += Dashboard_FormClosed;
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

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menghapus referensi dashboard setelah form ditutup.
            dashboard = null;
        }

        private void lblNavKategori_Click(object sender, EventArgs e)
        {
            // Membuka atau mengaktifkan halaman pengelolaan kategori.
            if (kategori == null)
            {
                kategori = new FormKategori();
                kategori.FormClosed += Kategori_FormClosed;
                kategori.MdiParent = this;
                kategori.Dock = DockStyle.Fill;
                kategori.Show();
            }
            else
            {
                kategori.TampilKategori();
                kategori.Activate();
            }
        }

        private void Kategori_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menghapus referensi kategori setelah form ditutup.
            kategori = null;
        }

        private void lblNavProduk_Click(object sender, EventArgs e)
        {
            // Membuka atau mengaktifkan halaman pengelolaan produk.
            if (produk == null)
            {
                produk = new FormProduk();
                produk.FormClosed += Produk_FormClosed;
                produk.MdiParent = this;
                produk.Dock = DockStyle.Fill;
                produk.Show();
            }
            else
            {
                produk.TampilProduk();
                produk.Activate();
            }
        }

        private void Produk_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menghapus referensi produk setelah form ditutup.
            produk = null;
        }

        private void lblNavTopings_Click(object sender, EventArgs e)
        {
            // Membuka atau mengaktifkan halaman pengelolaan toping.
            if (toping == null)
            {
                toping = new FormTopings();
                toping.FormClosed += Toping_FormClosed;
                toping.MdiParent = this;
                toping.Dock = DockStyle.Fill;
                toping.Show();
            }
            else
            {
                toping.TampilTopings();
                toping.Activate();
            }
        }

        private void Toping_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Menghapus referensi toping setelah form ditutup.
            toping = null;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Logout mengarahkan pengguna kembali ke form login.
            keluarAkun = true;
            Formlogin login = new Formlogin();
            login.Show();
            this.Close();
        }
    }
}
