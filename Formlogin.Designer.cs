namespace projek_mie
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSubJudul = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.lblKeDaftar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(160, 29);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(246, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "Masuk ke akunmu";
            // 
            // lblSubJudul
            // 
            this.lblSubJudul.AutoSize = true;
            this.lblSubJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudul.Location = new System.Drawing.Point(162, 73);
            this.lblSubJudul.Name = "lblSubJudul";
            this.lblSubJudul.Size = new System.Drawing.Size(215, 20);
            this.lblSubJudul.TabIndex = 1;
            this.lblSubJudul.Text = "Masuk untuk mulai memesan";
            this.lblSubJudul.Click += new System.EventHandler(this.lblSubJudul_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(51, 21);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(89, 78);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(35, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(39, 160);
            this.textEmail.Multiline = false;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(468, 29);
            this.textEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(35, 209);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRole.Location = new System.Drawing.Point(35, 287);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(139, 24);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Masuk Sebagai";
            this.lblRole.Visible = false;
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbRole.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Pembeli",
            "Penjual"});
            this.cmbRole.Location = new System.Drawing.Point(39, 314);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(467, 25);
            this.cmbRole.TabIndex = 8;
            this.cmbRole.Visible = false;
            // 
            // btnMasuk
            // 
            this.btnMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasuk.ForeColor = System.Drawing.Color.Black;
            this.btnMasuk.Location = new System.Drawing.Point(166, 295);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(220, 44);
            this.btnMasuk.TabIndex = 9;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = false;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(39, 236);
            this.textPassword.Multiline = false;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(468, 29);
            this.textPassword.TabIndex = 10;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // lblKeDaftar
            // 
            this.lblKeDaftar.AutoSize = true;
            this.lblKeDaftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKeDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeDaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblKeDaftar.Location = new System.Drawing.Point(187, 355);
            this.lblKeDaftar.Name = "lblKeDaftar";
            this.lblKeDaftar.Size = new System.Drawing.Size(181, 18);
            this.lblKeDaftar.TabIndex = 11;
            this.lblKeDaftar.Text = "Belum punya akun? Daftar";
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.lblKeDaftar);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.btnMasuk);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblSubJudul);
            this.Controls.Add(this.lblJudul);
            this.Name = "Formlogin";
            this.Text = "Formlogin";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label lblKeDaftar;
    }
}
