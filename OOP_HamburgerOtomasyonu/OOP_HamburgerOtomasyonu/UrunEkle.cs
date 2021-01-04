using System;
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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Menuler menuler = new Menuler();
            menuler.MenuAd = txtMenu.Text;
            menuler.Fiyat = nudFiyat.Value;
            Menuler.MenuListesi.Add(menuler);

        }
    }
}
