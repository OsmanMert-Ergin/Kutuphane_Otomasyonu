namespace Kütüphane_Otomasyonu
{
    partial class UyeListelemefrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UyeIptalTxt = new System.Windows.Forms.Button();
            this.GuncelleTxt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UyeAdresTxt = new System.Windows.Forms.TextBox();
            this.UyeEmailTxt = new System.Windows.Forms.TextBox();
            this.UyeTelTxt = new System.Windows.Forms.TextBox();
            this.UyeSoyadiTxt = new System.Windows.Forms.TextBox();
            this.UyeAdiTxt = new System.Windows.Forms.TextBox();
            this.UyeIdNoTxt = new System.Windows.Forms.TextBox();
            this.UyeTcAraTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UyeSilTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // UyeIptalTxt
            // 
            this.UyeIptalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeIptalTxt.Location = new System.Drawing.Point(538, 661);
            this.UyeIptalTxt.Name = "UyeIptalTxt";
            this.UyeIptalTxt.Size = new System.Drawing.Size(125, 43);
            this.UyeIptalTxt.TabIndex = 27;
            this.UyeIptalTxt.Text = "İptal";
            this.UyeIptalTxt.UseVisualStyleBackColor = true;
            this.UyeIptalTxt.Click += new System.EventHandler(this.UyeIptalTxt_Click);
            // 
            // GuncelleTxt
            // 
            this.GuncelleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleTxt.Location = new System.Drawing.Point(237, 661);
            this.GuncelleTxt.Name = "GuncelleTxt";
            this.GuncelleTxt.Size = new System.Drawing.Size(125, 43);
            this.GuncelleTxt.TabIndex = 26;
            this.GuncelleTxt.Text = "Güncelle";
            this.GuncelleTxt.UseVisualStyleBackColor = true;
            this.GuncelleTxt.Click += new System.EventHandler(this.GuncelleTxt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(669, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Adres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(669, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(669, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(74, 615);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(74, 575);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(74, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "TC Kimlik No";
            // 
            // UyeAdresTxt
            // 
            this.UyeAdresTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeAdresTxt.Location = new System.Drawing.Point(778, 619);
            this.UyeAdresTxt.Multiline = true;
            this.UyeAdresTxt.Name = "UyeAdresTxt";
            this.UyeAdresTxt.Size = new System.Drawing.Size(298, 94);
            this.UyeAdresTxt.TabIndex = 19;
            // 
            // UyeEmailTxt
            // 
            this.UyeEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeEmailTxt.Location = new System.Drawing.Point(778, 568);
            this.UyeEmailTxt.Name = "UyeEmailTxt";
            this.UyeEmailTxt.Size = new System.Drawing.Size(298, 27);
            this.UyeEmailTxt.TabIndex = 18;
            // 
            // UyeTelTxt
            // 
            this.UyeTelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeTelTxt.Location = new System.Drawing.Point(778, 519);
            this.UyeTelTxt.Name = "UyeTelTxt";
            this.UyeTelTxt.Size = new System.Drawing.Size(298, 27);
            this.UyeTelTxt.TabIndex = 17;
            // 
            // UyeSoyadiTxt
            // 
            this.UyeSoyadiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeSoyadiTxt.Location = new System.Drawing.Point(236, 615);
            this.UyeSoyadiTxt.Name = "UyeSoyadiTxt";
            this.UyeSoyadiTxt.Size = new System.Drawing.Size(298, 27);
            this.UyeSoyadiTxt.TabIndex = 16;
            // 
            // UyeAdiTxt
            // 
            this.UyeAdiTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeAdiTxt.Location = new System.Drawing.Point(236, 572);
            this.UyeAdiTxt.Name = "UyeAdiTxt";
            this.UyeAdiTxt.Size = new System.Drawing.Size(298, 27);
            this.UyeAdiTxt.TabIndex = 15;
            // 
            // UyeIdNoTxt
            // 
            this.UyeIdNoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeIdNoTxt.Location = new System.Drawing.Point(236, 526);
            this.UyeIdNoTxt.Name = "UyeIdNoTxt";
            this.UyeIdNoTxt.Size = new System.Drawing.Size(298, 27);
            this.UyeIdNoTxt.TabIndex = 14;
            this.UyeIdNoTxt.TextChanged += new System.EventHandler(this.UyeIdNoTxt_TextChanged);
            // 
            // UyeTcAraTxt
            // 
            this.UyeTcAraTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeTcAraTxt.Location = new System.Drawing.Point(286, 22);
            this.UyeTcAraTxt.Name = "UyeTcAraTxt";
            this.UyeTcAraTxt.Size = new System.Drawing.Size(298, 27);
            this.UyeTcAraTxt.TabIndex = 28;
            this.UyeTcAraTxt.TextChanged += new System.EventHandler(this.UyeTcAraTxt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(74, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "TC Kimlik No Ara";
            // 
            // UyeSilTxt
            // 
            this.UyeSilTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeSilTxt.Location = new System.Drawing.Point(383, 661);
            this.UyeSilTxt.Name = "UyeSilTxt";
            this.UyeSilTxt.Size = new System.Drawing.Size(125, 43);
            this.UyeSilTxt.TabIndex = 30;
            this.UyeSilTxt.Text = "Sil";
            this.UyeSilTxt.UseVisualStyleBackColor = true;
            this.UyeSilTxt.Click += new System.EventHandler(this.UyeSilTxt_Click);
            // 
            // UyeListelemefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1185, 726);
            this.Controls.Add(this.UyeSilTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UyeTcAraTxt);
            this.Controls.Add(this.UyeIptalTxt);
            this.Controls.Add(this.GuncelleTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UyeAdresTxt);
            this.Controls.Add(this.UyeEmailTxt);
            this.Controls.Add(this.UyeTelTxt);
            this.Controls.Add(this.UyeSoyadiTxt);
            this.Controls.Add(this.UyeAdiTxt);
            this.Controls.Add(this.UyeIdNoTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UyeListelemefrm";
            this.Text = "Üye Listeleri";
            this.Load += new System.EventHandler(this.UyeListelemefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UyeIptalTxt;
        private System.Windows.Forms.Button GuncelleTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UyeAdresTxt;
        private System.Windows.Forms.TextBox UyeEmailTxt;
        private System.Windows.Forms.TextBox UyeTelTxt;
        private System.Windows.Forms.TextBox UyeSoyadiTxt;
        private System.Windows.Forms.TextBox UyeAdiTxt;
        private System.Windows.Forms.TextBox UyeIdNoTxt;
        private System.Windows.Forms.TextBox UyeTcAraTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button UyeSilTxt;
    }
}