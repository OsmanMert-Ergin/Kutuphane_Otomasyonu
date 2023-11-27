namespace Kütüphane_Otomasyonu
{
    partial class HesapOlusturma
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
            this.KayitTxt = new System.Windows.Forms.Button();
            this.textKayitKullanici = new System.Windows.Forms.TextBox();
            this.textKayitSifre = new System.Windows.Forms.TextBox();
            this.textKayitAd = new System.Windows.Forms.TextBox();
            this.textKayıtSoyad = new System.Windows.Forms.TextBox();
            this.textKayitEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // KayitTxt
            // 
            this.KayitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitTxt.Location = new System.Drawing.Point(60, 544);
            this.KayitTxt.Name = "KayitTxt";
            this.KayitTxt.Size = new System.Drawing.Size(132, 44);
            this.KayitTxt.TabIndex = 3;
            this.KayitTxt.Text = "Kayıt Ol";
            this.KayitTxt.UseVisualStyleBackColor = true;
            this.KayitTxt.Click += new System.EventHandler(this.KayitTxt_Click);
            // 
            // textKayitKullanici
            // 
            this.textKayitKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textKayitKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKayitKullanici.ForeColor = System.Drawing.SystemColors.Window;
            this.textKayitKullanici.Location = new System.Drawing.Point(60, 246);
            this.textKayitKullanici.Name = "textKayitKullanici";
            this.textKayitKullanici.Size = new System.Drawing.Size(327, 28);
            this.textKayitKullanici.TabIndex = 4;
            this.textKayitKullanici.Text = "Kullanıcı Adı";
            this.textKayitKullanici.Enter += new System.EventHandler(this.textKayitKullanici_Enter);
            this.textKayitKullanici.Leave += new System.EventHandler(this.textKayitKullanici_Leave);
            // 
            // textKayitSifre
            // 
            this.textKayitSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textKayitSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKayitSifre.ForeColor = System.Drawing.SystemColors.Window;
            this.textKayitSifre.Location = new System.Drawing.Point(60, 295);
            this.textKayitSifre.Name = "textKayitSifre";
            this.textKayitSifre.Size = new System.Drawing.Size(260, 28);
            this.textKayitSifre.TabIndex = 5;
            this.textKayitSifre.Text = "Şifre";
            this.textKayitSifre.Enter += new System.EventHandler(this.textKayitSifre_Enter);
            this.textKayitSifre.Leave += new System.EventHandler(this.textKayitSifre_Leave);
            // 
            // textKayitAd
            // 
            this.textKayitAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textKayitAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKayitAd.ForeColor = System.Drawing.SystemColors.Window;
            this.textKayitAd.Location = new System.Drawing.Point(60, 355);
            this.textKayitAd.Name = "textKayitAd";
            this.textKayitAd.Size = new System.Drawing.Size(215, 28);
            this.textKayitAd.TabIndex = 6;
            this.textKayitAd.Text = "İsim";
            this.textKayitAd.Enter += new System.EventHandler(this.textKayitAd_Enter);
            this.textKayitAd.Leave += new System.EventHandler(this.textKayitAd_Leave);
            // 
            // textKayıtSoyad
            // 
            this.textKayıtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textKayıtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKayıtSoyad.ForeColor = System.Drawing.SystemColors.Window;
            this.textKayıtSoyad.Location = new System.Drawing.Point(60, 415);
            this.textKayıtSoyad.Name = "textKayıtSoyad";
            this.textKayıtSoyad.Size = new System.Drawing.Size(163, 28);
            this.textKayıtSoyad.TabIndex = 7;
            this.textKayıtSoyad.Text = "Soyisim";
            this.textKayıtSoyad.Enter += new System.EventHandler(this.textKayıtSoyad_Enter);
            this.textKayıtSoyad.Leave += new System.EventHandler(this.textKayıtSoyad_Leave);
            // 
            // textKayitEmail
            // 
            this.textKayitEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textKayitEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textKayitEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.textKayitEmail.Location = new System.Drawing.Point(60, 468);
            this.textKayitEmail.Name = "textKayitEmail";
            this.textKayitEmail.Size = new System.Drawing.Size(132, 28);
            this.textKayitEmail.TabIndex = 8;
            this.textKayitEmail.Text = "E-Mail";
            this.textKayitEmail.Enter += new System.EventHandler(this.textKayitEmail_Enter);
            this.textKayitEmail.Leave += new System.EventHandler(this.textKayitEmail_Leave);
            // 
            // HesapOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kütüphane_Otomasyonu.Properties.Resources.KayıtOl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 658);
            this.Controls.Add(this.textKayitEmail);
            this.Controls.Add(this.textKayıtSoyad);
            this.Controls.Add(this.textKayitAd);
            this.Controls.Add(this.textKayitSifre);
            this.Controls.Add(this.textKayitKullanici);
            this.Controls.Add(this.KayitTxt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HesapOlusturma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HesapOlusturma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KayitTxt;
        private System.Windows.Forms.TextBox textKayitKullanici;
        private System.Windows.Forms.TextBox textKayitSifre;
        private System.Windows.Forms.TextBox textKayitAd;
        private System.Windows.Forms.TextBox textKayıtSoyad;
        private System.Windows.Forms.TextBox textKayitEmail;
    }
}