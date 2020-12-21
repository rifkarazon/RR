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
    public partial class YuzukForm : Form
    {
        public YuzukForm()
        {
            InitializeComponent();
        }

        string malzemeSecimi;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            Yuzuk yuzuk = new Yuzuk();
            yuzuk.isleme = txtIsleme.Text;
            yuzuk.karat = nudKarat.Value;
            yuzuk.olcu = nudOlcu.Value;
            yuzuk.tas = txtTas.Text;
            yuzuk.fiyat = nudFiyat.Value;

            if (rbtAltin.Checked)
            {
                yuzuk.malzeme = true;
                malzemeSecimi = rbtAltin.Text;
            }
            else
            {
                yuzuk.malzeme = false;
                malzemeSecimi = rbtBeyazAltin.Text;

            }
            string format = string.Format("İşleme: {0}, Taş Seçimi: {1}, Karat: {2}, Ölçü: {3} cm, Seçilen Malzeme: {4}, Fiyat: {5} TL", yuzuk.isleme, yuzuk.tas, yuzuk.karat, yuzuk.olcu, malzemeSecimi, yuzuk.fiyat);
            lbxYazdir.Items.Add(format);


        }
    }
}
