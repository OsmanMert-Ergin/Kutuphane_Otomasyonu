namespace Kütüphane_Otomasyonu
{
    partial class EmanetIadeFrm
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
            this.txtTeslimAl = new System.Windows.Forms.Button();
            this.txtIptal = new System.Windows.Forms.Button();
            this.txtBarkodAra = new System.Windows.Forms.TextBox();
            this.txtTcKimlikAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1204, 520);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTeslimAl
            // 
            this.txtTeslimAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTeslimAl.Location = new System.Drawing.Point(961, 648);
            this.txtTeslimAl.Name = "txtTeslimAl";
            this.txtTeslimAl.Size = new System.Drawing.Size(109, 36);
            this.txtTeslimAl.TabIndex = 2;
            this.txtTeslimAl.Text = "Teslim Al";
            this.txtTeslimAl.UseVisualStyleBackColor = true;
            this.txtTeslimAl.Click += new System.EventHandler(this.txtTeslimAl_Click);
            // 
            // txtIptal
            // 
            this.txtIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIptal.Location = new System.Drawing.Point(1105, 648);
            this.txtIptal.Name = "txtIptal";
            this.txtIptal.Size = new System.Drawing.Size(88, 36);
            this.txtIptal.TabIndex = 3;
            this.txtIptal.Text = "İptal";
            this.txtIptal.UseVisualStyleBackColor = true;
            this.txtIptal.Click += new System.EventHandler(this.txtIptal_Click);
            // 
            // txtBarkodAra
            // 
            this.txtBarkodAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodAra.Location = new System.Drawing.Point(834, 32);
            this.txtBarkodAra.Name = "txtBarkodAra";
            this.txtBarkodAra.Size = new System.Drawing.Size(181, 27);
            this.txtBarkodAra.TabIndex = 4;
            this.txtBarkodAra.TextChanged += new System.EventHandler(this.txtBarkodAra_TextChanged);
            // 
            // txtTcKimlikAra
            // 
            this.txtTcKimlikAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlikAra.Location = new System.Drawing.Point(352, 32);
            this.txtTcKimlikAra.Name = "txtTcKimlikAra";
            this.txtTcKimlikAra.Size = new System.Drawing.Size(181, 27);
            this.txtTcKimlikAra.TabIndex = 5;
            this.txtTcKimlikAra.TextChanged += new System.EventHandler(this.txtTcKimlikAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tc Kimlik Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(719, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Barkod Ara";
            // 
            // EmanetIadeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1227, 720);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTcKimlikAra);
            this.Controls.Add(this.txtBarkodAra);
            this.Controls.Add(this.txtIptal);
            this.Controls.Add(this.txtTeslimAl);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmanetIadeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emanet İade";
            this.Load += new System.EventHandler(this.EmanetIadeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtTeslimAl;
        private System.Windows.Forms.Button txtIptal;
        private System.Windows.Forms.TextBox txtBarkodAra;
        private System.Windows.Forms.TextBox txtTcKimlikAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}