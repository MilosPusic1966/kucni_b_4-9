﻿
namespace kucni_b_4_9
{
    partial class Glavna
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
            this.sifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novcaniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.troskoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oRGoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prometToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prometToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifarniciToolStripMenuItem,
            this.prometToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sifarniciToolStripMenuItem
            // 
            this.sifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem,
            this.novcaniciToolStripMenuItem,
            this.troskoviToolStripMenuItem,
            this.oRGoviToolStripMenuItem,
            this.firmeToolStripMenuItem});
            this.sifarniciToolStripMenuItem.Name = "sifarniciToolStripMenuItem";
            this.sifarniciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sifarniciToolStripMenuItem.Text = "Sifarnici";
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.osobaToolStripMenuItem.Text = "Osobe";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // novcaniciToolStripMenuItem
            // 
            this.novcaniciToolStripMenuItem.Name = "novcaniciToolStripMenuItem";
            this.novcaniciToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novcaniciToolStripMenuItem.Text = "Novcanici";
            this.novcaniciToolStripMenuItem.Click += new System.EventHandler(this.novcaniciToolStripMenuItem_Click);
            // 
            // troskoviToolStripMenuItem
            // 
            this.troskoviToolStripMenuItem.Name = "troskoviToolStripMenuItem";
            this.troskoviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.troskoviToolStripMenuItem.Text = "Troskovi";
            this.troskoviToolStripMenuItem.Click += new System.EventHandler(this.troskoviToolStripMenuItem_Click);
            // 
            // oRGoviToolStripMenuItem
            // 
            this.oRGoviToolStripMenuItem.Name = "oRGoviToolStripMenuItem";
            this.oRGoviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oRGoviToolStripMenuItem.Text = "ORG-ovi";
            this.oRGoviToolStripMenuItem.Click += new System.EventHandler(this.oRGoviToolStripMenuItem_Click);
            // 
            // firmeToolStripMenuItem
            // 
            this.firmeToolStripMenuItem.Name = "firmeToolStripMenuItem";
            this.firmeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmeToolStripMenuItem.Text = "Firme";
            this.firmeToolStripMenuItem.Click += new System.EventHandler(this.firmeToolStripMenuItem_Click);
            // 
            // prometToolStripMenuItem
            // 
            this.prometToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prometToolStripMenuItem1});
            this.prometToolStripMenuItem.Name = "prometToolStripMenuItem";
            this.prometToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.prometToolStripMenuItem.Text = "Promet";
            // 
            // prometToolStripMenuItem1
            // 
            this.prometToolStripMenuItem1.Name = "prometToolStripMenuItem1";
            this.prometToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.prometToolStripMenuItem1.Text = "Promet";
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novcaniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem troskoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oRGoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prometToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prometToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
    }
}

