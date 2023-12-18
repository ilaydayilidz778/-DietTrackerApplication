namespace EFDiyetUygulamasi.PL
{
    partial class KiyasForm
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
            lblOgunKullanici = new Label();
            groupBox1 = new GroupBox();
            lblKategoriKullanici = new Label();
            groupBox2 = new GroupBox();
            lblKategoriTumKullanici = new Label();
            lblOgunTumKullanici = new Label();
            cboOgunler = new ComboBox();
            label5 = new Label();
            cboKategoriler = new ComboBox();
            label6 = new Label();
            dgvKullaniciSiralama = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            label7 = new Label();
            label8 = new Label();
            dtpTakvimBitis = new DateTimePicker();
            dtpTakvimBaslangic = new DateTimePicker();
            btnOguneGoreListele = new Button();
            btnKategoriyeGoreListele = new Button();
            dgvTumSiralama = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciSiralama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTumSiralama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblOgunKullanici
            // 
            lblOgunKullanici.AutoSize = true;
            lblOgunKullanici.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblOgunKullanici.ForeColor = Color.LimeGreen;
            lblOgunKullanici.Location = new Point(6, 44);
            lblOgunKullanici.Name = "lblOgunKullanici";
            lblOgunKullanici.Size = new Size(440, 50);
            lblOgunKullanici.TabIndex = 0;
            lblOgunKullanici.Text = "Bu Süreçte Kahvaltı Öğününde En Çok Tüketilen Besin\r\n\r\n";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblKategoriKullanici);
            groupBox1.Controls.Add(lblOgunKullanici);
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(132, 348);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 238);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcıya Özel";
            // 
            // lblKategoriKullanici
            // 
            lblKategoriKullanici.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblKategoriKullanici.ForeColor = Color.LimeGreen;
            lblKategoriKullanici.Location = new Point(0, 112);
            lblKategoriKullanici.Name = "lblKategoriKullanici";
            lblKategoriKullanici.Size = new Size(432, 105);
            lblKategoriKullanici.TabIndex = 2;
            lblKategoriKullanici.Text = "Bu Süreçte Et Ürünleri Kategorisinde En Çok Tüketilen Besin";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblKategoriTumKullanici);
            groupBox2.Controls.Add(lblOgunTumKullanici);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            groupBox2.Location = new Point(611, 348);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(485, 238);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tüm Kullanıcıların";
            // 
            // lblKategoriTumKullanici
            // 
            lblKategoriTumKullanici.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblKategoriTumKullanici.ForeColor = Color.LimeGreen;
            lblKategoriTumKullanici.Location = new Point(6, 112);
            lblKategoriTumKullanici.Name = "lblKategoriTumKullanici";
            lblKategoriTumKullanici.Size = new Size(432, 105);
            lblKategoriTumKullanici.TabIndex = 3;
            lblKategoriTumKullanici.Text = "Bu Süreçte Et Ürünleri Kategorisinde En Çok Tüketilen Besin";
            // 
            // lblOgunTumKullanici
            // 
            lblOgunTumKullanici.AutoSize = true;
            lblOgunTumKullanici.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblOgunTumKullanici.ForeColor = Color.LimeGreen;
            lblOgunTumKullanici.Location = new Point(10, 44);
            lblOgunTumKullanici.Name = "lblOgunTumKullanici";
            lblOgunTumKullanici.Size = new Size(440, 50);
            lblOgunTumKullanici.TabIndex = 0;
            lblOgunTumKullanici.Text = "Bu Süreçte Kahvaltı Öğününde En Çok Tüketilen Besin\r\n\r\n";
            // 
            // cboOgunler
            // 
            cboOgunler.DisplayMember = "Ad";
            cboOgunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOgunler.FormattingEnabled = true;
            cboOgunler.Location = new Point(132, 294);
            cboOgunler.Name = "cboOgunler";
            cboOgunler.Size = new Size(457, 33);
            cboOgunler.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(132, 253);
            label5.Name = "label5";
            label5.Size = new Size(91, 28);
            label5.TabIndex = 6;
            label5.Text = "Öğünler ";
            // 
            // cboKategoriler
            // 
            cboKategoriler.DisplayMember = "Ad";
            cboKategoriler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKategoriler.FormattingEnabled = true;
            cboKategoriler.Location = new Point(611, 294);
            cboKategoriler.Name = "cboKategoriler";
            cboKategoriler.Size = new Size(485, 33);
            cboKategoriler.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(611, 253);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 8;
            label6.Text = "Kategoriler";
            // 
            // dgvKullaniciSiralama
            // 
            dgvKullaniciSiralama.AllowUserToAddRows = false;
            dgvKullaniciSiralama.AllowUserToDeleteRows = false;
            dgvKullaniciSiralama.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKullaniciSiralama.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKullaniciSiralama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullaniciSiralama.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvKullaniciSiralama.Location = new Point(133, 634);
            dgvKullaniciSiralama.Name = "dgvKullaniciSiralama";
            dgvKullaniciSiralama.ReadOnly = true;
            dgvKullaniciSiralama.RowHeadersVisible = false;
            dgvKullaniciSiralama.RowHeadersWidth = 62;
            dgvKullaniciSiralama.Size = new Size(456, 214);
            dgvKullaniciSiralama.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BesinAd";
            Column1.HeaderText = "Besin Adı";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TekrarSayisi";
            Column2.HeaderText = "Tüketme Sayısı";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(132, 121);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 45;
            label7.Text = "Bitiş Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gold;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(133, 21);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 44;
            label8.Text = "Başlangıç Tarihi";
            // 
            // dtpTakvimBitis
            // 
            dtpTakvimBitis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            dtpTakvimBitis.Location = new Point(133, 157);
            dtpTakvimBitis.Margin = new Padding(4, 5, 4, 5);
            dtpTakvimBitis.Name = "dtpTakvimBitis";
            dtpTakvimBitis.Size = new Size(526, 32);
            dtpTakvimBitis.TabIndex = 43;
            dtpTakvimBitis.ValueChanged += dtpTakvimBitis_ValueChanged;
            // 
            // dtpTakvimBaslangic
            // 
            dtpTakvimBaslangic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            dtpTakvimBaslangic.Location = new Point(133, 54);
            dtpTakvimBaslangic.Margin = new Padding(4, 5, 4, 5);
            dtpTakvimBaslangic.Name = "dtpTakvimBaslangic";
            dtpTakvimBaslangic.Size = new Size(526, 32);
            dtpTakvimBaslangic.TabIndex = 42;
            dtpTakvimBaslangic.ValueChanged += dtpTakvimBaslangic_ValueChanged;
            // 
            // btnOguneGoreListele
            // 
            btnOguneGoreListele.BackColor = SystemColors.ControlLight;
            btnOguneGoreListele.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnOguneGoreListele.Location = new Point(133, 860);
            btnOguneGoreListele.Name = "btnOguneGoreListele";
            btnOguneGoreListele.Size = new Size(457, 40);
            btnOguneGoreListele.TabIndex = 46;
            btnOguneGoreListele.Text = "Öğüne Göre Listele";
            btnOguneGoreListele.UseVisualStyleBackColor = false;
            btnOguneGoreListele.Click += btnOguneGoreListele_Click;
            // 
            // btnKategoriyeGoreListele
            // 
            btnKategoriyeGoreListele.BackColor = SystemColors.ControlLight;
            btnKategoriyeGoreListele.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            btnKategoriyeGoreListele.Location = new Point(617, 860);
            btnKategoriyeGoreListele.Name = "btnKategoriyeGoreListele";
            btnKategoriyeGoreListele.Size = new Size(479, 40);
            btnKategoriyeGoreListele.TabIndex = 47;
            btnKategoriyeGoreListele.Text = "Kategoriye Göre Listele";
            btnKategoriyeGoreListele.UseVisualStyleBackColor = false;
            btnKategoriyeGoreListele.Click += btnKategoriyeGoreListele_Click;
            // 
            // dgvTumSiralama
            // 
            dgvTumSiralama.AllowUserToAddRows = false;
            dgvTumSiralama.AllowUserToDeleteRows = false;
            dgvTumSiralama.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTumSiralama.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTumSiralama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumSiralama.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dgvTumSiralama.Location = new Point(617, 634);
            dgvTumSiralama.Name = "dgvTumSiralama";
            dgvTumSiralama.ReadOnly = true;
            dgvTumSiralama.RowHeadersVisible = false;
            dgvTumSiralama.RowHeadersWidth = 62;
            dgvTumSiralama.Size = new Size(479, 214);
            dgvTumSiralama.TabIndex = 48;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "BesinAd";
            Column3.HeaderText = "Besin Adı";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TekrarSayisi";
            Column4.HeaderText = "Tüketme Sayısı";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(133, 598);
            label1.Name = "label1";
            label1.Size = new Size(93, 28);
            label1.TabIndex = 49;
            label1.Text = "Kullanıcı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(617, 598);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 50;
            label2.Text = "Genel";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.KarsilastirmaForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // KiyasForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTumSiralama);
            Controls.Add(btnKategoriyeGoreListele);
            Controls.Add(btnOguneGoreListele);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dtpTakvimBitis);
            Controls.Add(dtpTakvimBaslangic);
            Controls.Add(dgvKullaniciSiralama);
            Controls.Add(cboKategoriler);
            Controls.Add(label6);
            Controls.Add(cboOgunler);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1661, 999);
            Name = "KiyasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Karşılaştırma Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciSiralama).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTumSiralama).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOgunKullanici;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lblOgunTumKullanici;
        private ComboBox cboOgunler;
        private Label label5;
        private ComboBox cboKategoriler;
        private Label label6;
        private DataGridView dgvKullaniciSiralama;
        private Label label7;
        private Label label8;
        private DateTimePicker dtpTakvimBitis;
        private DateTimePicker dtpTakvimBaslangic;
        private Button btnOguneGoreListele;
        private Button btnKategoriyeGoreListele;
        private Label lblKategoriKullanici;
        private Label lblKategoriTumKullanici;
        private DataGridView dgvTumSiralama;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox pictureBox1;
    }
}