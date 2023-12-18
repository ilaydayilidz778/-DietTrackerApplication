namespace EFDiyetUygulamasi.PL
{
    partial class YoneticiKullaniciForm
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
            dgvKullanicilar = new DataGridView();
            label1 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtSifre = new TextBox();
            label4 = new Label();
            label5 = new Label();
            nudBoy = new NumericUpDown();
            nudKilo = new NumericUpDown();
            label6 = new Label();
            nudYas = new NumericUpDown();
            label7 = new Label();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            btnEkle = new Button();
            btnSil = new Button();
            btnGeri = new Button();
            dgvPasifKullanicilar = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasifKullanicilar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.AllowUserToAddRows = false;
            dgvKullanicilar.AllowUserToDeleteRows = false;
            dgvKullanicilar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKullanicilar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(406, 75);
            dgvKullanicilar.Margin = new Padding(4, 5, 4, 5);
            dgvKullanicilar.MultiSelect = false;
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.ReadOnly = true;
            dgvKullanicilar.RowHeadersVisible = false;
            dgvKullanicilar.RowHeadersWidth = 62;
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.Size = new Size(771, 442);
            dgvKullanicilar.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(19, 251);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(344, 25);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(19, 281);
            txtAd.Margin = new Padding(4, 5, 4, 5);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(344, 32);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(19, 364);
            txtSoyad.Margin = new Padding(4, 5, 4, 5);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(344, 32);
            txtSoyad.TabIndex = 4;
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(19, 334);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(344, 25);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(19, 113);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 32);
            txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(19, 83);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(344, 25);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(19, 191);
            txtSifre.Margin = new Padding(4, 5, 4, 5);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(344, 32);
            txtSifre.TabIndex = 8;
            // 
            // label4
            // 
            label4.BackColor = Color.Gold;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(19, 161);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(344, 25);
            label4.TabIndex = 7;
            label4.Text = "Şifre";
            // 
            // label5
            // 
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(17, 414);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(346, 25);
            label5.TabIndex = 9;
            label5.Text = "Boy";
            // 
            // nudBoy
            // 
            nudBoy.Location = new Point(16, 444);
            nudBoy.Margin = new Padding(4, 5, 4, 5);
            nudBoy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudBoy.Minimum = new decimal(new int[] { 120, 0, 0, 0 });
            nudBoy.Name = "nudBoy";
            nudBoy.Size = new Size(346, 32);
            nudBoy.TabIndex = 10;
            nudBoy.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // nudKilo
            // 
            nudKilo.Location = new Point(17, 530);
            nudKilo.Margin = new Padding(4, 5, 4, 5);
            nudKilo.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudKilo.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            nudKilo.Name = "nudKilo";
            nudKilo.Size = new Size(346, 32);
            nudKilo.TabIndex = 12;
            nudKilo.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // label6
            // 
            label6.BackColor = Color.Gold;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(19, 500);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(344, 25);
            label6.TabIndex = 11;
            label6.Text = "Kilo";
            // 
            // nudYas
            // 
            nudYas.Location = new Point(16, 627);
            nudYas.Margin = new Padding(4, 5, 4, 5);
            nudYas.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            nudYas.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(346, 32);
            nudYas.TabIndex = 14;
            nudYas.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label7
            // 
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(17, 597);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(343, 25);
            label7.TabIndex = 13;
            label7.Text = "Yaş";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(52, 38);
            rbErkek.Margin = new Padding(4, 5, 4, 5);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(80, 29);
            rbErkek.TabIndex = 16;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(177, 38);
            rbKadin.Margin = new Padding(4, 5, 4, 5);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(83, 29);
            rbKadin.TabIndex = 17;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.LightGray;
            btnEkle.Location = new Point(13, 785);
            btnEkle.Margin = new Padding(4, 5, 4, 5);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(350, 34);
            btnEkle.TabIndex = 18;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightGray;
            btnSil.Location = new Point(12, 830);
            btnSil.Margin = new Padding(4, 5, 4, 5);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(350, 32);
            btnSil.TabIndex = 20;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGeri
            // 
            btnGeri.BackColor = Color.DarkGray;
            btnGeri.Location = new Point(13, 892);
            btnGeri.Margin = new Padding(4, 5, 4, 5);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(347, 32);
            btnGeri.TabIndex = 21;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // dgvPasifKullanicilar
            // 
            dgvPasifKullanicilar.AllowUserToAddRows = false;
            dgvPasifKullanicilar.AllowUserToDeleteRows = false;
            dgvPasifKullanicilar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPasifKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPasifKullanicilar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPasifKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPasifKullanicilar.Location = new Point(406, 597);
            dgvPasifKullanicilar.MultiSelect = false;
            dgvPasifKullanicilar.Name = "dgvPasifKullanicilar";
            dgvPasifKullanicilar.ReadOnly = true;
            dgvPasifKullanicilar.RowHeadersVisible = false;
            dgvPasifKullanicilar.RowHeadersWidth = 62;
            dgvPasifKullanicilar.Size = new Size(771, 327);
            dgvPasifKullanicilar.TabIndex = 22;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = Color.Teal;
            label9.Location = new Point(406, 26);
            label9.Name = "label9";
            label9.Size = new Size(771, 35);
            label9.TabIndex = 23;
            label9.Text = "Tüm Kullanıcılar";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label10.ForeColor = Color.Teal;
            label10.Location = new Point(406, 549);
            label10.Name = "label10";
            label10.Size = new Size(771, 38);
            label10.TabIndex = 24;
            label10.Text = "Son 2 Haftada İşlem Yapmamış Kullanıcılar";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbKadin);
            groupBox1.Controls.Add(rbErkek);
            groupBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(13, 680);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 82);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.YoneticiKullaniciForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // YoneticiKullaniciForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(dgvPasifKullanicilar);
            Controls.Add(btnGeri);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(nudYas);
            Controls.Add(label7);
            Controls.Add(nudKilo);
            Controls.Add(label6);
            Controls.Add(nudBoy);
            Controls.Add(label5);
            Controls.Add(txtSifre);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Controls.Add(dgvKullanicilar);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1661, 999);
            Name = "YoneticiKullaniciForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Yönetim Form";
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPasifKullanicilar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKullanicilar;
        private Label label1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtSifre;
        private Label label4;
        private Label label5;
        private NumericUpDown nudBoy;
        private NumericUpDown nudKilo;
        private Label label6;
        private NumericUpDown nudYas;
        private Label label7;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGeri;
        private DataGridView dgvPasifKullanicilar;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
    }
}