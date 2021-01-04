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
    public partial class RandevuOluştur : Form
    {
        public RandevuOluştur()
        {
            InitializeComponent();
        }

        List<string> saatler = new List<string>()
        {
            "10:00","10:30","11:00","11:30","12:00", "12.30","13.00", "13.30", "14.00","14.30", "15.00"
        };
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            if (txtTc.Text == "" || txtAd.Text == "" || txtSoyad.Text == "" || cmbRandevuBrans.SelectedIndex < 0 || cmbRandevuDoktor.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bütün alanları gerekli bilgilerle doldurunuz.");

                if (dtpTarih.Value.Day <= DateTime.Today.Day)
                {
                    MessageBox.Show("Lütfen ileri bir tarih seçiniz");
                }
            }
          

            else
            {
                SaatOlustur();
            }
        }

        void SaatOlustur()
        {
            Button btn = new Button();
            for (int i = 0; i < saatler.Count; i++)
            {
               
                btn.Text = saatler[i];
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);

                
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DialogResult drs = MessageBox.Show(dtpTarih.Value.ToShortDateString()+ "tarihli"+ btn.Text + "saatli randevunuz oluşturulsun mu?", "Randevu",MessageBoxButtons.YesNo, MessageBoxIcon.Information);


            if (drs==DialogResult.Yes)
            {
                Randevu randevu = new Randevu();

                btn.Enabled = false;
                btn.BackColor = Color.Red;
                randevu.Tckn = txtTc.Text;
                randevu.Ad = txtAd.Text;
                randevu.Soyad = txtSoyad.Text;
                randevu.Tarih=dtpTarih.Value;
                randevu.Saat = btn.Text;
                randevu.Brans = (Brans)cmbRandevuBrans.SelectedItem;
                randevu.Doktor = (Doktor)cmbRandevuDoktor.SelectedItem;
                Randevu.RandevularListesi.Add(randevu);


            }
            else
            {
                MessageBox.Show("Randevu işlemi iptal edilmiştir.");
            }
        }

        private void RandevuOluştur_Load(object sender, EventArgs e)
        {
            cmbRandevuBrans.DataSource = Brans.Branslar.ToList();
      
        }

        private void cmbRandevuBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRandevuDoktor.Items.Clear();

            foreach (Doktor doktor in Brans.Doktorlar)
            {
                if (doktor.Brans== cmbRandevuBrans.SelectedItem)
                {
                    cmbRandevuDoktor.Items.Add(doktor);
                }
            }
            
        }
    }
}
