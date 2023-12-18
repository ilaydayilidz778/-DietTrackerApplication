using EFDiyetUygulamasi.BL.Repositories;
using EFDiyetUygulamasi.DAL.Entities;
using EFDiyetUygulamasi.PL.View;
using Microsoft.EntityFrameworkCore;
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
    public partial class YoneticiKullaniciForm : Form
    {
        List<Kullanici> kullaniciList;
        List<Kullanici> pasifKullaniciList = new();
        private readonly Repository<Kullanici> KullaniciRepository;
        private readonly Repository<OgunBilgisi> OgunBilgileriRepository;

        public YoneticiKullaniciForm(Repository<Kullanici> kullaniciRepository, Repository<OgunBilgisi> ogunBilgileriRepository)
        {
            InitializeComponent();
            KullaniciRepository = kullaniciRepository;
            OgunBilgileriRepository = ogunBilgileriRepository;
            TumKullanicilariListele();
            PasifKullanicilariListele();
        }

        private void PasifKullanicilariListele()
        {
            var kullaniciList = KullaniciRepository
                            .HepsiniEgarLoadingleGetir()
                            .AsNoTracking()
                            .ToList();

            foreach(var kullanici in kullaniciList)
            {
                var sonOgunBilgisi = OgunBilgileriRepository
                    .HepsiniEgarLoadingleGetir()
                    .AsNoTracking()
                    .Where(a => a.KullaniciId == kullanici.Id)
                    .OrderByDescending(x => x.Tarih)
                    .FirstOrDefault();
                if (sonOgunBilgisi == null)
                {
                    continue;
                }
                if (sonOgunBilgisi.Tarih.Date <= DateTime.Now.AddDays(-15))
                {
                    pasifKullaniciList.Add(sonOgunBilgisi.Kullanici);
                }
            }
            var pasifKullaniciProfilViewList = new List<KullaniciProfilView>();
            foreach (var kullanici in pasifKullaniciList)
            {
                if (kullanici.KullaniciProfil != null)
                {
                    var kullaniciProfilView = new KullaniciProfilView()
                    {
                        Id = kullanici.Id,
                        Email = kullanici.Email,
                        Sifre = kullanici.Sifre,
                        Ad = kullanici.KullaniciProfil.Ad,
                        Soyad = kullanici.KullaniciProfil.Soyad,
                        Boy = kullanici.KullaniciProfil.Boy,
                        Kilo = kullanici.KullaniciProfil.Kilo,
                        Yas = kullanici.KullaniciProfil.Yas,
                        Cinsiyet = kullanici.KullaniciProfil.Cinsiyet
                    };
                    pasifKullaniciProfilViewList.Add(kullaniciProfilView);
                }
            }
            dgvPasifKullanicilar.DataSource = pasifKullaniciProfilViewList;
        }

        private void TumKullanicilariListele()
        {
            kullaniciList = KullaniciRepository
                    .HepsiniEgarLoadingleGetir()
                    .AsNoTracking()
                    .ToList();
            var KullaniciProfilViewList = new List<KullaniciProfilView>();
            foreach(var kullanici in kullaniciList)
            {
                if(kullanici.KullaniciProfil != null)
                {
                    var kullaniciProfilView = new KullaniciProfilView()
                    {
                        Id = kullanici.Id,
                        Email = kullanici.Email,
                        Sifre = kullanici.Sifre,
                        Ad = kullanici.KullaniciProfil.Ad,
                        Soyad = kullanici.KullaniciProfil.Soyad,
                        Boy = kullanici.KullaniciProfil.Boy,
                        Kilo = kullanici.KullaniciProfil.Kilo,
                        Yas = kullanici.KullaniciProfil.Yas,
                        Cinsiyet = kullanici.KullaniciProfil.Cinsiyet
                    };
                    KullaniciProfilViewList.Add(kullaniciProfilView);
                }
            }
            dgvKullanicilar.DataSource = KullaniciProfilViewList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string hashedSifre = sha256_hash(sifre);
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            if (email == "" || sifre == ""|| ad == "" || soyad == "" || (rbErkek.Checked == false && rbKadin.Checked == false))
            {
                MessageBox.Show("Tüm alanları uygun şekilde doldurunuz");
                return;
            }
            if (KullaniciRepository.HepsiniGetir().FirstOrDefault(k => k.Email == email) != null)
            {
                MessageBox.Show("Bu E-mail kullanımda!");
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
            MessageBox.Show("Kullanıcı Kaydı Başarılı");
            TumKullanicilariListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.Rows.Count > 0)
            {
                Kullanici silinecek = new Kullanici();
                 silinecek.Id = ((KullaniciProfilView)dgvKullanicilar.SelectedRows[0].DataBoundItem).Id;

                KullaniciRepository.Sil(silinecek.Id);
                MessageBox.Show("Kullanıcı başarıyla silindi");
                TumKullanicilariListele();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
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
