using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormKategori : Form
    {
        // Digunakan untuk mengambil koneksi saat membaca atau mengubah kategori.
        private readonly koneksi_db db = new koneksi_db();

        // Menyimpan ID kategori yang dipilih agar ubah dan hapus tepat sasaran.
        private int idKategoriTerpilih = 0;

        public FormKategori()
        {
            InitializeComponent();

            // Hubungkan tombol, pencarian, dan tabel dengan fungsi pengelola kategori.
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            textCariKategori.TextChanged += textCariKategori_TextChanged;
            dgvKategori.CellClick += dgvKategori_CellClick;

            // Isi tabel kategori saat form dibuka.
            TampilKategori();
        }

        // Mengambil semua kategori atau hanya kategori yang cocok dengan kata pencarian.
        public void TampilKategori(string cari = "")
        {
            dgvKategori.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM kategori WHERE nama_kategori LIKE @cari";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Tanda persen membuat pencarian cocok dengan teks di bagian mana pun.
                        cmd.Parameters.AddWithValue("@cari", "%" + cari + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dgvKategori.Rows.Add(reader["id_kategori"], reader["nama_kategori"]);
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

        // Memasukkan kategori dari baris yang dipilih ke dalam kotak input.
        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Abaikan klik pada header tabel karena bukan baris data.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKategori.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    // ID disimpan terpisah dari nama agar query ubah/hapus memakai identitas yang benar.
                    idKategoriTerpilih = Convert.ToInt32(row.Cells[0].Value);
                    textNamaKategori.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        // Menyimpan kategori baru setelah nama kategori diisi.
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (textNamaKategori.Text.Trim() == "")
            {
                // Nama kategori wajib ada sebelum data disimpan.
                MessageBox.Show("Nama kategori harus diisi!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO kategori (nama_kategori) VALUES (@nama)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", textNamaKategori.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kategori berhasil ditambah!");
                    // Bersihkan input dan muat ulang tabel agar hasil langsung terlihat.
                    Bersihkan();
                    TampilKategori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengubah nama kategori yang sedang dipilih.
        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idKategoriTerpilih == 0)
            {
                // ID nol berarti belum ada kategori yang dipilih dari tabel.
                MessageBox.Show("Pilih kategori di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    // Kondisi WHERE membatasi perubahan hanya pada kategori terpilih.
                    string query = "UPDATE kategori SET nama_kategori = @nama WHERE id_kategori = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama", textNamaKategori.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", idKategoriTerpilih);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kategori berhasil diubah!");
                    Bersihkan();
                    TampilKategori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Menghapus kategori yang dipilih dari tabel.
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idKategoriTerpilih == 0)
            {
                // Cegah perintah hapus dijalankan tanpa target kategori.
                MessageBox.Show("Pilih kategori di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM kategori WHERE id_kategori = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idKategoriTerpilih);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Kategori berhasil dihapus!");
                    Bersihkan();
                    TampilKategori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Menghapus pilihan kategori dan mengosongkan input serta pencarian.
        private void Bersihkan()
        {
            idKategoriTerpilih = 0;
            textNamaKategori.Clear();
            textCariKategori.Clear();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
            // Tampilkan seluruh kategori setelah kata pencarian dihapus.
            TampilKategori();
        }

        private void textCariKategori_TextChanged(object sender, EventArgs e)
        {
            // Terapkan pencarian langsung saat isi kotak pencarian berubah.
            TampilKategori(textCariKategori.Text.Trim());
        }

        private void textNamaKategori_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
