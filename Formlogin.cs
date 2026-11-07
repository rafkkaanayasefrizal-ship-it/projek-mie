using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class Formlogin : Form
    {
        koneksi_db db = new koneksi_db();

        public Formlogin()
        {
            InitializeComponent();

            btnMasuk.Click += btnMasuk_Click;
            lblKeDaftar.Click += lblKeDaftar_Click;
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void lblSubJudul_Click(object sender, EventArgs e)
        {
        }

        private void lblKeDaftar_Click(object sender, EventArgs e)
        {
            FormDaftar daftar = new FormDaftar();
            this.Hide();
            daftar.ShowDialog();
            this.Show();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Email dan Password harus diisi!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM users WHERE (email = @email OR nama_lengkap = @email) AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        koneksi_db.UserId = Convert.ToInt32(reader["id"]);
                        koneksi_db.NamaUser = reader["nama_lengkap"].ToString();
                        string roleDb = reader["role"].ToString().ToLower();

                        MessageBox.Show("Login Berhasil! Selamat datang, " + koneksi_db.NamaUser);
                        this.Hide();

                        // Otomatis arahkan berdasarkan role di database (admin@gmail.com -> penjual, user lain -> pembeli)
                        if (roleDb == "penjual" || email.ToLower() == "admin@gmail.com")
                        {
                            FormNavpenjual navPenjual = new FormNavpenjual();
                            navPenjual.Show();
                        }
                        else
                        {
                            formNav navPembeli = new formNav();
                            navPembeli.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email atau Password salah!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error koneksi: " + ex.Message);
            }
        }
    }
}
