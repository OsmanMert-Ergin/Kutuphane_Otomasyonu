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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kütüphane_Otomasyonu
{
    public partial class KitapListeleFrm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataTable tableKitaplar = new DataTable();//
        public KitapListeleFrm()
        {
            InitializeComponent();
        }

        DataSet daset = new DataSet();// Kitaplar tablosundaki kayıtları göstermek için bir DataSet nesnesi oluşturur.
        private void kitaplistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * From Kitaplar", baglanti);// Kitaplar tablosundaki tüm kayıtları seçen bir SQL komutu için bir veri adaptörü oluşturur.
            adtr.Fill(daset, "Kitaplar");// Veri adaptörü ile DataSet nesnesini doldur ve Kitaplar adında bir tablo oluşturur.
            dataGridView1.DataSource = daset.Tables["Kitaplar"];// dataGridView1 kontrolünün veri kaynağını DataSet nesnesindeki Kitaplar tablosu olarak ayarlar.
            baglanti.Close();
        }
        private void KitapListeleFrm_Load(object sender, EventArgs e)// Form yüklendiğinde çalışacak eylemler.
        {
            SqlDataAdapter adrKitaplar = new SqlDataAdapter("Select * From Kitaplar order by Kitap_Adi", baglanti);// Kitaplar tablosundaki kayıtları kitap adına göre sıralayan bir SQL komutu için bir veri adaptörü oluşturur.
            adrKitaplar.Fill(tableKitaplar);// Kitaplar tablosundaki kayıtları bir DataTable nesnesine dolduran bir veri adaptörü oluşturur.
            dataGridView1.DataSource = tableKitaplar;// dataGridView1 kontrolünün veri kaynağını DataTable nesnesi olarak ayarlar.
            // dataGridView1 kontrolündeki sütun başlıklarını değiştirir.
            dataGridView1.Columns["Barkod_No"].HeaderText = "Barkod No";
            dataGridView1.Columns["Kitap_Adi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["Yazari"].HeaderText = "Yazarı";
            dataGridView1.Columns["Yayinevi"].HeaderText = "Yayınevi";
            dataGridView1.Columns["Sayfa_Sayisi"].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns["Stok_Sayisi"].HeaderText = "Stok Sayısı";
            dataGridView1.Columns["Raf_No"].HeaderText = "Raf No";
            baglanti.Close();
            kitaplistele();
        }

        private void txtSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Kitap kaydını silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);// Kullanıcıya kitap kaydını silmek isteyip istemediğini soran bir mesaj kutusu gösterir.
            if (dialog == DialogResult.Yes)// Kullanıcı evet seçeneğini seçerse
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Delete From Kitaplar Where Barkod_No=@Barkod_No", baglanti);// Kitaplar tablosundan seçili kaydı silen bir SQL komutu oluşturur.
                komut.Parameters.AddWithValue("@Barkod_No", dataGridView1.CurrentRow.Cells["Barkod_No"].Value.ToString());// SQL komutuna parametre olarak dataGridView1 kontrolündeki seçili satırın Barkod_No değerini ekler.
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme İşlemi Gerçekleşti.");// Silme işlemi gerçekleştiğinde vereceği çıktı mesajı
                daset.Tables["Kitaplar"].Clear();// Kitaplar tablosunu temizler.
                kitaplistele();// kitaplistele metotunu çağırır
                // Formdaki tüm metin kutularını sıfırlar
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txtGuncelle_Click(object sender, EventArgs e)
        {//
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Kitaplar set Kitap_Adi=@Kitap_Adi,Yazari=@Yazari,Yayinevi=@Yayinevi,Sayfa_Sayisi=@Sayfa_Sayisi,Stok_Sayisi=@Stok_Sayisi,Raf_No=@Raf_No Where Barkod_No=@Barkod_No", baglanti);// Kitaplar tablosunda seçili kaydı güncelleyen bir SQL komutu oluştur
            // SQL komutuna parametreleri ekler.
            komut.Parameters.AddWithValue("@Barkod_No", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@Kitap_Adi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@Yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@Yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@Sayfa_Sayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@Stok_Sayisi", txtStokSayisi.Text);
            komut.Parameters.AddWithValue("@Raf_No", txtRafNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti.");// Kullanıcıya güncelleme işleminin gerçekleştiğini bildiren bir mesaj kutusu gösterir.
            daset.Tables["Kitaplar"].Clear();
            kitaplistele();
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {//
            daset.Tables.Clear();// DataSet nesnesindeki tüm tabloları temizler
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Kitaplar Where Barkod_No like '%" + txtBarkodAra.Text + "%'", baglanti);// Kitaplar tablosundan barkod numarasına göre arama yapan bir SQL komutu oluşturur. txtBarkodAra metin kutusundaki değeri SQL komutuna parametre olarak ekler.
            adtr.Fill(daset,"Kitaplar");// Veri adaptörü ile DataSet nesnesini doldur ve Kitaplar adında bir tablo oluşturur.
            dataGridView1.DataSource = daset.Tables["Kitaplar"];// dataGridView1 kontrolünün veri kaynağını DataSet nesnesindeki Kitaplar tablosu olarak ayarlar.
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {//
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Kitaplar where Barkod_No like '" + txtBarkodNo.Text + "'", baglanti);// Kitaplar tablosundan barkod numarasına göre kayıt seçen bir SQL komutu oluşturur. txtBarkodNo metin kutusundaki değeri SQL komutuna parametre olarak ekler.
            SqlDataReader read = komut.ExecuteReader();// SQL komutunu çalıştır ve sonuçları bir veri okuyucusuna aktarır.
            while (read.Read())// Veri okuyucusu sonraki kaydı okuyabildiği sürece bunları yapacak.
            { // Veri okuyucudan kitap bilgilerini al ve ilgili metin kutularına yaz.
                txtKitapAdi.Text = read["Kitap_Adi"].ToString();
                txtYazar.Text = read["Yazari"].ToString();
                txtYayinevi.Text = read["Yayinevi"].ToString();
                txtSayfaSayisi.Text = read["Sayfa_Sayisi"].ToString();
                txtStokSayisi.Text = read["Stok_Sayisi"].ToString();
                txtRafNo.Text = read["Raf_No"].ToString();
            }
            baglanti.Close();
        }

        private void txtIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
