namespace EFDiyetUygulamasi.PL
{
    partial class YoneticiRaporForm
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
            dtpTarih = new DateTimePicker();
            cmbKullanicilar = new ComboBox();
            dgvRapor = new DataGridView();
            btnGoruntule = new Button();
            label8 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(132, 50);
            dtpTarih.Margin = new Padding(4, 5, 4, 5);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(396, 31);
            dtpTarih.TabIndex = 0;
            // 
            // cmbKullanicilar
            // 
            cmbKullanicilar.FormattingEnabled = true;
            cmbKullanicilar.Location = new Point(132, 130);
            cmbKullanicilar.Margin = new Padding(4, 5, 4, 5);
            cmbKullanicilar.Name = "cmbKullanicilar";
            cmbKullanicilar.Size = new Size(396, 33);
            cmbKullanicilar.TabIndex = 2;
            // 
            // dgvRapor
            // 
            dgvRapor.AllowUserToAddRows = false;
            dgvRapor.AllowUserToDeleteRows = false;
            dgvRapor.Anchor = AnchorStyles.None;
            dgvRapor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRapor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Location = new Point(132, 251);
            dgvRapor.Margin = new Padding(4, 5, 4, 5);
            dgvRapor.MultiSelect = false;
            dgvRapor.Name = "dgvRapor";
            dgvRapor.ReadOnly = true;
            dgvRapor.RowHeadersVisible = false;
            dgvRapor.RowHeadersWidth = 62;
            dgvRapor.Size = new Size(946, 678);
            dgvRapor.TabIndex = 6;
            // 
            // btnGoruntule
            // 
            btnGoruntule.BackColor = Color.LightGray;
            btnGoruntule.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGoruntule.Location = new Point(132, 184);
            btnGoruntule.Margin = new Padding(4, 5, 4, 5);
            btnGoruntule.Name = "btnGoruntule";
            btnGoruntule.Size = new Size(396, 35);
            btnGoruntule.TabIndex = 7;
            btnGoruntule.Text = "Görüntüle";
            btnGoruntule.UseVisualStyleBackColor = false;
            btnGoruntule.Click += btnGoruntule_Click;
            // 
            // label8
            // 
            label8.BackColor = Color.Gold;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(132, 17);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(396, 28);
            label8.TabIndex = 49;
            label8.Text = "Başlangıç Tarihi";
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(132, 97);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(396, 28);
            label1.TabIndex = 50;
            label1.Text = "Kullanıcılar";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.YoneticiRaporFormBackGround;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 51;
            pictureBox1.TabStop = false;
            // 
            // YoneticiRaporForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(btnGoruntule);
            Controls.Add(dgvRapor);
            Controls.Add(cmbKullanicilar);
            Controls.Add(dtpTarih);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1661, 999);
            Name = "YoneticiRaporForm";
            Text = "Yönetici Rapor Form";
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpTarih;
        private DateTimePicker dtpBitis;
        private ComboBox cmbKullanicilar;
        private Label label2;
        private DataGridView dgvRapor;
        private Button btnGoruntule;
        private Label label8;
        private Label label1;
        private PictureBox pictureBox1;
    }
}