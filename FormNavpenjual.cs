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
    public partial class FormNavpenjual : Form
    {
        public FormNavpenjual()
        {
            InitializeComponent();
        }

        private void lblNavDashboard_Click(object sender, EventArgs e)
        {
            foreach(Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
             dashboardPenjual dashboardPenjual = new dashboardPenjual();
             dashboardPenjual.MdiParent = this;
             dashboardPenjual.FormBorderStyle = FormBorderStyle.None;
            dashboardPenjual.Dock = DockStyle.Fill;
            dashboardPenjual.Show();
        }

        private void lblNavProduk_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
            FormProduk formProduk = new FormProduk();
            formProduk.MdiParent = this;
            formProduk.FormBorderStyle = FormBorderStyle.None;
            formProduk.Dock = DockStyle.Fill;
            formProduk.Show();
        }

        private void lblNavTopings_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
            FormTopings formTopings = new FormTopings();
            formTopings.MdiParent = this;
            formTopings.FormBorderStyle = FormBorderStyle.None;
            formTopings.Dock = DockStyle.Fill;
            formTopings.Show();
        }

        private void lblNavKategori_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
            FormKategori formKategori = new FormKategori();
            formKategori.MdiParent = this;
            formKategori.FormBorderStyle = FormBorderStyle.None;
            formKategori.Dock = DockStyle.Fill;
            formKategori.Show();
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

        private void FormNavpenjual_Load(object sender, EventArgs e)
        {
            foreach (Form mdiChild in this.MdiChildren)
            {
                mdiChild.Close();
            }
            dashboardPenjual dashboardPenjual = new dashboardPenjual();
            dashboardPenjual.MdiParent = this;
            dashboardPenjual.FormBorderStyle = FormBorderStyle.None;
            dashboardPenjual.Dock = DockStyle.Fill;
            dashboardPenjual.Show();
        }
    }
}
