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
    public partial class YemekCesitForm : Form
    {
        private readonly Kullanici Kullanici;
        private readonly Repository<Kategori> KategoriRepository;
        private readonly Repository<Ogun> OgunRepository;
        private readonly Repository<Besin> BesinlerRepository;
        private readonly Repository<OgunBilgisi> OgunBilgileriRepository;

        public YemekCesitForm(Kullanici kullanici,
            Repository<Kategori> kategoriRepository,
            Repository<Ogun> ogunRepository,
            Repository<Besin> besinlerRepository,
            Repository<OgunBilgisi> ogunBilgileriRepository)
        {
            InitializeComponent();
            Kullanici = kullanici;
            KategoriRepository = kategoriRepository;
            OgunRepository = ogunRepository;
            BesinlerRepository = besinlerRepository;
            OgunBilgileriRepository = ogunBilgileriRepository;
            KategorileriYukle();
            TumBesinleriYukle();
        }

        private void TumBesinleriYukle()
        {

            
            var ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking().ToList();

            var enCokTekrarEdenList = ogunBilgisiList
                .GroupBy(ob => ob.Besin.Ad)
                .OrderByDescending(grup => grup.Count())
                .Select(ob => new { BesinAd = ob.Key, TekrarSayisi = ob.Count() })
                .ToList();

            dgvBesinler.DataSource = enCokTekrarEdenList;
        }

        private void KategorileriYukle()
        {
            cboKategoriler.DataSource = KategoriRepository.HepsiniGetir();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            var ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking().ToList()
               .Where(ob => ob.KullaniciId == Kullanici.Id)
               .ToList();

            var enCokTekrarEdenList = ogunBilgisiList
                .Where(ob => ob.BesinId == ((Besin)cboBesinler.SelectedItem).Id)
                .GroupBy(ob => ob.Ogun.Ad)
                .OrderByDescending(grup => grup.Count())
                .Select(ob => new { OgunAd = ob.Key, TekrarSayisi = ob.Count() })
                .ToList();

            dgvOgunSiralama.DataSource = enCokTekrarEdenList;
        }

        private void cboKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            BesinleriYukle();
        }

        private void BesinleriYukle()
        {
            cboBesinler.DataSource = BesinlerRepository.HepsiniGetir().Where(b => b.KategoriId == ((Kategori)cboKategoriler.SelectedItem).Id).ToList();
        }
    }
}
