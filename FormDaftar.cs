using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormDaftar : Form
    {
        // Digunakan untuk mengambil koneksi database saat menyimpan akun baru.
        private readonly koneksi_db db = new koneksi_db();

        public FormDaftar()
        {
            InitializeComponent();

            // Hubungkan tombol form dengan proses daftar dan batal.
            btnDaftar.Click += btnDaftar_Click;
            btnBatal.Click += btnBatal_Click;
        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Trim menghapus spasi di awal dan akhir agar input lebih konsisten.
            string nama = textNama.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();
            string konfirmasi = textKonfirmasiPassword.Text.Trim();

            if (nama == "" || email == "" || password == "" || konfirmasi == "")
            {
                // Pendaftaran dihentikan jika masih ada kolom wajib yang kosong.
                MessageBox.Show("Semua kolom harus diisi!");
                return;
            }

            if (password != konfirmasi)
            {
                // Pastikan pengguna mengetik password yang sama pada kedua kolom.
                MessageBox.Show("Password dan Konfirmasi Password tidak sama!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Cek jumlah akun dengan email yang sama sebelum membuat akun baru.
                    string cekEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                    int jumlah;
                    using (MySqlCommand cmdCek = new MySqlCommand(cekEmail, conn))
                    {
                        cmdCek.Parameters.AddWithValue("@email", email);
                        jumlah = Convert.ToInt32(cmdCek.ExecuteScalar());
                    }

                    if (jumlah > 0)
                    {
                        MessageBox.Show("Email sudah terdaftar, gunakan email lain!");
                        return;
                    }

                    // Akun yang dibuat dari form ini otomatis mendapat peran sebagai pembeli.
                    string query = "INSERT INTO users (nama_lengkap, email, password, role) VALUES (@nama, @email, @password, 'pembeli')";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.ExecuteNonQuery();
                    }

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
            // Tutup form pendaftaran tanpa menyimpan data.
            this.Close();
        }
    }
}
