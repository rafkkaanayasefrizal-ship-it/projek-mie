using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using projek_mie.Connection;

namespace projek_mie
{
    public partial class FormProduk : Form
    {
        // Objek ini dipakai bersama untuk membuka koneksi ke database.
        private readonly koneksi_db db = new koneksi_db();

        // Menyimpan ID produk yang sedang dipilih pada tabel.
        private int idProdukTerpilih = 0;

        public FormProduk()
        {
            InitializeComponent();

            // Hubungkan setiap tombol dan kontrol dengan fungsi yang menangani aksinya.
            btnTambah.Click += btnTambah_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnBersihkan.Click += btnBersihkan_Click;
            textCariProduk.TextChanged += textCariProduk_TextChanged;
            dgvProduk.CellClick += dgvProduk_CellClick;

            // Tampilkan semua produk saat form pertama kali dibuka.
            TampilProduk();
        }

        // Mengambil daftar produk dari database dan menampilkannya pada tabel.
        public void TampilProduk(string cari = "")
        {
            dgvProduk.Rows.Clear();

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    // Ambil ID, nama, kategori, harga, dan stok untuk ditampilkan pada tabel produk.
                    // Nama tabel ditulis lengkap supaya asal setiap kolom mudah dikenali.
                    string query = @"SELECT produk.id_produk, produk.nama_produk, kategori.nama_kategori, produk.harga, produk.stok
                                     FROM produk
                                     LEFT JOIN kategori ON produk.id_kategori = kategori.id_kategori
                                     WHERE produk.nama_produk LIKE @cari";
                    // LEFT JOIN tetap menampilkan produk meskipun data kategorinya tidak ditemukan.
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Parameter digunakan agar teks pencarian tidak disisipkan langsung ke query SQL.
                        cmd.Parameters.AddWithValue("@cari", "%" + cari + "%");

                        // Reader membaca hasil query satu baris demi satu baris.
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mencari ID kategori berdasarkan nama kategori yang dipilih pada form.
        private int AmbilIdKategori(string namaVarian, MySqlConnection conn)
        {
            string query = "SELECT id_kategori FROM kategori WHERE nama_kategori = @nama LIMIT 1";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nama", namaVarian);
                object hasil = cmd.ExecuteScalar();

                if (hasil != null)
                {
                    // ID dari database diubah ke integer agar bisa dipakai saat menyimpan produk.
                    return Convert.ToInt32(hasil);
                }
            }

            // Jika kategori tidak ditemukan, gunakan kategori default dengan ID 1.
            return 1;
        }

        // Memeriksa input form dan mengubah harga serta stok ke tipe angka sebelum disimpan.
        private bool CobaAmbilDataProduk(out string nama, out decimal harga, out int stok)
        {
            nama = textNamaProduk.Text.Trim();

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(cmbVarian.Text) ||
                string.IsNullOrWhiteSpace(textHarga.Text) || string.IsNullOrWhiteSpace(textStok.Text))
            {
                // Hentikan proses jika ada data wajib yang belum diisi.
                MessageBox.Show("Nama produk, varian, harga, dan stok harus diisi!");
                harga = 0;
                stok = 0;
                return false;
            }

            if (!decimal.TryParse(textHarga.Text.Trim(), out harga))
            {
                // TryParse mencegah aplikasi error ketika harga bukan angka yang valid.
                MessageBox.Show("Harga harus berupa angka yang valid!");
                stok = 0;
                return false;
            }

            if (!int.TryParse(textStok.Text.Trim(), out stok))
            {
                // Stok harus berupa bilangan bulat, misalnya 5, bukan 5,5.
                MessageBox.Show("Stok harus berupa bilangan bulat yang valid!");
                return false;
            }

            return true;
        }

        // Memindahkan data dari baris tabel ke kotak input agar bisa dilihat atau diedit.
        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // RowIndex bernilai negatif saat pengguna mengeklik header tabel.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduk.Rows[e.RowIndex];
                if (row.Cells[0].Value != null)
                {
                    // Simpan ID baris yang dipilih supaya tombol ubah dan hapus tahu targetnya.
                    idProdukTerpilih = Convert.ToInt32(row.Cells[0].Value);
                    textNamaProduk.Text = row.Cells[1].Value.ToString();
                    cmbVarian.Text = row.Cells[2].Value.ToString();
                    textHarga.Text = row.Cells[3].Value.ToString();
                    textStok.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : "0";
                }
            }
        }

        // Menambahkan produk baru setelah semua input dinyatakan valid.
        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Data divalidasi sebelum koneksi database dibuka.
            if (!CobaAmbilDataProduk(out string nama, out decimal harga, out int stok))
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    // Nama kategori perlu dicari ID-nya karena tabel produk menyimpan ID kategori.
                    int idKat = AmbilIdKategori(cmbVarian.Text, conn);

                    // Query berparameter menyimpan produk baru tanpa menggabungkan input ke SQL langsung.
                    string query = "INSERT INTO produk (id_kategori, nama_produk, harga, stok) VALUES (@idKat, @nama, @harga, @stok)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idKat", idKat);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        // Jalankan perintah INSERT karena query ini tidak mengembalikan daftar data.
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produk berhasil ditambah!");
                    // Kosongkan form lalu muat ulang tabel agar produk baru langsung terlihat.
                    Bersihkan();
                    TampilProduk();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengubah data produk yang sebelumnya dipilih pada tabel.
        private void btnUbah_Click(object sender, EventArgs e)
        {
            // Perubahan tidak bisa dilakukan sebelum pengguna memilih produk.
            if (idProdukTerpilih == 0)
            {
                MessageBox.Show("Pilih produk di tabel dulu!");
                return;
            }

            if (!CobaAmbilDataProduk(out string nama, out decimal harga, out int stok))
            {
                return;
            }

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    int idKat = AmbilIdKategori(cmbVarian.Text, conn);

                    // Klausa WHERE memastikan hanya produk yang dipilih yang akan diperbarui.
                    string query = "UPDATE produk SET id_kategori = @idKat, nama_produk = @nama, harga = @harga, stok = @stok WHERE id_produk = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idKat", idKat);
                        cmd.Parameters.AddWithValue("@nama", nama);
                        cmd.Parameters.AddWithValue("@harga", harga);
                        cmd.Parameters.AddWithValue("@stok", stok);
                        cmd.Parameters.AddWithValue("@id", idProdukTerpilih);
                        // Jalankan perintah UPDATE untuk menyimpan perubahan produk.
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produk & stok berhasil diubah!");
                    // Setelah berhasil, hapus pilihan lama dan tampilkan data terbaru.
                    Bersihkan();
                    TampilProduk();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Menghapus produk yang sedang dipilih pada tabel.
        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Pastikan ada produk yang dipilih agar tidak menghapus data yang salah.
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
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProdukTerpilih);
                        // ID menjadi syarat agar hanya satu produk yang dipilih yang dihapus.
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Produk berhasil dihapus!");
                    // Reset pilihan dan perbarui isi tabel setelah penghapusan.
                    Bersihkan();
                    TampilProduk();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Mengosongkan input form dan menghapus status produk yang sedang dipilih.
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
            // Reset input dan pilihan produk sebelum memuat kembali semua produk.
            Bersihkan();
            // Tampilkan kembali semua produk setelah pencarian di-reset.
            TampilProduk();
        }

        // Memperbarui hasil pencarian setiap kali teks pencarian berubah.
        private void textCariProduk_TextChanged(object sender, EventArgs e)
        {
            // Gunakan teks yang sudah dibersihkan dari spasi luar sebagai kata pencarian.
            TampilProduk(textCariProduk.Text.Trim());
        }

        private void textNamaProduk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
