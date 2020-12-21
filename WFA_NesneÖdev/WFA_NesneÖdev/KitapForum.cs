using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_NesneÖdev
{
    public partial class KitapForum : Form
    {
        public KitapForum()
        {
            InitializeComponent();
        }

        string kapakSecimi;
    
        private void btnAktar_Click(object sender, EventArgs e)
        {

            Kitap kitap = new Kitap();



            kitap.kacSayfa = nudSayfa.Value;
            kitap.fiyat = nudFiyat.Value;
            kitap.isim = txtİsim.Text;
            kitap.yazar = txtYazar.Text;
            kitap.yayimci = txtYayimci.Text;
        



            if (rbtSert.Checked)
            {
                kitap.sertKapakMi = true;
                kapakSecimi = rbtSert.Text;
            }
            else
            {


                kitap.sertKapakMi = false;
                kapakSecimi = rbtKagit.Text;
            }


            string format = string.Format("Kitap İsmi: {0}, Yazar: {1}, Yayımcı: {2}, Sayfa: {3}, Kapak Tercihi: {4}, Fiyat: {5} TL", kitap.isim, kitap.yazar, kitap.yayimci, kitap.kacSayfa, kapakSecimi, kitap.fiyat);
            lbxYazdir.Items.Add(format);





        }







    }
}

