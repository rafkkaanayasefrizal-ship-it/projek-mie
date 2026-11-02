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

        private void lblNavDashboard_Click(object sender, EventArgs e)
        {
            formdashboard dashboard = new formdashboard();
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
