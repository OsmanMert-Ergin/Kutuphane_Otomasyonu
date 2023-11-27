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
    public partial class EmanetListeleFrm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();// Emanet_Kitap tablosundaki kayıtları göstermek için bir DataSet nesnesi oluşturur.
        // Emanet_Kitap tablosundaki kayıtları göstermek için DataTable nesnesi oluşturur.
        DataTable tableUyeler = new DataTable();
        DataTable tableKitaplar = new DataTable();
        public EmanetListeleFrm()
        {
            InitializeComponent();
        }

        private void EmanetListeleFrm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            
            SqlDataAdapter adrUyeler = new SqlDataAdapter("Select * From Emanet_Kitap order by UyeAdi", baglanti);// Emanet_Kitap tablosundan üye bilgilerini seçen bir SQL komutu için bir veri adaptörü oluşturur.
            adrUyeler.Fill(tableUyeler);// Veri adaptörü ile tableUyeler nesnesini doldurur.
            dataGridView1.DataSource = tableUyeler;// dataGridView1 kontrolünün veri kaynağını tableUyeler nesnesi olarak ayarlar.
            // dataGridView1 kontrolündeki sütun başlıklarını değiştirir.
            dataGridView1.Columns["id_no"].HeaderText = "TC Kimlik No";
            dataGridView1.Columns["UyeAdi"].HeaderText = "İsim";
            dataGridView1.Columns["UyeSoyadi"].HeaderText = "Soyisim";
            dataGridView1.Columns["UyeTel"].HeaderText = "Telefon";
            dataGridView1.Columns["UyeAdres"].HeaderText = "Adres";
            tableKitaplar.Clear();
            SqlDataAdapter adrKitaplar = new SqlDataAdapter("Select * From Emanet_Kitap order by Kitap_Adi", baglanti);// Emanet_Kitap tablosundan kitap bilgilerini seçen bir SQL komutu için bir veri adaptörü oluşturur.
            adrKitaplar.Fill(tableKitaplar);// Veri adaptörü ile tableKitaplar nesnesini doldurur.
            dataGridView1.DataSource = tableKitaplar;// dataGridView1 kontrolünün veri kaynağını tableKitaplar nesnesi olarak ayarlar.
            dataGridView1.Columns["Barkod_No"].HeaderText = "Barkod No";
            dataGridView1.Columns["Kitap_Adi"].HeaderText = "Kitap Adı";
            dataGridView1.Columns["Yazari"].HeaderText = "Yazarı";
            dataGridView1.Columns["Yayinevi"].HeaderText = "Yayınevi";
            dataGridView1.Columns["Sayfa_Sayisi"].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns["Stok_Sayisi"].HeaderText = "Stok Sayısı";
            dataGridView1.Columns["Raf_No"].HeaderText = "Raf No";
            dataGridView1.Columns["Verilme_Tarihi"].HeaderText = "Verilme Tarihi";
            dataGridView1.Columns["Teslim_Tarihi"].HeaderText = "Teslim Tarihi";
            baglanti.Close();
            EmanetListele();// EmanetListele metotunu çağırır.
            comboBox1.SelectedIndex = 0;// comboBox1 kontrolünün seçili öğesini 0. indekse ayarlar.
        }

        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(" Select * From Emanet_Kitap", baglanti);// Emanet_Kitap tablosundan tüm kayıtları seçen bir SQL komutu için bir veri adaptörü oluşturur.
            adtr.Fill(daset, "Emanet_Kitap");// Veri adaptörü ile DataSet nesnesini doldur ve Emanet_Kitap adında bir tablo oluşturur.
            dataGridView1.DataSource = daset.Tables["Emanet_Kitap"]; // dataGridView1 kontrolünün veri kaynağını DataSet nesnesindeki Emanet_Kitap tablosu olarak ayarlar.
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)// comboBox1 açılır liste kutusunda seçili öğe değiştiğinde çalışacak olay işleyicisi
        {
            daset.Tables["Emanet_Kitap"].Clear();// DataSet nesnesindeki Emanet_Kitap tablosunu temizler.
            if (comboBox1.SelectedIndex == 0)// comboBox1 kontrolündeki seçili öğe 0. indekse sahipse (Tüm Kitaplar seçeneği) yapılacak işlemler.
            {
                EmanetListele();// EmanetListele metotunu çağırır.
            }
            else if (comboBox1.SelectedIndex == 1)// comboBox1 kontrolündeki seçili öğe 1. indekse sahipse (Geciken Kitaplar seçeneği) yapılacak işlemler.
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(" Select * From Emanet_Kitap Where '"+DateTime.Now.ToShortDateString()+"'>Teslim_Tarihi", baglanti); // Emanet_Kitap tablosundan teslim tarihi bugünden geçmiş olan kayıtları seçen bir SQL komutu için bir veri adaptörü oluşturur. Bugünün tarihini DateTime.Now.ToShortDateString() metodu ile alır.
                adtr.Fill(daset, "Emanet_Kitap");// Veri adaptörü ile DataSet nesnesini doldur ve Emanet_Kitap adında bir tablo oluşturur.
                dataGridView1.DataSource = daset.Tables["Emanet_Kitap"];// dataGridView1 kontrolünün veri kaynağını DataSet nesnesindeki Emanet_Kitap tablosu olarak ayarlar.
                baglanti.Close();
            }
            else if(comboBox1.SelectedIndex == 2)// comboBox1 kontrolündeki seçili öğe 2. indekse sahipse (Zamanında Teslim Edilen Kitaplar seçeneği) yapılacak işlemler.
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter(" Select * From Emanet_Kitap Where '" + DateTime.Now.ToShortDateString() + "'<=Teslim_Tarihi", baglanti);// Emanet_Kitap tablosundan teslim tarihi bugüne eşit veya daha ileri olan kayıtları seçen bir SQL komutu için bir veri adaptörü oluşturur.  Bugünün tarihini DateTime.Now.ToShortDateString() metodu ile alır.
                adtr.Fill(daset, "Emanet_Kitap");// Veri adaptörü ile DataSet nesnesini doldur ve Emanet_Kitap adında bir tablo oluşturur.
                dataGridView1.DataSource = daset.Tables["Emanet_Kitap"];// dataGridView1 kontrolünün veri kaynağını DataSet nesnesindeki Emanet_Kitap tablosu olarak ayarlar.
                baglanti.Close();
            }
        }
    }
}
