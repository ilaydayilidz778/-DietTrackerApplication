namespace EFDiyetUygulamasi.PL
{
    partial class YoneticiBesinForm
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
            dgvBesinler = new DataGridView();
            label1 = new Label();
            txtAd = new TextBox();
            label2 = new Label();
            nudKalori = new NumericUpDown();
            nudProtein = new NumericUpDown();
            label3 = new Label();
            nudKarbonhidrat = new NumericUpDown();
            label4 = new Label();
            nudYag = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            cmbKategori = new ComboBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnGeri = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvBesinler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudProtein).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKarbonhidrat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvBesinler
            // 
            dgvBesinler.AllowUserToAddRows = false;
            dgvBesinler.AllowUserToDeleteRows = false;
            dgvBesinler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBesinler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBesinler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBesinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBesinler.Location = new Point(444, 15);
            dgvBesinler.Margin = new Padding(4, 5, 4, 5);
            dgvBesinler.MultiSelect = false;
            dgvBesinler.Name = "dgvBesinler";
            dgvBesinler.ReadOnly = true;
            dgvBesinler.RowHeadersWidth = 62;
            dgvBesinler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBesinler.Size = new Size(727, 914);
            dgvBesinler.TabIndex = 0;
            dgvBesinler.RowHeaderMouseClick += dgvBesinler_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(29, 90);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(363, 25);
            label1.TabIndex = 1;
            label1.Text = "Besin Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(29, 120);
            txtAd.Margin = new Padding(4, 5, 4, 5);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(363, 31);
            txtAd.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(29, 184);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(363, 25);
            label2.TabIndex = 3;
            label2.Text = "Kalori";
            // 
            // nudKalori
            // 
            nudKalori.Location = new Point(29, 214);
            nudKalori.Margin = new Padding(4, 5, 4, 5);
            nudKalori.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudKalori.Name = "nudKalori";
            nudKalori.Size = new Size(363, 31);
            nudKalori.TabIndex = 4;
            nudKalori.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudProtein
            // 
            nudProtein.Location = new Point(29, 318);
            nudProtein.Margin = new Padding(4, 5, 4, 5);
            nudProtein.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudProtein.Name = "nudProtein";
            nudProtein.Size = new Size(363, 31);
            nudProtein.TabIndex = 6;
            nudProtein.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(29, 288);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(363, 25);
            label3.TabIndex = 5;
            label3.Text = "Protein";
            // 
            // nudKarbonhidrat
            // 
            nudKarbonhidrat.Location = new Point(29, 417);
            nudKarbonhidrat.Margin = new Padding(4, 5, 4, 5);
            nudKarbonhidrat.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudKarbonhidrat.Name = "nudKarbonhidrat";
            nudKarbonhidrat.Size = new Size(363, 31);
            nudKarbonhidrat.TabIndex = 8;
            nudKarbonhidrat.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.BackColor = Color.Gold;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(29, 387);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(363, 25);
            label4.TabIndex = 7;
            label4.Text = "Karbonhidrat";
            // 
            // nudYag
            // 
            nudYag.Location = new Point(29, 508);
            nudYag.Margin = new Padding(4, 5, 4, 5);
            nudYag.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudYag.Name = "nudYag";
            nudYag.Size = new Size(363, 31);
            nudYag.TabIndex = 10;
            nudYag.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(29, 478);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(363, 25);
            label5.TabIndex = 9;
            label5.Text = "Yağ";
            // 
            // label6
            // 
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(29, 578);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(363, 25);
            label6.TabIndex = 11;
            label6.Text = "Kategori";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(29, 608);
            cmbKategori.Margin = new Padding(4, 5, 4, 5);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(363, 33);
            cmbKategori.TabIndex = 12;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightGray;
            btnEkle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnEkle.Location = new Point(29, 677);
            btnEkle.Margin = new Padding(4, 5, 4, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(363, 39);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightGray;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnGuncelle.Location = new Point(29, 729);
            btnGuncelle.Margin = new Padding(4, 5, 4, 5);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(363, 39);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightGray;
            btnSil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnSil.Location = new Point(29, 783);
            btnSil.Margin = new Padding(4, 5, 4, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(363, 42);
            btnSil.TabIndex = 15;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.LightGray;
            btnGeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnGeri.Location = new Point(29, 879);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(363, 38);
            btnGeri.TabIndex = 16;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.YoneticiBesinForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // YoneticiBesinForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(btnGeri);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(cmbKategori);
            Controls.Add(label6);
            Controls.Add(nudYag);
            Controls.Add(label5);
            Controls.Add(nudKarbonhidrat);
            Controls.Add(label4);
            Controls.Add(nudProtein);
            Controls.Add(label3);
            Controls.Add(nudKalori);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(dgvBesinler);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1661, 999);
            Name = "YoneticiBesinForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Besin Yönetim Form";
            ((System.ComponentModel.ISupportInitialize)dgvBesinler).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKalori).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudProtein).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKarbonhidrat).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYag).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBesinler;
        private Label label1;
        private TextBox txtAd;
        private Label label2;
        private NumericUpDown nudKalori;
        private NumericUpDown nudProtein;
        private Label label3;
        private NumericUpDown nudKarbonhidrat;
        private Label label4;
        private NumericUpDown nudYag;
        private Label label5;
        private Label label6;
        private ComboBox cmbKategori;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnGeri;
        private PictureBox pictureBox1;
    }
}