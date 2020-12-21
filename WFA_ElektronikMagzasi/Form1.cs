using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_ElektronikMagzasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] elektronik = { "Telefon", "Bilgisayar" };
        string[] modeller = { "Iphone 11", "Samsung Note 8", "Oppo Reno 4", "Xiaomi mi 5", "Huawei Mate 9 Pro", "Apple MacBook Pro", "Monster Tulpar", "Monster Abra", "HP Gamer", "Lenovo Think Pad" };
        double[] fiyatlar = { 10000, 7425, 3566, 2748, 4665, 21532, 9522, 7800, 11256, 5633 };
        double toplamFiyat = 0;
        string ekstra = "";
        string hafiza = "";
        double fiyat = 0;
        string model = "";
        double sonFiyat = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < elektronik.Length; i++)
            {
                cmbKategori.Items.Add(elektronik[i]);

            }
            rbtRam.Text = "";
            rbtDiger.Text = "";
           
            
            
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbMarka.Items.Clear();
            switch (cmbKategori.Text)
            {
                case "Bilgisayar":
                    cmbMarka.Items.Add(modeller[5]);
                    cmbMarka.Items.Add(modeller[6]);
                    cmbMarka.Items.Add(modeller[7]);
                    cmbMarka.Items.Add(modeller[8]);
                    cmbMarka.Items.Add(modeller[9]);

                    break;

                case "Telefon":
                    cmbMarka.Items.Add(modeller[0]);
                    cmbMarka.Items.Add(modeller[1]);
                    cmbMarka.Items.Add(modeller[2]);
                    cmbMarka.Items.Add(modeller[3]);
                    cmbMarka.Items.Add(modeller[4]);
                    break;
            }
            if (cmbKategori.Text == "Bilgisayar")
            {
                rbtRam.Text = "520 GB";
                rbtDiger.Text = "1 TB ve üstü";
            }
            else if (cmbKategori.Text == "Telefon")
            {
                rbtRam.Text = "8 GB";
                rbtDiger.Text = "16 GB ve üstü";
            }

        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            ekstra = "";
            if (cmbKategori.SelectedItem is null)
            {
                MessageBox.Show("Lütfen bir kategori seçiniz.");
            }


            if (cmbMarka.SelectedItem is null)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }

          
            else
            {
               

                if (rbtRam.Checked)
                {
                    hafiza = rbtRam.Text;
                }
                else if (rbtDiger.Checked)
                {
                    hafiza = rbtDiger.Text;
                    toplamFiyat += 350; 

                }

                else
                {
                    MessageBox.Show("Lütfen bir hafıza ürünü seçiniz.");
                }

                if (cbxKilif.Checked)
                {
                    ekstra += "Kılıf";
                    toplamFiyat += 210;
                }

                if (cbxKulaklik.Checked)
                {
                    ekstra += " Kulaklik";
                    toplamFiyat += 550;
                }

                if (cbxSarj.Checked)
                {
                    ekstra += " Şarj";
                    toplamFiyat += 420;
                }
                
                int y = 0;
                for (int x = 0; x < 9; x++)
                {
                    while (cmbMarka.SelectedIndex == y)
                    {
                        fiyat = fiyatlar[y];
                        model = modeller[y];

                        y++;
                    }
                    y++;

                   
                }
                toplamFiyat += fiyat;
                 sonFiyat = toplamFiyat;
                lbxFiltrele.Items.Add(cmbMarka.Text + " " + hafiza + " " + ekstra );
                toplamFiyat = 0;
                fiyat = 0;

            }


        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {


            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;

            if (lbxFiltrele.SelectedItem is null)
            {
                MessageBox.Show("Lütfen ürünleri seçiniz.");
            }
            else
            {
           

                lvi.Text = lbxFiltrele.SelectedItem.ToString();
                lvi.SubItems.Add(sonFiyat.ToString());
                lvi.SubItems.Add("");

                lvi.SubItems[2].BackColor = btnRenk.BackColor;
                lswSiparis.Items.Add(lvi);

                
            }
          

          
        }

        private void btnSiparisVer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("İşlemi onaylamak istiyor musnuz? Ödenecek tutar " + sonFiyat.ToString(), "Ödeme Tutarı", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result==DialogResult.Yes)
            {
                cmbKategori.Items.Clear();
                cmbMarka.Items.Clear();
                rbtRam.Checked = false;
                rbtDiger.Checked = false;
                cbxKilif.Checked = false;
                cbxKulaklik.Checked = false;
                cbxSarj.Checked=false;
                lbxFiltrele.Items.Clear();
                lswSiparis.Items.Clear();
                Application.Exit();
            }

            else
            {
                MessageBox.Show("Siparişinize devam edebilirsiniz.");
            }
            

            
          
        }

        private void btnSepettenCikar_Click(object sender, EventArgs e)
        {

            if (lswSiparis.Items.Count == 0)
            {
                MessageBox.Show("Silmek için bir ürün ekleyin.");
            }
            else if (lswSiparis.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silmek için ürün seçin.");
            }
            else
            {
                lswSiparis.Items.Remove(lswSiparis.SelectedItems[0]);
            }
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            DialogResult clr = colorDialog1.ShowDialog();

            if (clr ==DialogResult.OK)
            {
                btnRenk.BackColor = colorDialog1.Color;
            }

            else
            {
                MessageBox.Show("Renk seçimi iptal edildi.");
            }
           
        }
    }
}





