
namespace WFA_NesneÖdev
{
    partial class YuzukForm
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
            this.rbtBeyazAltin = new System.Windows.Forms.RadioButton();
            this.rbtAltin = new System.Windows.Forms.RadioButton();
            this.btnAktar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Sayfa = new System.Windows.Forms.Label();
            this.nudOlcu = new System.Windows.Forms.NumericUpDown();
            this.lbxYazdir = new System.Windows.Forms.ListBox();
            this.txtIsleme = new System.Windows.Forms.TextBox();
            this.txtTas = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudKarat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudOlcu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtBeyazAltin
            // 
            this.rbtBeyazAltin.AutoSize = true;
            this.rbtBeyazAltin.Location = new System.Drawing.Point(178, 280);
            this.rbtBeyazAltin.Name = "rbtBeyazAltin";
            this.rbtBeyazAltin.Size = new System.Drawing.Size(77, 17);
            this.rbtBeyazAltin.TabIndex = 59;
            this.rbtBeyazAltin.TabStop = true;
            this.rbtBeyazAltin.Text = "Beyaz Altın";
            this.rbtBeyazAltin.UseVisualStyleBackColor = true;
            // 
            // rbtAltin
            // 
            this.rbtAltin.AutoSize = true;
            this.rbtAltin.Location = new System.Drawing.Point(72, 280);
            this.rbtAltin.Name = "rbtAltin";
            this.rbtAltin.Size = new System.Drawing.Size(45, 17);
            this.rbtAltin.TabIndex = 58;
            this.rbtAltin.TabStop = true;
            this.rbtAltin.Text = "Altın";
            this.rbtAltin.UseVisualStyleBackColor = true;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(117, 330);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(90, 34);
            this.btnAktar.TabIndex = 55;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Karat";
            // 
            // Sayfa
            // 
            this.Sayfa.AutoSize = true;
            this.Sayfa.Location = new System.Drawing.Point(69, 176);
            this.Sayfa.Name = "Sayfa";
            this.Sayfa.Size = new System.Drawing.Size(29, 13);
            this.Sayfa.TabIndex = 53;
            this.Sayfa.Text = "Ölçü";
            // 
            // nudOlcu
            // 
            this.nudOlcu.Location = new System.Drawing.Point(143, 174);
            this.nudOlcu.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudOlcu.Name = "nudOlcu";
            this.nudOlcu.Size = new System.Drawing.Size(120, 20);
            this.nudOlcu.TabIndex = 52;
            // 
            // lbxYazdir
            // 
            this.lbxYazdir.FormattingEnabled = true;
            this.lbxYazdir.Location = new System.Drawing.Point(337, 27);
            this.lbxYazdir.Name = "lbxYazdir";
            this.lbxYazdir.Size = new System.Drawing.Size(504, 446);
            this.lbxYazdir.TabIndex = 51;
            // 
            // txtIsleme
            // 
            this.txtIsleme.Location = new System.Drawing.Point(143, 78);
            this.txtIsleme.Name = "txtIsleme";
            this.txtIsleme.Size = new System.Drawing.Size(100, 20);
            this.txtIsleme.TabIndex = 50;
            // 
            // txtTas
            // 
            this.txtTas.Location = new System.Drawing.Point(143, 104);
            this.txtTas.Name = "txtTas";
            this.txtTas.Size = new System.Drawing.Size(100, 20);
            this.txtTas.TabIndex = 49;
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(31, 78);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(106, 13);
            this.Yazar.TabIndex = 48;
            this.Yazar.Text = "İşleme yapılacak yazı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Taş";
            // 
            // nudKarat
            // 
            this.nudKarat.Location = new System.Drawing.Point(143, 200);
            this.nudKarat.Name = "nudKarat";
            this.nudKarat.Size = new System.Drawing.Size(120, 20);
            this.nudKarat.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Fiyat";
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(143, 226);
            this.nudFiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 20);
            this.nudFiyat.TabIndex = 60;
            // 
            // YuzukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 569);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.rbtBeyazAltin);
            this.Controls.Add(this.rbtAltin);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sayfa);
            this.Controls.Add(this.nudOlcu);
            this.Controls.Add(this.lbxYazdir);
            this.Controls.Add(this.txtIsleme);
            this.Controls.Add(this.txtTas);
            this.Controls.Add(this.Yazar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudKarat);
            this.Name = "YuzukForm";
            this.Text = "YuzukForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudOlcu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKarat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtBeyazAltin;
        private System.Windows.Forms.RadioButton rbtAltin;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Sayfa;
        private System.Windows.Forms.NumericUpDown nudOlcu;
        private System.Windows.Forms.ListBox lbxYazdir;
        private System.Windows.Forms.TextBox txtIsleme;
        private System.Windows.Forms.TextBox txtTas;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudKarat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFiyat;
    }
}