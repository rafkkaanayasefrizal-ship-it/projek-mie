namespace projek_mie
{
    partial class FormDashboard
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
            this.lblJudulPage = new System.Windows.Forms.Label();
            this.lblSubJudulPage = new System.Windows.Forms.Label();
            this.panelCardPesananAktif = new System.Windows.Forms.Panel();
            this.lblPesananAktif = new System.Windows.Forms.Label();
            this.lblCardTitlePesananAktif = new System.Windows.Forms.Label();
            this.panelCardTotalPesanan = new System.Windows.Forms.Panel();
            this.lblTotalPesanan = new System.Windows.Forms.Label();
            this.lblCardTitleTotalPesanan = new System.Windows.Forms.Label();
            this.panelCardTotalBelanja = new System.Windows.Forms.Panel();
            this.lblTotalBelanja = new System.Windows.Forms.Label();
            this.lblCardTitleTotalBelanja = new System.Windows.Forms.Label();
            this.lblJudulTabel = new System.Windows.Forms.Label();
            this.dgvPesananKamu = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesanSekarang = new System.Windows.Forms.Button();
            this.btnLihatRiwayat = new System.Windows.Forms.Button();
            this.lblStatusFooter = new System.Windows.Forms.Label();
            this.panelCardPesananAktif.SuspendLayout();
            this.panelCardTotalPesanan.SuspendLayout();
            this.panelCardTotalBelanja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesananKamu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudulPage
            // 
            this.lblJudulPage.AutoSize = true;
            this.lblJudulPage.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulPage.Location = new System.Drawing.Point(25, 9);
            this.lblJudulPage.Name = "lblJudulPage";
            this.lblJudulPage.Size = new System.Drawing.Size(97, 20);
            this.lblJudulPage.TabIndex = 8;
            this.lblJudulPage.Text = "Dashboard";
            // 
            // lblSubJudulPage
            // 
            this.lblSubJudulPage.AutoSize = true;
            this.lblSubJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudulPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudulPage.Location = new System.Drawing.Point(26, 29);
            this.lblSubJudulPage.Name = "lblSubJudulPage";
            this.lblSubJudulPage.Size = new System.Drawing.Size(223, 15);
            this.lblSubJudulPage.TabIndex = 9;
            this.lblSubJudulPage.Text = "Pilih mie favoritmu dan pesan langsung";
            // 
            // panelCardPesananAktif
            // 
            this.panelCardPesananAktif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCardPesananAktif.Controls.Add(this.lblPesananAktif);
            this.panelCardPesananAktif.Controls.Add(this.lblCardTitlePesananAktif);
            this.panelCardPesananAktif.Location = new System.Drawing.Point(29, 64);
            this.panelCardPesananAktif.Name = "panelCardPesananAktif";
            this.panelCardPesananAktif.Size = new System.Drawing.Size(220, 100);
            this.panelCardPesananAktif.TabIndex = 10;
            // 
            // lblPesananAktif
            // 
            this.lblPesananAktif.AutoSize = true;
            this.lblPesananAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesananAktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPesananAktif.Location = new System.Drawing.Point(19, 57);
            this.lblPesananAktif.Name = "lblPesananAktif";
            this.lblPesananAktif.Size = new System.Drawing.Size(20, 24);
            this.lblPesananAktif.TabIndex = 14;
            this.lblPesananAktif.Text = "1";
            // 
            // lblCardTitlePesananAktif
            // 
            this.lblCardTitlePesananAktif.AutoSize = true;
            this.lblCardTitlePesananAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitlePesananAktif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCardTitlePesananAktif.Location = new System.Drawing.Point(19, 14);
            this.lblCardTitlePesananAktif.Name = "lblCardTitlePesananAktif";
            this.lblCardTitlePesananAktif.Size = new System.Drawing.Size(81, 15);
            this.lblCardTitlePesananAktif.TabIndex = 13;
            this.lblCardTitlePesananAktif.Text = "Pesanan Aktif";
            // 
            // panelCardTotalPesanan
            // 
            this.panelCardTotalPesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCardTotalPesanan.Controls.Add(this.lblTotalPesanan);
            this.panelCardTotalPesanan.Controls.Add(this.lblCardTitleTotalPesanan);
            this.panelCardTotalPesanan.Location = new System.Drawing.Point(282, 64);
            this.panelCardTotalPesanan.Name = "panelCardTotalPesanan";
            this.panelCardTotalPesanan.Size = new System.Drawing.Size(225, 100);
            this.panelCardTotalPesanan.TabIndex = 11;
            // 
            // lblTotalPesanan
            // 
            this.lblTotalPesanan.AutoSize = true;
            this.lblTotalPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalPesanan.Location = new System.Drawing.Point(19, 57);
            this.lblTotalPesanan.Name = "lblTotalPesanan";
            this.lblTotalPesanan.Size = new System.Drawing.Size(21, 24);
            this.lblTotalPesanan.TabIndex = 16;
            this.lblTotalPesanan.Text = "2";
            // 
            // lblCardTitleTotalPesanan
            // 
            this.lblCardTitleTotalPesanan.AutoSize = true;
            this.lblCardTitleTotalPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitleTotalPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCardTitleTotalPesanan.Location = new System.Drawing.Point(19, 14);
            this.lblCardTitleTotalPesanan.Name = "lblCardTitleTotalPesanan";
            this.lblCardTitleTotalPesanan.Size = new System.Drawing.Size(86, 15);
            this.lblCardTitleTotalPesanan.TabIndex = 15;
            this.lblCardTitleTotalPesanan.Text = "Total Pesanan";
            // 
            // panelCardTotalBelanja
            // 
            this.panelCardTotalBelanja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCardTotalBelanja.Controls.Add(this.lblTotalBelanja);
            this.panelCardTotalBelanja.Controls.Add(this.lblCardTitleTotalBelanja);
            this.panelCardTotalBelanja.Location = new System.Drawing.Point(532, 64);
            this.panelCardTotalBelanja.Name = "panelCardTotalBelanja";
            this.panelCardTotalBelanja.Size = new System.Drawing.Size(229, 100);
            this.panelCardTotalBelanja.TabIndex = 12;
            // 
            // lblTotalBelanja
            // 
            this.lblTotalBelanja.AutoSize = true;
            this.lblTotalBelanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBelanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalBelanja.Location = new System.Drawing.Point(17, 57);
            this.lblTotalBelanja.Name = "lblTotalBelanja";
            this.lblTotalBelanja.Size = new System.Drawing.Size(97, 24);
            this.lblTotalBelanja.TabIndex = 18;
            this.lblTotalBelanja.Text = "Rp32.000";
            // 
            // lblCardTitleTotalBelanja
            // 
            this.lblCardTitleTotalBelanja.AutoSize = true;
            this.lblCardTitleTotalBelanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitleTotalBelanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCardTitleTotalBelanja.Location = new System.Drawing.Point(17, 14);
            this.lblCardTitleTotalBelanja.Name = "lblCardTitleTotalBelanja";
            this.lblCardTitleTotalBelanja.Size = new System.Drawing.Size(79, 15);
            this.lblCardTitleTotalBelanja.TabIndex = 17;
            this.lblCardTitleTotalBelanja.Text = "Total Belanja";
            // 
            // lblJudulTabel
            // 
            this.lblJudulTabel.AutoSize = true;
            this.lblJudulTabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulTabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblJudulTabel.Location = new System.Drawing.Point(26, 180);
            this.lblJudulTabel.Name = "lblJudulTabel";
            this.lblJudulTabel.Size = new System.Drawing.Size(104, 15);
            this.lblJudulTabel.TabIndex = 19;
            this.lblJudulTabel.Text = "Pesanan Kamu";
            // 
            // dgvPesananKamu
            // 
            this.dgvPesananKamu.AllowUserToAddRows = false;
            this.dgvPesananKamu.AllowUserToDeleteRows = false;
            this.dgvPesananKamu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesananKamu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvPesananKamu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesananKamu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu,
            this.varian,
            this.harga});
            this.dgvPesananKamu.Location = new System.Drawing.Point(29, 206);
            this.dgvPesananKamu.Name = "dgvPesananKamu";
            this.dgvPesananKamu.ReadOnly = true;
            this.dgvPesananKamu.Size = new System.Drawing.Size(575, 150);
            this.dgvPesananKamu.TabIndex = 20;
            // 
            // menu
            // 
            this.menu.HeaderText = "Menu";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
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
            // btnPesanSekarang
            // 
            this.btnPesanSekarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPesanSekarang.Location = new System.Drawing.Point(620, 206);
            this.btnPesanSekarang.Name = "btnPesanSekarang";
            this.btnPesanSekarang.Size = new System.Drawing.Size(141, 36);
            this.btnPesanSekarang.TabIndex = 21;
            this.btnPesanSekarang.Text = "Pesan Sekarang";
            this.btnPesanSekarang.UseVisualStyleBackColor = false;
            // 
            // btnLihatRiwayat
            // 
            this.btnLihatRiwayat.BackColor = System.Drawing.Color.White;
            this.btnLihatRiwayat.Location = new System.Drawing.Point(620, 259);
            this.btnLihatRiwayat.Name = "btnLihatRiwayat";
            this.btnLihatRiwayat.Size = new System.Drawing.Size(141, 36);
            this.btnLihatRiwayat.TabIndex = 22;
            this.btnLihatRiwayat.Text = "Lihat Riwayat";
            this.btnLihatRiwayat.UseVisualStyleBackColor = false;
            // 
            // lblStatusFooter
            // 
            this.lblStatusFooter.AutoSize = true;
            this.lblStatusFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatusFooter.Location = new System.Drawing.Point(26, 376);
            this.lblStatusFooter.Name = "lblStatusFooter";
            this.lblStatusFooter.Size = new System.Drawing.Size(28, 13);
            this.lblStatusFooter.TabIndex = 23;
            this.lblStatusFooter.Text = "Siap";
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.lblStatusFooter);
            this.Controls.Add(this.btnLihatRiwayat);
            this.Controls.Add(this.btnPesanSekarang);
            this.Controls.Add(this.dgvPesananKamu);
            this.Controls.Add(this.lblJudulTabel);
            this.Controls.Add(this.panelCardTotalBelanja);
            this.Controls.Add(this.panelCardTotalPesanan);
            this.Controls.Add(this.panelCardPesananAktif);
            this.Controls.Add(this.lblSubJudulPage);
            this.Controls.Add(this.lblJudulPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.panelCardPesananAktif.ResumeLayout(false);
            this.panelCardPesananAktif.PerformLayout();
            this.panelCardTotalPesanan.ResumeLayout(false);
            this.panelCardTotalPesanan.PerformLayout();
            this.panelCardTotalBelanja.ResumeLayout(false);
            this.panelCardTotalBelanja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesananKamu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudulPage;
        private System.Windows.Forms.Label lblSubJudulPage;
        private System.Windows.Forms.Panel panelCardPesananAktif;
        private System.Windows.Forms.Label lblPesananAktif;
        private System.Windows.Forms.Label lblCardTitlePesananAktif;
        private System.Windows.Forms.Panel panelCardTotalPesanan;
        private System.Windows.Forms.Label lblTotalPesanan;
        private System.Windows.Forms.Label lblCardTitleTotalPesanan;
        private System.Windows.Forms.Panel panelCardTotalBelanja;
        private System.Windows.Forms.Label lblTotalBelanja;
        private System.Windows.Forms.Label lblCardTitleTotalBelanja;
        private System.Windows.Forms.Label lblJudulTabel;
        internal System.Windows.Forms.DataGridView dgvPesananKamu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn varian;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.Button btnPesanSekarang;
        private System.Windows.Forms.Button btnLihatRiwayat;
        private System.Windows.Forms.Label lblStatusFooter;
    }
}
