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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void randevuOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuOluştur randevuoluştur = new RandevuOluştur();
            randevuoluştur.MdiParent = this;
            randevuoluştur.Show();
        }

        private void branşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BranForm bransform = new BranForm();
            bransform.MdiParent = this;
            bransform.Show();
        }

        private void doktorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorForm doktorform = new DoktorForm();
            doktorform.MdiParent = this;
            doktorform.Show();
        }

        private void randevuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuForm randevuform = new RandevuForm();
            randevuform.MdiParent = this;
            randevuform.Show();
        }

     
    }
}
