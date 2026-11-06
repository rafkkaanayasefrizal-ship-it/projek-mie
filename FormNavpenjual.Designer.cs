namespace projek_mie
{
    partial class FormNavpenjual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavpenjual));
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.lblNavKategori = new System.Windows.Forms.Label();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblUserGreeting = new System.Windows.Forms.Label();
            this.lblNavTopings = new System.Windows.Forms.Label();
            this.lblNavProduk = new System.Windows.Forms.Label();
            this.lblNavDashboard = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(0, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(800, 40);
            this.panelNavbar.TabIndex = 3;
            // 
            // lblNavKategori
            // 
            this.lblNavKategori.AutoSize = true;
            this.lblNavKategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNavKategori.Location = new System.Drawing.Point(413, 15);
            this.lblNavKategori.Name = "lblNavKategori";
            this.lblNavKategori.Size = new System.Drawing.Size(46, 13);
            this.lblNavKategori.TabIndex = 8;
            this.lblNavKategori.Text = "Kategori";
            this.lblNavKategori.Click += new System.EventHandler(this.lblNavKategori_Click);
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
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
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
            this.lblNavTopings.Click += new System.EventHandler(this.lblNavTopings_Click);
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
            this.lblNavProduk.Click += new System.EventHandler(this.lblNavProduk_Click);
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
            this.lblNavDashboard.Click += new System.EventHandler(this.lblNavDashboard_Click);
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
            // FormNavpenjual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelNavbar);
            this.IsMdiContainer = true;
            this.Name = "FormNavpenjual";
            this.Text = "FormNavpenjual";
            this.Load += new System.EventHandler(this.FormNavpenjual_Load);
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

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
    }
}