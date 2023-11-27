using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class EmanetIadeFrm : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MERT3761;Initial Catalog=\"Kütüphane Otomasyonu\";Integrated Security=True");
        DataSet daset = new DataSet();// Emanet_Kitap tablosundaki kayıtları göstermek için bir DataSet nesnesi oluşturur.
        DataTable table = new DataTable();
        DataView dataView = new DataView();

        public EmanetIadeFrm()
        {
            InitializeComponent();
        }
        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(" Select * From Emanet_Kitap", baglanti);// Emanet_Kitap tablosundaki tüm kayıtları almak için bir SqlDataAdapter oluşturur.
            adtr.Fill(daset, "Emanet_Kitap");
            dataGridView1.DataSource = daset.Tables["Emanet_Kitap"];// DataGridView'in DataSource'ını doldurulan veri kümesinin "Emanet_Kitap" tablosuna ayarlar.
            baglanti.Close();
        }

        private void EmanetIadeFrm_Load(object sender, EventArgs e)
        {//
            baglanti.Open();
            table.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Emanet_Kitap order by UyeAdi", baglanti);//Bu satır, bir SqlDataAdapter nesnesi oluşturur. Bu nesne, veritabanı ile program arasında bir bağlantı kurar. Emanet_Kitap tablosundaki tüm verileri UyeAdi sütununa göre sıralayarak seçer.
            adtr.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.Columns["id_no"].HeaderText = "TC Kimlik No";// Bu satır, dataGridView1 nesnesinin Columns koleksiyonundan id_no isimli sütunu seçer ve HeaderText özelliğini TC Kimlik No olarak değiştirir. Bu şekilde, sütunun başlığı değişir.
            dataGridView1.Columns["UyeAdi"].HeaderText = "İsim";
            dataGridView1.Columns["UyeSoyadi"].HeaderText = "Soyisim";
            dataGridView1.Columns["UyeTel"].HeaderText = "Telefon";
            dataGridView1.Columns["UyeAdres"].HeaderText = "Adres";
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
            EmanetListele();
        }

        private void txtIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcKimlikAra_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "id_no LIKE '%" + txtTcKimlikAra.Text + "%'";//Bu satır, dataView nesnesinin RowFilter özelliğini bir filtre ifadesi ile değiştirir. Bu ifade, id_no sütununun txtTcKimlikAra nesnesinin Text özelliğini içeren değerleri seçer. LIKE operatörü, bir kalıpla eşleşen değerleri bulmak için kullanılır. 
            dataGridView1.DataSource = dataView;
        }

        private void txtBarkodAra_TextChanged(object sender, EventArgs e)
        {
            dataView = table.DefaultView;
            dataView.RowFilter = "Barkod_No LIKE '%" + txtBarkodAra.Text + "%'";
            dataGridView1.DataSource = dataView;
        }

        private void txtTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete from Emanet_Kitap where id_no=@id_no and Barkod_No=@Barkod_No", baglanti);//Bu satır, bir SqlCommand nesnesi oluşturur. Bu nesne, veritabanında bir komut çalıştırmak için kullanılır. Emanet_Kitap tablosundan id_no ve Barkod_No değerleri belirtilen kayıtları siler.
            komut.Parameters.AddWithValue("@id_no", dataGridView1.CurrentRow.Cells["id_no"].Value.ToString());//Bu satır, komut nesnesinin Parameters koleksiyonuna bir parametre ekler. Bu parametre, @id_no yer tutucusunun değerini belirler. Değer, dataGridView1 nesnesinin CurrentRow özelliği ile seçilen satırın Cells koleksiyonundan id_no isimli hücrenin Value özelliğinin ToString metodu ile metne dönüştürülmesi ile elde edilir.
            komut.Parameters.AddWithValue("@Barkod_No", dataGridView1.CurrentRow.Cells["Barkod_No"].Value.ToString());
            komut.ExecuteNonQuery();
            table.Clear();
            SqlCommand komut2 = new SqlCommand("Update Kitaplar Set Stok_Sayisi=Stok_Sayisi+'" + dataGridView1.CurrentRow.Cells["Stok_Sayisi"].Value.ToString() + "' Where Barkod_No=@Barkod_No", baglanti);//Kitaplar tablosunda Barkod_No değeri belirtilen kayıtların Stok_Sayisi sütununu, dataGridView1 nesnesinin CurrentRow özelliği ile seçilen satırın Cells koleksiyonundan Stok_Sayisi isimli hücrenin Value özelliğinin ToString metodu ile metne dönüştürülmesi ile elde edilen değer ile günceller.
            komut2.Parameters.AddWithValue("@Barkod_No", dataGridView1.CurrentRow.Cells["Barkod_No"].Value.ToString());
            komut2.ExecuteNonQuery();
            table.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Emanet_Kitap order by UyeAdi", baglanti);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            MessageBox.Show("Kitap iadesi başarılı bir şekilde gerçekleşti.");
            baglanti.Close();
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
