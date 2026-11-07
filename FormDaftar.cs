using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormDaftar : Form
    {
        koneksi_db db = new koneksi_db();

        public FormDaftar()
        {
            InitializeComponent();

            btnDaftar.Click += btnDaftar_Click;
            btnBatal.Click += btnBatal_Click;
        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string nama = textNama.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();
            string konfirmasi = textKonfirmasiPassword.Text.Trim();

            if (nama == "" || email == "" || password == "" || konfirmasi == "")
            {
                MessageBox.Show("Semua kolom harus diisi!");
                return;
            }

            if (password != konfirmasi)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak sama!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string cekEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                    MySqlCommand cmdCek = new MySqlCommand(cekEmail, conn);
                    cmdCek.Parameters.AddWithValue("@email", email);

                    int jumlah = Convert.ToInt32(cmdCek.ExecuteScalar());
                    if (jumlah > 0)
                    {
                        MessageBox.Show("Email sudah terdaftar, gunakan email lain!");
                        return;
                    }

                    // Simpan user baru otomatis sebagai pembeli
                    string query = "INSERT INTO users (nama_lengkap, email, password, role) VALUES (@nama, @email, @password, 'pembeli')";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pendaftaran berhasil! Silakan login.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mendaftar: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
