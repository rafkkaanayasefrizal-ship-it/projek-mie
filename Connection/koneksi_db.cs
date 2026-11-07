using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projek_mie.Connection
{
    internal class koneksi_db
    {
        private readonly string connectionString = "Server=localhost;Port=3306;Database=mie;Uid=root;Pwd=;";

        // Menyimpan data user yang sedang login
        public static int UserId = 0;
        public static string NamaUser = "";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
