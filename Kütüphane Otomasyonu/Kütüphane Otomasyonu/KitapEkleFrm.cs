using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapEkleFrm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        public KitapEkleFrm()
        {
            InitializeComponent();
        }

        private void KitapEkleFrm_Load(object sender, EventArgs e)
        {

        }

        private void txtIptal_Click(object sender, EventArgs e)
        {
            this.Close();// Formu kapattığımız kısım
        }

        private void txtKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Kitaplar(Barkod_No,Kitap_Adi,Yazari,Yayinevi,Sayfa_Sayisi,Stok_Sayisi,Raf_No) values(@Barkod_No,@Kitap_Adi,@Yazari,@Yayinevi,@Sayfa_Sayisi,@Stok_Sayisi,@Raf_No)", baglanti);// Kitaplar tablosuna yeni bir kayıt eklemek için SQL komutu oluşturur.
            // SQL komutuna parametreleri ekliyoruz
            komut.Parameters.AddWithValue("@Barkod_No",txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@Kitap_Adi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@Yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@Yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@Sayfa_Sayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@Stok_Sayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@Raf_No", txtRafNo.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kitap başarıyla kaydedilmiştir.");
            baglanti.Close();
            //Formdaki tüm metin kutusunu kontrol edip kaydetme başarılı olduktan sonra temizliğini yapan kısım
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
