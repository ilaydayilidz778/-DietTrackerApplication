namespace EFDiyetUygulamasi.PL
{
    partial class ProfilForm
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
            lblSifreGucu = new Label();
            btnGuncelle = new Button();
            grpCinsiyet = new GroupBox();
            rbErkek = new RadioButton();
            rbKadin = new RadioButton();
            nudYas = new NumericUpDown();
            nudKilo = new NumericUpDown();
            nudBoy = new NumericUpDown();
            btnIptal = new Button();
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
            pictureBox1 = new PictureBox();
            grpCinsiyet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSifreGucu
            // 
            lblSifreGucu.AutoSize = true;
            lblSifreGucu.BackColor = SystemColors.ControlLightLight;
            lblSifreGucu.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblSifreGucu.ForeColor = SystemColors.ActiveCaptionText;
            lblSifreGucu.Location = new Point(229, 203);
            lblSifreGucu.Margin = new Padding(2, 0, 2, 0);
            lblSifreGucu.Name = "lblSifreGucu";
            lblSifreGucu.Size = new Size(81, 21);
            lblSifreGucu.TabIndex = 43;
            lblSifreGucu.Text = "Şifre Gücü";
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Gold;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnGuncelle.ForeColor = SystemColors.ActiveCaptionText;
            btnGuncelle.Location = new Point(229, 825);
            btnGuncelle.Margin = new Padding(2);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(475, 40);
            btnGuncelle.TabIndex = 42;
            btnGuncelle.Text = "Bilgileri Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // grpCinsiyet
            // 
            grpCinsiyet.BackColor = Color.DarkSlateGray;
            grpCinsiyet.Controls.Add(rbErkek);
            grpCinsiyet.Controls.Add(rbKadin);
            grpCinsiyet.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            grpCinsiyet.ForeColor = Color.White;
            grpCinsiyet.Location = new Point(229, 712);
            grpCinsiyet.Margin = new Padding(2);
            grpCinsiyet.Name = "grpCinsiyet";
            grpCinsiyet.Padding = new Padding(2);
            grpCinsiyet.Size = new Size(475, 74);
            grpCinsiyet.TabIndex = 41;
            grpCinsiyet.TabStop = false;
            grpCinsiyet.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(103, 25);
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
            rbKadin.Location = new Point(258, 25);
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
            nudYas.Location = new Point(229, 658);
            nudYas.Margin = new Padding(2);
            nudYas.Maximum = new decimal(new int[] { 45, 0, 0, 0 });
            nudYas.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            nudYas.Name = "nudYas";
            nudYas.Size = new Size(475, 31);
            nudYas.TabIndex = 40;
            nudYas.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // nudKilo
            // 
            nudKilo.DecimalPlaces = 2;
            nudKilo.Location = new Point(229, 568);
            nudKilo.Margin = new Padding(2);
            nudKilo.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudKilo.Minimum = new decimal(new int[] { 35, 0, 0, 0 });
            nudKilo.Name = "nudKilo";
            nudKilo.Size = new Size(475, 31);
            nudKilo.TabIndex = 39;
            nudKilo.Value = new decimal(new int[] { 35, 0, 0, 0 });
            // 
            // nudBoy
            // 
            nudBoy.Location = new Point(229, 472);
            nudBoy.Margin = new Padding(2);
            nudBoy.Maximum = new decimal(new int[] { 250, 0, 0, 0 });
            nudBoy.Minimum = new decimal(new int[] { 120, 0, 0, 0 });
            nudBoy.Name = "nudBoy";
            nudBoy.Size = new Size(475, 31);
            nudBoy.TabIndex = 38;
            nudBoy.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.Gold;
            btnIptal.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            btnIptal.ForeColor = SystemColors.ActiveCaptionText;
            btnIptal.Location = new Point(229, 882);
            btnIptal.Margin = new Padding(2);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(475, 39);
            btnIptal.TabIndex = 37;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += btnIptal_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.DarkSlateGray;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = Color.White;
            label8.Location = new Point(229, 622);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(475, 34);
            label8.TabIndex = 36;
            label8.Text = "Yaş";
            // 
            // label5
            // 
            label5.BackColor = Color.DarkSlateGray;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.White;
            label5.Location = new Point(229, 532);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(475, 33);
            label5.TabIndex = 35;
            label5.Text = "Kilo";
            // 
            // label6
            // 
            label6.BackColor = Color.DarkSlateGray;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.White;
            label6.Location = new Point(229, 432);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(475, 37);
            label6.TabIndex = 34;
            label6.Text = "Boy";
            // 
            // label3
            // 
            label3.BackColor = Color.DarkSlateGray;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(229, 346);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(475, 34);
            label3.TabIndex = 33;
            label3.Text = "Soyad";
            // 
            // label4
            // 
            label4.BackColor = Color.DarkSlateGray;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(229, 257);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(475, 33);
            label4.TabIndex = 32;
            label4.Text = "Ad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(229, 383);
            txtSoyad.Margin = new Padding(2);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(475, 31);
            txtSoyad.TabIndex = 31;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(229, 295);
            txtAd.Margin = new Padding(2);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(475, 31);
            txtAd.TabIndex = 30;
            // 
            // label2
            // 
            label2.BackColor = Color.DarkSlateGray;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(229, 120);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(475, 36);
            label2.TabIndex = 29;
            label2.Text = "Şifre";
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSlateGray;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(229, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(475, 38);
            label1.TabIndex = 28;
            label1.Text = "E-mail";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(229, 160);
            txtSifre.Margin = new Padding(2);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(475, 31);
            txtSifre.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(229, 77);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(475, 31);
            txtEmail.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.ProfilForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(986, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // ProfilForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 943);
            Controls.Add(lblSifreGucu);
            Controls.Add(btnGuncelle);
            Controls.Add(grpCinsiyet);
            Controls.Add(nudYas);
            Controls.Add(nudKilo);
            Controls.Add(nudBoy);
            Controls.Add(btnIptal);
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
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
            MaximumSize = new Size(1008, 999);
            Name = "ProfilForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Profil Form";
            grpCinsiyet.ResumeLayout(false);
            grpCinsiyet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudYas).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKilo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBoy).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSifreGucu;
        private Button btnGuncelle;
        private GroupBox grpCinsiyet;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private NumericUpDown nudYas;
        private NumericUpDown nudKilo;
        private NumericUpDown nudBoy;
        private Button btnIptal;
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
        private PictureBox pictureBox1;
    }
}