using EFDiyetUygulamasi.BL.Repositories;
using EFDiyetUygulamasi.DAL.Entities;
using System.Security.Cryptography;
using System.Text;

namespace EFDiyetUygulamasi.PL
{
    public partial class GirisForm : Form
    {
        Repository<Kullanici> KullaniciRepository = new Repository<Kullanici>();
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
                {
                    MessageBox.Show("Lütfen tüm alanlarý doldurunuz!");
                    return;
                }

                if (txtEmail.Text.Trim() == "admin" && txtSifre.Text.Trim() == "password")
                {
                    YoneticiForm yoneticiForm = new YoneticiForm();
                    this.Hide();
                    yoneticiForm.ShowDialog();
                    if (yoneticiForm.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                        txtEmail.Clear();
                        txtSifre.Clear();
                    }
                    else
                    {
                        this.Close();
                    }
                }

                Kullanici kullanici = KullaniciRepository.HepsiniGetir().FirstOrDefault(k => k.Email == txtEmail.Text.Trim());

                if (kullanici != null && kullanici.Sifre == sha256_hash(txtSifre.Text.Trim()))
                {
                    AnaForm anafrm = new AnaForm(kullanici, KullaniciRepository);
                    this.Hide();
                    anafrm.ShowDialog();
                    if (anafrm.DialogResult == DialogResult.OK)
                    {
                        this.Show();
                        txtEmail.Clear();
                        txtSifre.Clear();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (kullanici != null && kullanici.Sifre != sha256_hash(txtSifre.Text.Trim()))
                {
                    MessageBox.Show("Þifre Yanlýþ!");
                }
                else
                {
                    MessageBox.Show("Böyle bir kullanýcý bulunamadý!");
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }


        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            try
            {
                UyeForm uyefrm = new UyeForm(KullaniciRepository);
                uyefrm.ShowDialog();
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void chcSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txtSifre.UseSystemPasswordChar = !chcSifreyiGoster.Checked;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }

        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void HandleException(Exception ex)
        {
            MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
