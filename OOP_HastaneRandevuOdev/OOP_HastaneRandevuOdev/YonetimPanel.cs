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
    public partial class YonetimPanel : Form
    {
        public YonetimPanel()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi = txtKullanici.Text.ToLower();
            kullanici.Sifre = txtSifra.Text;
            if (kullanici.KullaniciAdi=="bilgedoktor")
            {
                if (kullanici.Sifre=="1234")
                {
                    MdiForm mdiForm = new MdiForm();
                    mdiForm.Show();
                    this.Hide();
                }
            }
       
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış. Lütfen bilgilerinizi kontrol ediniz.");
            }


           
        }
    }
}
