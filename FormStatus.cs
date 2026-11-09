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
    public partial class FormStatus : Form
    {
        // Constructor ini tetap dipertahankan agar form bisa dibuka dari Designer.
        public FormStatus()
            : this("")
        {
        }

        // Menampilkan notifikasi untuk nomor antrean tertentu.
        public FormStatus(string noAntrian)
        {
            InitializeComponent();

            label4.Text = string.IsNullOrWhiteSpace(noAntrian) ? "-" : noAntrian;
            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tombol OK digunakan untuk menutup notifikasi.
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
