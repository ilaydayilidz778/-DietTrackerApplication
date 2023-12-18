namespace EFDiyetUygulamasi.PL
{
    partial class YoneticiForm
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
            btnKullanici = new Button();
            btnBesin = new Button();
            btnRapor = new Button();
            btnKategori = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKullanici
            // 
            btnKullanici.BackColor = Color.Gold;
            btnKullanici.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnKullanici.Location = new Point(38, 116);
            btnKullanici.Margin = new Padding(4, 5, 4, 5);
            btnKullanici.Name = "btnKullanici";
            btnKullanici.Size = new Size(471, 89);
            btnKullanici.TabIndex = 0;
            btnKullanici.Text = "Kullanıcı Ekranı";
            btnKullanici.UseVisualStyleBackColor = false;
            btnKullanici.Click += btnKullanici_Click;
            // 
            // btnBesin
            // 
            btnBesin.BackColor = Color.Gold;
            btnBesin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnBesin.ForeColor = SystemColors.ActiveCaptionText;
            btnBesin.Location = new Point(38, 311);
            btnBesin.Margin = new Padding(4, 5, 4, 5);
            btnBesin.Name = "btnBesin";
            btnBesin.Size = new Size(471, 89);
            btnBesin.TabIndex = 1;
            btnBesin.Text = "Besin Ekranı";
            btnBesin.UseVisualStyleBackColor = false;
            btnBesin.Click += btnBesin_Click;
            // 
            // btnRapor
            // 
            btnRapor.BackColor = Color.Gold;
            btnRapor.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnRapor.Location = new Point(38, 708);
            btnRapor.Margin = new Padding(4, 5, 4, 5);
            btnRapor.Name = "btnRapor";
            btnRapor.Size = new Size(471, 89);
            btnRapor.TabIndex = 2;
            btnRapor.Text = "Rapor Ekranı";
            btnRapor.UseVisualStyleBackColor = false;
            btnRapor.Click += btnRapor_Click;
            // 
            // btnKategori
            // 
            btnKategori.BackColor = Color.Gold;
            btnKategori.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            btnKategori.Location = new Point(38, 502);
            btnKategori.Margin = new Padding(4, 5, 4, 5);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(471, 89);
            btnKategori.TabIndex = 3;
            btnKategori.Text = "Kategori Ekranı";
            btnKategori.UseVisualStyleBackColor = false;
            btnKategori.Click += btnKategori_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.YoneticiForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(1403, 959);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1403, 959);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // YoneticiForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 959);
            Controls.Add(btnKategori);
            Controls.Add(btnRapor);
            Controls.Add(btnBesin);
            Controls.Add(btnKullanici);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1425, 1015);
            Name = "YoneticiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici Ana Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKullanici;
        private Button btnBesin;
        private Button btnRapor;
        private Button btnKategori;
        private PictureBox pictureBox1;
    }
}