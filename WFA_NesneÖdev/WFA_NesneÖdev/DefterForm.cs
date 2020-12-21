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
    public partial class DefterForm : Form
    {
        public DefterForm()
        {
            InitializeComponent();
        }

        string cizgili;
        string telli;
        string[] renkler = { "Kırmızı" , "Mavi" , "Yeşil" , "Pembe" , "Mor" };
        private void DefterForm_Load(object sender, EventArgs e)
        {
            nudFiyat.Enabled = false;

            cmbKagitCinsi.Items.Add("Saman Kağıt");
            cmbKagitCinsi.Items.Add("Hamur Kağıt");
            cmbKapakSekli.Items.Add("Sert Kapak");
            cmbKapakSekli.Items.Add("Kağıt Kapak");

            foreach (string renk in renkler)
            {
                cmbRenk.Items.Add(renk);
            }

            cmbSayfaSayisi.Items.Add("50 Sayfa");
            cmbSayfaSayisi.Items.Add("100 Sayfa");
            cmbSayfaSayisi.Items.Add("150 Sayfa");
            cmbSayfaTipi.Items.Add("A4");
            cmbSayfaTipi.Items.Add("A3");
            cmbSayfaTipi.Items.Add("A5");
           


        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            Defter defter = new Defter();
            defter.renk = cmbRenk.Text;
            defter.kapakTuru = cmbKapakSekli.Text;
            defter.kagitCinsi = cmbKagitCinsi.Text;
            defter.sayfaSayisi = cmbSayfaSayisi.Text;
            defter.defterTipi = cmbSayfaTipi.Text;
            defter.fiyat = nudFiyat.Value = 20;

            if (rbtCiltli.Checked)
            {
                defter.telliMi = false;
                telli = rbtCiltli.Text;
                defter.fiyat += 10;
            }
            else if (rbtTelli.Checked)
            {
                defter.telliMi = true;
                telli = rbtTelli.Text;
                defter.fiyat += 5;

            }

            if (rbtKareli.Checked)
            {
                defter.neCesit = true;
                cizgili = rbtKareli.Text;

            }
           else if (rbtCizgili.Checked)
            {
                defter.neCesit = true;
                cizgili = rbtCizgili.Text;

            }
            if (rbtCizgisiz.Checked)
            {
                defter.neCesit = true;
                cizgili = rbtCizgisiz.Text;

            }
            string format = string.Format("Defter Tipi: {0}, Kapak Şekli: {1}, Kağıt Cinsi: {2}, Sayfa Sayisi: {3}, Renk: {4}, Özellikler{5}, Özellikler {6] Fiyat {7} TL", defter.defterTipi, defter.kapakTuru, defter.kagitCinsi, defter.sayfaSayisi, defter.renk, telli, cizgili, defter.fiyat);
            lbxYazdir.Items.Add(format);
        }
    }
}
