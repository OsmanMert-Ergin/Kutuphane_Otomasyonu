using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class AnaSayfaTxt : Form
    {
        public AnaSayfaTxt()
        {
            InitializeComponent();
        }

        private void UyekleTxt_Click(object sender, EventArgs e)
        {
            UyeEklefrm uyeekle = new UyeEklefrm();
            uyeekle.ShowDialog();
        }

        private void UyeListeleTxt_Click(object sender, EventArgs e)
        {
            UyeListelemefrm uyelistele = new UyeListelemefrm();
            uyelistele.ShowDialog();
        }

        private void KitapEkleTxt_Click(object sender, EventArgs e)
        {
            KitapEkleFrm kitapekle = new KitapEkleFrm();
            kitapekle.ShowDialog();
        }

        private void KitapListeleTxt_Click(object sender, EventArgs e)
        {
            KitapListeleFrm kitaplistele = new KitapListeleFrm();
            kitaplistele.ShowDialog();
        }

        private void EmanetVerTxt_Click(object sender, EventArgs e)
        {
            EmanetVerFrm emanetver = new EmanetVerFrm();
            emanetver.ShowDialog();
        }

        private void AnaSayfaTxt_Load(object sender, EventArgs e)
        {

        }

        private void EmanetListeleTxt_Click(object sender, EventArgs e)
        {
            EmanetListeleFrm listele = new EmanetListeleFrm();
            listele.ShowDialog();
        }

        private void EmanetİadeTxt_Click(object sender, EventArgs e)
        {
            EmanetIadeFrm iade = new EmanetIadeFrm();
            iade.ShowDialog();
        }
    }
}
