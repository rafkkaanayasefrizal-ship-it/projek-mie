namespace projek_mie
{
    partial class FormPesan
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
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.menu2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.topings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapusItem = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotalBayarTitle = new System.Windows.Forms.Label();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.panelPilihanItem = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblSubtotalTitle = new System.Windows.Forms.Label();
            this.numJumlah = new System.Windows.Forms.NumericUpDown();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.btnTambahPesanan = new System.Windows.Forms.Button();
            this.lblTitleTopings = new System.Windows.Forms.Label();
            this.lblSpacer = new System.Windows.Forms.Label();
            this.rbPilus = new System.Windows.Forms.RadioButton();
            this.rbTelur = new System.Windows.Forms.RadioButton();
            this.lblJudulKeranjang = new System.Windows.Forms.Label();
            this.lblStatusFooter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.panelPilihanItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudulPage
            // 
            this.lblJudulPage.AutoSize = true;
            this.lblJudulPage.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulPage.Location = new System.Drawing.Point(19, 9);
            this.lblJudulPage.Name = "lblJudulPage";
            this.lblJudulPage.Size = new System.Drawing.Size(92, 20);
            this.lblJudulPage.TabIndex = 1;
            this.lblJudulPage.Text = "Pesan Mie";
            // 
            // lblSubJudulPage
            // 
            this.lblSubJudulPage.AutoSize = true;
            this.lblSubJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudulPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudulPage.Location = new System.Drawing.Point(20, 40);
            this.lblSubJudulPage.Name = "lblSubJudulPage";
            this.lblSubJudulPage.Size = new System.Drawing.Size(295, 15);
            this.lblSubJudulPage.TabIndex = 5;
            this.lblSubJudulPage.Text = "Pilih menu,tambah topings,lalu masukan kepesanan";
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu,
            this.varian,
            this.harga});
            this.dgvMenu.Location = new System.Drawing.Point(23, 70);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.Size = new System.Drawing.Size(373, 150);
            this.dgvMenu.TabIndex = 6;
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
            // dgvKeranjang
            // 
            this.dgvKeranjang.AllowUserToAddRows = false;
            this.dgvKeranjang.AllowUserToDeleteRows = false;
            this.dgvKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKeranjang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu2,
            this.topings,
            this.jumlah,
            this.subtotal});
            this.dgvKeranjang.Location = new System.Drawing.Point(23, 260);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.ReadOnly = true;
            this.dgvKeranjang.Size = new System.Drawing.Size(764, 55);
            this.dgvKeranjang.TabIndex = 7;
            // 
            // menu2
            // 
            this.menu2.HeaderText = "Menu";
            this.menu2.Name = "menu2";
            this.menu2.ReadOnly = true;
            // 
            // topings
            // 
            this.topings.HeaderText = "Topings";
            this.topings.Name = "topings";
            this.topings.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // btnHapusItem
            // 
            this.btnHapusItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHapusItem.Location = new System.Drawing.Point(23, 321);
            this.btnHapusItem.Name = "btnHapusItem";
            this.btnHapusItem.Size = new System.Drawing.Size(150, 31);
            this.btnHapusItem.TabIndex = 8;
            this.btnHapusItem.Text = "Hapus Pilihan";
            this.btnHapusItem.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheckout.Location = new System.Drawing.Point(637, 326);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(150, 31);
            this.btnCheckout.TabIndex = 9;
            this.btnCheckout.Text = "Pesan Sekarang";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // lblTotalBayarTitle
            // 
            this.lblTotalBayarTitle.AutoSize = true;
            this.lblTotalBayarTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalBayarTitle.Location = new System.Drawing.Point(446, 330);
            this.lblTotalBayarTitle.Name = "lblTotalBayarTitle";
            this.lblTotalBayarTitle.Size = new System.Drawing.Size(67, 13);
            this.lblTotalBayarTitle.TabIndex = 10;
            this.lblTotalBayarTitle.Text = "Total Bayar :";
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBayar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalBayar.Location = new System.Drawing.Point(528, 330);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(92, 20);
            this.lblTotalBayar.TabIndex = 11;
            this.lblTotalBayar.Text = "Rp 32.000";
            // 
            // panelPilihanItem
            // 
            this.panelPilihanItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPilihanItem.Controls.Add(this.lblSubtotal);
            this.panelPilihanItem.Controls.Add(this.lblSubtotalTitle);
            this.panelPilihanItem.Controls.Add(this.numJumlah);
            this.panelPilihanItem.Controls.Add(this.lblJumlah);
            this.panelPilihanItem.Controls.Add(this.btnTambahPesanan);
            this.panelPilihanItem.Controls.Add(this.lblTitleTopings);
            this.panelPilihanItem.Controls.Add(this.lblSpacer);
            this.panelPilihanItem.Controls.Add(this.rbPilus);
            this.panelPilihanItem.Controls.Add(this.rbTelur);
            this.panelPilihanItem.Location = new System.Drawing.Point(431, 70);
            this.panelPilihanItem.Name = "panelPilihanItem";
            this.panelPilihanItem.Size = new System.Drawing.Size(341, 150);
            this.panelPilihanItem.TabIndex = 12;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubtotal.Location = new System.Drawing.Point(197, 101);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(92, 20);
            this.lblSubtotal.TabIndex = 13;
            this.lblSubtotal.Text = "Rp 18.000";
            // 
            // lblSubtotalTitle
            // 
            this.lblSubtotalTitle.AutoSize = true;
            this.lblSubtotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubtotalTitle.Location = new System.Drawing.Point(198, 78);
            this.lblSubtotalTitle.Name = "lblSubtotalTitle";
            this.lblSubtotalTitle.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotalTitle.TabIndex = 11;
            this.lblSubtotalTitle.Text = "Subtotal";
            // 
            // numJumlah
            // 
            this.numJumlah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numJumlah.Location = new System.Drawing.Point(201, 32);
            this.numJumlah.Name = "numJumlah";
            this.numJumlah.Size = new System.Drawing.Size(94, 20);
            this.numJumlah.TabIndex = 10;
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblJumlah.Location = new System.Drawing.Point(198, 16);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(40, 13);
            this.lblJumlah.TabIndex = 6;
            this.lblJumlah.Text = "Jumlah";
            // 
            // btnTambahPesanan
            // 
            this.btnTambahPesanan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTambahPesanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahPesanan.Location = new System.Drawing.Point(20, 97);
            this.btnTambahPesanan.Name = "btnTambahPesanan";
            this.btnTambahPesanan.Size = new System.Drawing.Size(150, 31);
            this.btnTambahPesanan.TabIndex = 9;
            this.btnTambahPesanan.Text = "Tambah Ke Pesanan";
            this.btnTambahPesanan.UseVisualStyleBackColor = false;
            // 
            // lblTitleTopings
            // 
            this.lblTitleTopings.AutoSize = true;
            this.lblTitleTopings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleTopings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitleTopings.Location = new System.Drawing.Point(23, 0);
            this.lblTitleTopings.Name = "lblTitleTopings";
            this.lblTitleTopings.Size = new System.Drawing.Size(58, 15);
            this.lblTitleTopings.TabIndex = 7;
            this.lblTitleTopings.Text = "Topings";
            // 
            // lblSpacer
            // 
            this.lblSpacer.AutoSize = true;
            this.lblSpacer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSpacer.Location = new System.Drawing.Point(17, 0);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(0, 13);
            this.lblSpacer.TabIndex = 6;
            // 
            // rbPilus
            // 
            this.rbPilus.AutoSize = true;
            this.rbPilus.Location = new System.Drawing.Point(26, 74);
            this.rbPilus.Name = "rbPilus";
            this.rbPilus.Size = new System.Drawing.Size(100, 17);
            this.rbPilus.TabIndex = 1;
            this.rbPilus.TabStop = true;
            this.rbPilus.Text = "Pilus + Rp2.000";
            this.rbPilus.UseVisualStyleBackColor = true;
            // 
            // rbTelur
            // 
            this.rbTelur.AutoSize = true;
            this.rbTelur.Location = new System.Drawing.Point(26, 32);
            this.rbTelur.Name = "rbTelur";
            this.rbTelur.Size = new System.Drawing.Size(102, 17);
            this.rbTelur.TabIndex = 0;
            this.rbTelur.TabStop = true;
            this.rbTelur.Text = "Telur + Rp3.000";
            this.rbTelur.UseVisualStyleBackColor = true;
            this.rbTelur.CheckedChanged += new System.EventHandler(this.rbTelur_CheckedChanged);
            // 
            // lblJudulKeranjang
            // 
            this.lblJudulKeranjang.AutoSize = true;
            this.lblJudulKeranjang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulKeranjang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblJudulKeranjang.Location = new System.Drawing.Point(21, 233);
            this.lblJudulKeranjang.Name = "lblJudulKeranjang";
            this.lblJudulKeranjang.Size = new System.Drawing.Size(104, 15);
            this.lblJudulKeranjang.TabIndex = 14;
            this.lblJudulKeranjang.Text = "Pesanan Kamu";
            // 
            // lblStatusFooter
            // 
            this.lblStatusFooter.AutoSize = true;
            this.lblStatusFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatusFooter.Location = new System.Drawing.Point(21, 355);
            this.lblStatusFooter.Name = "lblStatusFooter";
            this.lblStatusFooter.Size = new System.Drawing.Size(28, 13);
            this.lblStatusFooter.TabIndex = 6;
            this.lblStatusFooter.Text = "Siap";
            // 
            // FormPesan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatusFooter);
            this.Controls.Add(this.lblJudulKeranjang);
            this.Controls.Add(this.panelPilihanItem);
            this.Controls.Add(this.lblTotalBayar);
            this.Controls.Add(this.lblTotalBayarTitle);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnHapusItem);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.lblSubJudulPage);
            this.Controls.Add(this.lblJudulPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormPesan";
            this.Text = "FormPesan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.panelPilihanItem.ResumeLayout(false);
            this.panelPilihanItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudulPage;
        private System.Windows.Forms.Label lblSubJudulPage;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Button btnHapusItem;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotalBayarTitle;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.Panel panelPilihanItem;
        private System.Windows.Forms.RadioButton rbPilus;
        private System.Windows.Forms.RadioButton rbTelur;
        private System.Windows.Forms.Label lblTitleTopings;
        private System.Windows.Forms.Label lblSpacer;
        private System.Windows.Forms.NumericUpDown numJumlah;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Button btnTambahPesanan;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblSubtotalTitle;
        internal System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn varian;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu2;
        private System.Windows.Forms.DataGridViewTextBoxColumn topings;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.Label lblJudulKeranjang;
        private System.Windows.Forms.Label lblStatusFooter;
    }
}
