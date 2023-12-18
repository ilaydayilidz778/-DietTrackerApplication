namespace EFDiyetUygulamasi.PL
{
    partial class UyeForm
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
            btnIptal = new Button();
            btnUyeKaydet = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox1 = new PictureBox();
            grpCinsiyet = new GroupBox();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            nudYas = new NumericUpDown();
            nudKilo = new NumericUpDown();
            nudBoy = new NumericUpDown();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            lblSifreGucu = new Label();
            lblOneriSifre = new Label();
            btnOneriSifreEkle = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpCinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).BeginInit();
            SuspendLayout();
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Gold;
            btnIptal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnIptal.Location = new Point(255, 875);
            btnIptal.Margin = new Padding(2);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(468, 39);
            btnIptal.TabIndex = 17;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // btnUyeKaydet
            // 
            btnUyeKaydet.BackColor = Color.Gold;
            btnUyeKaydet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnUyeKaydet.Location = new Point(255, 819);
            btnUyeKaydet.Margin = new Padding(2);
            btnUyeKaydet.Name = "btnUyeKaydet";
            btnUyeKaydet.Size = new Size(468, 39);
            btnUyeKaydet.TabIndex = 24;
            btnUyeKaydet.Text = "Kaydol";
            btnUyeKaydet.UseVisualStyleBackColor = false;
            btnUyeKaydet.Click += btnUyeKaydet_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.UyeForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(986, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // grpCinsiyet
            // 
            grpCinsiyet.BackColor = Color.DarkSlateGray;
            grpCinsiyet.Controls.Add(rbErkek);
            grpCinsiyet.Controls.Add(rbKadin);
            grpCinsiyet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            grpCinsiyet.ForeColor = Color.White;
            grpCinsiyet.Location = new Point(255, 710);
            grpCinsiyet.Margin = new Padding(2);
            grpCinsiyet.Name = "grpCinsiyet";
            grpCinsiyet.Padding = new Padding(2);
            grpCinsiyet.Size = new Size(475, 74);
            grpCinsiyet.TabIndex = 59;
            grpCinsiyet.TabStop = false;
            grpCinsiyet.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(102, 24);
            rbErkek.Margin = new Padding(2);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(87, 32);
            rbErkek.TabIndex = 21;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.Location = new Point(257, 24);
            rbKadin.Margin = new Padding(2);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(90, 32);
            rbKadin.TabIndex = 22;
            rbKadin.TabStop = true;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = true;
            // 
            // nudYas
            // 
            nudYas.Location = new Point(255, 656);
            nudYas.Margin = new Padding(2);
            nudYas.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            nudYas.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(475, 31);
            nudYas.TabIndex = 58;
            nudYas.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // nudKilo
            // 
            nudKilo.DecimalPlaces = 2;
            nudKilo.Location = new Point(255, 566);
            nudKilo.Margin = new Padding(2);
            nudKilo.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudKilo.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            nudKilo.Name = "nudKilo";
            nudKilo.Size = new Size(475, 31);
            nudKilo.TabIndex = 57;
            nudKilo.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // nudBoy
            // 
            nudBoy.Location = new Point(255, 470);
            nudBoy.Margin = new Padding(2);
            nudBoy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudBoy.Minimum = new decimal(new int[] { 120, 0, 0, 0 });
            nudBoy.Name = "nudBoy";
            nudBoy.Size = new Size(475, 31);
            nudBoy.TabIndex = 56;
            nudBoy.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label8
            // 
            label8.BackColor = Color.DarkSlateGray;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(255, 620);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(475, 34);
            label8.TabIndex = 55;
            label8.Text = "Yaş";
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(255, 530);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(475, 33);
            label5.TabIndex = 54;
            label5.Text = "Kilo";
            // 
            // label6
            // 
            label6.BackColor = Color.DarkSlateGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(255, 430);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(475, 37);
            label6.TabIndex = 53;
            label6.Text = "Boy";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkSlateGray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(255, 344);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(475, 34);
            label3.TabIndex = 52;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.BackColor = Color.DarkSlateGray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(255, 255);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(475, 33);
            label4.TabIndex = 51;
            label4.Text = "Ad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(255, 381);
            txtSoyad.Margin = new Padding(2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(475, 31);
            txtSoyad.TabIndex = 50;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(255, 293);
            txtAd.Margin = new Padding(2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(475, 31);
            txtAd.TabIndex = 49;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSlateGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(255, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(475, 36);
            label2.TabIndex = 48;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSlateGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(255, 30);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(475, 38);
            label1.TabIndex = 47;
            label1.Text = "E-mail";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(255, 158);
            txtSifre.Margin = new Padding(2);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(475, 31);
            txtSifre.TabIndex = 46;
            txtSifre.TextChanged += txtSifre_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(255, 75);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(475, 31);
            txtEmail.TabIndex = 45;
            // 
            // lblSifreGucu
            // 
            lblSifreGucu.AutoSize = true;
            lblSifreGucu.Location = new Point(255, 201);
            lblSifreGucu.Name = "lblSifreGucu";
            lblSifreGucu.Size = new Size(0, 25);
            lblSifreGucu.TabIndex = 60;
            // 
            // lblOneriSifre
            // 
            lblOneriSifre.Location = new Point(353, 201);
            lblOneriSifre.Name = "lblOneriSifre";
            lblOneriSifre.Size = new Size(327, 35);
            lblOneriSifre.TabIndex = 61;
            // 
            // btnOneriSifreEkle
            // 
            btnOneriSifreEkle.BackColor = SystemColors.ControlLight;
            btnOneriSifreEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnOneriSifreEkle.Location = new Point(692, 201);
            btnOneriSifreEkle.Name = "btnOneriSifreEkle";
            btnOneriSifreEkle.Size = new Size(38, 34);
            btnOneriSifreEkle.TabIndex = 62;
            btnOneriSifreEkle.Text = "+";
            btnOneriSifreEkle.UseVisualStyleBackColor = false;
            btnOneriSifreEkle.Click += btnOneriSifreEkle_Click;
            // 
            // UyeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 943);
            Controls.Add(btnOneriSifreEkle);
            Controls.Add(lblOneriSifre);
            Controls.Add(lblSifreGucu);
            Controls.Add(grpCinsiyet);
            Controls.Add(nudYas);
            Controls.Add(nudKilo);
            Controls.Add(nudBoy);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(btnIptal);
            Controls.Add(btnUyeKaydet);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            MaximumSize = new Size(1008, 999);
            Name = "UyeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Kayıt Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpCinsiyet.ResumeLayout(false);
            grpCinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button button1;
        private Button btnIptal;
        private Button btnUyeKaydet;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        private GroupBox grpCinsiyet;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private NumericUpDown nudYas;
        private NumericUpDown nudKilo;
        private NumericUpDown nudBoy;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private Label lblSifreGucu;
        private Label lblOneriSifre;
        private Button btnOneriSifreEkle;
    }
}