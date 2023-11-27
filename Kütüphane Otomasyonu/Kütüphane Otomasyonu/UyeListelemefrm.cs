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
    public partial class UyeListelemefrm : Form
    {
       SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");// Veri tabanına bağlamak için SQL sunucusunun adresini ve kütüphane otomasyonu veritabanının adını belirten bir SqlConnection nesnesi oluşturuyoruz.
        DataTable table = new DataTable();// table adında bir DataTable nesnesi oluşturuyoruz, bu nesne veritabanından alınan verileri tutmak için kullanılacak.
        public UyeListelemefrm()
        {
            InitializeComponent();
        }

        private void UyeIptalTxt_Click(object sender, EventArgs e)
        {
            this.Close();// Uygulamadan çıkmak için belirliyoruz.
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UyeIdNoTxt.Text = dataGridView1.CurrentRow.Cells["id_no"].Value.ToString();// dataGridView1 adında bir DataGridView nesnesinin CellDoubleClick olayına bağlı bir metot tanımlıyoruz, bu metot sender ve e adında iki parametre alıyor. sender parametresi olayı tetikleyen nesneyi, e parametresi ise olayla ilgili ek bilgileri içeriyor. UyeIdNoTxt adında bir TextBox nesnesinin Text özelliğini dataGridView1 nesnesinin CurrentRow özelliği ile seçili olan satırın, Cells koleksiyonu ile “id_no” adlı hücresinin, Value özelliği ile hücrenin değerinin, ToString() metodu ile string değere dönüştürülmesi olarak belirliyoruz. Böylece seçili satırdaki id_no değerini UyeIdNoTxt nesnesine aktarıyoruz.
        }

        private void UyeIdNoTxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Uyeler where id_no like '"+UyeIdNoTxt.Text+"'" , baglanti);// komut adında bir SqlCommand nesnesi oluşturuyoruz, bu nesne veritabanında bir SQL sorgusu çalıştıracak. Sorgumuz Uyeler tablosundan id_no alanı UyeIdNoTxt nesnesinin Text özelliğine benzeyen tüm kayıtları seçiyor. like operatörü ile metinsel eşleşme sağlıyoruz.
            SqlDataReader reader = komut.ExecuteReader();// reader adında bir SqlDataReader nesnesi oluşturuyoruz, bu nesne komut nesnesinin ExecuteReader() metodu ile sorgumuzun sonucunu okuyacak. ExecuteReader() metodu birden fazla değer döndüren sorgular için kullanılır.
            while (reader.Read()) // reader nesnesinin Read() metodu ile sorgu sonucundaki her bir satırı tek tek okuyoruz. Read() metodu okunan satır varsa true, yoksa false değer döndürür. Bu yüzden while döngüsü ile tüm satırları geziyoruz.
            {
                UyeAdiTxt.Text = reader["UyeAdi"].ToString();// UyeAdiTxt adında bir TextBox nesnesinin Text özelliğini reader nesnesinin indexer özelliği ile “UyeAdi” adlı alanın, ToString() metodu ile string değere dönüştürülmesi olarak belirliyoruz. Böylece okunan satırdaki UyeAdi değerini UyeAdiTxt nesnesine aktarıyoruz.
                UyeSoyadiTxt.Text = reader["UyeSoyadi"].ToString();
                UyeTelTxt.Text = reader["UyeTel"].ToString();
                UyeEmailTxt.Text = reader["Email"].ToString();
                UyeAdresTxt.Text = reader["UyeAdres"].ToString();
            }
            baglanti.Close();
        }
        DataSet daset = new DataSet();// Bir veri kümesi nesnesi oluşturuyoruz.
        private void UyeTcAraTxt_TextChanged(object sender, EventArgs e)
        {
            daset.Tables.Clear();// Veri kümesindeki tabloları temizler.
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Uyeler Where id_no like '%" + UyeTcAraTxt.Text + "%'", baglanti);// Veritabanından uyeler tablosundan TC numarası arama metni ile eşleşen kayıtları seçiyoruz
            adtr.Fill(daset,"Uyeler");// Veri kümesine uyeler tablosunu dolduruyoruz.
            dataGridView1.DataSource = daset.Tables["Uyeler"];// DataGridView1’in veri kaynağını veri kümesindeki uyeler tablosu olarak ayarlıyoruz.
            baglanti.Close();
        }

        private void UyeSilTxt_Click(object sender, EventArgs e)
        {
            DialogResult dialog;// Bir diyalog sonucu nesnesi oluşturuyoruz.
            dialog = MessageBox.Show("Üye kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//
            if (dialog==DialogResult.Yes)// Eğer kullanıcı evet cevabı verirse
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Uyeler Where id_no=@id_no", baglanti);// Veritabanından uyeler tablosundan TC numarası verilen kaydı siler
                komut.Parameters.AddWithValue("@id_no", dataGridView1.CurrentRow.Cells["id_no"].Value.ToString());// TC numarası parametresini DataGridView1'in seçili satırındaki id_no hücresinden alır
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");// Kullanıcıya bir bilgi mesajı gösterir
                daset.Tables["Uyeler"].Clear();// Veri kümesindeki uyeler tablosunu temizler
                uyelistele();
                foreach (Control item in Controls)// foreach döngüsü ile formun Controls koleksiyonundaki tüm nesneleri tek tek geziyoruz. item değişkeni ile her bir nesneyi temsil ediyoruz.
                {
                    if (item is TextBox)//item nesnesinin TextBox sınıfından olup olmadığını kontrol ediyoruz. Eğer TextBox ise aşağıdaki kod bloğunu çalıştırıyoruz.
                    {
                        item.Text = "";// item nesnesinin Text özelliğini boş bir string değere atıyoruz. Böylece TextBox nesnelerinin içeriğini temizlemiş oluyoruz.
                    }
                }
            }
            
        }
        private void uyelistele()// Uyeleri listelemek için bir fonksiyon tanımlar
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Uyeler", baglanti);
            adtr.Fill(daset, "Uyeler");
            dataGridView1.DataSource = daset.Tables["Uyeler"];
            baglanti.Close();
        }
        private void UyeListelemefrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adrUyeler = new SqlDataAdapter("Select * From Uyeler order by UyeAdi", baglanti);// Bir SqlDataAdapter nesnesi oluşturur ve veritabanından uyeler tablosundaki tüm kayıtları seçmek için bir SQL sorgusu gönderir. baglanti parametresi veritabanı bağlantı nesnesini belirtir.
            adrUyeler.Fill(table);// Bir tablo nesnesine uyeler tablosunu doldurur
            dataGridView1.DataSource = table;// DataGridView1’in veri kaynağını tablo nesnesi olarak ayarlar
            dataGridView1.Columns["id_no"].HeaderText = "TC Kimlik No";// DataGridView1’in id_no sütununun başlık metnini değiştirir
            dataGridView1.Columns["UyeAdi"].HeaderText = "İsim";
            dataGridView1.Columns["UyeSoyadi"].HeaderText = "Soyisim";
            dataGridView1.Columns["UyeTel"].HeaderText = "Telefon";
            dataGridView1.Columns["UyeAdres"].HeaderText = "Adres";
            baglanti.Close();
            uyelistele();
        }

        private void GuncelleTxt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Uyeler set UyeAdi=@UyeAdi,UyeSoyadi=@UyeSoyadi,UyeTel=@UyeTel,Email=@Email,UyeAdres=@UyeAdres Where id_no=@id_no", baglanti);// Bir SqlCommand nesnesi oluşturur ve veritabanında uyeler tablosunda TC numarası verilen kaydın bilgilerini güncellemek için bir SQL sorgusu gönderir. Sorguda @ işareti ile belirtilen parametrelerin değerleri daha sonra kodda belirlenir. baglanti parametresi veritabanı bağlantı nesnesini belirtir.
            komut.Parameters.AddWithValue("@id_no", UyeIdNoTxt.Text);// komut nesnesinin Parameters koleksiyonuna AddWithValue metodu ile yeni bir parametre ekliyoruz. Parametrenin adı “@id_no”, değeri ise UyeIdNoTxt nesnesinin Text özelliği olarak belirliyoruz.
            komut.Parameters.AddWithValue("@UyeAdi", UyeAdiTxt.Text);
            komut.Parameters.AddWithValue("@UyeSoyadi", UyeSoyadiTxt.Text);
            komut.Parameters.AddWithValue("@UyeTel", UyeTelTxt.Text);
            komut.Parameters.AddWithValue("@Email", UyeEmailTxt.Text);
            komut.Parameters.AddWithValue("@UyeAdres", UyeAdresTxt.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");
            daset.Tables["Uyeler"].Clear();// Veri kümesindeki üyeler tablosunu temizler
            uyelistele();
            foreach (Control item in Controls)// foreach döngüsü ile formun Controls koleksiyonundaki tüm nesneleri tek tek geziyoruz. item değişkeni ile her bir nesneyi temsil ediyoruz.
            {
                if (item is TextBox)// item nesnesinin TextBox sınıfından olup olmadığını kontrol ediyoruz. Eğer TextBox ise aşağıdaki kod bloğunu çalıştırıyoruz.
                {
                    item.Text = "";// item nesnesinin Text özelliğini boş bir string değere atıyoruz. Böylece TextBox nesnelerinin içeriğini temizlemiş oluyoruz.
                }
            }
        }
    }
}
