
namespace WFA_NesneÖdev
{
    partial class KoltukForm
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
            this.rbtUclu = new System.Windows.Forms.RadioButton();
            this.rbtKose = new System.Windows.Forms.RadioButton();
            this.Sayfa = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbxYazdir = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOlculer = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtTekli = new System.Windows.Forms.RadioButton();
            this.rbtİkili = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtCeviz = new System.Windows.Forms.RadioButton();
            this.rbtMese = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtElyaf = new System.Windows.Forms.RadioButton();
            this.rbtParcaElyaf = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOlculer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtUclu
            // 
            this.rbtUclu.AutoSize = true;
            this.rbtUclu.Location = new System.Drawing.Point(129, 19);
            this.rbtUclu.Name = "rbtUclu";
            this.rbtUclu.Size = new System.Drawing.Size(80, 17);
            this.rbtUclu.TabIndex = 83;
            this.rbtUclu.TabStop = true;
            this.rbtUclu.Text = "Üçlü Koltuk";
            this.rbtUclu.UseVisualStyleBackColor = true;
            // 
            // rbtKose
            // 
            this.rbtKose.AutoSize = true;
            this.rbtKose.Location = new System.Drawing.Point(6, 19);
            this.rbtKose.Name = "rbtKose";
            this.rbtKose.Size = new System.Drawing.Size(82, 17);
            this.rbtKose.TabIndex = 82;
            this.rbtKose.TabStop = true;
            this.rbtKose.Text = "Köşe Koltuk";
            this.rbtKose.UseVisualStyleBackColor = true;
            // 
            // Sayfa
            // 
            this.Sayfa.AutoSize = true;
            this.Sayfa.Location = new System.Drawing.Point(66, 128);
            this.Sayfa.Name = "Sayfa";
            this.Sayfa.Size = new System.Drawing.Size(29, 13);
            this.Sayfa.TabIndex = 81;
            this.Sayfa.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(140, 126);
            this.nudFiyat.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 80;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(140, 58);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 79;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(140, 91);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 78;
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(66, 61);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(37, 13);
            this.Yazar.TabIndex = 77;
            this.Yazar.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "Renk";
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(117, 421);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(90, 32);
            this.btnAktar.TabIndex = 85;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbxYazdir
            // 
            this.lbxYazdir.FormattingEnabled = true;
            this.lbxYazdir.Location = new System.Drawing.Point(332, 58);
            this.lbxYazdir.Name = "lbxYazdir";
            this.lbxYazdir.Size = new System.Drawing.Size(675, 381);
            this.lbxYazdir.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 91;
            this.label2.Text = "Ölçüler";
            // 
            // nudOlculer
            // 
            this.nudOlculer.Location = new System.Drawing.Point(140, 162);
            this.nudOlculer.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudOlculer.Name = "nudOlculer";
            this.nudOlculer.Size = new System.Drawing.Size(120, 20);
            this.nudOlculer.TabIndex = 90;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtTekli);
            this.groupBox1.Controls.Add(this.rbtİkili);
            this.groupBox1.Controls.Add(this.rbtUclu);
            this.groupBox1.Controls.Add(this.rbtKose);
            this.groupBox1.Location = new System.Drawing.Point(69, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 84);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stil Seçimi";
            // 
            // rbtTekli
            // 
            this.rbtTekli.AutoSize = true;
            this.rbtTekli.Location = new System.Drawing.Point(129, 61);
            this.rbtTekli.Name = "rbtTekli";
            this.rbtTekli.Size = new System.Drawing.Size(81, 17);
            this.rbtTekli.TabIndex = 85;
            this.rbtTekli.TabStop = true;
            this.rbtTekli.Text = "Tekli Koltuk";
            this.rbtTekli.UseVisualStyleBackColor = true;
            // 
            // rbtİkili
            // 
            this.rbtİkili.AutoSize = true;
            this.rbtİkili.Location = new System.Drawing.Point(6, 61);
            this.rbtİkili.Name = "rbtİkili";
            this.rbtİkili.Size = new System.Drawing.Size(73, 17);
            this.rbtİkili.TabIndex = 84;
            this.rbtİkili.TabStop = true;
            this.rbtİkili.Text = "İkili Koltuk";
            this.rbtİkili.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtCeviz);
            this.groupBox2.Controls.Add(this.rbtMese);
            this.groupBox2.Location = new System.Drawing.Point(69, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 59);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Koltuk Ayağı Seçimi";
            // 
            // rbtCeviz
            // 
            this.rbtCeviz.AutoSize = true;
            this.rbtCeviz.Location = new System.Drawing.Point(129, 19);
            this.rbtCeviz.Name = "rbtCeviz";
            this.rbtCeviz.Size = new System.Drawing.Size(51, 17);
            this.rbtCeviz.TabIndex = 83;
            this.rbtCeviz.TabStop = true;
            this.rbtCeviz.Text = "Ceviz";
            this.rbtCeviz.UseVisualStyleBackColor = true;
            // 
            // rbtMese
            // 
            this.rbtMese.AutoSize = true;
            this.rbtMese.Location = new System.Drawing.Point(6, 19);
            this.rbtMese.Name = "rbtMese";
            this.rbtMese.Size = new System.Drawing.Size(51, 17);
            this.rbtMese.TabIndex = 82;
            this.rbtMese.TabStop = true;
            this.rbtMese.Text = "Meşe";
            this.rbtMese.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtElyaf);
            this.groupBox3.Controls.Add(this.rbtParcaElyaf);
            this.groupBox3.Location = new System.Drawing.Point(69, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 60);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dolgu Tipi";
            // 
            // rbtElyaf
            // 
            this.rbtElyaf.AutoSize = true;
            this.rbtElyaf.Location = new System.Drawing.Point(129, 19);
            this.rbtElyaf.Name = "rbtElyaf";
            this.rbtElyaf.Size = new System.Drawing.Size(79, 17);
            this.rbtElyaf.TabIndex = 83;
            this.rbtElyaf.TabStop = true;
            this.rbtElyaf.Text = "Bütün Elyaf";
            this.rbtElyaf.UseVisualStyleBackColor = true;
            // 
            // rbtParcaElyaf
            // 
            this.rbtParcaElyaf.AutoSize = true;
            this.rbtParcaElyaf.Location = new System.Drawing.Point(6, 19);
            this.rbtParcaElyaf.Name = "rbtParcaElyaf";
            this.rbtParcaElyaf.Size = new System.Drawing.Size(79, 17);
            this.rbtParcaElyaf.TabIndex = 82;
            this.rbtParcaElyaf.TabStop = true;
            this.rbtParcaElyaf.Text = "Parça Elyaf";
            this.rbtParcaElyaf.UseVisualStyleBackColor = true;
            // 
            // KoltukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudOlculer);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lbxYazdir);
            this.Controls.Add(this.Sayfa);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.Yazar);
            this.Controls.Add(this.label1);
            this.Name = "KoltukForm";
            this.Text = "KoltukForm";
            this.Load += new System.EventHandler(this.KoltukForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOlculer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtUclu;
        private System.Windows.Forms.RadioButton rbtKose;
        private System.Windows.Forms.Label Sayfa;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbxYazdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOlculer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtCeviz;
        private System.Windows.Forms.RadioButton rbtMese;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtElyaf;
        private System.Windows.Forms.RadioButton rbtParcaElyaf;
        private System.Windows.Forms.RadioButton rbtTekli;
        private System.Windows.Forms.RadioButton rbtİkili;
    }
}