using System;
using System.Windows.Forms;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormNavpenjual : Form
    {
        // Referensi form anak dipakai ulang supaya tidak ada banyak jendela yang sama.
        dashboardPenjual dashboard;
        FormKategori kategori;
        FormProduk produk;
        FormTopings toping;

        // Flag ini membedakan logout dari penutupan aplikasi biasa.
        bool keluarAkun = false;

        public FormNavpenjual()
        {
            InitializeComponent();
            // Penutupan jendela utama tanpa logout berarti aplikasi harus dihentikan.
            this.FormClosed += (s, e) => { if (!keluarAkun) Application.Exit(); };
        }

        private void FormNavpenjual_Load(object sender, EventArgs e)
        {
            // Tampilkan nama penjual dan buka dashboard saat navigasi pertama kali dimuat.
            lblUserGreeting.Text = "Halo, " + koneksi_db.NamaUser;
            lblNavDashboard_Click(sender, e);
        }

        private void lblNavDashboard_Click(object sender, EventArgs e)
        {
            // Buat dashboard jika belum ada; jika sudah ada, segarkan dan aktifkan kembali.
            if (dashboard == null)
            {
                dashboard = new dashboardPenjual();
                dashboard.FormClosed += Dashboard_FormClosed;
                // Form anak ditampilkan di dalam area form navigasi penjual.
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
            // Reset referensi supaya navigasi berikutnya bisa membuat form baru.
            dashboard = null;
        }

        private void lblNavKategori_Click(object sender, EventArgs e)
        {
            // Buka pengelolaan kategori, atau muat ulang data jika form sudah terbuka.
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
            // Lepaskan referensi setelah form kategori ditutup.
            kategori = null;
        }

        private void lblNavProduk_Click(object sender, EventArgs e)
        {
            // Buka pengelolaan produk, atau segarkan daftar produk yang sudah terbuka.
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
            // Lepaskan referensi setelah form produk ditutup.
            produk = null;
        }

        private void lblNavTopings_Click(object sender, EventArgs e)
        {
            // Buka pengelolaan topping, atau segarkan daftar topping yang sudah terbuka.
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
            // Lepaskan referensi setelah form topping ditutup.
            toping = null;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            // Buka kembali halaman login sebelum menutup navigasi penjual.
            keluarAkun = true;
            Formlogin login = new Formlogin();
            login.Show();
            this.Close();
        }
    }
}
