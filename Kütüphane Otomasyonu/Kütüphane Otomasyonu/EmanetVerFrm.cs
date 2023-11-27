using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kütüphane_Otomasyonu
{
    public partial class EmanetVerFrm : Form
    {//
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();// Emanet_Kitap tablosundaki kayıtları göstermek için bir DataSet nesnesi oluşturur.
        // Emanet_Kitap tablosundaki kayıtları göstermek için DataTable nesnesi oluşturur.
        DataTable tableUyeler = new DataTable();
        DataTable tableKitaplar = new DataTable();
        DataView dataView = new DataView();


        public EmanetVerFrm()
        {
            InitializeComponent();
        }
        private void EmanetVerFrm_Load(object sender, EventArgs e)
        {//
            baglanti.Open();
            tableUyeler.Clear();
            SqlDataAdapter adrUyeler = new SqlDataAdapter("Select * From Uyeler order by UyeAdi", baglanti);// Üyeler tablosundan üye bilgilerini seçen bir SQL komutu için bir veri adaptörü oluşturur.
            adrUyeler.Fill(tableUyeler);// Veri adaptörü ile tableUyeler nesnesini doldurur.
            dataGridView1.DataSource = tableUyeler;// dataGridView1 kontrolünün veri kaynağını tableUyeler nesnesi olarak ayarlar.
            // dataGridView1 kontrolündeki sütun başlıklarını değiştirir.
            dataGridView1.Columns["id_no"].HeaderText = "TC Kimlik No";
            dataGridView1.Columns["UyeAdi"].HeaderText = "İsim";
            dataGridView1.Columns["UyeSoyadi"].HeaderText = "Soyisim";
            dataGridView1.Columns["UyeTel"].HeaderText = "Telefon";
            dataGridView1.Columns["UyeAdres"].HeaderText = "Adres";
            tableKitaplar.Clear();
            SqlDataAdapter adrKitaplar = new SqlDataAdapter("Select * From Kitaplar order by Kitap_Adi", baglanti);// Kitaplar tablosundan kitap bilgilerini seçen bir SQL komutu için bir veri adaptörü oluşturur.
            adrKitaplar.Fill(tableKitaplar);// Veri adaptörü ile tableKitaplar nesnesini doldurur.
            dataGridView2.DataSource = tableKitaplar;// dataGridView2 kontrolünün veri kaynağını tableKitaplar nesnesi olarak ayarlar.
            // dataGridView2 kontrolündeki sütun başlıklarını değiştirir.
            dataGridView2.Columns["Barkod_No"].HeaderText = "Barkod No";
            dataGridView2.Columns["Kitap_Adi"].HeaderText = "Kitap Adı";
            dataGridView2.Columns["Yazari"].HeaderText = "Yazarı";
            dataGridView2.Columns["Yayinevi"].HeaderText = "Yayınevi";
            dataGridView2.Columns["Sayfa_Sayisi"].HeaderText = "Sayfa Sayısı";
            dataGridView2.Columns["Stok_Sayisi"].HeaderText = "Stok Sayısı";
            dataGridView2.Columns["Raf_No"].HeaderText = "Raf No";
            baglanti.Close();
        }

        private void txtİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVer_Click(object sender, EventArgs e)
        {
            try// try-catch bloğu ile hata yakalamaya çalışıyoruz. try bloğu içindeki kodları normal olarak çalıştırıyoruz, eğer bir hata olursa catch bloğu içindeki kodları çalıştırıyoruz.
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Emanet_Kitap(id_no,UyeAdi,UyeSoyadi,UyeTel,Email,UyeAdres,Barkod_No,Kitap_Adi,Yazari,Yayinevi,Sayfa_Sayisi,Stok_Sayisi,Raf_No,Verilme_Tarihi,Teslim_Tarihi)" +
                    " values(@id_no,@UyeAdi,@UyeSoyadi,@UyeTel,@Email,@UyeAdres,@Barkod_No,@Kitap_Adi,@Yazari,@Yayinevi,@Sayfa_Sayisi,@Stok_Sayisi,@Raf_No,@Verilme_Tarihi,@Teslim_Tarihi)", baglanti);// Emanet_Kitap tablosuna yeni bir kayıt eklemek için SQL komutu oluşturur.
                // dataGridView1 ve dataGridView2 kontrollerindeki seçili satırlardan değerleri alır.
                komut.Parameters.AddWithValue("@id_no", dataGridView1.CurrentRow.Cells["id_no"].Value.ToString()); //
                komut.Parameters.AddWithValue("@UyeAdi", dataGridView1.CurrentRow.Cells["UyeAdi"].Value.ToString());
                komut.Parameters.AddWithValue("@UyeSoyadi", dataGridView1.CurrentRow.Cells["UyeSoyadi"].Value.ToString());
                komut.Parameters.AddWithValue("@UyeTel", dataGridView1.CurrentRow.Cells["UyeTel"].Value.ToString());
                komut.Parameters.AddWithValue("@Email", dataGridView1.CurrentRow.Cells["Email"].Value.ToString());
                komut.Parameters.AddWithValue("@UyeAdres", dataGridView1.CurrentRow.Cells["UyeAdres"].Value.ToString());
                komut.Parameters.AddWithValue("@Barkod_No", dataGridView2.CurrentRow.Cells["Barkod_No"].Value.ToString());
                komut.Parameters.AddWithValue("@Kitap_Adi", dataGridView2.CurrentRow.Cells["Kitap_Adi"].Value.ToString());
                komut.Parameters.AddWithValue("@Yazari", dataGridView2.CurrentRow.Cells["Yazari"].Value.ToString());
                komut.Parameters.AddWithValue("@Yayinevi", dataGridView2.CurrentRow.Cells["Yayinevi"].Value.ToString());
                komut.Parameters.AddWithValue("@Sayfa_Sayisi", dataGridView2.CurrentRow.Cells["Sayfa_Sayisi"].Value.ToString());
                komut.Parameters.AddWithValue("@Stok_Sayisi", dataGridView2.CurrentRow.Cells["Stok_Sayisi"].Value.ToString());
                komut.Parameters.AddWithValue("@Raf_No", dataGridView2.CurrentRow.Cells["Raf_No"].Value.ToString());
                komut.Parameters.AddWithValue("@Verilme_Tarihi", dateTimePicker1.Value.ToString());
                komut.Parameters.AddWithValue("@Teslim_Tarihi", dateTimePicker2.Value.ToString());
                komut.ExecuteNonQuery();
                MessageBox.Show("Kitap emanet işlemi başarılı bir şekilde gerçekleşti.");
                baglanti.Close();
            }
            catch (Exception)// Hata oluşursa
            {// Kullanıcıya hata mesajı gösterir.
                MessageBox.Show("Bilgileri kontrol edin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            dataView = tableUyeler.DefaultView;// tableUyeler nesnesinin varsayılan görünümünü alır.
            dataView.RowFilter = "id_no LIKE '%" + txtTcAra.Text + "%'";// Varsayılan görünümün satır filtresini txtTcAra metin kutusundaki değere göre ayarlar. TC kimlik numarası txtTcAra metin kutusundaki değeri içeren kayıtları seçer.
            dataGridView1.DataSource = dataView;// dataGridView1 kontrolünün veri kaynağını varsayılan görünüm olarak ayarlar.
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {//
            dataView = tableKitaplar.DefaultView;// tableKitaplar nesnesinin varsayılan görünümünü alır.
            dataView.RowFilter = "Barkod_No LIKE '%" + txtBarkodAra.Text + "%'";// Varsayılan görünümün satır filtresini txtBarkodAra metin kutusundaki değere göre ayarlar. Barkod numarası txtBarkodAra metin kutusundaki değeri içeren kayıtları seçer.
            dataGridView2.DataSource = dataView;// dataGridView2 kontrolünün veri kaynağını varsayılan görünüm olarak ayarlar.
        }
    }
}
