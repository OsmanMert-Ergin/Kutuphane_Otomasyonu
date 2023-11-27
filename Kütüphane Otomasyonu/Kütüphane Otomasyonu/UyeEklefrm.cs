using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;// SQL bağlamak için kütüphane eklendi.

namespace Kütüphane_Otomasyonu
{
    public partial class UyeEklefrm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");// Veri tabanına bağlamak için SQL sunucusunun adresini ve kütüphane otomasyonu veritabanının adını belirten bir SqlConnection nesnesi oluşturuyoruz.
        public UyeEklefrm()// Form sınıfı tanımladık.
        {
            InitializeComponent();
        }
        public int checkId(string text)// checkId adında bir metot tanımlıyoruz, bu metot bir string parametre alıyor ve int değer döndürüyor.
        {
            int result;// result adında bir int değişkeni tanımlıyoruz, bu değişken metotun döndüreceği değeri tutacak.
            baglanti.Open();// Veri tabanına veri eklemek için bağlantıyı açıyoruz.
            SqlCommand com = new SqlCommand("Select Count(id_no) from Uyeler where id_no='" + text + "'", baglanti);// com adında bir SqlCommand nesnesi oluşturuyoruz, bu nesne veritabanında bir SQL sorgusu çalıştıracak. Sorgumuz Uyeler tablosundan id_no alanı text parametresine eşit olan kayıtların sayısını seçiyor.
            result = Convert.ToInt32(com.ExecuteScalar());// com nesnesinin ExecuteScalar() metodu ile sorgumuzu çalıştırıyoruz ve sonucu int değere dönüştürerek result değişkenine atıyoruz. ExecuteScalar() metodu tek bir değer döndüren sorgular için kullanılır.
            baglanti.Close();// Bağlantıyı kapıtıyoruz.
            return result;//result değişkenini metotun döndürdüğü değer olarak belirliyoruz.
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void UyeIptalTxt_Click(object sender, EventArgs e)
        {
            this.Close();// Uygulamadan çıkmak için belirliyoruz.
        }

        private void UyeKaydetTxt_Click(object sender, EventArgs e)// UyeKaydetTxt adında bir butonun Click olayına bağlı bir metot tanımlıyoruz.
        {
            if (UyeIdNoTxt.Text == "")// UyeIdNoTxt adında bir TextBox nesnesinin Text özelliğinin boş olup olmadığını kontrol ediyoruz. Eğer boş ise aşağıdaki kod bloğunu çalıştırıyoruz.
            {
                MessageBox.Show("TC Kimlik No alanı boş bırakılamaz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);// MessageBox.Show metodu ile bir uyarı mesajı gösteriyoruz. Mesajın içeriği “TC Kimlik No alanı boş bırakılamaz!”, başlığı “UYARI”, butonu “OK”, ikonu ise “Warning” olarak belirliyoruz.
            }
            else// UyeIdNoTxt.Text boş değilse aşağıdaki kod bloğunu çalıştırıyoruz.
            {
                try// try-catch bloğu ile hata yakalamaya çalışıyoruz. try bloğu içindeki kodları normal olarak çalıştırıyoruz, eğer bir hata olursa catch bloğu içindeki kodları çalıştırıyoruz.
                {
                    if (checkId(UyeIdNoTxt.Text) != 0)// checkId metodu ile UyeIdNoTxt.Text değerinin veritabanında kayıtlı olup olmadığını kontrol ediyoruz. Eğer kayıtlı ise checkId metodu 0’dan farklı bir değer döndürecektir. Bu durumda aşağıdaki kod bloğunu çalıştırıyoruz.
                    {
                        MessageBox.Show("Bu TC Kimlik Numarası zaten kayıtlı!");// MessageBox.Show metodu ile bir bilgi mesajı gösteriyoruz.
                    }
                    else// checkId metodu 0 değerini döndürürse, yani UyeIdNoTxt.Text değeri veritabanında kayıtlı değilse aşağıdaki kod bloğunu çalıştırıyoruz.
                    {
                        baglanti.Open();// Veri tabanına veri eklemek için bağlantıyı açıyoruz.
                        SqlCommand komut = new SqlCommand("insert into Uyeler(id_no,UyeAdi,UyeSoyadi,UyeTel,Email,UyeAdres) values(@id_no,@UyeAdi,@UyeSoyadi,@UyeTel,@Email,@UyeAdres)", baglanti);// komut adında bir SqlCommand nesnesi oluşturuyoruz, bu nesne veritabanında bir SQL sorgusu çalıştıracak. Sorgumuz Uyeler tablosuna yeni bir kayıt eklemek için insert into komutunu kullanıyor. Kaydın alanları id_no, UyeAdi, UyeSoyadi, UyeTel, Email, UyeAdres olarak belirleniyor. Bu alanların değerleri ise @ işareti ile başlayan parametreler olarak tanımlanıyor. Bu parametreler daha sonra TextBox nesnelerinin Text özellikleri ile eşleştirilecek.
                        komut.Parameters.AddWithValue("@id_no", UyeIdNoTxt.Text);// komut nesnesinin Parameters koleksiyonuna AddWithValue metodu ile yeni bir parametre ekliyoruz. Parametrenin adı “@id_no”, değeri ise UyeIdNoTxt nesnesinin Text özelliği olarak belirliyoruz.
                        komut.Parameters.AddWithValue("@UyeAdi", UyeAdiTxt.Text);
                        komut.Parameters.AddWithValue("@UyeSoyadi", UyeSoyadiTxt.Text);
                        komut.Parameters.AddWithValue("@UyeTel", UyeTelTxt.Text);
                        komut.Parameters.AddWithValue("@Email", UyeEmailTxt.Text);
                        komut.Parameters.AddWithValue("@UyeAdres", UyeAdresTxt.Text);
                        komut.ExecuteNonQuery();//  SQL komut nesnesinin ExecuteNonQuery metodu ile sorgumuzu çalıştırıyoruz. ExecuteNonQuery metodu bir değer döndürmeyen sorgular için kullanılır.
                        MessageBox.Show("Üye başarıyla kaydedilmiştir.");
                        baglanti.Close();
                    }
                }
                catch (Exception)// try bloğu içindeki kodlarda bir hata oluşursa catch bloğu içindeki kodları çalıştırıyoruz. Exception sınıfı ile hata nesnesini yakalıyoruz.
                {
                    MessageBox.Show("Hay aksi! Kayıt işlemi sırasında bir hata oluştu. Lütfen tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);// MessageBox.Show metodu ile bir hata mesajı gösteriyoruz.
                }
                foreach (Control item in Controls)// foreach döngüsü ile formun Controls koleksiyonundaki tüm nesneleri tek tek geziyoruz. item değişkeni ile her bir nesneyi temsil ediyoruz.
                {
                    if (item is TextBox)// item nesnesinin TextBox sınıfından olup olmadığını kontrol ediyoruz. Eğer TextBox ise aşağıdaki kod bloğunu çalıştırıyoruz.
                    {
                        item.Text = "";// item nesnesinin Text özelliğini boş bir string değere atıyoruz. Böylece TextBox nesnelerinin içeriğini temizlemiş oluyoruz.
                    }
                }
            }
            
        }

        private void UyeEklefrm_Load(object sender, EventArgs e)
        {

        }

        private void UyeIdNoTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
