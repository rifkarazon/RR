
namespace WFA_NesneÖdev
{
    partial class KitapForum
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
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Yazar = new System.Windows.Forms.Label();
            this.txtİsim = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.lbxYazdir = new System.Windows.Forms.ListBox();
            this.rbtSert = new System.Windows.Forms.RadioButton();
            this.rbtKagit = new System.Windows.Forms.RadioButton();
            this.txtYayimci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSayfa = new System.Windows.Forms.NumericUpDown();
            this.Sayfa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAktar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(86, 216);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap İsmi";
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(26, 129);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(34, 13);
            this.Yazar.TabIndex = 2;
            this.Yazar.Text = "Yazar";
            // 
            // txtİsim
            // 
            this.txtİsim.Location = new System.Drawing.Point(86, 100);
            this.txtİsim.Name = "txtİsim";
            this.txtİsim.Size = new System.Drawing.Size(100, 20);
            this.txtİsim.TabIndex = 3;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(86, 126);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(100, 20);
            this.txtYazar.TabIndex = 4;
            // 
            // lbxYazdir
            // 
            this.lbxYazdir.FormattingEnabled = true;
            this.lbxYazdir.Location = new System.Drawing.Point(307, 34);
            this.lbxYazdir.Name = "lbxYazdir";
            this.lbxYazdir.Size = new System.Drawing.Size(539, 446);
            this.lbxYazdir.TabIndex = 5;
            // 
            // rbtSert
            // 
            this.rbtSert.AutoSize = true;
            this.rbtSert.Location = new System.Drawing.Point(12, 271);
            this.rbtSert.Name = "rbtSert";
            this.rbtSert.Size = new System.Drawing.Size(78, 17);
            this.rbtSert.TabIndex = 6;
            this.rbtSert.TabStop = true;
            this.rbtSert.Text = "Sert Kapak";
            this.rbtSert.UseVisualStyleBackColor = true;
            // 
            // rbtKagit
            // 
            this.rbtKagit.AutoSize = true;
            this.rbtKagit.Location = new System.Drawing.Point(123, 271);
            this.rbtKagit.Name = "rbtKagit";
            this.rbtKagit.Size = new System.Drawing.Size(83, 17);
            this.rbtKagit.TabIndex = 7;
            this.rbtKagit.TabStop = true;
            this.rbtKagit.Text = "Kağıt Kapak";
            this.rbtKagit.UseVisualStyleBackColor = true;
            // 
            // txtYayimci
            // 
            this.txtYayimci.Location = new System.Drawing.Point(86, 157);
            this.txtYayimci.Name = "txtYayimci";
            this.txtYayimci.Size = new System.Drawing.Size(100, 20);
            this.txtYayimci.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yayımcı";
            // 
            // nudSayfa
            // 
            this.nudSayfa.Location = new System.Drawing.Point(86, 190);
            this.nudSayfa.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSayfa.Name = "nudSayfa";
            this.nudSayfa.Size = new System.Drawing.Size(120, 20);
            this.nudSayfa.TabIndex = 10;
            // 
            // Sayfa
            // 
            this.Sayfa.AutoSize = true;
            this.Sayfa.Location = new System.Drawing.Point(29, 196);
            this.Sayfa.Name = "Sayfa";
            this.Sayfa.Size = new System.Drawing.Size(34, 13);
            this.Sayfa.TabIndex = 11;
            this.Sayfa.Text = "Sayfa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fiyat";
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(86, 321);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(90, 34);
            this.btnAktar.TabIndex = 13;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // KitapForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 511);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sayfa);
            this.Controls.Add(this.nudSayfa);
            this.Controls.Add(this.txtYayimci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtKagit);
            this.Controls.Add(this.rbtSert);
            this.Controls.Add(this.lbxYazdir);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtİsim);
            this.Controls.Add(this.Yazar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFiyat);
            this.Name = "KitapForum";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.TextBox txtİsim;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.ListBox lbxYazdir;
        private System.Windows.Forms.RadioButton rbtSert;
        private System.Windows.Forms.RadioButton rbtKagit;
        private System.Windows.Forms.TextBox txtYayimci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSayfa;
        private System.Windows.Forms.Label Sayfa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAktar;
    }
}

