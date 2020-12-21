
namespace WFA_NesneÖdev
{
    partial class KulaklikForm
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
            this.rbtKablolu = new System.Windows.Forms.RadioButton();
            this.rbtBluetooth = new System.Windows.Forms.RadioButton();
            this.btnAktar = new System.Windows.Forms.Button();
            this.Sayfa = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.lbxYazdir = new System.Windows.Forms.ListBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxStil = new System.Windows.Forms.GroupBox();
            this.cbxKulakici = new System.Windows.Forms.CheckBox();
            this.cbxMikrofonlu = new System.Windows.Forms.CheckBox();
            this.cbxHeadphone = new System.Windows.Forms.CheckBox();
            this.cbxTekKulak = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.gbxStil.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtKablolu
            // 
            this.rbtKablolu.AutoSize = true;
            this.rbtKablolu.Location = new System.Drawing.Point(183, 155);
            this.rbtKablolu.Name = "rbtKablolu";
            this.rbtKablolu.Size = new System.Drawing.Size(60, 17);
            this.rbtKablolu.TabIndex = 75;
            this.rbtKablolu.TabStop = true;
            this.rbtKablolu.Text = "Kablolu";
            this.rbtKablolu.UseVisualStyleBackColor = true;
            this.rbtKablolu.CheckedChanged += new System.EventHandler(this.rbtKablolu_CheckedChanged);
            // 
            // rbtBluetooth
            // 
            this.rbtBluetooth.AutoSize = true;
            this.rbtBluetooth.Location = new System.Drawing.Point(47, 155);
            this.rbtBluetooth.Name = "rbtBluetooth";
            this.rbtBluetooth.Size = new System.Drawing.Size(70, 17);
            this.rbtBluetooth.TabIndex = 74;
            this.rbtBluetooth.TabStop = true;
            this.rbtBluetooth.Text = "Bluetooth";
            this.rbtBluetooth.UseVisualStyleBackColor = true;
            this.rbtBluetooth.CheckedChanged += new System.EventHandler(this.rbtBluetooth_CheckedChanged);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(126, 363);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(90, 32);
            this.btnAktar.TabIndex = 71;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Sayfa
            // 
            this.Sayfa.AutoSize = true;
            this.Sayfa.Location = new System.Drawing.Point(69, 120);
            this.Sayfa.Name = "Sayfa";
            this.Sayfa.Size = new System.Drawing.Size(29, 13);
            this.Sayfa.TabIndex = 70;
            this.Sayfa.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(143, 118);
            this.nudFiyat.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 69;
            // 
            // lbxYazdir
            // 
            this.lbxYazdir.FormattingEnabled = true;
            this.lbxYazdir.Location = new System.Drawing.Point(311, 50);
            this.lbxYazdir.Name = "lbxYazdir";
            this.lbxYazdir.Size = new System.Drawing.Size(672, 316);
            this.lbxYazdir.TabIndex = 68;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(143, 50);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 67;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(143, 83);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 66;
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(69, 53);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(37, 13);
            this.Yazar.TabIndex = 65;
            this.Yazar.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Renk";
            // 
            // gbxStil
            // 
            this.gbxStil.Controls.Add(this.cbxTekKulak);
            this.gbxStil.Controls.Add(this.cbxHeadphone);
            this.gbxStil.Controls.Add(this.cbxMikrofonlu);
            this.gbxStil.Controls.Add(this.cbxKulakici);
            this.gbxStil.Location = new System.Drawing.Point(40, 192);
            this.gbxStil.Name = "gbxStil";
            this.gbxStil.Size = new System.Drawing.Size(253, 131);
            this.gbxStil.TabIndex = 78;
            this.gbxStil.TabStop = false;
            this.gbxStil.Text = "Stiller";
            // 
            // cbxKulakici
            // 
            this.cbxKulakici.AutoSize = true;
            this.cbxKulakici.Location = new System.Drawing.Point(7, 34);
            this.cbxKulakici.Name = "cbxKulakici";
            this.cbxKulakici.Size = new System.Drawing.Size(67, 17);
            this.cbxKulakici.TabIndex = 0;
            this.cbxKulakici.Text = "Kulak İçi";
            this.cbxKulakici.UseVisualStyleBackColor = true;
            // 
            // cbxMikrofonlu
            // 
            this.cbxMikrofonlu.AutoSize = true;
            this.cbxMikrofonlu.Location = new System.Drawing.Point(7, 78);
            this.cbxMikrofonlu.Name = "cbxMikrofonlu";
            this.cbxMikrofonlu.Size = new System.Drawing.Size(115, 17);
            this.cbxMikrofonlu.TabIndex = 1;
            this.cbxMikrofonlu.Text = "Mikrofonlu Kulaklık";
            this.cbxMikrofonlu.UseVisualStyleBackColor = true;
            // 
            // cbxHeadphone
            // 
            this.cbxHeadphone.AutoSize = true;
            this.cbxHeadphone.Location = new System.Drawing.Point(139, 34);
            this.cbxHeadphone.Name = "cbxHeadphone";
            this.cbxHeadphone.Size = new System.Drawing.Size(82, 17);
            this.cbxHeadphone.TabIndex = 2;
            this.cbxHeadphone.Text = "Headphone";
            this.cbxHeadphone.UseVisualStyleBackColor = true;
            // 
            // cbxTekKulak
            // 
            this.cbxTekKulak.AutoSize = true;
            this.cbxTekKulak.Location = new System.Drawing.Point(139, 78);
            this.cbxTekKulak.Name = "cbxTekKulak";
            this.cbxTekKulak.Size = new System.Drawing.Size(75, 17);
            this.cbxTekKulak.TabIndex = 3;
            this.cbxTekKulak.Text = "Tek Kulak";
            this.cbxTekKulak.UseVisualStyleBackColor = true;
            // 
            // KulaklikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 462);
            this.Controls.Add(this.gbxStil);
            this.Controls.Add(this.rbtKablolu);
            this.Controls.Add(this.rbtBluetooth);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.Sayfa);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.lbxYazdir);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.Yazar);
            this.Controls.Add(this.label1);
            this.Name = "KulaklikForm";
            this.Text = "KulaklikFormcs";
            this.Load += new System.EventHandler(this.KulaklikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.gbxStil.ResumeLayout(false);
            this.gbxStil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtKablolu;
        private System.Windows.Forms.RadioButton rbtBluetooth;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label Sayfa;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.ListBox lbxYazdir;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxStil;
        private System.Windows.Forms.CheckBox cbxTekKulak;
        private System.Windows.Forms.CheckBox cbxHeadphone;
        private System.Windows.Forms.CheckBox cbxMikrofonlu;
        private System.Windows.Forms.CheckBox cbxKulakici;
    }
}