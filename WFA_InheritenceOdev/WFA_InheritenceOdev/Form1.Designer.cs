
namespace WFA_InheritenceOdev
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
            this.lstKitap = new System.Windows.Forms.ListBox();
            this.lstMuzik = new System.Windows.Forms.ListBox();
            this.lstElektronik = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstKitap
            // 
            this.lstKitap.FormattingEnabled = true;
            this.lstKitap.Location = new System.Drawing.Point(37, 21);
            this.lstKitap.Name = "lstKitap";
            this.lstKitap.Size = new System.Drawing.Size(273, 394);
            this.lstKitap.TabIndex = 0;
            // 
            // lstMuzik
            // 
            this.lstMuzik.FormattingEnabled = true;
            this.lstMuzik.Location = new System.Drawing.Point(382, 21);
            this.lstMuzik.Name = "lstMuzik";
            this.lstMuzik.Size = new System.Drawing.Size(273, 394);
            this.lstMuzik.TabIndex = 1;
            // 
            // lstElektronik
            // 
            this.lstElektronik.FormattingEnabled = true;
            this.lstElektronik.Location = new System.Drawing.Point(711, 21);
            this.lstElektronik.Name = "lstElektronik";
            this.lstElektronik.Size = new System.Drawing.Size(273, 394);
            this.lstElektronik.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 471);
            this.Controls.Add(this.lstElektronik);
            this.Controls.Add(this.lstMuzik);
            this.Controls.Add(this.lstKitap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstKitap;
        private System.Windows.Forms.ListBox lstMuzik;
        private System.Windows.Forms.ListBox lstElektronik;
    }
}

