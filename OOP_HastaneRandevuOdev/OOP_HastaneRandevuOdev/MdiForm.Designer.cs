
namespace OOP_HastaneRandevuOdev
{
    partial class MdiForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevuOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yönetimPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.branşToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuOluşturToolStripMenuItem,
            this.yönetimPanelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevuOluşturToolStripMenuItem
            // 
            this.randevuOluşturToolStripMenuItem.Name = "randevuOluşturToolStripMenuItem";
            this.randevuOluşturToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.randevuOluşturToolStripMenuItem.Text = "Randevu Oluştur";
            this.randevuOluşturToolStripMenuItem.Click += new System.EventHandler(this.randevuOluşturToolStripMenuItem_Click);
            // 
            // yönetimPanelToolStripMenuItem
            // 
            this.yönetimPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.branşToolStripMenuItem,
            this.doktorToolStripMenuItem,
            this.randevuToolStripMenuItem});
            this.yönetimPanelToolStripMenuItem.Name = "yönetimPanelToolStripMenuItem";
            this.yönetimPanelToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.yönetimPanelToolStripMenuItem.Text = "Yönetim Panel";
            // 
            // branşToolStripMenuItem
            // 
            this.branşToolStripMenuItem.Name = "branşToolStripMenuItem";
            this.branşToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.branşToolStripMenuItem.Text = "Branş";
            this.branşToolStripMenuItem.Click += new System.EventHandler(this.branşToolStripMenuItem_Click);
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Enabled = false;
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.Enabled = false;
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randevuToolStripMenuItem.Text = "Randevu";
            this.randevuToolStripMenuItem.Click += new System.EventHandler(this.randevuToolStripMenuItem_Click);
            // 
            // MdiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiForm";
            this.Text = "MdiForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yönetimPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem branşToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
    }
}