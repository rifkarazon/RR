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
    public partial class RandevuForm : Form
    {
        public RandevuForm()
        {
            InitializeComponent();
        }

        private void RandevuForm_Load(object sender, EventArgs e)
        {
            foreach (Randevu randevu in Randevu.RandevularListesi)
            {
                string[] randevular = { randevu.Ad, " ", randevu.Soyad, " ", randevu.Brans.ToString(), " ", randevu.Doktor.ToString(), " ", randevu.Tarih.ToShortDateString() };

                ListViewItem lsw = new ListViewItem(randevular);
                listView1.Items.Add(lsw);
            }
        }

       
    }
}
