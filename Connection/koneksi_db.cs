using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projek_mie.Connection
{
    public class koneksi_db
    {
        // =========================================================================================
        // PANDUAN PENGATURAN KONEKSI DATABASE (MySQL / XAMPP / VS Code Database):
        // 1. Standar default database lokal (XAMPP / VS Code):
        //    - Server   : localhost
        //    - Port     : 3306
        //    - User     : root
        //    - Password : (kosong)
        //    - Database : db_mie (akan otomatis dibuatkan jika belum ada di server lokal)
        // 2. Anda juga bisa mengatur connection string lewat file App.config (tag <connectionStrings>).
        // =========================================================================================

        public static string Server = "localhost";
        public static string Port = "3306";
        public static string User = "root";
        public static string Password = "";
        public static string Database = "db_mie";

        private static string defaultConnectionString =
            $"server={Server};port={Port};uid={User};pwd={Password};database={Database};Charset=utf8mb4;";

        /// <summary>
        /// Mengambil connection string aktif (memprioritaskan dari App.config jika ada, lalu fallback ke default).
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                try
                {
                    if (ConfigurationManager.ConnectionStrings["DbConnection"] != null &&
                        !string.IsNullOrWhiteSpace(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString))
                    {
                        return ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
                    }
                }
                catch
                {
                    // Fallback jika App.config belum diset
                }
                return $"server={Server};port={Port};uid={User};pwd={Password};database={Database};Charset=utf8mb4;";
            }
            set
            {
                defaultConnectionString = value;
            }
        }

        /// <summary>
        /// Membuat objek MySqlConnection baru berdasarkan connection string aktif.
        /// </summary>
        public static MySqlConnection GetKoneksi()
        {
            return new MySqlConnection(ConnectionString);
        }

        /// <summary>
        /// Memastikan database lokal dan tabel-tabel dasarnya sudah ada di MySQL server Anda.
        /// </summary>
        public static bool InisialisasiDatabaseLokal(out string pesanError)
        {
            try
            {
                // Hubungkan ke server MySQL lokal tanpa memilih database terlebih dahulu
                string serverOnlyConnStr = $"server={Server};port={Port};uid={User};pwd={Password};";
                using (MySqlConnection conn = new MySqlConnection(serverOnlyConnStr))
                {
                    conn.Open();

                    // Buat database jika belum ada
                    string sqlCreateDb = $"CREATE DATABASE IF NOT EXISTS `{Database}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;";
                    using (MySqlCommand cmd = new MySqlCommand(sqlCreateDb, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Buat tabel-tabel awal jika belum ada
                using (MySqlConnection conn = GetKoneksi())
                {
                    conn.Open();

                    string sqlCreateTables = @"
                        CREATE TABLE IF NOT EXISTS `users` (
                            `id` INT AUTO_INCREMENT PRIMARY KEY,
                            `username` VARCHAR(50) NOT NULL UNIQUE,
                            `password` VARCHAR(255) NOT NULL,
                            `nama` VARCHAR(100),
                            `role` VARCHAR(20) DEFAULT 'Pembeli'
                        );

                        CREATE TABLE IF NOT EXISTS `kategori` (
                            `id` INT AUTO_INCREMENT PRIMARY KEY,
                            `nama_kategori` VARCHAR(100) NOT NULL
                        );

                        CREATE TABLE IF NOT EXISTS `produk` (
                            `id` INT AUTO_INCREMENT PRIMARY KEY,
                            `nama_produk` VARCHAR(100) NOT NULL,
                            `varian` VARCHAR(50),
                            `harga` DECIMAL(10,2) NOT NULL,
                            `kategori_id` INT NULL
                        );

                        CREATE TABLE IF NOT EXISTS `topings` (
                            `id` INT AUTO_INCREMENT PRIMARY KEY,
                            `nama_toping` VARCHAR(100) NOT NULL,
                            `harga` DECIMAL(10,2) NOT NULL
                        );

                        CREATE TABLE IF NOT EXISTS `pesanan` (
                            `id` INT AUTO_INCREMENT PRIMARY KEY,
                            `no_transaksi` VARCHAR(50),
                            `tanggal` DATETIME DEFAULT CURRENT_TIMESTAMP,
                            `total_harga` DECIMAL(10,2) NOT NULL,
                            `user_id` INT NULL
                        );
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(sqlCreateTables, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                pesanError = string.Empty;
                return true;
            }
            catch (Exception ex)
            {
                pesanError = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Menguji apakah koneksi ke database lokal berhasil.
        /// </summary>
        public static bool TestKoneksi(out string pesanError)
        {
            try
            {
                // Inisialisasi database jika belum ada
                string errInit;
                InisialisasiDatabaseLokal(out errInit);

                using (MySqlConnection conn = GetKoneksi())
                {
                    conn.Open();
                    pesanError = string.Empty;
                    return true;
                }
            }
            catch (Exception ex)
            {
                pesanError = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Menguji koneksi dan memunculkan pop-up MessageBox status (berhasil / gagal).
        /// </summary>
        public static bool TestKoneksiDenganPesan()
        {
            string pesanError;
            if (TestKoneksi(out pesanError))
            {
                MessageBox.Show("Koneksi ke MySQL Database Lokal berhasil terhubung!\nDatabase '" + Database + "' siap digunakan.",
                    "Koneksi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Gagal terhubung ke MySQL database lokal!\n\nPesan Error:\n" + pesanError +
                    "\n\nTips:\n1. Pastikan modul MySQL di XAMPP Control Panel sudah START (hijau).\n2. Pastikan port 3306 tidak terblokir.",
                    "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Menjalankan query SELECT dan mengembalikan data dalam format DataTable (siap di-bind ke DataGridView).
        /// Contoh: dgvProduk.DataSource = koneksi_db.GetData("SELECT * FROM produk");
        /// </summary>
        public static DataTable GetData(string query, MySqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = GetKoneksi())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengambil data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /// <summary>
        /// Menjalankan query manipulasi data (INSERT, UPDATE, DELETE).
        /// Mengembalikan jumlah baris yang terpengaruh (int).
        /// </summary>
        public static int EksekusiQuery(string query, MySqlParameter[] parameters = null)
        {
            int hasil = 0;
            try
            {
                using (MySqlConnection conn = GetKoneksi())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        hasil = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memproses data:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return hasil;
        }

        /// <summary>
        /// Menjalankan query yang menghasilkan satu nilai (misal: COUNT, MAX, atau verifikasi login).
        /// </summary>
        public static object EksekusiScalar(string query, MySqlParameter[] parameters = null)
        {
            object hasil = null;
            try
            {
                using (MySqlConnection conn = GetKoneksi())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        hasil = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat mengeksekusi query scalar:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hasil;
        }
    }
}

namespace projek_mie
{
    // Shortcut alias agar form-form yang berada di namespace projek_mie bisa langsung memanggil koneksi_db
    public class koneksi_db : projek_mie.Connection.koneksi_db
    {
    }
}
