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
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void lblNavPesan_Click(object sender, EventArgs e)
        {
            FormPesan pesan = new FormPesan();
            pesan.FormClosed += Pesan_FormClosed;
            pesan.Show();   
        }

        private void Pesan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void lblNavRiwayat_Click(object sender, EventArgs e)
        {
            FormRiwayat riwayat = new FormRiwayat();        
            riwayat.FormClosed += Riwayat_FormClosed;
            riwayat.Show();
        }

        private void Riwayat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
