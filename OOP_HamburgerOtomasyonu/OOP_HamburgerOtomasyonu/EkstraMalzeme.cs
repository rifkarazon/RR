﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_HamburgerOtomasyonu
{
    public partial class EkstraMalzeme : Form
    {
        public EkstraMalzeme()
        {
            InitializeComponent();
        }

        private void btnEkstraKaydet_Click(object sender, EventArgs e)
        {
            Ekstralar ekstra = new Ekstralar();
            ekstra.EkstraAd = txtEkstra.Text;
            ekstra.Fiyat = nudEkstraFiyat.Value;
            Ekstralar.EkstraListesi.Add(ekstra);
        }
    }
}
