using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormKategori : Form
    {
        koneksi_db db = new koneksi_db();
        int idKategoriTerpilih = 0;

        public FormKategori()
        {
            InitializeComponent();

            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            textCariKategori.TextChanged += textCariKategori_TextChanged;
            dgvKategori.CellClick += dgvKategori_CellClick;

            TampilKategori();
        }

        public void TampilKategori(string cari = "")
        {
            dgvKategori.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM kategori WHERE nama_kategori LIKE @cari";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cari", "%" + cari + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvKategori.Rows.Add(reader["id_kategori"], reader["nama_kategori"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKategori.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    idKategoriTerpilih = Convert.ToInt32(row.Cells[0].Value);
                    textNamaKategori.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (textNamaKategori.Text.Trim() == "")
            {
                MessageBox.Show("Nama kategori harus diisi!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO kateudahgori (nama_kategori) VALUES (@nama)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", textNamaKategori.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Kategori berhasil ditambah!");
                    Bersihkan();
                    TampilKategori();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idKategoriTerpilih == 0)
            {
                MessageBox.Show("Pilih kategori di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE kategori SET nama_kategori = @nama WHERE id_kategori = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", textNamaKategori.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", idKategoriTerpilih);
                    cmd.ExecuteNonQuery();

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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idKategoriTerpilih == 0)
            {
                MessageBox.Show("Pilih kategori di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM kategori WHERE id_kategori = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idKategoriTerpilih);
                    cmd.ExecuteNonQuery();

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

        private void Bersihkan()
        {
            idKategoriTerpilih = 0;
            textNamaKategori.Clear();
            textCariKategori.Clear();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
            TampilKategori();
        }

        private void textCariKategori_TextChanged(object sender, EventArgs e)
        {
            TampilKategori(textCariKategori.Text.Trim());
        }

        private void textNamaKategori_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
