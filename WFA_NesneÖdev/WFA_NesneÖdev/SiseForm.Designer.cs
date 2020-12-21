
namespace WFA_NesneÖdev
{
    partial class SiseForm
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
            this.rbtSaydam = new System.Windows.Forms.RadioButton();
            this.rbtOpak = new System.Windows.Forms.RadioButton();
            this.btnAktar = new System.Windows.Forms.Button();
            this.Sayfa = new System.Windows.Forms.Label();
            this.nudHacim = new System.Windows.Forms.NumericUpDown();
            this.lbxYazdir = new System.Windows.Forms.ListBox();
            this.txtMadde = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.Yazar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtSikistirma = new System.Windows.Forms.RadioButton();
            this.rbtCevirmeli = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudHacim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtSaydam
            // 
            this.rbtSaydam.AutoSize = true;
            this.rbtSaydam.Location = new System.Drawing.Point(105, 34);
            this.rbtSaydam.Name = "rbtSaydam";
            this.rbtSaydam.Size = new System.Drawing.Size(63, 17);
            this.rbtSaydam.TabIndex = 59;
            this.rbtSaydam.TabStop = true;
            this.rbtSaydam.Text = "Saydam";
            this.rbtSaydam.UseVisualStyleBackColor = true;
            // 
            // rbtOpak
            // 
            this.rbtOpak.AutoSize = true;
            this.rbtOpak.Location = new System.Drawing.Point(6, 34);
            this.rbtOpak.Name = "rbtOpak";
            this.rbtOpak.Size = new System.Drawing.Size(51, 17);
            this.rbtOpak.TabIndex = 58;
            this.rbtOpak.TabStop = true;
            this.rbtOpak.Text = "Opak";
            this.rbtOpak.UseVisualStyleBackColor = true;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(154, 312);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(90, 34);
            this.btnAktar.TabIndex = 55;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // Sayfa
            // 
            this.Sayfa.AutoSize = true;
            this.Sayfa.Location = new System.Drawing.Point(138, 128);
            this.Sayfa.Name = "Sayfa";
            this.Sayfa.Size = new System.Drawing.Size(37, 13);
            this.Sayfa.TabIndex = 53;
            this.Sayfa.Text = "Hacim";
            // 
            // nudHacim
            // 
            this.nudHacim.Location = new System.Drawing.Point(212, 126);
            this.nudHacim.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudHacim.Name = "nudHacim";
            this.nudHacim.Size = new System.Drawing.Size(120, 20);
            this.nudHacim.TabIndex = 52;
            // 
            // lbxYazdir
            // 
            this.lbxYazdir.FormattingEnabled = true;
            this.lbxYazdir.Location = new System.Drawing.Point(406, 12);
            this.lbxYazdir.Name = "lbxYazdir";
            this.lbxYazdir.Size = new System.Drawing.Size(672, 316);
            this.lbxYazdir.TabIndex = 51;
            // 
            // txtMadde
            // 
            this.txtMadde.Location = new System.Drawing.Point(212, 86);
            this.txtMadde.Name = "txtMadde";
            this.txtMadde.Size = new System.Drawing.Size(100, 20);
            this.txtMadde.TabIndex = 50;
            // 
            // txtRenk
            // 
            this.txtRenk.Location = new System.Drawing.Point(212, 60);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(100, 20);
            this.txtRenk.TabIndex = 49;
            // 
            // Yazar
            // 
            this.Yazar.AutoSize = true;
            this.Yazar.Location = new System.Drawing.Point(138, 89);
            this.Yazar.Name = "Yazar";
            this.Yazar.Size = new System.Drawing.Size(61, 13);
            this.Yazar.TabIndex = 48;
            this.Yazar.Text = "Hammadde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Renk";
            // 
            // rbtSikistirma
            // 
            this.rbtSikistirma.AutoSize = true;
            this.rbtSikistirma.Location = new System.Drawing.Point(225, 163);
            this.rbtSikistirma.Name = "rbtSikistirma";
            this.rbtSikistirma.Size = new System.Drawing.Size(73, 17);
            this.rbtSikistirma.TabIndex = 63;
            this.rbtSikistirma.TabStop = true;
            this.rbtSikistirma.Text = "Sıkıştırmalı";
            this.rbtSikistirma.UseVisualStyleBackColor = true;
            // 
            // rbtCevirmeli
            // 
            this.rbtCevirmeli.AutoSize = true;
            this.rbtCevirmeli.Location = new System.Drawing.Point(112, 163);
            this.rbtCevirmeli.Name = "rbtCevirmeli";
            this.rbtCevirmeli.Size = new System.Drawing.Size(67, 17);
            this.rbtCevirmeli.TabIndex = 62;
            this.rbtCevirmeli.TabStop = true;
            this.rbtCevirmeli.Text = "Çevirmeli";
            this.rbtCevirmeli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtOpak);
            this.groupBox1.Controls.Add(this.rbtSaydam);
            this.groupBox1.Location = new System.Drawing.Point(112, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 68);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şişe Şekli";
            // 
            // SiseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 508);
            this.Controls.Add(this.rbtCevirmeli);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbtSikistirma);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.Sayfa);
            this.Controls.Add(this.nudHacim);
            this.Controls.Add(this.lbxYazdir);
            this.Controls.Add(this.txtMadde);
            this.Controls.Add(this.txtRenk);
            this.Controls.Add(this.Yazar);
            this.Controls.Add(this.label1);
            this.Name = "SiseForm";
            this.Text = "SiseForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudHacim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtSaydam;
        private System.Windows.Forms.RadioButton rbtOpak;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Label Sayfa;
        private System.Windows.Forms.NumericUpDown nudHacim;
        private System.Windows.Forms.ListBox lbxYazdir;
        private System.Windows.Forms.TextBox txtMadde;
        private System.Windows.Forms.TextBox txtRenk;
        private System.Windows.Forms.Label Yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtSikistirma;
        private System.Windows.Forms.RadioButton rbtCevirmeli;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}