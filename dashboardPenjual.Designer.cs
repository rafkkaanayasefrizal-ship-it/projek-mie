namespace projek_mie
{
    partial class dashboardPenjual
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
            this.panelCardPesananMasuk = new System.Windows.Forms.Panel();
            this.lblPesananMasuk = new System.Windows.Forms.Label();
            this.lblCardTitlePesananMasuk = new System.Windows.Forms.Label();
            this.panelCardPendapatan = new System.Windows.Forms.Panel();
            this.lblPendapatanHariIni = new System.Windows.Forms.Label();
            this.lblCardTitlePendapatan = new System.Windows.Forms.Label();
            this.panelCardMenuTerjual = new System.Windows.Forms.Panel();
            this.lblMenuTerjual = new System.Windows.Forms.Label();
            this.lblCardTitleMenuTerjual = new System.Windows.Forms.Label();
            this.panelCardMenuTerlaris = new System.Windows.Forms.Panel();
            this.lblMenuTerlaris = new System.Windows.Forms.Label();
            this.lblCardTitleMenuTerlaris = new System.Windows.Forms.Label();
            this.lblJudulTabel = new System.Windows.Forms.Label();
            this.dgvPesananMasuk = new System.Windows.Forms.DataGridView();
            this.noAntrian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHarga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.lblFooterKiri = new System.Windows.Forms.Label();
            this.lblFooterKanan = new System.Windows.Forms.Label();
            this.panelCardPesananMasuk.SuspendLayout();
            this.panelCardPendapatan.SuspendLayout();
            this.panelCardMenuTerjual.SuspendLayout();
            this.panelCardMenuTerlaris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesananMasuk)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudulPage
            // 
            this.lblJudulPage.AutoSize = true;
            this.lblJudulPage.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulPage.Location = new System.Drawing.Point(12, 9);
            this.lblJudulPage.Name = "lblJudulPage";
            this.lblJudulPage.Size = new System.Drawing.Size(161, 20);
            this.lblJudulPage.TabIndex = 9;
            this.lblJudulPage.Text = "Dashboard Penjual";
            // 
            // lblSubJudulPage
            // 
            this.lblSubJudulPage.AutoSize = true;
            this.lblSubJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudulPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudulPage.Location = new System.Drawing.Point(12, 33);
            this.lblSubJudulPage.Name = "lblSubJudulPage";
            this.lblSubJudulPage.Size = new System.Drawing.Size(262, 15);
            this.lblSubJudulPage.TabIndex = 11;
            this.lblSubJudulPage.Text = "Pantau pesanan masuk dan penjualan hari ini.";
            // 
            // panelCardPesananMasuk
            // 
            this.panelCardPesananMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCardPesananMasuk.Controls.Add(this.lblPesananMasuk);
            this.panelCardPesananMasuk.Controls.Add(this.lblCardTitlePesananMasuk);
            this.panelCardPesananMasuk.Location = new System.Drawing.Point(15, 52);
            this.panelCardPesananMasuk.Name = "panelCardPesananMasuk";
            this.panelCardPesananMasuk.Size = new System.Drawing.Size(181, 85);
            this.panelCardPesananMasuk.TabIndex = 12;
            // 
            // lblPesananMasuk
            // 
            this.lblPesananMasuk.AutoSize = true;
            this.lblPesananMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesananMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPesananMasuk.Location = new System.Drawing.Point(19, 45);
            this.lblPesananMasuk.Name = "lblPesananMasuk";
            this.lblPesananMasuk.Size = new System.Drawing.Size(21, 24);
            this.lblPesananMasuk.TabIndex = 14;
            this.lblPesananMasuk.Text = "0";
            // 
            // lblCardTitlePesananMasuk
            // 
            this.lblCardTitlePesananMasuk.AutoSize = true;
            this.lblCardTitlePesananMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitlePesananMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCardTitlePesananMasuk.Location = new System.Drawing.Point(19, 12);
            this.lblCardTitlePesananMasuk.Name = "lblCardTitlePesananMasuk";
            this.lblCardTitlePesananMasuk.Size = new System.Drawing.Size(96, 15);
            this.lblCardTitlePesananMasuk.TabIndex = 13;
            this.lblCardTitlePesananMasuk.Text = "Pesanan Masuk";
            // 
            // panelCardPendapatan
            // 
            this.panelCardPendapatan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCardPendapatan.Controls.Add(this.lblPendapatanHariIni);
            this.panelCardPendapatan.Controls.Add(this.lblCardTitlePendapatan);
            this.panelCardPendapatan.Location = new System.Drawing.Point(218, 52);
            this.panelCardPendapatan.Name = "panelCardPendapatan";
            this.panelCardPendapatan.Size = new System.Drawing.Size(181, 85);
            this.panelCardPendapatan.TabIndex = 15;
            // 
            // lblPendapatanHariIni
            // 
            this.lblPendapatanHariIni.AutoSize = true;
            this.lblPendapatanHariIni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendapatanHariIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPendapatanHariIni.Location = new System.Drawing.Point(19, 45);
            this.lblPendapatanHariIni.Name = "lblPendapatanHariIni";
            this.lblPendapatanHariIni.Size = new System.Drawing.Size(53, 24);
            this.lblPendapatanHariIni.TabIndex = 14;
            this.lblPendapatanHariIni.Text = "Rp 0";
            // 
            // lblCardTitlePendapatan
            // 
            this.lblCardTitlePendapatan.AutoSize = true;
            this.lblCardTitlePendapatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitlePendapatan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCardTitlePendapatan.Location = new System.Drawing.Point(19, 12);
            this.lblCardTitlePendapatan.Name = "lblCardTitlePendapatan";
            this.lblCardTitlePendapatan.Size = new System.Drawing.Size(116, 15);
            this.lblCardTitlePendapatan.TabIndex = 13;
            this.lblCardTitlePendapatan.Text = "Pendapatan Hari Ini";
            // 
            // panelCardMenuTerjual
            // 
            this.panelCardMenuTerjual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCardMenuTerjual.Controls.Add(this.lblMenuTerjual);
            this.panelCardMenuTerjual.Controls.Add(this.lblCardTitleMenuTerjual);
            this.panelCardMenuTerjual.Location = new System.Drawing.Point(405, 52);
            this.panelCardMenuTerjual.Name = "panelCardMenuTerjual";
            this.panelCardMenuTerjual.Size = new System.Drawing.Size(181, 85);
            this.panelCardMenuTerjual.TabIndex = 15;
            // 
            // lblMenuTerjual
            // 
            this.lblMenuTerjual.AutoSize = true;
            this.lblMenuTerjual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTerjual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMenuTerjual.Location = new System.Drawing.Point(19, 45);
            this.lblMenuTerjual.Name = "lblMenuTerjual";
            this.lblMenuTerjual.Size = new System.Drawing.Size(21, 24);
            this.lblMenuTerjual.TabIndex = 14;
            this.lblMenuTerjual.Text = "0";
            // 
            // lblCardTitleMenuTerjual
            // 
            this.lblCardTitleMenuTerjual.AutoSize = true;
            this.lblCardTitleMenuTerjual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitleMenuTerjual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCardTitleMenuTerjual.Location = new System.Drawing.Point(19, 12);
            this.lblCardTitleMenuTerjual.Name = "lblCardTitleMenuTerjual";
            this.lblCardTitleMenuTerjual.Size = new System.Drawing.Size(80, 15);
            this.lblCardTitleMenuTerjual.TabIndex = 13;
            this.lblCardTitleMenuTerjual.Text = "Menu Terjual";
            // 
            // panelCardMenuTerlaris
            // 
            this.panelCardMenuTerlaris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelCardMenuTerlaris.Controls.Add(this.lblMenuTerlaris);
            this.panelCardMenuTerlaris.Controls.Add(this.lblCardTitleMenuTerlaris);
            this.panelCardMenuTerlaris.Location = new System.Drawing.Point(607, 52);
            this.panelCardMenuTerlaris.Name = "panelCardMenuTerlaris";
            this.panelCardMenuTerlaris.Size = new System.Drawing.Size(181, 85);
            this.panelCardMenuTerlaris.TabIndex = 15;
            // 
            // lblMenuTerlaris
            // 
            this.lblMenuTerlaris.AutoSize = true;
            this.lblMenuTerlaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTerlaris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMenuTerlaris.Location = new System.Drawing.Point(19, 45);
            this.lblMenuTerlaris.Name = "lblMenuTerlaris";
            this.lblMenuTerlaris.Size = new System.Drawing.Size(12, 16);
            this.lblMenuTerlaris.TabIndex = 14;
            this.lblMenuTerlaris.Text = "-";
            // 
            // lblCardTitleMenuTerlaris
            // 
            this.lblCardTitleMenuTerlaris.AutoSize = true;
            this.lblCardTitleMenuTerlaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTitleMenuTerlaris.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCardTitleMenuTerlaris.Location = new System.Drawing.Point(19, 12);
            this.lblCardTitleMenuTerlaris.Name = "lblCardTitleMenuTerlaris";
            this.lblCardTitleMenuTerlaris.Size = new System.Drawing.Size(83, 15);
            this.lblCardTitleMenuTerlaris.TabIndex = 13;
            this.lblCardTitleMenuTerlaris.Text = "Menu Terlaris";
            // 
            // lblJudulTabel
            // 
            this.lblJudulTabel.AutoSize = true;
            this.lblJudulTabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulTabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblJudulTabel.Location = new System.Drawing.Point(12, 146);
            this.lblJudulTabel.Name = "lblJudulTabel";
            this.lblJudulTabel.Size = new System.Drawing.Size(109, 15);
            this.lblJudulTabel.TabIndex = 20;
            this.lblJudulTabel.Text = "Pesanan Masuk";
            // 
            // dgvPesananMasuk
            // 
            this.dgvPesananMasuk.AllowUserToAddRows = false;
            this.dgvPesananMasuk.AllowUserToDeleteRows = false;
            this.dgvPesananMasuk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPesananMasuk.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvPesananMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesananMasuk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noAntrian,
            this.namaPelanggan,
            this.menu,
            this.totalHarga,
            this.status});
            this.dgvPesananMasuk.Location = new System.Drawing.Point(12, 166);
            this.dgvPesananMasuk.Name = "dgvPesananMasuk";
            this.dgvPesananMasuk.ReadOnly = true;
            this.dgvPesananMasuk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesananMasuk.Size = new System.Drawing.Size(760, 125);
            this.dgvPesananMasuk.TabIndex = 21;
            // 
            // noAntrian
            // 
            this.noAntrian.HeaderText = "No Antrean";
            this.noAntrian.Name = "noAntrian";
            this.noAntrian.ReadOnly = true;
            // 
            // namaPelanggan
            // 
            this.namaPelanggan.HeaderText = "Pelanggan";
            this.namaPelanggan.Name = "namaPelanggan";
            this.namaPelanggan.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.HeaderText = "Menu";
            this.menu.Name = "menu";
            this.menu.ReadOnly = true;
            // 
            // totalHarga
            // 
            this.totalHarga.HeaderText = "Total";
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // btnProses
            // 
            this.btnProses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(173)))), ((int)(((byte)(43)))));
            this.btnProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProses.Location = new System.Drawing.Point(12, 298);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(140, 32);
            this.btnProses.TabIndex = 22;
            this.btnProses.Text = "Proses Pesanan";
            this.btnProses.UseVisualStyleBackColor = false;
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.White;
            this.btnSelesai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelesai.Location = new System.Drawing.Point(164, 298);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(140, 32);
            this.btnSelesai.TabIndex = 23;
            this.btnSelesai.Text = "Tandai Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            // 
            // btnTolak
            // 
            this.btnTolak.BackColor = System.Drawing.Color.White;
            this.btnTolak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTolak.Location = new System.Drawing.Point(316, 298);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(140, 32);
            this.btnTolak.TabIndex = 24;
            this.btnTolak.Text = "Batalkan";
            this.btnTolak.UseVisualStyleBackColor = false;
            // 
            // lblFooterKiri
            // 
            this.lblFooterKiri.AutoSize = true;
            this.lblFooterKiri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFooterKiri.Location = new System.Drawing.Point(12, 338);
            this.lblFooterKiri.Name = "lblFooterKiri";
            this.lblFooterKiri.Size = new System.Drawing.Size(90, 13);
            this.lblFooterKiri.TabIndex = 25;
            this.lblFooterKiri.Text = "0 pesanan hari ini";
            // 
            // lblFooterKanan
            // 
            this.lblFooterKanan.AutoSize = true;
            this.lblFooterKanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFooterKanan.Location = new System.Drawing.Point(645, 338);
            this.lblFooterKanan.Name = "lblFooterKanan";
            this.lblFooterKanan.Size = new System.Drawing.Size(114, 13);
            this.lblFooterKanan.TabIndex = 26;
            this.lblFooterKanan.Text = "Login sebagai: Penjual";
            // 
            // dashboardPenjual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.lblFooterKanan);
            this.Controls.Add(this.lblFooterKiri);
            this.Controls.Add(this.btnTolak);
            this.Controls.Add(this.btnSelesai);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.dgvPesananMasuk);
            this.Controls.Add(this.lblJudulTabel);
            this.Controls.Add(this.panelCardMenuTerlaris);
            this.Controls.Add(this.panelCardMenuTerjual);
            this.Controls.Add(this.panelCardPendapatan);
            this.Controls.Add(this.panelCardPesananMasuk);
            this.Controls.Add(this.lblSubJudulPage);
            this.Controls.Add(this.lblJudulPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardPenjual";
            this.Text = "dashboardPenjual";
            this.panelCardPesananMasuk.ResumeLayout(false);
            this.panelCardPesananMasuk.PerformLayout();
            this.panelCardPendapatan.ResumeLayout(false);
            this.panelCardPendapatan.PerformLayout();
            this.panelCardMenuTerjual.ResumeLayout(false);
            this.panelCardMenuTerjual.PerformLayout();
            this.panelCardMenuTerlaris.ResumeLayout(false);
            this.panelCardMenuTerlaris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesananMasuk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudulPage;
        private System.Windows.Forms.Label lblSubJudulPage;
        private System.Windows.Forms.Panel panelCardPesananMasuk;
        private System.Windows.Forms.Label lblPesananMasuk;
        private System.Windows.Forms.Label lblCardTitlePesananMasuk;
        private System.Windows.Forms.Panel panelCardPendapatan;
        private System.Windows.Forms.Label lblPendapatanHariIni;
        private System.Windows.Forms.Label lblCardTitlePendapatan;
        private System.Windows.Forms.Panel panelCardMenuTerjual;
        private System.Windows.Forms.Label lblMenuTerjual;
        private System.Windows.Forms.Label lblCardTitleMenuTerjual;
        private System.Windows.Forms.Panel panelCardMenuTerlaris;
        private System.Windows.Forms.Label lblMenuTerlaris;
        private System.Windows.Forms.Label lblCardTitleMenuTerlaris;
        private System.Windows.Forms.Label lblJudulTabel;
        private System.Windows.Forms.DataGridView dgvPesananMasuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn noAntrian;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHarga;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.Label lblFooterKiri;
        private System.Windows.Forms.Label lblFooterKanan;
    }
}
