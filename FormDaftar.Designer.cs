namespace projek_mie
{
    partial class FormDaftar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDaftar));
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblSubJudul = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblKonfirmasiPassword = new System.Windows.Forms.Label();
            this.btnDaftar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textKonfirmasiPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(184, 30);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(297, 32);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "DAFTAR AKUN BARU";
            // 
            // lblSubJudul
            // 
            this.lblSubJudul.AutoSize = true;
            this.lblSubJudul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubJudul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSubJudul.Location = new System.Drawing.Point(186, 74);
            this.lblSubJudul.Name = "lblSubJudul";
            this.lblSubJudul.Size = new System.Drawing.Size(309, 24);
            this.lblSubJudul.TabIndex = 1;
            this.lblSubJudul.Text = "Isi data berikut untuk membuat akun";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNama.Location = new System.Drawing.Point(66, 134);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(111, 20);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama lengkap";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEmail.Location = new System.Drawing.Point(67, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(66, 248);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblKonfirmasiPassword
            // 
            this.lblKonfirmasiPassword.AutoSize = true;
            this.lblKonfirmasiPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKonfirmasiPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblKonfirmasiPassword.Location = new System.Drawing.Point(67, 305);
            this.lblKonfirmasiPassword.Name = "lblKonfirmasiPassword";
            this.lblKonfirmasiPassword.Size = new System.Drawing.Size(156, 20);
            this.lblKonfirmasiPassword.TabIndex = 5;
            this.lblKonfirmasiPassword.Text = "Konfirmasi Password";
            // 
            // btnDaftar
            // 
            this.btnDaftar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftar.Location = new System.Drawing.Point(121, 381);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(178, 37);
            this.btnDaftar.TabIndex = 6;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(406, 381);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(185, 37);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(70, 21);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(87, 87);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 8;
            this.picLogo.TabStop = false;
            // 
            // textNama
            // 
            this.textNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textNama.Location = new System.Drawing.Point(70, 157);
            this.textNama.Multiline = true;
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(636, 31);
            this.textNama.TabIndex = 9;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textEmail.Location = new System.Drawing.Point(68, 214);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(636, 31);
            this.textEmail.TabIndex = 10;
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textPassword.Location = new System.Drawing.Point(68, 271);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(636, 31);
            this.textPassword.TabIndex = 11;
            // 
            // textKonfirmasiPassword
            // 
            this.textKonfirmasiPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textKonfirmasiPassword.Location = new System.Drawing.Point(68, 328);
            this.textKonfirmasiPassword.Multiline = true;
            this.textKonfirmasiPassword.Name = "textKonfirmasiPassword";
            this.textKonfirmasiPassword.Size = new System.Drawing.Size(636, 31);
            this.textKonfirmasiPassword.TabIndex = 12;
            // 
            // FormDaftar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(772, 450);
            this.Controls.Add(this.textKonfirmasiPassword);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.lblKonfirmasiPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblSubJudul);
            this.Controls.Add(this.lblJudul);
            this.Name = "FormDaftar";
            this.Text = "FormDaftar";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblSubJudul;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblKonfirmasiPassword;
        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textKonfirmasiPassword;
    }
}
