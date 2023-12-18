namespace EFDiyetUygulamasi.PL
{
    partial class RaporForm
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
            label7 = new Label();
            label8 = new Label();
            dtpTakvimBitis = new DateTimePicker();
            dtpTakvimBaslangic = new DateTimePicker();
            dgvOgunlerOzeti = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            gboBesinDegerleri = new GroupBox();
            label2 = new Label();
            pbKalori = new ProgressBar();
            lblToplamKalori = new Label();
            pbYag = new ProgressBar();
            pbProtein = new ProgressBar();
            pbKarbonhidrat = new ProgressBar();
            lblYag = new Label();
            label5 = new Label();
            lblProtein = new Label();
            lblKarbonhidrat = new Label();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOgunlerOzeti).BeginInit();
            gboBesinDegerleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Gold;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(131, 124);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 28);
            label7.TabIndex = 49;
            label7.Text = "Bitiş Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gold;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(131, 30);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 48;
            label8.Text = "Başlangıç Tarihi";
            // 
            // dtpTakvimBitis
            // 
            dtpTakvimBitis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            dtpTakvimBitis.Location = new Point(131, 157);
            dtpTakvimBitis.Margin = new Padding(4, 5, 4, 5);
            dtpTakvimBitis.Name = "dtpTakvimBitis";
            dtpTakvimBitis.Size = new Size(376, 32);
            dtpTakvimBitis.TabIndex = 47;
            dtpTakvimBitis.ValueChanged += dtpTakvimBitis_ValueChanged;
            // 
            // dtpTakvimBaslangic
            // 
            dtpTakvimBaslangic.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            dtpTakvimBaslangic.Location = new Point(131, 63);
            dtpTakvimBaslangic.Margin = new Padding(4, 5, 4, 5);
            dtpTakvimBaslangic.Name = "dtpTakvimBaslangic";
            dtpTakvimBaslangic.Size = new Size(376, 32);
            dtpTakvimBaslangic.TabIndex = 46;
            dtpTakvimBaslangic.ValueChanged += dtpTakvimBaslangic_ValueChanged;
            // 
            // dgvOgunlerOzeti
            // 
            dgvOgunlerOzeti.AllowUserToAddRows = false;
            dgvOgunlerOzeti.AllowUserToDeleteRows = false;
            dgvOgunlerOzeti.BackgroundColor = SystemColors.ButtonFace;
            dgvOgunlerOzeti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunlerOzeti.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column10, Column2, Column4, Column5, Column6, Column7 });
            dgvOgunlerOzeti.Location = new Point(131, 315);
            dgvOgunlerOzeti.Margin = new Padding(4, 5, 4, 5);
            dgvOgunlerOzeti.Name = "dgvOgunlerOzeti";
            dgvOgunlerOzeti.ReadOnly = true;
            dgvOgunlerOzeti.RowHeadersVisible = false;
            dgvOgunlerOzeti.RowHeadersWidth = 51;
            dgvOgunlerOzeti.Size = new Size(587, 574);
            dgvOgunlerOzeti.TabIndex = 50;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Tarih";
            Column3.FillWeight = 3.258712F;
            Column3.HeaderText = "Tarih";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "OgunAdi";
            Column1.FillWeight = 4.239735F;
            Column1.HeaderText = "Öğün Ad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "BesinAdi";
            Column10.FillWeight = 4.42204762F;
            Column10.HeaderText = "Besin Ad";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Porsiyon";
            Column2.FillWeight = 4.72742844F;
            Column2.HeaderText = "Porsiyon";
            Column2.MinimumWidth = 2;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Protein";
            Column4.FillWeight = 4.21201754F;
            Column4.HeaderText = "Protein";
            Column4.MinimumWidth = 3;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Karbonhidrat";
            Column5.FillWeight = 5.99491072F;
            Column5.HeaderText = "Karbonhidrat";
            Column5.MinimumWidth = 3;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Yag";
            Column6.FillWeight = 2.728246F;
            Column6.HeaderText = "Yağ";
            Column6.MinimumWidth = 3;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Kalori";
            Column7.FillWeight = 3.416903F;
            Column7.HeaderText = "Kalori";
            Column7.MinimumWidth = 3;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // gboBesinDegerleri
            // 
            gboBesinDegerleri.BackColor = Color.Transparent;
            gboBesinDegerleri.Controls.Add(label2);
            gboBesinDegerleri.Controls.Add(pbKalori);
            gboBesinDegerleri.Controls.Add(lblToplamKalori);
            gboBesinDegerleri.Controls.Add(pbYag);
            gboBesinDegerleri.Controls.Add(pbProtein);
            gboBesinDegerleri.Controls.Add(pbKarbonhidrat);
            gboBesinDegerleri.Controls.Add(lblYag);
            gboBesinDegerleri.Controls.Add(label5);
            gboBesinDegerleri.Controls.Add(lblProtein);
            gboBesinDegerleri.Controls.Add(lblKarbonhidrat);
            gboBesinDegerleri.Controls.Add(label1);
            gboBesinDegerleri.Controls.Add(label3);
            gboBesinDegerleri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            gboBesinDegerleri.ForeColor = Color.Black;
            gboBesinDegerleri.Location = new Point(743, 315);
            gboBesinDegerleri.Margin = new Padding(4);
            gboBesinDegerleri.Name = "gboBesinDegerleri";
            gboBesinDegerleri.Padding = new Padding(4);
            gboBesinDegerleri.Size = new Size(425, 582);
            gboBesinDegerleri.TabIndex = 51;
            gboBesinDegerleri.TabStop = false;
            gboBesinDegerleri.Text = "Alınan Ortalama Besin Değeri Ve Ortalama Kalori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(22, 442);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 54;
            label2.Text = "Toplam Kalori:\r\n";
            // 
            // pbKalori
            // 
            pbKalori.Location = new Point(22, 471);
            pbKalori.Margin = new Padding(4);
            pbKalori.Name = "pbKalori";
            pbKalori.Size = new Size(384, 28);
            pbKalori.TabIndex = 53;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblToplamKalori.ForeColor = Color.LimeGreen;
            lblToplamKalori.Location = new Point(22, 502);
            lblToplamKalori.Margin = new Padding(4, 0, 4, 0);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(60, 25);
            lblToplamKalori.TabIndex = 52;
            lblToplamKalori.Text = "Kalori";
            // 
            // pbYag
            // 
            pbYag.Location = new Point(22, 332);
            pbYag.Margin = new Padding(4);
            pbYag.Name = "pbYag";
            pbYag.Size = new Size(384, 30);
            pbYag.TabIndex = 23;
            // 
            // pbProtein
            // 
            pbProtein.Location = new Point(22, 210);
            pbProtein.Margin = new Padding(4);
            pbProtein.Name = "pbProtein";
            pbProtein.Size = new Size(384, 30);
            pbProtein.TabIndex = 21;
            // 
            // pbKarbonhidrat
            // 
            pbKarbonhidrat.Location = new Point(22, 103);
            pbKarbonhidrat.Margin = new Padding(4);
            pbKarbonhidrat.Name = "pbKarbonhidrat";
            pbKarbonhidrat.Size = new Size(384, 30);
            pbKarbonhidrat.TabIndex = 20;
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblYag.ForeColor = Color.LimeGreen;
            lblYag.Location = new Point(22, 371);
            lblYag.Margin = new Padding(4, 0, 4, 0);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(42, 25);
            lblYag.TabIndex = 22;
            lblYag.Text = "Yağ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gold;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(22, 74);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(188, 25);
            label5.TabIndex = 19;
            label5.Text = "Toplam Karbonhidrat:";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblProtein.ForeColor = Color.LimeGreen;
            lblProtein.Location = new Point(19, 244);
            lblProtein.Margin = new Padding(4, 0, 4, 0);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(70, 25);
            lblProtein.TabIndex = 18;
            lblProtein.Text = "Protein";
            // 
            // lblKarbonhidrat
            // 
            lblKarbonhidrat.AutoSize = true;
            lblKarbonhidrat.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblKarbonhidrat.ForeColor = Color.LimeGreen;
            lblKarbonhidrat.Location = new Point(19, 137);
            lblKarbonhidrat.Margin = new Padding(4, 0, 4, 0);
            lblKarbonhidrat.Name = "lblKarbonhidrat";
            lblKarbonhidrat.Size = new Size(118, 25);
            lblKarbonhidrat.TabIndex = 20;
            lblKarbonhidrat.Text = "Karbonhidrat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(22, 303);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 21;
            label1.Text = "Toplam Yağ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(22, 181);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 17;
            label3.Text = "Toplam Protein:";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.RaporFormBackGround;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gold;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(131, 265);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(423, 28);
            label4.TabIndex = 53;
            label4.Text = "Belirtilen Tarih Aralığınadaki Öğünleri Listele";
            // 
            // RaporForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(label4);
            Controls.Add(gboBesinDegerleri);
            Controls.Add(dgvOgunlerOzeti);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dtpTakvimBitis);
            Controls.Add(dtpTakvimBaslangic);
            Controls.Add(pictureBox1);
            Margin = new Padding(4);
            MaximumSize = new Size(1661, 999);
            Name = "RaporForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rapor Form";
            ((System.ComponentModel.ISupportInitialize)dgvOgunlerOzeti).EndInit();
            gboBesinDegerleri.ResumeLayout(false);
            gboBesinDegerleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label8;
        private DateTimePicker dtpTakvimBitis;
        private DateTimePicker dtpTakvimBaslangic;
        private DataGridView dgvOgunlerOzeti;
        private GroupBox gboBesinDegerleri;
        private ProgressBar pbYag;
        private ProgressBar pbProtein;
        private ProgressBar pbKarbonhidrat;
        private Label lblYag;
        private Label label5;
        private Label lblProtein;
        private Label lblKarbonhidrat;
        private Label label1;
        private Label label3;
        private Label label2;
        private ProgressBar pbKalori;
        private Label lblToplamKalori;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private PictureBox pictureBox1;
        private Label label4;
    }
}