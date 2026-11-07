namespace projek_mie
{
    partial class FormProduk
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblJudulPage = new System.Windows.Forms.Label();
            this.lblSubJudulPage = new System.Windows.Forms.Label();
            this.dgvProduk = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProduk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFormInput = new System.Windows.Forms.Panel();
            this.textStok = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.btnBersihkan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cmbVarian = new System.Windows.Forms.ComboBox();
            this.textHarga = new System.Windows.Forms.TextBox();
            this.textNamaProduk = new System.Windows.Forms.TextBox();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblVarian = new System.Windows.Forms.Label();
            this.lblNamaProduk = new System.Windows.Forms.Label();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.textCariProduk = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).BeginInit();
            this.panelFormInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudulPage
            // 
            this.lblJudulPage.AutoSize = true;
            this.lblJudulPage.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulPage.Location = new System.Drawing.Point(12, 0);
            this.lblJudulPage.Name = "lblJudulPage";
            this.lblJudulPage.Size = new System.Drawing.Size(109, 20);
            this.lblJudulPage.TabIndex = 10;
            this.lblJudulPage.Text = "Data Produk";
            // 
            // lblSubJudulPage
            // 
            this.lblSubJudulPage.AutoSize = true;
            this.lblSubJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudulPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudulPage.Location = new System.Drawing.Point(13, 20);
            this.lblSubJudulPage.Name = "lblSubJudulPage";
            this.lblSubJudulPage.Size = new System.Drawing.Size(219, 15);
            this.lblSubJudulPage.TabIndex = 12;
            this.lblSubJudulPage.Text = "Tambah, ubah, atur stok, atau hapus produk.";
            // 
            // dgvProduk
            // 
            this.dgvProduk.AllowUserToAddRows = false;
            this.dgvProduk.AllowUserToDeleteRows = false;
            this.dgvProduk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.namaProduk,
            this.varian,
            this.harga,
            this.stok});
            this.dgvProduk.Location = new System.Drawing.Point(16, 46);
            this.dgvProduk.Name = "dgvProduk";
            this.dgvProduk.ReadOnly = true;
            this.dgvProduk.Size = new System.Drawing.Size(469, 260);
            this.dgvProduk.TabIndex = 13;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // namaProduk
            // 
            this.namaProduk.HeaderText = "Nama Produk";
            this.namaProduk.Name = "namaProduk";
            this.namaProduk.ReadOnly = true;
            // 
            // varian
            // 
            this.varian.HeaderText = "Varian";
            this.varian.Name = "varian";
            this.varian.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // stok
            // 
            this.stok.HeaderText = "Stok";
            this.stok.Name = "stok";
            this.stok.ReadOnly = true;
            // 
            // panelFormInput
            // 
            this.panelFormInput.Controls.Add(this.textStok);
            this.panelFormInput.Controls.Add(this.lblStok);
            this.panelFormInput.Controls.Add(this.btnBersihkan);
            this.panelFormInput.Controls.Add(this.btnHapus);
            this.panelFormInput.Controls.Add(this.btnUbah);
            this.panelFormInput.Controls.Add(this.btnTambah);
            this.panelFormInput.Controls.Add(this.cmbVarian);
            this.panelFormInput.Controls.Add(this.textHarga);
            this.panelFormInput.Controls.Add(this.textNamaProduk);
            this.panelFormInput.Controls.Add(this.lblHarga);
            this.panelFormInput.Controls.Add(this.lblVarian);
            this.panelFormInput.Controls.Add(this.lblNamaProduk);
            this.panelFormInput.Controls.Add(this.lblFormHeader);
            this.panelFormInput.Location = new System.Drawing.Point(501, 46);
            this.panelFormInput.Name = "panelFormInput";
            this.panelFormInput.Size = new System.Drawing.Size(287, 330);
            this.panelFormInput.TabIndex = 14;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStok.Location = new System.Drawing.Point(3, 206);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(29, 13);
            this.lblStok.TabIndex = 23;
            this.lblStok.Text = "Stok";
            // 
            // textStok
            // 
            this.textStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStok.Location = new System.Drawing.Point(6, 222);
            this.textStok.Multiline = false;
            this.textStok.Name = "textStok";
            this.textStok.Size = new System.Drawing.Size(263, 24);
            this.textStok.TabIndex = 24;
            // 
            // btnBersihkan
            // 
            this.btnBersihkan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBersihkan.Location = new System.Drawing.Point(210, 265);
            this.btnBersihkan.Name = "btnBersihkan";
            this.btnBersihkan.Size = new System.Drawing.Size(65, 29);
            this.btnBersihkan.TabIndex = 22;
            this.btnBersihkan.Text = "Bersihkan";
            this.btnBersihkan.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHapus.Location = new System.Drawing.Point(142, 265);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(59, 29);
            this.btnHapus.TabIndex = 21;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUbah.Location = new System.Drawing.Point(74, 265);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(59, 29);
            this.btnUbah.TabIndex = 20;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTambah.Location = new System.Drawing.Point(6, 265);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(59, 29);
            this.btnTambah.TabIndex = 19;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // cmbVarian
            // 
            this.cmbVarian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVarian.FormattingEnabled = true;
            this.cmbVarian.Items.AddRange(new object[] {
            "Rebus",
            "Goreng"});
            this.cmbVarian.Location = new System.Drawing.Point(6, 112);
            this.cmbVarian.Name = "cmbVarian";
            this.cmbVarian.Size = new System.Drawing.Size(263, 24);
            this.cmbVarian.TabIndex = 18;
            // 
            // textHarga
            // 
            this.textHarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHarga.Location = new System.Drawing.Point(6, 167);
            this.textHarga.Multiline = false;
            this.textHarga.Name = "textHarga";
            this.textHarga.Size = new System.Drawing.Size(263, 24);
            this.textHarga.TabIndex = 17;
            // 
            // textNamaProduk
            // 
            this.textNamaProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textNamaProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNamaProduk.Location = new System.Drawing.Point(6, 55);
            this.textNamaProduk.Multiline = false;
            this.textNamaProduk.Name = "textNamaProduk";
            this.textNamaProduk.Size = new System.Drawing.Size(263, 24);
            this.textNamaProduk.TabIndex = 16;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoSize = true;
            this.lblHarga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHarga.Location = new System.Drawing.Point(3, 151);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(36, 13);
            this.lblHarga.TabIndex = 15;
            this.lblHarga.Text = "Harga";
            // 
            // lblVarian
            // 
            this.lblVarian.AutoSize = true;
            this.lblVarian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVarian.Location = new System.Drawing.Point(3, 96);
            this.lblVarian.Name = "lblVarian";
            this.lblVarian.Size = new System.Drawing.Size(37, 13);
            this.lblVarian.TabIndex = 14;
            this.lblVarian.Text = "Varian";
            // 
            // lblNamaProduk
            // 
            this.lblNamaProduk.AutoSize = true;
            this.lblNamaProduk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNamaProduk.Location = new System.Drawing.Point(3, 39);
            this.lblNamaProduk.Name = "lblNamaProduk";
            this.lblNamaProduk.Size = new System.Drawing.Size(72, 13);
            this.lblNamaProduk.TabIndex = 13;
            this.lblNamaProduk.Text = "Nama Produk";
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.AutoSize = true;
            this.lblFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFormHeader.Location = new System.Drawing.Point(3, 11);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(95, 15);
            this.lblFormHeader.TabIndex = 9;
            this.lblFormHeader.Text = "Detail Produk";
            // 
            // textCariProduk
            // 
            this.textCariProduk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textCariProduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCariProduk.Location = new System.Drawing.Point(623, 9);
            this.textCariProduk.Multiline = false;
            this.textCariProduk.Name = "textCariProduk";
            this.textCariProduk.Size = new System.Drawing.Size(160, 24);
            this.textCariProduk.TabIndex = 24;
            // 
            // FormProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textCariProduk);
            this.Controls.Add(this.panelFormInput);
            this.Controls.Add(this.dgvProduk);
            this.Controls.Add(this.lblSubJudulPage);
            this.Controls.Add(this.lblJudulPage);
            this.Name = "FormProduk";
            this.Text = "FormProduk";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduk)).EndInit();
            this.panelFormInput.ResumeLayout(false);
            this.panelFormInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudulPage;
        private System.Windows.Forms.Label lblSubJudulPage;
        private System.Windows.Forms.DataGridView dgvProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProduk;
        private System.Windows.Forms.DataGridViewTextBoxColumn varian;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.Panel panelFormInput;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblVarian;
        private System.Windows.Forms.Label lblNamaProduk;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox textStok;
        private System.Windows.Forms.TextBox textNamaProduk;
        private System.Windows.Forms.Button btnBersihkan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cmbVarian;
        private System.Windows.Forms.TextBox textHarga;
        private System.Windows.Forms.TextBox textCariProduk;
    }
}
