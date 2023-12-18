namespace EFDiyetUygulamasi.PL
{
    partial class OgunForm
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
            label6 = new Label();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnIptal = new Button();
            btnEkle = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            nudPorsiyon = new NumericUpDown();
            cboKategoriler = new ComboBox();
            dtpTakvim = new DateTimePicker();
            dgvYemekler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            cboOgunler = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            dgvOgunBilgisi = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            pbYemekGorseli = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunBilgisi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYemekGorseli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label6.Location = new Point(515, 30);
            label6.Name = "label6";
            label6.Size = new Size(634, 36);
            label6.TabIndex = 17;
            label6.Text = "Seçili Kategori";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.LightGray;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnGuncelle.Location = new Point(859, 883);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(290, 46);
            btnGuncelle.TabIndex = 18;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightGray;
            btnSil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnSil.Location = new Point(520, 883);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(315, 48);
            btnSil.TabIndex = 19;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.LightGray;
            btnIptal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnIptal.Location = new Point(24, 864);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(428, 42);
            btnIptal.TabIndex = 7;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightGray;
            btnEkle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            btnEkle.Location = new Point(22, 805);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(430, 43);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(22, 361);
            label2.Name = "label2";
            label2.Size = new Size(430, 30);
            label2.TabIndex = 4;
            label2.Text = "Kategoriler";
            // 
            // label3
            // 
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(19, 691);
            label3.Name = "label3";
            label3.Size = new Size(433, 30);
            label3.TabIndex = 10;
            label3.Text = "Porsiyon";
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(19, 264);
            label1.Name = "label1";
            label1.Size = new Size(433, 30);
            label1.TabIndex = 3;
            label1.Text = "Öğünler ";
            // 
            // nudPorsiyon
            // 
            nudPorsiyon.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            nudPorsiyon.Location = new Point(19, 734);
            nudPorsiyon.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPorsiyon.Name = "nudPorsiyon";
            nudPorsiyon.Size = new Size(433, 32);
            nudPorsiyon.TabIndex = 11;
            nudPorsiyon.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboKategoriler
            // 
            cboKategoriler.DisplayMember = "Ad";
            cboKategoriler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKategoriler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            cboKategoriler.FormattingEnabled = true;
            cboKategoriler.Location = new Point(22, 399);
            cboKategoriler.Name = "cboKategoriler";
            cboKategoriler.Size = new Size(430, 33);
            cboKategoriler.TabIndex = 2;
            cboKategoriler.SelectedIndexChanged += cboKategoriler_SelectedIndexChanged;
            // 
            // dtpTakvim
            // 
            dtpTakvim.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            dtpTakvim.Location = new Point(19, 208);
            dtpTakvim.Name = "dtpTakvim";
            dtpTakvim.Size = new Size(433, 32);
            dtpTakvim.TabIndex = 12;
            dtpTakvim.ValueChanged += dtpTakvim_ValueChanged;
            // 
            // dgvYemekler
            // 
            dgvYemekler.AllowUserToAddRows = false;
            dgvYemekler.AllowUserToDeleteRows = false;
            dgvYemekler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvYemekler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvYemekler.BackgroundColor = SystemColors.ButtonFace;
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvYemekler.Location = new Point(19, 454);
            dgvYemekler.MultiSelect = false;
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.ReadOnly = true;
            dgvYemekler.RowHeadersVisible = false;
            dgvYemekler.RowHeadersWidth = 62;
            dgvYemekler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvYemekler.Size = new Size(433, 220);
            dgvYemekler.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Ad";
            Column1.FillWeight = 5F;
            Column1.HeaderText = "Ad";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Kalori";
            Column2.FillWeight = 2F;
            Column2.HeaderText = "Kalori";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // cboOgunler
            // 
            cboOgunler.DisplayMember = "Ad";
            cboOgunler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOgunler.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            cboOgunler.FormattingEnabled = true;
            cboOgunler.Location = new Point(19, 303);
            cboOgunler.Name = "cboOgunler";
            cboOgunler.Size = new Size(433, 33);
            cboOgunler.TabIndex = 0;
            cboOgunler.SelectedIndexChanged += cboOgunler_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(19, 173);
            label7.Name = "label7";
            label7.Size = new Size(433, 28);
            label7.TabIndex = 14;
            label7.Text = "Tarih";
            // 
            // label5
            // 
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(520, 566);
            label5.Name = "label5";
            label5.Size = new Size(629, 36);
            label5.TabIndex = 14;
            label5.Text = "Eklenen Öğünler";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvOgunBilgisi
            // 
            dgvOgunBilgisi.AllowUserToAddRows = false;
            dgvOgunBilgisi.AllowUserToDeleteRows = false;
            dgvOgunBilgisi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgunBilgisi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgunBilgisi.BackgroundColor = SystemColors.ButtonFace;
            dgvOgunBilgisi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunBilgisi.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6 });
            dgvOgunBilgisi.Location = new Point(520, 618);
            dgvOgunBilgisi.MultiSelect = false;
            dgvOgunBilgisi.Name = "dgvOgunBilgisi";
            dgvOgunBilgisi.ReadOnly = true;
            dgvOgunBilgisi.RowHeadersVisible = false;
            dgvOgunBilgisi.RowHeadersWidth = 62;
            dgvOgunBilgisi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgunBilgisi.Size = new Size(634, 249);
            dgvOgunBilgisi.TabIndex = 6;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Ogun";
            Column3.HeaderText = "Öğün Ad";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Besin";
            Column4.HeaderText = "Besin Ad";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Porsiyon";
            Column5.HeaderText = "Porsiyon";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Tarih";
            Column6.HeaderText = "Tarih";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // pbYemekGorseli
            // 
            pbYemekGorseli.BackColor = Color.Transparent;
            pbYemekGorseli.Location = new Point(520, 73);
            pbYemekGorseli.Name = "pbYemekGorseli";
            pbYemekGorseli.Size = new Size(634, 454);
            pbYemekGorseli.SizeMode = PictureBoxSizeMode.CenterImage;
            pbYemekGorseli.TabIndex = 5;
            pbYemekGorseli.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.OgunEklemeForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // OgunForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1639, 943);
            Controls.Add(pbYemekGorseli);
            Controls.Add(btnEkle);
            Controls.Add(label5);
            Controls.Add(dgvOgunBilgisi);
            Controls.Add(btnIptal);
            Controls.Add(nudPorsiyon);
            Controls.Add(dgvYemekler);
            Controls.Add(label3);
            Controls.Add(cboOgunler);
            Controls.Add(cboKategoriler);
            Controls.Add(label7);
            Controls.Add(btnSil);
            Controls.Add(dtpTakvim);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuncelle);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1661, 999);
            Name = "OgunForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Öğün Ekleme Form";
            ((System.ComponentModel.ISupportInitialize)nudPorsiyon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgunBilgisi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYemekGorseli).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label6;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnIptal;
        private Button btnEkle;
        private Label label2;
        private Label label3;
        private Label label1;
        private NumericUpDown nudPorsiyon;
        private ComboBox cboKategoriler;
        private DateTimePicker dtpTakvim;
        private DataGridView dgvYemekler;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private ComboBox cboOgunler;
        private Label label7;
        private Label label5;
        private DataGridView dgvOgunBilgisi;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private PictureBox pbYemekGorseli;
        private PictureBox pictureBox1;
    }
}