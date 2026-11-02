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
    public partial class FormPesan : Form
    {
        public FormPesan()
        {   
            InitializeComponent();
        }

        private void lblNavDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.Show();
            this.Hide();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void lblNavRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat riwayat = new FormRiwayat();
            riwayat.FormClosed += Riwayat_FormClosed;
            riwayat.Show();
            this.Hide();
        }

        private void Riwayat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
