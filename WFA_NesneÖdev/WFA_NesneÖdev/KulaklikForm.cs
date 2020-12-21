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
    public partial class KulaklikForm : Form
    {
        public KulaklikForm()
        {
            InitializeComponent();
        }
        string bluetoothSecimi;
        string erisim;
        private void KulaklikForm_Load(object sender, EventArgs e)
        {
            gbxStil.Visible = false;
            nudFiyat.Enabled = false;
           
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            Kulaklik kulaklik = new Kulaklik();
            kulaklik.fiyat = nudFiyat.Value = 650;
            kulaklik.marka = txtMarka.Text;
            kulaklik.renk = txtRenk.Text;

         

            foreach (CheckBox cbx in gbxStil.Controls)
            {
                if (cbx.Checked)
                {
                    
                    kulaklik.stil += cbx.Text + ", ";
                }
            }
            erisim += kulaklik.stil;

            if (rbtBluetooth.Checked)
            {
                kulaklik.fiyat += 550;
                kulaklik.bluetoothMu = true;
                bluetoothSecimi = rbtBluetooth.Text;
                    
            }
            else
            {
                kulaklik.bluetoothMu = false;
                bluetoothSecimi = rbtKablolu.Text;

            }
            

            string format = string.Format("Marka: {0}, Renk: {1}, Fiyat: {2} TL, Erişim: {3}, Stil: {4}", kulaklik.marka, kulaklik.renk, kulaklik.fiyat, bluetoothSecimi, erisim);
            lbxYazdir.Items.Add(format);

            


        }

        private void rbtBluetooth_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rbx = (RadioButton)ctrl;
                    if (rbx.Checked)
                    {
                        gbxStil.Visible = true;
                        rbtKablolu.Enabled = false;
                    }
                }
            }


        }

        private void rbtKablolu_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton rbx = (RadioButton)ctrl;
                    if (rbx.Checked)
                    {
                        gbxStil.Visible = true;
                        rbtBluetooth.Enabled = false;
                    }
                }
            }
        }
    }
}
