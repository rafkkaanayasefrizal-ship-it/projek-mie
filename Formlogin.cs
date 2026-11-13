using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class Formlogin : Form
    {
        // Digunakan untuk membuka koneksi database dan menyimpan data sesi pengguna.
        private readonly koneksi_db db = new koneksi_db();
        private CheckBox chkTampilkanPassword;

        public Formlogin()
        {
            InitializeComponent();

            // Sediakan pilihan untuk menampilkan atau menyembunyikan password.
            chkTampilkanPassword = new CheckBox
            {
                Text = "Tampilkan password",
                AutoSize = true,
                Location = new System.Drawing.Point(39, 270),
                TabIndex = 11
            };
            chkTampilkanPassword.CheckedChanged += (sender, e) =>
            {
                textPassword.UseSystemPasswordChar = !chkTampilkanPassword.Checked;
            };
            Controls.Add(chkTampilkanPassword);

            // Hubungkan tombol dan label dengan aksi login atau pindah ke form daftar.
            btnMasuk.Click += btnMasuk_Click;
            lblKeDaftar.Click += lblKeDaftar_Click;

            // Aplikasi ditutup jika form login yang menjadi form utama ikut ditutup.
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void lblSubJudul_Click(object sender, EventArgs e)
        {
        }

        private void lblKeDaftar_Click(object sender, EventArgs e)
        {
            FormDaftar daftar = new FormDaftar();
            // Sembunyikan login selama form daftar terbuka, lalu tampilkan kembali setelah ditutup.
            this.Hide();
            daftar.ShowDialog();
            this.Show();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            // Hilangkan spasi luar agar pencocokan akun tidak terganggu oleh input yang tidak sengaja.
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();

            if (email == "" || password == "")
            {
                // Tidak perlu mengirim query jika salah satu input wajib masih kosong.
                MessageBox.Show("Email dan Password harus diisi!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Pengguna dapat masuk memakai email atau nama lengkap yang terdaftar.
                    string query = "SELECT * FROM users WHERE (email = @email OR nama_lengkap = @email) AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Simpan identitas pengguna agar bisa dipakai oleh form lain.
                                koneksi_db.UserId = Convert.ToInt32(reader["id"]);
                                koneksi_db.NamaUser = reader["nama_lengkap"].ToString();
                                string roleDb = reader["role"].ToString().ToLower();

                                MessageBox.Show("Login Berhasil! Selamat datang, " + koneksi_db.NamaUser);
                                this.Hide();

                                // Arahkan pengguna ke navigasi yang sesuai dengan perannya.
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error koneksi: " + ex.Message);
            }
        }
    }
}
