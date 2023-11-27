namespace Kütüphane_Otomasyonu
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GirisTxt = new System.Windows.Forms.Button();
            this.HesapTxt = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(110, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Kullanıcı Adı";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(111, 314);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(277, 28);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Şifre";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // GirisTxt
            // 
            this.GirisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisTxt.Location = new System.Drawing.Point(183, 383);
            this.GirisTxt.Name = "GirisTxt";
            this.GirisTxt.Size = new System.Drawing.Size(132, 44);
            this.GirisTxt.TabIndex = 2;
            this.GirisTxt.Text = "Giriş Yap";
            this.GirisTxt.UseVisualStyleBackColor = true;
            this.GirisTxt.Click += new System.EventHandler(this.GirisTxt_Click);
            // 
            // HesapTxt
            // 
            this.HesapTxt.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.HesapTxt.AutoSize = true;
            this.HesapTxt.BackColor = System.Drawing.Color.Transparent;
            this.HesapTxt.ForeColor = System.Drawing.Color.Transparent;
            this.HesapTxt.LinkColor = System.Drawing.Color.White;
            this.HesapTxt.Location = new System.Drawing.Point(13, 555);
            this.HesapTxt.Name = "HesapTxt";
            this.HesapTxt.Size = new System.Drawing.Size(92, 16);
            this.HesapTxt.TabIndex = 3;
            this.HesapTxt.TabStop = true;
            this.HesapTxt.Text = "Hesap Oluştur";
            this.HesapTxt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HesapTxt_LinkClicked);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::Kütüphane_Otomasyonu.Properties.Resources.giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 587);
            this.Controls.Add(this.HesapTxt);
            this.Controls.Add(this.GirisTxt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sayfa Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel HesapTxt;
        private System.Windows.Forms.Button GirisTxt;
    }
}

