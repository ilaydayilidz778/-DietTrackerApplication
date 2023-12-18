namespace EFDiyetUygulamasi.PL
{
    partial class AnaForm
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
            menuStrip1 = new MenuStrip();
            profilToolStripMenuItem = new ToolStripMenuItem();
            profilimToolStripMenuItem = new ToolStripMenuItem();
            cikisYapToolStripMenuItem = new ToolStripMenuItem();
            öğünToolStripMenuItem = new ToolStripMenuItem();
            ogunEkleToolStripMenuItem = new ToolStripMenuItem();
            ogunlerimToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            ogunlerRaporToolStripMenuItem = new ToolStripMenuItem();
            kiyasRaporToolStripMenuItem = new ToolStripMenuItem();
            grafikRaporuToolStripMenuItem = new ToolStripMenuItem();
            yemekÇeşidiRaporuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.LightGray;
            menuStrip1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { profilToolStripMenuItem, öğünToolStripMenuItem, raporlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 1, 0, 1);
            menuStrip1.Size = new Size(1639, 34);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { profilimToolStripMenuItem, cikisYapToolStripMenuItem });
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(78, 32);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // profilimToolStripMenuItem
            // 
            profilimToolStripMenuItem.Name = "profilimToolStripMenuItem";
            profilimToolStripMenuItem.Size = new Size(197, 36);
            profilimToolStripMenuItem.Text = "Profilim";
            profilimToolStripMenuItem.Click += profilimToolStripMenuItem_Click;
            // 
            // cikisYapToolStripMenuItem
            // 
            cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            cikisYapToolStripMenuItem.Size = new Size(197, 36);
            cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            cikisYapToolStripMenuItem.Click += cikisYapToolStripMenuItem_Click;
            // 
            // öğünToolStripMenuItem
            // 
            öğünToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogunEkleToolStripMenuItem, ogunlerimToolStripMenuItem });
            öğünToolStripMenuItem.Name = "öğünToolStripMenuItem";
            öğünToolStripMenuItem.Size = new Size(78, 32);
            öğünToolStripMenuItem.Text = "Öğün";
            // 
            // ogunEkleToolStripMenuItem
            // 
            ogunEkleToolStripMenuItem.Name = "ogunEkleToolStripMenuItem";
            ogunEkleToolStripMenuItem.Size = new Size(212, 36);
            ogunEkleToolStripMenuItem.Text = "Öğün Ekle";
            ogunEkleToolStripMenuItem.Click += ogunEkleToolStripMenuItem_Click;
            // 
            // ogunlerimToolStripMenuItem
            // 
            ogunlerimToolStripMenuItem.Name = "ogunlerimToolStripMenuItem";
            ogunlerimToolStripMenuItem.Size = new Size(212, 36);
            ogunlerimToolStripMenuItem.Text = "Öğünlerim";
            ogunlerimToolStripMenuItem.Click += ogunlerimToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ogunlerRaporToolStripMenuItem, kiyasRaporToolStripMenuItem, grafikRaporuToolStripMenuItem, yemekÇeşidiRaporuToolStripMenuItem });
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(106, 32);
            raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // ogunlerRaporToolStripMenuItem
            // 
            ogunlerRaporToolStripMenuItem.Name = "ogunlerRaporToolStripMenuItem";
            ogunlerRaporToolStripMenuItem.Size = new Size(304, 36);
            ogunlerRaporToolStripMenuItem.Text = "Öğünler Raporu";
            ogunlerRaporToolStripMenuItem.Click += ogunlerRaporToolStripMenuItem_Click;
            // 
            // kiyasRaporToolStripMenuItem
            // 
            kiyasRaporToolStripMenuItem.Name = "kiyasRaporToolStripMenuItem";
            kiyasRaporToolStripMenuItem.Size = new Size(304, 36);
            kiyasRaporToolStripMenuItem.Text = "Kıyas Raporu";
            kiyasRaporToolStripMenuItem.Click += kiyasRaporToolStripMenuItem_Click;
            // 
            // grafikRaporuToolStripMenuItem
            // 
            grafikRaporuToolStripMenuItem.Name = "grafikRaporuToolStripMenuItem";
            grafikRaporuToolStripMenuItem.Size = new Size(304, 36);
            grafikRaporuToolStripMenuItem.Text = "Grafik Raporu";
            grafikRaporuToolStripMenuItem.Click += grafikRaporuToolStripMenuItem_Click;
            // 
            // yemekÇeşidiRaporuToolStripMenuItem
            // 
            yemekÇeşidiRaporuToolStripMenuItem.Name = "yemekÇeşidiRaporuToolStripMenuItem";
            yemekÇeşidiRaporuToolStripMenuItem.Size = new Size(304, 36);
            yemekÇeşidiRaporuToolStripMenuItem.Text = "Yemek Çeşidi Raporu";
            yemekÇeşidiRaporuToolStripMenuItem.Click += yemekÇeşidiRaporuToolStripMenuItem_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 4, 2, 4);
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart Dine Tracker'a Hoşgeldiniz!";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğünToolStripMenuItem;
        private ToolStripMenuItem ogunEkleToolStripMenuItem;
        private ToolStripMenuItem ogunlerimToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem profilimToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem ogunlerRaporToolStripMenuItem;
        private ToolStripMenuItem kiyasRaporToolStripMenuItem;
        private ToolStripMenuItem grafikRaporuToolStripMenuItem;
        private ToolStripMenuItem yemekÇeşidiRaporuToolStripMenuItem;
    }
}