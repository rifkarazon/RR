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
    public partial class BisikletForm : Form
    {
        public BisikletForm()
        {
            InitializeComponent();
        }
        string aksesuarSecimi;
        decimal toplamFiyat;
        private void btnAktar_Click(object sender, EventArgs e)
        {
            Bisiklet bisiklet = new Bisiklet();

            
            bisiklet.kadrajBoyu = nudKadraj.Value;
            bisiklet.tekerlekBoyu = nudTekerlek.Value;
            bisiklet.vites = nudVites.Value;
            bisiklet.renk = txtRenk.Text;
            bisiklet.marka = txtMarka.Text;

            if (rbtAksesuarlı.Checked)
            {
                bisiklet.aksesuar = true;
                aksesuarSecimi = rbtAksesuarlı.Text;
             
            }
            else
            {
                bisiklet.aksesuar = false;
                aksesuarSecimi = rbtAksesuarsız.Text;
                toplamFiyat = 1500 - 500;
                nudFiyat.Value = toplamFiyat;
            }
            string format = string.Format("Marka: {0}, Renk: {1}, Vites: {2}, Kadraj Boyutu: {3} inç, Tekerlek Boyutu: {4} inç, Aksesuar Seçimi: {5} Fiyat: {6} TL", bisiklet.marka, bisiklet.renk, bisiklet.vites, bisiklet.kadrajBoyu, bisiklet.tekerlekBoyu, aksesuarSecimi, toplamFiyat);
            lbxYazdir.Items.Add(format);

        }

        private void BisikletForm_Load(object sender, EventArgs e)
        {
            Bisiklet bisiklet = new Bisiklet();
            bisiklet.fiyat=nudFiyat.Value=1500;
            nudFiyat.Enabled = false;
        }
    }
}
