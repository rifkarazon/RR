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
    public partial class SiparisOlustur : Form
    {
        public SiparisOlustur()
        {
            InitializeComponent();
        }
 
        decimal toplamFiyat;
        private void SiparisOlustur_Load(object sender, EventArgs e)
        {
            cmbMenu.DataSource = Menuler.MenuListesi.ToList();

            foreach (Ekstralar ekstralar in Ekstralar.EkstraListesi)
            {
                CheckBox chk = new CheckBox();
                chk.Text = ekstralar.EkstraAd;
                flwEkstra.Controls.Add(chk);
               
                 
                
            }
            


        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            foreach (Menuler menuler in Menuler.MenuListesi)
            {
                if (cmbMenu.Text==menuler.MenuAd)
                {
                    toplamFiyat += menuler.Fiyat;
                }
            }


            Boyut boyut = new Boyut();

            switch (boyut)
            {
                case Boyut.Küçük:
                    
                    break;
                case Boyut.Orta:
                    toplamFiyat += 2m;
                    break;
                case Boyut.Büyük:
                    toplamFiyat += 5m;
                    break;
                
            }

            foreach (Ekstralar ekstra in Ekstralar.EkstraListesi)
            {
                foreach (Control control in flwEkstra.Controls)
                {

                    if (control is CheckBox)
                    {
                        CheckBox chk = new CheckBox();

                        if (chk.Text==ekstra.EkstraAd)
                        {
                            toplamFiyat += ekstra.Fiyat;
                        }
                    }
                }
            }
           
            lblToplamTutar.Text = toplamFiyat.ToString();

        }
    }
}
