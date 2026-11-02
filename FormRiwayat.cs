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
    public partial class FormRiwayat : Form
    {
        public FormRiwayat()
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

        private void lblNavPesan_Click(object sender, EventArgs e)
        {
            FormPesan pesan = new FormPesan();
            pesan.FormClosed += Pesan_FormClosed;
            pesan.Show();
            this.Hide();
        }

        private void Pesan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }   
    }
}
