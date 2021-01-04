using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HastaneRandevuOdev
{
    public partial class DoktorForm : Form
    {
        public DoktorForm()
        {
            InitializeComponent();
        }
      
       
        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();
            doktor.Ad = txtDoktor.Text;
            doktor.Brans = (Brans)cmbDoktorBrans.SelectedItem;
            Brans.Doktorlar.Add(doktor);
            ListViewItem lsw = new ListViewItem();
            lsw.Text = doktor.Ad;
            lsw.SubItems.Add(doktor.Brans.ToString());
            listView1.Items.Add(lsw);
         
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {

            cmbDoktorBrans.DataSource = Brans.Branslar.ToList();

        }
    }
}
