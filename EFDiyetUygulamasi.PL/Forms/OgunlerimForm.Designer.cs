namespace EFDiyetUygulamasi.PL
{
    partial class OgunlerimForm
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
            dgvOgunler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            lblToplamKalori = new Label();
            lblProtein = new Label();
            label3 = new Label();
            lblKarbonhidrat = new Label();
            label5 = new Label();
            lblYag = new Label();
            label7 = new Label();
            label8 = new Label();
            dtpTakvim = new DateTimePicker();
            gboBesinDegerleri = new GroupBox();
            pbYag = new ProgressBar();
            pbProtein = new ProgressBar();
            pbKarbonhidrat = new ProgressBar();
            pbKalori = new ProgressBar();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).BeginInit();
            gboBesinDegerleri.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvOgunler
            // 
            dgvOgunler.AllowUserToAddRows = false;
            dgvOgunler.AllowUserToDeleteRows = false;
            dgvOgunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgunler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgunler.BackgroundColor = SystemColors.ButtonFace;
            dgvOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column10, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvOgunler.Location = new Point(126, 243);
            dgvOgunler.Margin = new Padding(4, 5, 4, 5);
            dgvOgunler.Name = "dgvOgunler";
            dgvOgunler.ReadOnly = true;
            dgvOgunler.RowHeadersVisible = false;
            dgvOgunler.RowHeadersWidth = 51;
            dgvOgunler.Size = new Size(1044, 258);
            dgvOgunler.TabIndex = 14;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "OgunAdi";
            Column1.FillWeight = 4.239735F;
            Column1.HeaderText = "Öğün Ad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "BesinAdi";
            Column10.FillWeight = 4.42204762F;
            Column10.HeaderText = "Besin Ad";
            Column10.MinimumWidth = 8;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Porsiyon";
            Column2.FillWeight = 4.72742844F;
            Column2.HeaderText = "Porsiyon";
            Column2.MinimumWidth = 2;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Tarih";
            Column3.FillWeight = 3.258712F;
            Column3.HeaderText = "Tarih";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Protein";
            Column4.FillWeight = 4.21201754F;
            Column4.HeaderText = "Protein";
            Column4.MinimumWidth = 3;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Karbonhidrat";
            Column5.FillWeight = 5.99491072F;
            Column5.HeaderText = "Karbonhidrat";
            Column5.MinimumWidth = 3;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Yag";
            Column6.FillWeight = 2.728246F;
            Column6.HeaderText = "Yağ";
            Column6.MinimumWidth = 3;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Kalori";
            Column7.FillWeight = 3.416903F;
            Column7.HeaderText = "Kalori";
            Column7.MinimumWidth = 3;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            lblToplamKalori.ForeColor = Color.DarkRed;
            lblToplamKalori.Location = new Point(18, 124);
            lblToplamKalori.Margin = new Padding(4, 0, 4, 0);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(60, 25);
            lblToplamKalori.TabIndex = 16;
            lblToplamKalori.Text = "Kalori";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblProtein.ForeColor = Color.DarkRed;
            lblProtein.Location = new Point(22, 232);
            lblProtein.Margin = new Padding(4, 0, 4, 0);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(63, 21);
            lblProtein.TabIndex = 18;
            lblProtein.Text = "Protein";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(22, 169);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(140, 25);
            label3.TabIndex = 17;
            label3.Text = "Toplam Protein:";
            // 
            // lblKarbonhidrat
            // 
            lblKarbonhidrat.AutoSize = true;
            lblKarbonhidrat.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblKarbonhidrat.ForeColor = Color.DarkRed;
            lblKarbonhidrat.Location = new Point(22, 105);
            lblKarbonhidrat.Margin = new Padding(4, 0, 4, 0);
            lblKarbonhidrat.Name = "lblKarbonhidrat";
            lblKarbonhidrat.Size = new Size(106, 21);
            lblKarbonhidrat.TabIndex = 20;
            lblKarbonhidrat.Text = "Karbonhidrat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(22, 41);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(188, 25);
            label5.TabIndex = 19;
            label5.Text = "Toplam Karbonhidrat:";
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblYag.ForeColor = Color.DarkRed;
            lblYag.Location = new Point(22, 356);
            lblYag.Margin = new Padding(4, 0, 4, 0);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(37, 21);
            lblYag.TabIndex = 22;
            lblYag.Text = "Yağ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(22, 289);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 25);
            label7.TabIndex = 21;
            label7.Text = "Toplam Yağ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gold;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.Desktop;
            label8.Location = new Point(114, 70);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(289, 28);
            label8.TabIndex = 48;
            label8.Text = "Tarihe Göre Öğünlerimi Listele";
            // 
            // dtpTakvim
            // 
            dtpTakvim.CalendarFont = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dtpTakvim.CalendarTitleBackColor = SystemColors.ActiveBorder;
            dtpTakvim.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            dtpTakvim.Location = new Point(116, 107);
            dtpTakvim.Margin = new Padding(4, 5, 4, 5);
            dtpTakvim.Name = "dtpTakvim";
            dtpTakvim.Size = new Size(455, 34);
            dtpTakvim.TabIndex = 46;
            dtpTakvim.ValueChanged += dtpTakvim_ValueChanged;
            // 
            // gboBesinDegerleri
            // 
            gboBesinDegerleri.BackColor = Color.Transparent;
            gboBesinDegerleri.Controls.Add(pbYag);
            gboBesinDegerleri.Controls.Add(pbProtein);
            gboBesinDegerleri.Controls.Add(pbKarbonhidrat);
            gboBesinDegerleri.Controls.Add(lblYag);
            gboBesinDegerleri.Controls.Add(label5);
            gboBesinDegerleri.Controls.Add(lblProtein);
            gboBesinDegerleri.Controls.Add(lblKarbonhidrat);
            gboBesinDegerleri.Controls.Add(label7);
            gboBesinDegerleri.Controls.Add(label3);
            gboBesinDegerleri.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            gboBesinDegerleri.ForeColor = Color.Black;
            gboBesinDegerleri.Location = new Point(126, 524);
            gboBesinDegerleri.Margin = new Padding(4);
            gboBesinDegerleri.Name = "gboBesinDegerleri";
            gboBesinDegerleri.Padding = new Padding(4);
            gboBesinDegerleri.Size = new Size(576, 401);
            gboBesinDegerleri.TabIndex = 50;
            gboBesinDegerleri.TabStop = false;
            gboBesinDegerleri.Text = "Toplam Alınan Besin Değerleri";
            // 
            // pbYag
            // 
            pbYag.Location = new Point(22, 321);
            pbYag.Margin = new Padding(4);
            pbYag.Name = "pbYag";
            pbYag.Size = new Size(485, 31);
            pbYag.TabIndex = 23;
            // 
            // pbProtein
            // 
            pbProtein.Location = new Point(22, 198);
            pbProtein.Margin = new Padding(4);
            pbProtein.Name = "pbProtein";
            pbProtein.Size = new Size(485, 31);
            pbProtein.TabIndex = 21;
            // 
            // pbKarbonhidrat
            // 
            pbKarbonhidrat.Location = new Point(22, 70);
            pbKarbonhidrat.Margin = new Padding(4);
            pbKarbonhidrat.Name = "pbKarbonhidrat";
            pbKarbonhidrat.Size = new Size(485, 31);
            pbKarbonhidrat.TabIndex = 20;
            // 
            // pbKalori
            // 
            pbKalori.Location = new Point(18, 62);
            pbKalori.Margin = new Padding(4);
            pbKalori.Name = "pbKalori";
            pbKalori.Size = new Size(405, 37);
            pbKalori.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(pbKalori);
            groupBox1.Controls.Add(lblToplamKalori);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(728, 606);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(442, 188);
            groupBox1.TabIndex = 51;
            groupBox1.TabStop = false;
            groupBox1.Text = "Toplam Kalori";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.OgunlerimFormGuncel;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.MaximumSize = new Size(1639, 943);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // OgunlerimForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(groupBox1);
            Controls.Add(gboBesinDegerleri);
            Controls.Add(label8);
            Controls.Add(dtpTakvim);
            Controls.Add(dgvOgunler);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(1661, 999);
            Name = "OgunlerimForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğünlerim Form";
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).EndInit();
            gboBesinDegerleri.ResumeLayout(false);
            gboBesinDegerleri.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOgunler;
        private Label lblToplamKalori;
        private Label lblProtein;
        private Label label3;
        private Label lblKarbonhidrat;
        private Label label5;
        private Label lblYag;
        private Label label7;
        private Label label2;
        private Label label8;
        private DateTimePicker dtpTakvimBitis;
        private DateTimePicker dtpTakvim;
        private GroupBox gboBesinDegerleri;
        private ProgressBar pbKarbonhidrat;
        private ProgressBar pbYag;
        private ProgressBar pbProtein;
        private ProgressBar pbKalori;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private PictureBox pictureBox1;
    }
}