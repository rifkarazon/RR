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
        string ekstraSos;
        decimal toplamFiyat;
        decimal siparisFiyatı;
        string boyut;
        decimal menuFiyati = 0;
     
      
        int ekstraMalzemeAdedi;
        decimal ekstraFiyat = 0;

        int ekstraMalzemeAdediToplam = 0;

        Menuler menuler1 = new Menuler();

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
          


            //Siparis siparis = new Siparis();
            //siparis.Ad = cmbMenu.Text;
            //Boyut boyut = new Boyut();

            //Switch case ile radio button ataması yapamadım.
            //switch (boyut)
            //{

            //    case Boyut.Küçük:
            //        menuler1.MenuBoyu = Boyut.Küçük;
            //        siparis.Boyut = rbKucuk.Text;
            //        break;
            //    case Boyut.Orta:
            //        menuler1.MenuBoyu = Boyut.Orta;
            //        siparis.Boyut = rbOrta.Text;
            //    toplamFiyat += 2m;


            //        break;
            //    case Boyut.Büyük:
            //        menuler1.MenuBoyu = Boyut.Büyük;
            //        siparis.Boyut = rbBuyuk.Text;
            //        toplamFiyat += 5m;
            //        break;

            //}

           

    
            if (nudAdet.Value > 0 && cmbMenu.SelectedItem!= null)
            {
                
                foreach (Menuler menuler in Menuler.MenuListesi)
                {

                    if (cmbMenu.Text == menuler.MenuAd)
                    {
                        toplamFiyat += menuler.Fiyat;
                    }
                }

                menuler1.Fiyat = toplamFiyat;
                if (rbKucuk.Checked)
                {

                    menuler1.MenuBoyu = Boyut.Küçük;
                    boyut = "Küçük";
                }

                else if (rbOrta.Checked)
                {
                    menuFiyati += 2;
                    menuler1.MenuBoyu = Boyut.Orta;
                    boyut = "Orta";
                }

                else if (rbBuyuk.Checked)
                {
                    menuFiyati += 5;
                    menuler1.MenuBoyu = Boyut.Büyük;
                    boyut = "Büyük";
                }
                foreach (Ekstralar ekstra in Ekstralar.EkstraListesi)
                {
                    foreach (CheckBox control in flwEkstra.Controls)
                    {
                        CheckBox chkc = (CheckBox)control;

                        if (chkc.Checked)
                        {
                            if (chkc.Text == ekstra.EkstraAd)
                            {
                                toplamFiyat += ekstra.Fiyat;
                                ekstraSos = ekstra.EkstraAd + " ";
                                ekstraMalzemeAdedi++;
                            }
                        }

                    }
                   


                    
                }

                menuler1.Adet = Convert.ToInt32(nudAdet.Value);
                siparisFiyatı = menuler1.Adet * (ekstraFiyat + menuFiyati);
                toplamFiyat += siparisFiyatı;
                ekstraMalzemeAdediToplam += ekstraMalzemeAdedi;
                menuler1.MenuAd = cmbMenu.SelectedItem.ToString();
                listBox1.Items.Add($"{menuler1.MenuAd} - ({ekstraSos}) - {menuler1.Adet + " Adet"}  {toplamFiyat.ToString("C2")}");
                lblToplamTutar.Text = toplamFiyat.ToString();

                Siparis siparis = new Siparis();

                siparis.Ciro += siparisFiyatı;
                siparis.ToplamSiparis++;
               siparis.EkstraMalzeme += ekstraFiyat;
             siparis.SatilanUrun = (siparis.ToplamSiparis + ekstraMalzemeAdediToplam) * Convert.ToInt32(menuler1.Adet);
                siparis.SiparisAdet = nudAdet.Value;
                Siparis.SiparisListesi.Add(siparis);

               
                ekstraFiyat = 0;
                ekstraMalzemeAdedi = 0;



            }
            else
            {
                MessageBox.Show("Lütfen siparişinizin adını ve adedini girinz.");
            }

            siparisFiyatı = 0;
            toplamFiyat = 0;
            ekstraSos = "";


        }
        void Temiz()
        {
            toplamFiyat = 0;
            listBox1.Items.Clear();
            foreach (RadioButton rbt in groupBox1.Controls)
            {
                rbt.Checked = false;
            }

            foreach (CheckBox chk in flwEkstra.Controls)
            {
                chk.Checked = false;
            }
            nudAdet.Value = 0;
            cmbMenu.SelectedItem = null;
            lblToplamTutar.Text = null;


        }
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Siparişinizin toplamı:" +" "+ listBox1.Items.Count +" " + "Toplam Fiyat:" +" "+ toplamFiyat.ToString("C2")+" " + "Devam edilsin mi?", "Devam et", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
               
       
                Temiz();
            }

            else
            {
                MessageBox.Show("Siparişiniz iptal edilmiştir. Devam etmek için Siparişinizi tamamlamanız gerekmektedir.");
            }
        }
    }
}
