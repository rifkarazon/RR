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
    public partial class OjeForum : Form
    {
        public OjeForum()
        {
            InitializeComponent();
        }

      

      

        private void btnAktar_Click(object sender, EventArgs e)
        {
            Oje oje = new Oje();
            oje.renk = txtRenk.Text;
            oje.ojeNumarasi = nudOjeNumarasi.Value;
            oje.fiyat = nudFiyat.Value;
            oje.marka = txtMarka.Text;
            oje.olcu = nudOlcu.Value;

            string format= string.Format("Renk: {0}, Oje Numarası: {1}, Fiyat: {2} TL, Marka: {3}, Ölçü: {4} ml", oje.renk, oje.ojeNumarasi, oje.fiyat, oje.marka, oje.olcu);
            lbxYazdir.Items.Add(format);

        }
    }
}
