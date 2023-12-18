using EFDiyetUygulamasi.BL.Repositories;
using EFDiyetUygulamasi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetUygulamasi.PL
{
    public partial class KiyasForm : Form
    {
        private readonly Kullanici _kullanici;
        private readonly Repository<Kategori> KategorilerRepository;
        private readonly Repository<Ogun> OgunlerRepository;
        private readonly Repository<OgunBilgisi> OgunBilgileriRepository;
        Repository<Besin> BesinlerRepository = new Repository<Besin>();
        public KiyasForm(Kullanici kullanici, Repository<Kategori> kategorilerRepository, Repository<Ogun> ogunlerRepository, Repository<OgunBilgisi> ogunBilgileriRepository)
        {
            InitializeComponent();

            dtpTakvimBaslangic.MinDate = new DateTime(2023, 1, 1);
            dtpTakvimBaslangic.MaxDate = DateTime.Now;

            dtpTakvimBitis.MinDate = new DateTime(2023, 1, 1);
            dtpTakvimBitis.MaxDate = DateTime.Now;


            _kullanici = kullanici;
            KategorilerRepository = kategorilerRepository;
            OgunlerRepository = ogunlerRepository;
            OgunBilgileriRepository = ogunBilgileriRepository;
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            cboOgunler.DataSource = OgunlerRepository.HepsiniGetir().ToList(); ;
            cboKategoriler.DataSource = KategorilerRepository.HepsiniGetir().ToList();
        }

        private void KullaniciBazliOguneGoreSonuclariniGetir()
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value; ;
            if (baslangicTarihi > DateTime.Now || bitisTarihi > DateTime.Now)
            {
                MessageBox.Show("İleri tarihli bir aralık seçilemez!");
                return;
            }
            var ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking()
               .Where(ob => ob.KullaniciId == _kullanici.Id && ob.Tarih.Day >= baslangicTarihi.Day && ob.Tarih.Day <= bitisTarihi.Day)
               .OrderByDescending(ob => ob.Tarih.Day)
               .ToList();

            var enCokTekrarEden = ogunBilgisiList
                .Where(ob => ob.Ogun.Ad == ((Ogun)(cboOgunler.SelectedItem)).Ad)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .ToList()
                .FirstOrDefault();

            var enCokTekrarEdenList = ogunBilgisiList
                .Where(ob => ob.Ogun.Ad == ((Ogun)(cboOgunler.SelectedItem)).Ad)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .Select(ob => new { BesinAd = ob.Key, TekrarSayisi = ob.Count() })
                .ToList();

            dgvKullaniciSiralama.DataSource = enCokTekrarEdenList;

            if (enCokTekrarEden != null)
            {
                string enCokYenilenYiyecek = enCokTekrarEden.Key;
                int tekrarSayisi = enCokTekrarEden.Count();
                lblOgunKullanici.Text = $"Bu süreçte {((Ogun)cboOgunler.SelectedItem).Ad} öğününde en çok yenen yiyecek: \n{enCokYenilenYiyecek} ({tekrarSayisi} kez)";
            }
        }

        private void TumKullanicilarBazliOguneGoreSonuclariniGetir()
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value; ;
            if (baslangicTarihi > DateTime.Now || bitisTarihi > DateTime.Now)
            {
                MessageBox.Show("İleri tarihli bir aralık seçilemez!");
                return;
            }
            var ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking()
               .Where(ob => ob.Tarih.Date >= baslangicTarihi.Date && ob.Tarih.Date <= bitisTarihi.Date)
               .OrderByDescending(ob => ob.Tarih.Date)
               .ToList();

            var enCokTekrarEden = ogunBilgisiList
                .Where(ob => ob.OgunId == ((Ogun)(cboOgunler.SelectedItem)).Id)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .ToList()
                .FirstOrDefault();

            var enCokTekrarEdenList = ogunBilgisiList
                .Where(ob => ob.OgunId == ((Ogun)(cboOgunler.SelectedItem)).Id)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .Select(ob => new { BesinAd = ob.Key, TekrarSayisi = ob.Count() })
                .ToList();

            dgvTumSiralama.DataSource = enCokTekrarEdenList;


            if (enCokTekrarEden != null)
            {
                string enCokYenilenYiyecek = enCokTekrarEden.Key;
                int tekrarSayisi = enCokTekrarEden.Count();
                lblOgunTumKullanici.Text = $"Bu süreçte {((Ogun)cboOgunler.SelectedItem).Ad} öğününde en çok yenen yiyecek: \n{enCokYenilenYiyecek} ({tekrarSayisi} kez)";
            }
            else
            {
                lblOgunTumKullanici.Text = "Bu öğünde en çok tekrar eden besin yok!";
            }


        }

        private void btnOguneGoreListele_Click(object sender, EventArgs e)
        {
            TumKullanicilarBazliOguneGoreSonuclariniGetir();
            KullaniciBazliOguneGoreSonuclariniGetir();
        }

        private void dtpTakvimBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value; ;
            if (baslangicTarihi > bitisTarihi)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden büyük olamaz!");
                return;
            }
        }

        private void dtpTakvimBitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value; ;
            if (baslangicTarihi > bitisTarihi)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden büyük olamaz!");
                return;
            }
        }

        private void btnKategoriyeGoreListele_Click(object sender, EventArgs e)
        {
            TumKullanicilarBazliKategoriyeGoreSonuclariGetir();
            KullaniciBazliKategoriyeGoreSonuclariniGetir();
        }

        private void KullaniciBazliKategoriyeGoreSonuclariniGetir()
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value; ;
            if ( baslangicTarihi > DateTime.Now || bitisTarihi > DateTime.Now)
            {
                MessageBox.Show("İleri tarihli bir aralık seçilemez!");
                return;
            }
            var ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking()
               .Where(ob => ob.KullaniciId == _kullanici.Id && ob.Tarih.Date >= baslangicTarihi.Date && ob.Tarih.Date <= bitisTarihi.Date)
               .OrderByDescending(ob => ob.Tarih.Date)
               .ToList();

            var enCokTekrarEden = ogunBilgisiList
                .Where(ob => ob.Besin.KategoriId == ((Kategori)cboKategoriler.SelectedItem).Id)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .ToList()
                .FirstOrDefault();

            var enCokTekrarEdenList = ogunBilgisiList
                .Where(ob => ob.Besin.KategoriId == ((Kategori)cboKategoriler.SelectedItem).Id)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .Select(ob => new { BesinAd = ob.Key, TekrarSayisi = ob.Count() })
                .ToList();

            // DataGridView'e enCokTekrarEden listesini bağlayarak gösterme işlemi

            dgvKullaniciSiralama.DataSource = enCokTekrarEdenList;


            if (enCokTekrarEden != null)
            {
                string enCokYenilenYiyecek = enCokTekrarEden.Key;
                int tekrarSayisi = enCokTekrarEden.Count();
                lblKategoriKullanici.Text = $"Bu süreçte {(Kategori)cboKategoriler.SelectedItem} öğününde en çok yenen yiyecek: \n{enCokYenilenYiyecek} ({tekrarSayisi} kez)";
            }
            else
            {
                lblKategoriKullanici.Text = "Bu öğünde en çok tekrar eden besin yok";
            }
        }

        private void TumKullanicilarBazliKategoriyeGoreSonuclariGetir()
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value; ;
            if (baslangicTarihi > DateTime.Now || bitisTarihi > DateTime.Now)
            {
                MessageBox.Show("İleri tarihli bir aralık seçilemez!");
                return;
            }
            var ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking()
               .Where(ob => ob.Tarih.Date >= baslangicTarihi.Date && ob.Tarih.Date <= bitisTarihi.Date)
               .OrderByDescending(ob => ob.Tarih.Date)
               .ToList();

            var enCokTekrarEden = ogunBilgisiList
                .Where(ob => ob.Besin.KategoriId == ((Kategori)cboKategoriler.SelectedItem).Id)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .ToList()
                .FirstOrDefault();

            var enCokTekrarEdenList = ogunBilgisiList
                .Where(ob => ob.Besin.KategoriId == ((Kategori)cboKategoriler.SelectedItem).Id)
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .Select(ob => new { BesinAd = ob.Key, TekrarSayisi = ob.Count() })
                .ToList();

            // DataGridView'e enCokTekrarEden listesini bağlayarak gösterme işlemi

            dgvTumSiralama.DataSource = enCokTekrarEdenList;


            if (enCokTekrarEden != null)
            {
                string enCokYenilenYiyecek = enCokTekrarEden.Key;
                int tekrarSayisi = enCokTekrarEden.Count();
                lblKategoriTumKullanici.Text = $"Bu süreçte {(Kategori)cboKategoriler.SelectedItem} öğününde en çok yenen yiyecek: \n{enCokYenilenYiyecek} ({tekrarSayisi} kez)";
            }
            else
            {
                lblKategoriTumKullanici.Text = "Bu öğünde en çok tekrar eden besin yok";
            }
        }
    }
}


