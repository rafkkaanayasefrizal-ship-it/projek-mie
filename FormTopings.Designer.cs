namespace projek_mie
{
    partial class FormTopings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTopings));
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.lblNavKategori = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.lblNavTopings = new System.Windows.Forms.Label();
            this.lblNavProduk = new System.Windows.Forms.Label();
            this.lblNavDashboard = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblJudulPage = new System.Windows.Forms.Label();
            this.lblSubJudulPage = new System.Windows.Forms.Label();
            this.dgvTopings = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaTopings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormInput = new System.Windows.Forms.Panel();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.textHargaTopings = new System.Windows.Forms.TextBox();
            this.textNamaTopings = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblNamaTopping = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.textCariTopings = new System.Windows.Forms.TextBox();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopings)).BeginInit();
            this.panelFormInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelNavbar.Controls.Add(this.lblNavKategori);
            this.panelNavbar.Controls.Add(this.btnKeluar);
            this.panelNavbar.Controls.Add(this.lblUserGreeting);
            this.panelNavbar.Controls.Add(this.lblNavTopings);
            this.panelNavbar.Controls.Add(this.lblNavProduk);
            this.panelNavbar.Controls.Add(this.lblNavDashboard);
            this.panelNavbar.Controls.Add(this.lblBrand);
            this.panelNavbar.Controls.Add(this.picLogo);
            this.panelNavbar.Location = new System.Drawing.Point(12, 12);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(776, 40);
            this.panelNavbar.TabIndex = 4;
            // 
            // lblNavKategori
            // 
            this.lblNavKategori.AutoSize = true;
            this.lblNavKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNavKategori.Location = new System.Drawing.Point(409, 15);
            this.lblNavKategori.Name = "lblNavKategori";
            this.lblNavKategori.Size = new System.Drawing.Size(46, 13);
            this.lblNavKategori.TabIndex = 8;
            this.lblNavKategori.Text = "Kategori";
            // 
            // btnKeluar
            // 
            this.btnKeluar.BackColor = System.Drawing.Color.White;
            this.btnKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKeluar.Location = new System.Drawing.Point(683, 9);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 7;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            // 
            // lblUserGreeting
            // 
            this.lblUserGreeting.AutoSize = true;
            this.lblUserGreeting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblUserGreeting.Location = new System.Drawing.Point(575, 15);
            this.lblUserGreeting.Name = "lblUserGreeting";
            this.lblUserGreeting.Size = new System.Drawing.Size(69, 13);
            this.lblUserGreeting.TabIndex = 6;
            this.lblUserGreeting.Text = "Halo,Pembeli";
            // 
            // lblNavTopings
            // 
            this.lblNavTopings.AutoSize = true;
            this.lblNavTopings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNavTopings.Location = new System.Drawing.Point(344, 15);
            this.lblNavTopings.Name = "lblNavTopings";
            this.lblNavTopings.Size = new System.Drawing.Size(45, 13);
            this.lblNavTopings.TabIndex = 5;
            this.lblNavTopings.Text = "Topings";
            // 
            // lblNavProduk
            // 
            this.lblNavProduk.AutoSize = true;
            this.lblNavProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNavProduk.Location = new System.Drawing.Point(283, 15);
            this.lblNavProduk.Name = "lblNavProduk";
            this.lblNavProduk.Size = new System.Drawing.Size(41, 13);
            this.lblNavProduk.TabIndex = 4;
            this.lblNavProduk.Text = "Produk";
            // 
            // lblNavDashboard
            // 
            this.lblNavDashboard.AutoSize = true;
            this.lblNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNavDashboard.Location = new System.Drawing.Point(199, 15);
            this.lblNavDashboard.Name = "lblNavDashboard";
            this.lblNavDashboard.Size = new System.Drawing.Size(59, 13);
            this.lblNavDashboard.TabIndex = 3;
            this.lblNavDashboard.Text = "Dashboard";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBrand.Location = new System.Drawing.Point(70, 13);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(75, 15);
            this.lblBrand.TabIndex = 2;
            this.lblBrand.Text = "NieNoodle";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(52, 41);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblJudulPage
            // 
            this.lblJudulPage.AutoSize = true;
            this.lblJudulPage.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulPage.Location = new System.Drawing.Point(12, 73);
            this.lblJudulPage.Name = "lblJudulPage";
            this.lblJudulPage.Size = new System.Drawing.Size(117, 20);
            this.lblJudulPage.TabIndex = 11;
            this.lblJudulPage.Text = "Data Topings";
            // 
            // lblSubJudulPage
            // 
            this.lblSubJudulPage.AutoSize = true;
            this.lblSubJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudulPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudulPage.Location = new System.Drawing.Point(13, 93);
            this.lblSubJudulPage.Name = "lblSubJudulPage";
            this.lblSubJudulPage.Size = new System.Drawing.Size(221, 15);
            this.lblSubJudulPage.TabIndex = 13;
            this.lblSubJudulPage.Text = "Tambah,ubah,atau,hapus data topings\r\n";
            // 
            // dgvTopings
            // 
            this.dgvTopings.AllowUserToAddRows = false;
            this.dgvTopings.AllowUserToDeleteRows = false;
            this.dgvTopings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvTopings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.namaTopings,
            this.harga});
            this.dgvTopings.Location = new System.Drawing.Point(12, 127);
            this.dgvTopings.Name = "dgvTopings";
            this.dgvTopings.ReadOnly = true;
            this.dgvTopings.Size = new System.Drawing.Size(462, 86);
            this.dgvTopings.TabIndex = 14;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // namaTopings
            // 
            this.namaTopings.HeaderText = "Nama Topings";
            this.namaTopings.Name = "namaTopings";
            this.namaTopings.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // panelFormInput
            // 
            this.panelFormInput.Controls.Add(this.btnBersihkan);
            this.panelFormInput.Controls.Add(this.btnHapus);
            this.panelFormInput.Controls.Add(this.btnUbah);
            this.panelFormInput.Controls.Add(this.btnTambah);
            this.panelFormInput.Controls.Add(this.textHargaTopings);
            this.panelFormInput.Controls.Add(this.textNamaTopings);
            this.panelFormInput.Controls.Add(this.lblHarga);
            this.panelFormInput.Controls.Add(this.lblNamaTopping);
            this.panelFormInput.Controls.Add(this.lblFormHeader);
            this.panelFormInput.Location = new System.Drawing.Point(501, 127);
            this.panelFormInput.Name = "panelFormInput";
            this.panelFormInput.Size = new System.Drawing.Size(287, 271);
            this.panelFormInput.TabIndex = 15;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBersihkan.Location = new System.Drawing.Point(220, 228);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(62, 29);
            this.btnBersihkan.TabIndex = 22;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHapus.Location = new System.Drawing.Point(145, 228);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(59, 29);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUbah.Location = new System.Drawing.Point(80, 228);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(59, 29);
            this.btnUbah.TabIndex = 20;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTambah.Location = new System.Drawing.Point(6, 228);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(59, 29);
            this.btnTambah.TabIndex = 19;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // textHargaTopings
            // 
            this.textHargaTopings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textHargaTopings.Location = new System.Drawing.Point(6, 117);
            this.textHargaTopings.Multiline = true;
            this.textHargaTopings.Name = "textHargaTopings";
            this.textHargaTopings.Size = new System.Drawing.Size(263, 26);
            this.textHargaTopings.TabIndex = 17;
            // 
            // textNamaTopings
            // 
            this.textNamaTopings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textNamaTopings.Location = new System.Drawing.Point(6, 55);
            this.textNamaTopings.Multiline = true;
            this.textNamaTopings.Name = "textNamaTopings";
            this.textNamaTopings.Size = new System.Drawing.Size(263, 26);
            this.textNamaTopings.TabIndex = 16;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHarga.Location = new System.Drawing.Point(3, 101);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 15;
            this.lblHarga.Text = "Harga";
            // 
            // lblNamaTopping
            // 
            this.lblNamaTopping.AutoSize = true;
            this.lblNamaTopping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNamaTopping.Location = new System.Drawing.Point(3, 39);
            this.lblNamaTopping.Name = "lblNamaTopping";
            this.lblNamaTopping.Size = new System.Drawing.Size(77, 13);
            this.lblNamaTopping.TabIndex = 13;
            this.lblNamaTopping.Text = "Nama Topping";
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFormHeader.Location = new System.Drawing.Point(3, 11);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(100, 15);
            this.lblFormHeader.TabIndex = 9;
            this.lblFormHeader.Text = "Detail Topings";
            // 
            // textCariTopings
            // 
            this.textCariTopings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textCariTopings.Location = new System.Drawing.Point(620, 83);
            this.textCariTopings.Multiline = true;
            this.textCariTopings.Name = "textCariTopings";
            this.textCariTopings.Size = new System.Drawing.Size(160, 26);
            this.textCariTopings.TabIndex = 24;
            // 
            // FormTopings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCariTopings);
            this.Controls.Add(this.panelFormInput);
            this.Controls.Add(this.dgvTopings);
            this.Controls.Add(this.lblSubJudulPage);
            this.Controls.Add(this.lblJudulPage);
            this.Controls.Add(this.panelNavbar);
            this.Name = "FormTopings";
            this.Text = "FormTopings";
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopings)).EndInit();
            this.panelFormInput.ResumeLayout(false);
            this.panelFormInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Label lblNavKategori;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblUserGreeting;
        private System.Windows.Forms.Label lblNavTopings;
        private System.Windows.Forms.Label lblNavProduk;
        private System.Windows.Forms.Label lblNavDashboard;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblJudulPage;
        private System.Windows.Forms.Label lblSubJudulPage;
        private System.Windows.Forms.DataGridView dgvTopings;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaTopings;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.Panel panelFormInput;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox textHargaTopings;
        private System.Windows.Forms.TextBox textNamaTopings;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblNamaTopping;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.TextBox textCariTopings;
    }
}
