
namespace WFA_NesneÖdev
{
    partial class OjeForum
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
            this.btnAktar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Sayfa = new System.Windows.Forms.Label();
            this.nudOjeNumarasi = new System.Windows.Forms.NumericUpDown();
            this.lbxYazdir = new System.Windows.Forms.ListBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudOlcu = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudOjeNumarasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOlcu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(75, 250);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(90, 34);
            this.btnAktar.TabIndex = 27;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Fiyat";
            // 
            // Sayfa
            // 
            this.Sayfa.AutoSize = true;
            this.Sayfa.Location = new System.Drawing.Point(18, 141);
            this.Sayfa.Name = "Sayfa";
            this.Sayfa.Size = new System.Drawing.Size(68, 13);
            this.Sayfa.TabIndex = 25;
            this.Sayfa.Text = "Oje Numaras";
            // 
            // nudOjeNumarasi
            // 
            this.nudOjeNumarasi.Location = new System.Drawing.Point(92, 139);
            this.nudOjeNumarasi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudOjeNumarasi.Name = "nudOjeNumarasi";
            this.nudOjeNumarasi.Size = new System.Drawing.Size(120, 20);
            this.nudOjeNumarasi.TabIndex = 24;
            // 
            // lbxYazdir
            // 
            this.lbxYazdir.FormattingEnabled = true;
            this.lbxYazdir.Location = new System.Drawing.Point(285, 43);
            this.lbxYazdir.Name = "lbxYazdir";
            this.lbxYazdir.Size = new System.Drawing.Size(504, 446);
            this.lbxYazdir.TabIndex = 19;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(92, 100);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 18;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(92, 74);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 17;
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(18, 103);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(37, 13);
            this.Yazar.TabIndex = 16;
            this.Yazar.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Renk";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(92, 165);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ölçü";
            // 
            // nudOlcu
            // 
            this.nudOlcu.Location = new System.Drawing.Point(92, 191);
            this.nudOlcu.Name = "nudOlcu";
            this.nudOlcu.Size = new System.Drawing.Size(120, 20);
            this.nudOlcu.TabIndex = 28;
            // 
            // OjeForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudOlcu);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sayfa);
            this.Controls.Add(this.nudOjeNumarasi);
            this.Controls.Add(this.lbxYazdir);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.Yazar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFiyat);
            this.Name = "OjeForum";
            this.Text = "OjeForum";
         
            ((System.ComponentModel.ISupportInitialize)(this.nudOjeNumarasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOlcu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Sayfa;
        private System.Windows.Forms.NumericUpDown nudOjeNumarasi;
        private System.Windows.Forms.ListBox lbxYazdir;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudOlcu;
    }
}