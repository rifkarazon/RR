using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_InheritenceOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kadın kadin = new Kadın();
            kadin.Kitapadi = "Kadın Haklarının Gerekçelendirilmesi";
            kadin.Yazar = "Mary Woolstonecraft";
            kadin.Yayimci = "İş Bankasi";
            kadin.Fiyat = 14m;

            Roman roman = new Roman();
            roman.Kitapadi = "Uğultulu Tepeler";
            roman.Yazar = "Emily Bronte";
            roman.Yayimci = "Antik Batı";
            roman.Fiyat = 18.60m;

            Kulaklik kulaklik = new Kulaklik();
            kulaklik.Marka = "JBL";
            kulaklik.Renk = "Beyaz";
            kulaklik.Fiyat = 359.90m;

            YabanciAlbum yabanci = new YabanciAlbum();
            yabanci.SanatciAdi = "Queen";
            yabanci.Albumİsmi = "Bohemian Rapsody";
            yabanci.Fiyat = 220m;

            List<Urun> urunler = new List<Urun>();
            urunler.Add(kadin);
            urunler.Add(roman);
            urunler.Add(kulaklik);
            urunler.Add(yabanci);

            foreach (Urun urun in urunler)
            {
                if (urun is Kitap)
                {
                    Kitap k = (Kitap)urun;
                    lstKitap.Items.Add(k.Kitapadi);
                    
                }
                else if (urun is Muzik)
                {
                    Muzik m = (Muzik)urun;
                    lstMuzik.Items.Add(m.Albumİsmi);
                }
                else if (urun is Elektronik)
                {
                    Elektronik el = (Elektronik)urun;
                    lstElektronik.Items.Add(el.Marka);
                }
            }
        }

    }
}
