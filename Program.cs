using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_mie
{
    internal static class Program
    {
        // Titik awal aplikasi. Form login dibuka pertama kali saat program dijalankan.
        [STAThread]
        static void Main()
        {
            // Mengaktifkan tampilan Windows Forms agar kontrol mengikuti tema Windows.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formlogin());
        }
    }
}
