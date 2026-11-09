using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormDaftar : Form
    {
        // Dipakai setiap kali form perlu berkomunikasi dengan database.
        koneksi_db db = new koneksi_db();

        // Menyiapkan tampilan form dan menghubungkan tombol dengan event-nya.
        public FormDaftar()
        {
            InitializeComponent();

            btnDaftar.Click += btnDaftar_Click;
            btnBatal.Click += btnBatal_Click;
        }

        private void textNama_TextChanged(object sender, EventArgs e)
        {
            // Belum ada proses khusus saat nama diketik.
        }

        // Menjalankan seluruh proses pendaftaran akun baru.
        private void btnDaftar_Click(object sender, EventArgs e)
        {
            // Mengambil isi setiap input dan menghapus spasi di awal atau akhir.
            string nama = textNama.Text.Trim();
            string email = textEmail.Text.Trim();
            string password = textPassword.Text.Trim();
            string konfirmasi = textKonfirmasiPassword.Text.Trim();

            // Semua kolom wajib diisi sebelum proses dilanjutkan.
            if (nama == "" || email == "" || password == "" || konfirmasi == "")
            {
                MessageBox.Show("Semua kolom harus diisi!");
                return;
            }

            // Password dan konfirmasi password harus sama.
            if (password != konfirmasi)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak sama!");
                return;
            }

            try
            {
                // Satu koneksi dipakai untuk mengecek email dan menyimpan akun.
                using (MySqlConnection koneksi = db.GetConnection())
                {
                    koneksi.Open();

                    // Cek dulu agar satu email tidak digunakan oleh dua akun.
                    string queryCekEmail = "SELECT COUNT(*) FROM users WHERE email = @email";
                    using (MySqlCommand perintahCekEmail = new MySqlCommand(queryCekEmail, koneksi))
                    {
                        perintahCekEmail.Parameters.AddWithValue("@email", email);

                        int jumlahEmail = Convert.ToInt32(perintahCekEmail.ExecuteScalar());
                        if (jumlahEmail > 0)
                        {
                            MessageBox.Show("Email sudah terdaftar, gunakan email lain!");
                            return;
                        }
                    }

                    // Jika email belum digunakan, buat akun dengan role pembeli.
                    string querySimpanAkun = "INSERT INTO users (nama_lengkap, email, password, role) VALUES (@nama, @email, @password, 'pembeli')";
                    using (MySqlCommand perintahSimpanAkun = new MySqlCommand(querySimpanAkun, koneksi))
                    {
                        perintahSimpanAkun.Parameters.AddWithValue("@nama", nama);
                        perintahSimpanAkun.Parameters.AddWithValue("@email", email);
                        perintahSimpanAkun.Parameters.AddWithValue("@password", password);
                        perintahSimpanAkun.ExecuteNonQuery();
                    }

                    MessageBox.Show("Pendaftaran berhasil! Silakan login.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                // Jika database bermasalah, tampilkan pesan agar pengguna tahu penyebabnya.
                MessageBox.Show("Gagal mendaftar: " + ex.Message);
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            // Tombol batal hanya menutup form pendaftaran.
            Close();
        }
    }
}
