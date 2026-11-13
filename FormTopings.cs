using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormTopings : Form
    {
        // Digunakan untuk mengakses data topping pada database.
        private readonly koneksi_db db = new koneksi_db();

        // Menyimpan ID topping yang dipilih untuk proses ubah atau hapus.
        private int idTopingTerpilih = 0;

        public FormTopings()
        {
            InitializeComponent();

            // Hubungkan tombol, pencarian, dan tabel dengan fungsi pengelolaan topping.
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            textCariTopings.TextChanged += textCariTopings_TextChanged;
            dgvTopings.CellClick += dgvTopings_CellClick;

            // Tampilkan data topping saat form pertama kali dibuka.
            TampilTopings();
        }

        // Mengambil daftar topping dari database dan menerapkan pencarian jika diisi.
        public void TampilTopings(string cari = "")
        {
            dgvTopings.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM toping WHERE nama_toping LIKE @cari";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Parameter pencarian mencegah input dimasukkan langsung ke dalam query.
                        cmd.Parameters.AddWithValue("@cari", "%" + cari + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvTopings.Rows.Add(
                                    reader["id_toping"],
                                    reader["nama_toping"],
                                    reader["harga"]
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengambil nilai dari baris topping yang dipilih untuk ditampilkan di input.
        private void dgvTopings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Header tabel tidak memiliki data topping, jadi tidak diproses.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTopings.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    // ID diperlukan agar perubahan berikutnya mengarah ke topping yang benar.
                    idTopingTerpilih = Convert.ToInt32(row.Cells[0].Value);
                    textNamaTopings.Text = row.Cells[1].Value.ToString();
                    textHargaTopings.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        // Memvalidasi nama dan harga topping, lalu mengubah harga menjadi angka.
        private bool CobaAmbilDataToping(out string nama, out decimal harga)
        {
            nama = textNamaTopings.Text.Trim();

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(textHargaTopings.Text))
            {
                MessageBox.Show("Nama dan harga toping harus diisi!");
                harga = 0;
                return false;
            }

            if (!decimal.TryParse(textHargaTopings.Text.Trim(), out harga))
            {
                MessageBox.Show("Harga toping harus berupa angka yang valid!");
                return false;
            }

            return true;
        }

        // Menambahkan topping baru setelah nama dan harga berhasil divalidasi.
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!CobaAmbilDataToping(out string nama, out decimal harga))
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO toping (nama_toping, harga) VALUES (@nama, @harga)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Toping berhasil ditambah!");
                    Bersihkan();
                    TampilTopings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengubah topping yang dipilih menggunakan input yang sudah tervalidasi.
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idTopingTerpilih == 0)
            {
                // Pastikan pengguna memilih topping sebelum mencoba mengubahnya.
                MessageBox.Show("Pilih toping di tabel dulu!");
                return;
            }

            if (!CobaAmbilDataToping(out string nama, out decimal harga))
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE toping SET nama_toping = @nama, harga = @harga WHERE id_toping = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@id", idTopingTerpilih);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Toping berhasil diubah!");
                    Bersihkan();
                    TampilTopings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Menghapus topping yang dipilih dari database.
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idTopingTerpilih == 0)
            {
                // Tanpa ID terpilih, aplikasi tidak tahu data mana yang harus dihapus.
                MessageBox.Show("Pilih toping di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM toping WHERE id_toping = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idTopingTerpilih);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Toping berhasil dihapus!");
                    Bersihkan();
                    TampilTopings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Reset ID pilihan dan kosongkan nama serta harga topping.
        private void Bersihkan()
        {
            idTopingTerpilih = 0;
            textNamaTopings.Clear();
            textHargaTopings.Clear();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
            // Muat ulang tanpa kata pencarian untuk menampilkan semua topping.
            TampilTopings();
        }

        private void textCariTopings_TextChanged(object sender, EventArgs e)
        {
            // Cari ulang topping setiap kali teks pencarian berubah.
            TampilTopings(textCariTopings.Text.Trim());
        }
    }
}
