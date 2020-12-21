
namespace WFA_ElektronikMagzasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.lbxFiltrele = new System.Windows.Forms.ListBox();
            this.cbxKilif = new System.Windows.Forms.CheckBox();
            this.cbxKulaklik = new System.Windows.Forms.CheckBox();
            this.cbxSarj = new System.Windows.Forms.CheckBox();
            this.rbtDiger = new System.Windows.Forms.RadioButton();
            this.rbtRam = new System.Windows.Forms.RadioButton();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lswSiparis = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.btnSepettenCikar = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnRenk = new System.Windows.Forms.Button();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRenk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.btnSepeteEkle);
            this.groupBox1.Controls.Add(this.btnFiltrele);
            this.groupBox1.Controls.Add(this.lbxFiltrele);
            this.groupBox1.Controls.Add(this.cbxKilif);
            this.groupBox1.Controls.Add(this.cbxKulaklik);
            this.groupBox1.Controls.Add(this.cbxSarj);
            this.groupBox1.Controls.Add(this.rbtDiger);
            this.groupBox1.Controls.Add(this.rbtRam);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "radioButton1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Renk:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Marka:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 39);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(49, 13);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Kategori:";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSepeteEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(303, 381);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(102, 46);
            this.btnSepeteEkle.TabIndex = 10;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFiltrele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFiltrele.Location = new System.Drawing.Point(9, 324);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(93, 37);
            this.btnFiltrele.TabIndex = 9;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // lbxFiltrele
            // 
            this.lbxFiltrele.FormattingEnabled = true;
            this.lbxFiltrele.Location = new System.Drawing.Point(222, 19);
            this.lbxFiltrele.Name = "lbxFiltrele";
            this.lbxFiltrele.Size = new System.Drawing.Size(263, 342);
            this.lbxFiltrele.TabIndex = 8;
            // 
            // cbxKilif
            // 
            this.cbxKilif.AutoSize = true;
            this.cbxKilif.Location = new System.Drawing.Point(9, 288);
            this.cbxKilif.Name = "cbxKilif";
            this.cbxKilif.Size = new System.Drawing.Size(42, 17);
            this.cbxKilif.TabIndex = 7;
            this.cbxKilif.Text = "Kılıf";
            this.cbxKilif.UseVisualStyleBackColor = true;
            // 
            // cbxKulaklik
            // 
            this.cbxKulaklik.AutoSize = true;
            this.cbxKulaklik.Location = new System.Drawing.Point(9, 265);
            this.cbxKulaklik.Name = "cbxKulaklik";
            this.cbxKulaklik.Size = new System.Drawing.Size(63, 17);
            this.cbxKulaklik.TabIndex = 6;
            this.cbxKulaklik.Text = "Kulaklık";
            this.cbxKulaklik.UseVisualStyleBackColor = true;
            // 
            // cbxSarj
            // 
            this.cbxSarj.AutoSize = true;
            this.cbxSarj.Location = new System.Drawing.Point(9, 242);
            this.cbxSarj.Name = "cbxSarj";
            this.cbxSarj.Size = new System.Drawing.Size(44, 17);
            this.cbxSarj.TabIndex = 5;
            this.cbxSarj.Text = "Şarj";
            this.cbxSarj.UseVisualStyleBackColor = true;
            // 
            // rbtDiger
            // 
            this.rbtDiger.AutoSize = true;
            this.rbtDiger.Location = new System.Drawing.Point(9, 194);
            this.rbtDiger.Name = "rbtDiger";
            this.rbtDiger.Size = new System.Drawing.Size(85, 17);
            this.rbtDiger.TabIndex = 3;
            this.rbtDiger.TabStop = true;
            this.rbtDiger.Text = "radioButton2";
            this.rbtDiger.UseVisualStyleBackColor = true;
            // 
            // rbtRam
            // 
            this.rbtRam.AutoSize = true;
            this.rbtRam.Checked = true;
            this.rbtRam.Location = new System.Drawing.Point(9, 171);
            this.rbtRam.Name = "rbtRam";
            this.rbtRam.Size = new System.Drawing.Size(85, 17);
            this.rbtRam.TabIndex = 2;
            this.rbtRam.TabStop = true;
            this.rbtRam.Text = "radioButton1";
            this.rbtRam.UseVisualStyleBackColor = true;
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(78, 71);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbMarka.TabIndex = 1;
            // 
            // cmbKategori
            // 
            this.cmbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(78, 36);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lswSiparis
            // 
            this.lswSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lswSiparis.FullRowSelect = true;
            this.lswSiparis.GridLines = true;
            this.lswSiparis.HideSelection = false;
            this.lswSiparis.Location = new System.Drawing.Point(520, 21);
            this.lswSiparis.Name = "lswSiparis";
            this.lswSiparis.Size = new System.Drawing.Size(472, 389);
            this.lswSiparis.TabIndex = 1;
            this.lswSiparis.UseCompatibleStateImageBehavior = false;
            this.lswSiparis.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 328;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Fiyatı";
            this.columnHeader2.Width = 135;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSiparisVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.Location = new System.Drawing.Point(870, 426);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(105, 35);
            this.btnSiparisVer.TabIndex = 10;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = false;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // btnSepettenCikar
            // 
            this.btnSepettenCikar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSepettenCikar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepettenCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepettenCikar.Location = new System.Drawing.Point(540, 426);
            this.btnSepettenCikar.Name = "btnSepettenCikar";
            this.btnSepettenCikar.Size = new System.Drawing.Size(115, 45);
            this.btnSepettenCikar.TabIndex = 11;
            this.btnSepettenCikar.Text = "Sepetten Çıkar";
            this.btnSepettenCikar.UseVisualStyleBackColor = false;
            this.btnSepettenCikar.Click += new System.EventHandler(this.btnSepettenCikar_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(78, 109);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(121, 23);
            this.btnRenk.TabIndex = 14;
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Renk";
            this.columnHeader3.Width = 88;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 488);
            this.Controls.Add(this.btnSepettenCikar);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.lswSiparis);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.ListBox lbxFiltrele;
        private System.Windows.Forms.CheckBox cbxKilif;
        private System.Windows.Forms.CheckBox cbxKulaklik;
        private System.Windows.Forms.CheckBox cbxSarj;
        private System.Windows.Forms.RadioButton rbtDiger;
        private System.Windows.Forms.RadioButton rbtRam;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ListView lswSiparis;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.Button btnSepettenCikar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

