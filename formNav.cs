using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_mie
{
    public partial class formNav : Form
    {
        public formNav()
        {
            InitializeComponent();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in MdiChildren)
            {
                mdiChild.Close();
            }

            Formlogin formLogin = new Formlogin();
            formLogin.FormClosed += (s, args) => Show();
            Hide();
            formLogin.Show();
        }

        private void lblNavDashboard_Click(object sender, EventArgs e)
        {
            foreach(Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();

            }
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.MdiParent = this;
            formDashboard.FormBorderStyle = FormBorderStyle.None;
            formDashboard.Dock = DockStyle.Fill;
            formDashboard.Show();
            formDashboard.BringToFront();
        }

        private void formNav_Load(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();

            }
            FormDashboard formDashboard = new FormDashboard();
            formDashboard.MdiParent = this;
            formDashboard.FormBorderStyle = FormBorderStyle.None;
            formDashboard.Dock = DockStyle.Fill;
            formDashboard.Show();
            formDashboard.BringToFront();
        }

        private void lblNavPesan_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();

            }
            FormPesan Pesan = new FormPesan();
            Pesan.MdiParent = this;
            Pesan.FormBorderStyle = FormBorderStyle.None;
            Pesan.Dock = DockStyle.Fill;
            Pesan.Show();
            Pesan.BringToFront();
        }

        private void lblNavRiwayat_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();

            }
            FormRiwayat Riwayat = new FormRiwayat();
            Riwayat.MdiParent = this;
            Riwayat.FormBorderStyle = FormBorderStyle.None;
            Riwayat.Dock = DockStyle.Fill;
            Riwayat.Show();
            Riwayat.BringToFront();
        }

    }
}
