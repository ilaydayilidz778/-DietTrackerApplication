namespace EFDiyetUygulamasi.PL
{
    partial class GrafikForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            chrtGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)chrtGrafik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // chrtGrafik
            // 
            chrtGrafik.BorderlineColor = Color.LightGray;
            chartArea1.Name = "ChartArea1";
            chrtGrafik.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chrtGrafik.Legends.Add(legend1);
            chrtGrafik.Location = new Point(131, 248);
            chrtGrafik.Name = "chrtGrafik";
            chrtGrafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Kalori";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Protein";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Yağ";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "KarbonHidrat";
            chrtGrafik.Series.Add(series1);
            chrtGrafik.Series.Add(series2);
            chrtGrafik.Series.Add(series3);
            chrtGrafik.Series.Add(series4);
            chrtGrafik.Size = new Size(1000, 683);
            chrtGrafik.TabIndex = 0;
            chrtGrafik.Text = "chart1";
            title1.Name = "ToplamDeger";
            title1.Text = "Toplam Değerler";
            chrtGrafik.Titles.Add(title1);
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(131, 77);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(412, 31);
            dtpBaslangic.TabIndex = 1;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(131, 160);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(412, 31);
            dtpBitis.TabIndex = 2;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.GrafikForm;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            label7.TabIndex = 47;
            label7.Text = "Bitiş Tarihi";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Gold;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label8.Location = new Point(131, 37);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 46;
            label8.Text = "Başlangıç Tarihi";
            // 
            // GrafikForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(chrtGrafik);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(1661, 999);
            Name = "GrafikForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grafik Form";
            ((System.ComponentModel.ISupportInitialize)chrtGrafik).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGrafik;
        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label8;
    }
}