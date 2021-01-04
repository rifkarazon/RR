using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class SiparisBilgileri : Form
    {
        public SiparisBilgileri()
        {
            InitializeComponent();
        }
        int toplamSiparis;
        decimal ekstra;
        decimal satilanUrun;
        decimal ciro;
        private void SiparisBilgileri_Load(object sender, EventArgs e)
        {
            foreach (Siparis siparis in Siparis.SiparisListesi)
            {
                toplamSiparis = Siparis.SiparisListesi.Count;
                satilanUrun += siparis.SiparisAdet;
                ekstra += siparis.EkstraMalzeme;
                ciro += siparis.Ciro;


            }
            lblCiro.Text = ciro.ToString();
            lblSiparisSayisi.Text = toplamSiparis.ToString();
            lblEkstra.Text = ekstra.ToString();
            lblUrunAdedi.Text = satilanUrun.ToString();

            foreach (Siparis siparis1 in Siparis.SiparisListesi)
            {
                listBox1.Items.Add($"Menü Adı: {siparis1.SiparisAdi}, Boyut: {siparis1.Boyut}, Ekstralar: {siparis1.EkstraMalzeme}, Tutar: {siparis1.Fiyat.ToString()}");
            }

           
        }
    }
}
