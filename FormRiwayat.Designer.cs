namespace projek_mie
{
    partial class FormRiwayat
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
            this.dtpTanggal = new System.Windows.Forms.DateTimePicker();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.dgvRiwayat = new System.Windows.Forms.DataGridView();
            this.antrian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalBelanja = new System.Windows.Forms.Label();
            this.lblTotalBelanjaTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudulPage
            // 
            this.lblJudulPage.AutoSize = true;
            this.lblJudulPage.BackColor = System.Drawing.Color.Transparent;
            this.lblJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudulPage.Location = new System.Drawing.Point(21, 9);
            this.lblJudulPage.Name = "lblJudulPage";
            this.lblJudulPage.Size = new System.Drawing.Size(147, 20);
            this.lblJudulPage.TabIndex = 9;
            this.lblJudulPage.Text = "Riwayat Pesanan";
            // 
            // lblSubJudulPage
            // 
            this.lblSubJudulPage.AutoSize = true;
            this.lblSubJudulPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudulPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudulPage.Location = new System.Drawing.Point(22, 44);
            this.lblSubJudulPage.Name = "lblSubJudulPage";
            this.lblSubJudulPage.Size = new System.Drawing.Size(230, 15);
            this.lblSubJudulPage.TabIndex = 10;
            this.lblSubJudulPage.Text = "Semua pesanan yang pernah kamu buat";
            // 
            // dtpTanggal
            // 
            this.dtpTanggal.Location = new System.Drawing.Point(74, 126);
            this.dtpTanggal.Name = "dtpTanggal";
            this.dtpTanggal.Size = new System.Drawing.Size(135, 20);
            this.dtpTanggal.TabIndex = 11;
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTanggal.Location = new System.Drawing.Point(22, 76);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(46, 13);
            this.lblTanggal.TabIndex = 12;
            this.lblTanggal.Text = "Tanggal";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(246, 129);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // cmbFilterStatus
            // 
            this.cmbFilterStatus.FormattingEnabled = true;
            this.cmbFilterStatus.Items.AddRange(new object[] {
            "Berhasil",
            "Gagal",
            "Proses"});
            this.cmbFilterStatus.Location = new System.Drawing.Point(293, 126);
            this.cmbFilterStatus.Name = "cmbFilterStatus";
            this.cmbFilterStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbFilterStatus.TabIndex = 14;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCari.Location = new System.Drawing.Point(447, 126);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 21);
            this.btnCari.TabIndex = 15;
            this.btnCari.Text = "cari";
            this.btnCari.UseVisualStyleBackColor = false;
            // 
            // dgvRiwayat
            // 
            this.dgvRiwayat.AllowUserToAddRows = false;
            this.dgvRiwayat.AllowUserToDeleteRows = false;
            this.dgvRiwayat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRiwayat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRiwayat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.antrian,
            this.tanggal,
            this.menu3,
            this.total,
            this.status});
            this.dgvRiwayat.Location = new System.Drawing.Point(25, 165);
            this.dgvRiwayat.Name = "dgvRiwayat";
            this.dgvRiwayat.ReadOnly = true;
            this.dgvRiwayat.Size = new System.Drawing.Size(748, 80);
            this.dgvRiwayat.TabIndex = 16;
            // 
            // antrian
            // 
            this.antrian.HeaderText = "No Antrian";
            this.antrian.Name = "antrian";
            this.antrian.ReadOnly = true;
            // 
            // tanggal
            // 
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.Name = "tanggal";
            this.tanggal.ReadOnly = true;
            // 
            // menu3
            // 
            this.menu3.HeaderText = "Menu";
            this.menu3.Name = "menu3";
            this.menu3.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // lblTotalBelanja
            // 
            this.lblTotalBelanja.AutoSize = true;
            this.lblTotalBelanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBelanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalBelanja.Location = new System.Drawing.Point(676, 276);
            this.lblTotalBelanja.Name = "lblTotalBelanja";
            this.lblTotalBelanja.Size = new System.Drawing.Size(97, 24);
            this.lblTotalBelanja.TabIndex = 19;
            this.lblTotalBelanja.Text = "Rp32.000";
            // 
            // lblTotalBelanjaTitle
            // 
            this.lblTotalBelanjaTitle.AutoSize = true;
            this.lblTotalBelanjaTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBelanjaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalBelanjaTitle.Location = new System.Drawing.Point(544, 282);
            this.lblTotalBelanjaTitle.Name = "lblTotalBelanjaTitle";
            this.lblTotalBelanjaTitle.Size = new System.Drawing.Size(79, 15);
            this.lblTotalBelanjaTitle.TabIndex = 20;
            this.lblTotalBelanjaTitle.Text = "Total Belanja";
            // 
            // FormRiwayat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.lblTotalBelanjaTitle);
            this.Controls.Add(this.lblTotalBelanja);
            this.Controls.Add(this.dgvRiwayat);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.cmbFilterStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.dtpTanggal);
            this.Controls.Add(this.lblSubJudulPage);
            this.Controls.Add(this.lblJudulPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRiwayat";
            this.Text = "FormRiwayat";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRiwayat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJudulPage;
        private System.Windows.Forms.Label lblSubJudulPage;
        private System.Windows.Forms.DateTimePicker dtpTanggal;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbFilterStatus;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.DataGridView dgvRiwayat;
        private System.Windows.Forms.DataGridViewTextBoxColumn antrian;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu3;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Label lblTotalBelanja;
        private System.Windows.Forms.Label lblTotalBelanjaTitle;
    }
}
