using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane_Otomasyonu
{
    public partial class Giris : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");

        public Giris()
        {
            InitializeComponent();
        }
        
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text=="Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Kullanıcı Adı";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text =="Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }
        bool isThere;
        private void GirisTxt_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            baglanti.Open();
            SqlCommand com = new SqlCommand("Select *from Giris", baglanti);
            SqlDataReader rea = com.ExecuteReader();
            while (rea.Read()) 
            {
                if (Username == rea["Username"].ToString().TrimEnd() && Password == rea["Password"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else 
                {
                    isThere = false;
                }
            }
            baglanti.Close();

            if (isThere) 
            {
                MessageBox.Show("Giriş Yaptınız");
                this.Hide();
                AnaSayfaTxt anasayfa = new AnaSayfaTxt();
                anasayfa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Giriş Yapamadınız");
            }

            
        }

        private void HesapTxt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            HesapOlusturma hesapOlusturma = new HesapOlusturma();
            hesapOlusturma.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
