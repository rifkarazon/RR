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
    public partial class KoltukForm : Form
    {
        public KoltukForm()
        {
            InitializeComponent();
        }
        string tahta;
        string minder;
        string stilSecimi;
        private void KoltukForm_Load(object sender, EventArgs e)
        {
            nudFiyat.Enabled = false;
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            Koltuk koltuk = new Koltuk();
            koltuk.marka = txtMarka.Text;
            koltuk.renk = txtRenk.Text;
            koltuk.olculer = nudOlculer.Value;
            koltuk.fiyat = nudFiyat.Value = 0;

            if (rbtCeviz.Checked)
            {
                koltuk.tahtaSecimi = true;
                tahta = rbtCeviz.Text;
                koltuk.fiyat += 225;
            }
            else if (rbtMese.Checked)
            {
                koltuk.tahtaSecimi = false;
                tahta = rbtMese.Text;
                koltuk.fiyat += 250;
            }

            if (rbtElyaf.Checked)
            {
                koltuk.yastik = true;
                minder = rbtElyaf.Text;
                koltuk.fiyat += 150;
            }
            else if (rbtParcaElyaf.Checked)
            {
                koltuk.yastik = false;
                minder = rbtParcaElyaf.Text;
                koltuk.fiyat += 120;
            }

            if (rbtTekli.Checked)
            {
                koltuk.stil = true;
                stilSecimi = rbtTekli.Text;
                
            }
            else if (rbtİkili.Checked)
            {
                koltuk.stil = false;
                stilSecimi = rbtİkili.Text;
                koltuk.fiyat += 260;

            }
            else if (rbtUclu.Checked)
            {
                koltuk.stil = false;
                stilSecimi = rbtUclu.Text;
                koltuk.fiyat += 1500;

            }
            else if (rbtKose.Checked)
             {
                koltuk.stil = true;
                stilSecimi = rbtKose.Text;
                koltuk.fiyat += 3000;

            }

            string format = string.Format("Marka: {0}, Renk: {1}, Stil: {2}, Tahta Seçimi: {3}, Minder Seçimi: {4}, Fiyat {5} TL", koltuk.marka, koltuk.renk, stilSecimi,tahta,minder, koltuk.fiyat);
            lbxYazdir.Items.Add(format);


        }
    }
}
