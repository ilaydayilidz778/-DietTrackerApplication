using EFDiyetUygulamasi.BL.Repositories;
using EFDiyetUygulamasi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetUygulamasi.PL
{
    public partial class ProfilForm : Form
    {

        private readonly Repository<Kullanici> _kullaniciRepository;
        private readonly Kullanici _kullanici;

        public ProfilForm(Kullanici kullanici, Repository<Kullanici> kullaniciRepository)
        {

            InitializeComponent();
            _kullanici = kullanici;
            _kullaniciRepository = kullaniciRepository;
            VerileriDoldur();
        }

        private void VerileriDoldur()
        {
            KullaniciProfil guncellenecekProfil = (_kullaniciRepository.IdYeGoreGetir(_kullanici.Id)).KullaniciProfil;
            txtEmail.Text = _kullanici.Email;
            txtAd.Text = guncellenecekProfil.Ad;
            txtSoyad.Text = guncellenecekProfil.Soyad;
            nudBoy.Value = guncellenecekProfil.Boy;
            nudKilo.Value = guncellenecekProfil.Kilo;
            nudYas.Value = guncellenecekProfil.Yas;
            if (guncellenecekProfil.Cinsiyet == DAL.Enums.Cinsiyet.Erkek)
            {
                rbErkek.Checked = true;
            }
            else
            {
                rbKadin.Checked = true;
            }
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            int boy = (int)nudBoy.Value;
            decimal kilo = nudKilo.Value;
            int yas = (int)nudYas.Value;
            if (email == null || sifre == null || ad == null || soyad == null || (rbErkek.Checked == false && rbKadin.Checked == false))
            {
                MessageBox.Show("Tüm alanları uygun şekilde doldurunuz");
                return;
            }
            var eskiKullanici = _kullaniciRepository.HepsiniGetir().FirstOrDefault(k => k.Email == email);
            if (eskiKullanici != null && eskiKullanici.Email != email)
            {
                MessageBox.Show("Bu E-mail kullanımda!");
                return;
            }
            if (sifre != _kullanici.Sifre && !string.IsNullOrEmpty(sifre))
            {
                _kullanici.Sifre = sha256_hash(sifre);
            }

            _kullanici.Email = email;
            _kullanici.KullaniciProfil.Ad = ad;
            _kullanici.KullaniciProfil.Soyad = soyad;
            _kullanici.KullaniciProfil.Boy = boy;
            _kullanici.KullaniciProfil.Kilo = kilo;
            _kullanici.KullaniciProfil.Yas = yas;

            if (rbErkek.Checked)
            {
                _kullanici.KullaniciProfil.Cinsiyet = DAL.Enums.Cinsiyet.Erkek;
            }
            else
            {
                _kullanici.KullaniciProfil.Cinsiyet = DAL.Enums.Cinsiyet.Kadin;
            }

            _kullaniciRepository.Guncelle(_kullanici);
            MessageBox.Show("Değişiklikler başarıyla güncellendi.");
            this.Close();
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
    }





}
