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
    public partial class GomlekForm : Form
    {
        public GomlekForm()
        {
            InitializeComponent();
        }


        string yakaSecimi;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            Gomlek gomlek = new Gomlek();
            gomlek.beden = nudBeden.Value;
            gomlek.fiyat = nudFiyat.Value;
            gomlek.kumas = txtKumas.Text;
            gomlek.marka = txtMarka.Text;
            gomlek.renk = txtRenk.Text;

            if (rbtDugmeli.Checked)
            {
                
                gomlek.yakaSekli = true;
                yakaSecimi = rbtDugmeli.Text;
            }
            else
            {
                gomlek.yakaSekli = false;
                yakaSecimi = rbtDugmesiz.Text;
            }

            string format = string.Format("Marka: {0}, Beden: {1}, Kumaş: {2}, Renk: {3}, Yaka Şekli: {4}, Fiyat: {5} TL", gomlek.marka, gomlek.beden, gomlek.kumas, gomlek.renk, yakaSecimi, gomlek.fiyat);
            lbxYazdir.Items.Add(format);
        }
    }
}
