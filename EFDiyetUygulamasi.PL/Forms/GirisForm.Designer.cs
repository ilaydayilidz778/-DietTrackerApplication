namespace EFDiyetUygulamasi.PL
{
    partial class GirisForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGirisYap = new Button();
            btnUyeOl = new Button();
            label3 = new Label();
            chcSifreyiGoster = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 553);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(461, 32);
            txtEmail.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(182, 646);
            txtSifre.Margin = new Padding(2);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(461, 32);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(182, 513);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(461, 29);
            label1.TabIndex = 2;
            label1.Text = "E-Mail";
            // 
            // label2
            // 
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(182, 607);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(461, 28);
            label2.TabIndex = 3;
            label2.Text = "Şifre";
            // 
            // btnGirisYap
            // 
            btnGirisYap.BackColor = SystemColors.ControlLight;
            btnGirisYap.Location = new Point(182, 760);
            btnGirisYap.Margin = new Padding(2);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(461, 38);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = SystemColors.ControlLight;
            btnUyeOl.Location = new Point(182, 868);
            btnUyeOl.Margin = new Padding(2);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(461, 38);
            btnUyeOl.TabIndex = 5;
            btnUyeOl.Text = "Üye Ol";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gold;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(332, 829);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 6;
            label3.Text = "Üye değil misin?";
            // 
            // chcSifreyiGoster
            // 
            chcSifreyiGoster.AutoSize = true;
            chcSifreyiGoster.BackColor = Color.Transparent;
            chcSifreyiGoster.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            chcSifreyiGoster.ForeColor = SystemColors.ActiveCaptionText;
            chcSifreyiGoster.Location = new Point(182, 698);
            chcSifreyiGoster.Margin = new Padding(2);
            chcSifreyiGoster.Name = "chcSifreyiGoster";
            chcSifreyiGoster.Size = new Size(146, 29);
            chcSifreyiGoster.TabIndex = 7;
            chcSifreyiGoster.Text = "Şifreyi Göster";
            chcSifreyiGoster.UseVisualStyleBackColor = false;
            chcSifreyiGoster.CheckedChanged += chcSifreyiGoster_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.GirisFormBackGround;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1639, 943);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // GirisForm
            // 
            AcceptButton = btnGirisYap;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1639, 943);
            Controls.Add(chcSifreyiGoster);
            Controls.Add(label3);
            Controls.Add(btnUyeOl);
            Controls.Add(btnGirisYap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2);
            MaximumSize = new Size(1661, 999);
            Name = "GirisForm";
            Text = "Uygulama Giriş Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSifre;
        private Label label1;
        private Label label2;
        private Button btnGirisYap;
        private Button btnUyeOl;
        private Label label3;
        private CheckBox chcSifreyiGoster;
        private PictureBox pictureBox1;
    }
}
