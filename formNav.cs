using System;
using System.Windows.Forms;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class formNav : Form
    {
        FormDashboard dashboard;
        FormPesan pesan;
        FormRiwayat riwayat;

        bool keluarAkun = false;

        public formNav()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => { if (!keluarAkun) Application.Exit(); };
        }

        private void formNav_Load(object sender, EventArgs e)
        {
            lblUserGreeting.Text = "Halo, " + koneksi_db.NamaUser;
            BukaDashboard();
        }

        public void BukaDashboard()
        {
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
                dashboard.TampilData();
                dashboard.Activate();
            }
        }

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
            dashboard = null;
        }

        private void lblNavPesan_Click(object sender, EventArgs e)
        {
            BukaPesan();
        }

        private void Pesan_FormClosed(object sender, FormClosedEventArgs e)
        {
            pesan = null;
        }

        private void lblNavRiwayat_Click(object sender, EventArgs e)
        {
            BukaRiwayat();
        }

        private void Riwayat_FormClosed(object sender, FormClosedEventArgs e)
        {
            riwayat = null;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            keluarAkun = true;
            Formlogin login = new Formlogin();
            login.Show();
            this.Close();
        }
    }
}
