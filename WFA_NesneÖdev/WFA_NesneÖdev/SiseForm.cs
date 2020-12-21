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
    public partial class SiseForm : Form
    {
        public SiseForm()
        {
            InitializeComponent();
        }
       

   
        string kapakSecimi;
        string saydamlikSecimi;
       
        private void btnAktar_Click(object sender, EventArgs e)
        {
            Sise sise = new Sise();
            sise.hacim = nudHacim.Value;
            sise.renk = txtRenk.Text;
            sise.hammade = txtMadde.Text;


            if (rbtCevirmeli.Checked)
            {
                sise.kapakŞekli = true;
                kapakSecimi = rbtCevirmeli.Text;
            }
            else
            {
                sise.kapakŞekli = false;
                kapakSecimi = rbtSikistirma.Text;
            }

            if (rbtOpak.Checked)
            {
                sise.opakMi = true;
                saydamlikSecimi = rbtOpak.Text;

            }
            else
            {
                sise.opakMi = false;
                saydamlikSecimi = rbtSaydam.Text;
            }


            string format = string.Format("Renk: {0}, Hammadde: {1}, Hacim: {2} ml, Kapak Seçimi: {3}, Opaklık Seçimi: {4}" ,sise.renk,sise.hammade, sise.hacim, kapakSecimi,saydamlikSecimi);
            lbxYazdir.Items.Add(format);

        }

       
    }
}
