namespace EFDiyetUygulamasi.PL
{
    partial class YoneticiKategoriForm
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
            dgvKategoriler = new DataGridView();
            label1 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            btnSil = new Button();
            pictureBox1 = new PictureBox();
            pbKategori = new PictureBox();
            btnGuncelle = new Button();
            btnEkle = new Button();
            label3 = new Label();
            btnResimEkle = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKategori).BeginInit();
            SuspendLayout();
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.AllowUserToAddRows = false;
            dgvKategoriler.AllowUserToDeleteRows = false;
            dgvKategoriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategoriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategoriler.Location = new Point(448, 76);
            dgvKategoriler.MultiSelect = false;
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.ReadOnly = true;
            dgvKategoriler.RowHeadersWidth = 62;
            dgvKategoriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriler.Size = new Size(645, 848);
            dgvKategoriler.TabIndex = 0;
            dgvKategoriler.RowHeaderMouseClick += dgvKategoriler_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(448, 21);
            label1.Name = "label1";
            label1.Size = new Size(645, 38);
            label1.TabIndex = 1;
            label1.Text = "Kategoriler";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(25, 130);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(371, 31);
            txtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(25, 93);
            label2.Name = "label2";
            label2.Size = new Size(371, 29);
            label2.TabIndex = 3;
            label2.Text = "Ad";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightGray;
            btnSil.Location = new Point(25, 856);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(371, 38);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.YoneticiKategoriForm1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pbKategori
            // 
            pbKategori.Location = new Point(25, 238);
            pbKategori.Name = "pbKategori";
            pbKategori.Size = new Size(371, 360);
            pbKategori.SizeMode = PictureBoxSizeMode.Zoom;
            pbKategori.TabIndex = 8;
            pbKategori.TabStop = false;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightGray;
            btnGuncelle.Location = new Point(25, 798);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(371, 42);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightGray;
            btnEkle.Location = new Point(25, 736);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(371, 42);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(25, 190);
            label3.Name = "label3";
            label3.Size = new Size(371, 34);
            label3.TabIndex = 9;
            label3.Text = "Kategori Görseli";
            // 
            // btnResimEkle
            // 
            btnResimEkle.BackColor = Color.LightGray;
            btnResimEkle.Location = new Point(25, 615);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(371, 42);
            btnResimEkle.TabIndex = 10;
            btnResimEkle.Text = "Resim Ekle\r\n";
            btnResimEkle.UseVisualStyleBackColor = false;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // YoneticiKategoriForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(btnResimEkle);
            Controls.Add(label3);
            Controls.Add(pbKategori);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(dgvKategoriler);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1661, 999);
            Name = "YoneticiKategoriForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yonetici Kategori Form";
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKategori).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKategoriler;
        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private Button btnSil;
        private PictureBox pictureBox1;
        private PictureBox pbKategori;
        private Button btnGuncelle;
        private Button btnEkle;
        private Label label3;
        private Button btnResimEkle;
        private OpenFileDialog openFileDialog1;
    }
}