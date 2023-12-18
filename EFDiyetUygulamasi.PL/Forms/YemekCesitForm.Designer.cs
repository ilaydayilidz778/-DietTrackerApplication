namespace EFDiyetUygulamasi.PL
{
    partial class YemekCesitForm
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
            cboBesinler = new ComboBox();
            cboKategoriler = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgvOgunSiralama = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dgvBesinler = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label3 = new Label();
            label4 = new Label();
            btnGoster = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvOgunSiralama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBesinler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cboBesinler
            // 
            cboBesinler.FormattingEnabled = true;
            cboBesinler.Location = new Point(112, 126);
            cboBesinler.Name = "cboBesinler";
            cboBesinler.Size = new Size(407, 33);
            cboBesinler.TabIndex = 0;
            // 
            // cboKategoriler
            // 
            cboKategoriler.FormattingEnabled = true;
            cboKategoriler.Location = new Point(112, 45);
            cboKategoriler.Name = "cboKategoriler";
            cboKategoriler.Size = new Size(407, 33);
            cboKategoriler.TabIndex = 1;
            cboKategoriler.SelectedIndexChanged += cboKategoriler_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(112, 14);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 2;
            label1.Text = "Kategoriler";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(112, 95);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 3;
            label2.Text = "Besinler";
            // 
            // dgvOgunSiralama
            // 
            dgvOgunSiralama.AllowUserToAddRows = false;
            dgvOgunSiralama.AllowUserToDeleteRows = false;
            dgvOgunSiralama.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgunSiralama.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgunSiralama.BackgroundColor = Color.LightGray;
            dgvOgunSiralama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunSiralama.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvOgunSiralama.Location = new Point(131, 325);
            dgvOgunSiralama.Name = "dgvOgunSiralama";
            dgvOgunSiralama.ReadOnly = true;
            dgvOgunSiralama.RowHeadersVisible = false;
            dgvOgunSiralama.RowHeadersWidth = 62;
            dgvOgunSiralama.Size = new Size(460, 576);
            dgvOgunSiralama.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "OgunAd";
            Column1.HeaderText = "Öğün Adı";
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
            // dgvBesinler
            // 
            dgvBesinler.AllowUserToAddRows = false;
            dgvBesinler.AllowUserToDeleteRows = false;
            dgvBesinler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBesinler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBesinler.BackgroundColor = Color.LightGray;
            dgvBesinler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBesinler.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4 });
            dgvBesinler.Location = new Point(611, 325);
            dgvBesinler.Name = "dgvBesinler";
            dgvBesinler.ReadOnly = true;
            dgvBesinler.RowHeadersVisible = false;
            dgvBesinler.RowHeadersWidth = 62;
            dgvBesinler.Size = new Size(453, 576);
            dgvBesinler.TabIndex = 5;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(214, 258);
            label3.Name = "label3";
            label3.Size = new Size(243, 28);
            label3.TabIndex = 6;
            label3.Text = "En Çok Tüketilen Öğünler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gold;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(621, 245);
            label4.Name = "label4";
            label4.Size = new Size(391, 56);
            label4.TabIndex = 7;
            label4.Text = "Tüm Öğünlerin En çok Tüketilen Besinleri \r\n(Tüm Kullanıcılar)";
            // 
            // btnGoster
            // 
            btnGoster.BackColor = SystemColors.ControlLight;
            btnGoster.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGoster.Location = new Point(112, 177);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(407, 36);
            btnGoster.TabIndex = 8;
            btnGoster.Text = "Göster";
            btnGoster.UseVisualStyleBackColor = false;
            btnGoster.Click += btnGoster_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.YemekCesitForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // YemekCesitForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(btnGoster);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvBesinler);
            Controls.Add(dgvOgunSiralama);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboKategoriler);
            Controls.Add(cboBesinler);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1661, 999);
            Name = "YemekCesitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Çeşit Form";
            ((System.ComponentModel.ISupportInitialize)dgvOgunSiralama).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBesinler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboBesinler;
        private ComboBox cboKategoriler;
        private Label label1;
        private Label label2;
        private DataGridView dgvOgunSiralama;
        private DataGridView dgvBesinler;
        private Label label3;
        private Label label4;
        private Button btnGoster;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox pictureBox1;
    }
}