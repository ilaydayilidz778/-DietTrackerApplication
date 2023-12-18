using EFDiyetUygulamasi.BL.Repositories;
using EFDiyetUygulamasi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetUygulamasi.PL
{
    public partial class UyeForm : Form
    {
        private readonly Repository<Kullanici> KullaniciRepository;

        public UyeForm(Repository<Kullanici> kullaniciRepository)
        {
            InitializeComponent();
            KullaniciRepository = kullaniciRepository;
        }

        private void btnUyeKaydet_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string hashedSifre = sha256_hash(sifre);
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            if (email == "" || sifre == "" || ad == "" || soyad == "" || (rbErkek.Checked == false && rbKadin.Checked == false))
            {
                MessageBox.Show("Tüm alanları uygun şekilde doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (KullaniciRepository.HepsiniGetir().FirstOrDefault(k => k.Email == email) != null)
            {
                MessageBox.Show("Bu E-mail kullanımda!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Kullanici yeni = new Kullanici() { Email = email, Sifre = hashedSifre };
            KullaniciProfil yeniprofil = new KullaniciProfil() { Ad = ad, Soyad = soyad, Boy = (int)nudBoy.Value, Kilo = nudKilo.Value, Yas = (int)nudYas.Value };
            if (rbErkek.Checked)
            {
                yeniprofil.Cinsiyet = DAL.Enums.Cinsiyet.Erkek;
            }
            else
            {
                yeniprofil.Cinsiyet = DAL.Enums.Cinsiyet.Kadin;
            }
            yeni.KullaniciProfil = yeniprofil;
            KullaniciRepository.Ekle(yeni);
            MessageBox.Show("Kullanıcı Kaydı Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

            if (txtSifre.Text.Length <= 6)
            {
                lblSifreGucu.Text = "Zayıf!";
                lblSifreGucu.ForeColor = Color.Red;
                string gucluSifre = GuvenliSifreOner();
                lblOneriSifre.Text = $"Güçlü şifre önerisi: {gucluSifre}";
            }

            if (txtSifre.Text.Length > 6 && txtSifre.Text.Any(char.IsDigit))
            {
                lblSifreGucu.Text = "Orta";
                lblSifreGucu.ForeColor = Color.Orange;
            }
            if (txtSifre.Text.Length >= 10 && txtSifre.Text.Any(char.IsUpper) && txtSifre.Text.Any(char.IsDigit))
            {
                lblSifreGucu.Text = "Güçlü";
                lblSifreGucu.ForeColor = Color.Green;
            }
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private string GuvenliSifreOner(int uzunluk = 12)
        {
            const string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+[]{}|;:,.<>?";
            char[] sifre = new char[uzunluk];

            using (RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < uzunluk; i++)
                {
                    byte[] rastgeleBytes = new byte[1];
                    cryptoProvider.GetBytes(rastgeleBytes);
                    int rastgeleSayi = rastgeleBytes[0] % karakterler.Length;
                    sifre[i] = karakterler[rastgeleSayi];
                }
            }

            return new string(sifre);
        }

        private void btnOneriSifreEkle_Click(object sender, EventArgs e)
        {
            txtSifre.Text = lblOneriSifre.Text.Substring(21);
        }
    }
}





