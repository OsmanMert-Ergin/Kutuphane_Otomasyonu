using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kütüphane_Otomasyonu
{
    public partial class HesapOlusturma : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        public HesapOlusturma()
        {
            InitializeComponent();
        }

        private void textKayitKullanici_Enter(object sender, EventArgs e)
        {
            //
            if (textKayitKullanici.Text == "Kullanıcı Adı")//
            {
                textKayitKullanici.Text = "";
                textKayitKullanici.ForeColor = Color.White;//
            }
        }

        private void textKayitKullanici_Leave(object sender, EventArgs e)
        {//
            if (textKayitKullanici.Text == "")
            {
                textKayitKullanici.Text = "Kullanıcı Adı";
                textKayitKullanici.ForeColor = Color.Silver;
            }
        }

        private void textKayitSifre_Enter(object sender, EventArgs e)
        {//
            if (textKayitSifre.Text == "Şifre")
            {
                textKayitSifre.Text = "";
                textKayitSifre.ForeColor = Color.White;
                textKayitSifre.PasswordChar = '*';
            }
        }

        private void textKayitSifre_Leave(object sender, EventArgs e)
        {//
            char? none = null;//
            if (textKayitSifre.Text == "")
            {
                textKayitSifre.Text = "Şifre";
                textKayitSifre.ForeColor = Color.Silver;
                textKayitSifre.PasswordChar = Convert.ToChar(none);//
            }
        }

        private void textKayitAd_Enter(object sender, EventArgs e)
        {
            //
            if (textKayitAd.Text == "İsim")
            {
                textKayitAd.Text = "";
                textKayitAd.ForeColor = Color.White;
            }
        }

        private void textKayitAd_Leave(object sender, EventArgs e)
        {//
            if (textKayitAd.Text == "")
            {
                textKayitAd.Text = "İsim";
                textKayitAd.ForeColor = Color.Silver;
            }
        }

        private void textKayıtSoyad_Enter(object sender, EventArgs e)
        {//
            if (textKayıtSoyad.Text == "Soyisim")
            {
                textKayıtSoyad.Text = "";
                textKayıtSoyad.ForeColor = Color.White;
            }
        }

        private void textKayıtSoyad_Leave(object sender, EventArgs e)
        {//
            if (textKayıtSoyad.Text == "")
            {
                textKayıtSoyad.Text = "Soyisim";
                textKayıtSoyad.ForeColor = Color.Silver;
            }
        }

        private void textKayitEmail_Enter(object sender, EventArgs e)
        {//
            if (textKayitEmail.Text == "E-Mail")
            {
                textKayitEmail.Text = "";
                textKayitEmail.ForeColor = Color.White;
            }
        }

        private void textKayitEmail_Leave(object sender, EventArgs e)
        {//
            if (textKayitEmail.Text == "")
            {
                textKayitEmail.Text = "E-Mail";
                textKayitEmail.ForeColor = Color.Silver;
            }
        }

        private void KayitTxt_Click(object sender, EventArgs e)
        {//
            baglanti.Open();
            SqlCommand com = new SqlCommand("Insert into Giris(Username,Password,Kayitİsim,KayitSoyisim,E_mail) values ('"+textKayitKullanici.Text+"','"+textKayitSifre.Text+"','"+textKayitAd.Text+"','"+textKayıtSoyad.Text+"','"+ textKayitEmail.Text+"')",baglanti);
            com.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Edildiniz");
            this.Hide();
            Giris form1 = new Giris();
            form1.ShowDialog();
        }
    }
}
