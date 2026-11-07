using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormProduk : Form
    {
        koneksi_db db = new koneksi_db();
        int idProdukTerpilih = 0;

        public FormProduk()
        {
            InitializeComponent();

            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            textCariProduk.TextChanged += textCariProduk_TextChanged;
            dgvProduk.CellClick += dgvProduk_CellClick;

            TampilProduk();
        }

        public void TampilProduk(string cari = "")
        {
            dgvProduk.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT p.id_produk, p.nama_produk, k.nama_kategori, p.harga, p.stok 
                                     FROM produk p 
                                     LEFT JOIN kategori k ON p.id_kategori = k.id_kategori
                                     WHERE p.nama_produk LIKE @cari";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cari", "%" + cari + "%");

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dgvProduk.Rows.Add(
                            reader["id_produk"],
                            reader["nama_produk"],
                            reader["nama_kategori"],
                            reader["harga"],
                            reader["stok"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int AmbilIdKategori(string namaVarian, MySqlConnection conn)
        {
            string query = "SELECT id_kategori FROM kategori WHERE nama_kategori = @nama LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nama", namaVarian);
            object hasil = cmd.ExecuteScalar();

            if (hasil != null)
            {
                return Convert.ToInt32(hasil);
            }
            return 1;
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduk.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    idProdukTerpilih = Convert.ToInt32(row.Cells[0].Value);
                    textNamaProduk.Text = row.Cells[1].Value.ToString();
                    cmbVarian.Text = row.Cells[2].Value.ToString();
                    textHarga.Text = row.Cells[3].Value.ToString();
                    textStok.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "0";
                }
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (textNamaProduk.Text == "" || cmbVarian.Text == "" || textHarga.Text == "" || textStok.Text == "")
            {
                MessageBox.Show("Nama produk, varian, harga, dan stok harus diisi!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    int idKat = AmbilIdKategori(cmbVarian.Text, conn);

                    string query = "INSERT INTO produk (id_kategori, nama_produk, harga, stok) VALUES (@idKat, @nama, @harga, @stok)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idKat", idKat);
                    cmd.Parameters.AddWithValue("@nama", textNamaProduk.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(textHarga.Text.Trim()));
                    cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(textStok.Text.Trim()));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produk berhasil ditambah!");
                    Bersihkan();
                    TampilProduk();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (idProdukTerpilih == 0)
            {
                MessageBox.Show("Pilih produk di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    int idKat = AmbilIdKategori(cmbVarian.Text, conn);

                    string query = "UPDATE produk SET id_kategori = @idKat, nama_produk = @nama, harga = @harga, stok = @stok WHERE id_produk = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idKat", idKat);
                    cmd.Parameters.AddWithValue("@nama", textNamaProduk.Text.Trim());
                    cmd.Parameters.AddWithValue("@harga", Convert.ToDecimal(textHarga.Text.Trim()));
                    cmd.Parameters.AddWithValue("@stok", Convert.ToInt32(textStok.Text.Trim()));
                    cmd.Parameters.AddWithValue("@id", idProdukTerpilih);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produk & stok berhasil diubah!");
                    Bersihkan();
                    TampilProduk();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (idProdukTerpilih == 0)
            {
                MessageBox.Show("Pilih produk di tabel dulu!");
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM produk WHERE id_produk = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idProdukTerpilih);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produk berhasil dihapus!");
                    Bersihkan();
                    TampilProduk();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Bersihkan()
        {
            idProdukTerpilih = 0;
            textNamaProduk.Clear();
            textHarga.Clear();
            textStok.Clear();
            cmbVarian.SelectedIndex = -1;
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            Bersihkan();
            TampilProduk();
        }

        private void textCariProduk_TextChanged(object sender, EventArgs e)
        {
            TampilProduk(textCariProduk.Text.Trim());
        }
    }
}
