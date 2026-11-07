using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormTopings : Form
    {
        koneksi_db db = new koneksi_db();
        int idTopingTerpilih = 0;

        public FormTopings()
        {
            InitializeComponent();

            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            textCariTopings.TextChanged += textCariTopings_TextChanged;
            dgvTopings.CellClick += dgvTopings_CellClick;

            TampilTopings();
        }

        public void TampilTopings(string cari = "")
        {
            dgvTopings.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM toping WHERE nama_toping LIKE @cari";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cari", "%" + cari + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dgvTopings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTopings.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    idTopingTerpilih = Convert.ToInt32(row.Cells[0].Value);
                    textNamaTopings.Text = row.Cells[1].Value.ToString();
                    textHargaTopings.Text = row.Cells[2].Value.ToString();
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (textNamaTopings.Text == "" || textHargaTopings.Text == "")
            {
                MessageBox.Show("Nama dan harga toping harus diisi!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO toping (nama_toping, harga) VALUES (@nama, @harga)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", textNamaTopings.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(textHargaTopings.Text.Trim()));
                    cmd.ExecuteNonQuery();

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

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idTopingTerpilih == 0)
            {
                MessageBox.Show("Pilih toping di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE toping SET nama_toping = @nama, harga = @harga WHERE id_toping = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", textNamaTopings.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(textHargaTopings.Text.Trim()));
                    cmd.Parameters.AddWithValue("@id", idTopingTerpilih);
                    cmd.ExecuteNonQuery();

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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idTopingTerpilih == 0)
            {
                MessageBox.Show("Pilih toping di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM toping WHERE id_toping = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idTopingTerpilih);
                    cmd.ExecuteNonQuery();

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

        private void Bersihkan()
        {
            idTopingTerpilih = 0;
            textNamaTopings.Clear();
            textHargaTopings.Clear();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
            TampilTopings();
        }

        private void textCariTopings_TextChanged(object sender, EventArgs e)
        {
            TampilTopings(textCariTopings.Text.Trim());
        }
    }
}
