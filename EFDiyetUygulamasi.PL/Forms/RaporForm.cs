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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDiyetUygulamasi.PL
{
    public partial class RaporForm : Form
    {
        private readonly Kullanici _kullanici;
        private readonly Repository<OgunBilgisi> OgunBilgileriRepository;
        List<OgunBilgisi> ogunBilgisiList;
        public RaporForm(Kullanici kullanici, Repository<OgunBilgisi> ogunBilgileriRepository)
        {
            _kullanici = kullanici;
            OgunBilgileriRepository = ogunBilgileriRepository;
            InitializeComponent();

            dtpTakvimBitis.MinDate = new DateTime(2023, 1, 1);
            dtpTakvimBitis.MaxDate = DateTime.Now;

            dtpTakvimBaslangic.MinDate = new DateTime(2023, 1, 1);
            dtpTakvimBaslangic.MaxDate = DateTime.Now;

            dgvOgunlerOzeti.AutoGenerateColumns = false;
            ogunBilgisiList = new List<OgunBilgisi>();

            SecilenTarihAraliğindakiOgunleriYukle();
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
            SecilenTarihAraliğindakiOgunleriYukle();
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
            SecilenTarihAraliğindakiOgunleriYukle();
        }

        private void SecilenTarihAraliğindakiOgunleriYukle()
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value; ;
            if (baslangicTarihi > DateTime.Now || bitisTarihi > DateTime.Now)
            {
                MessageBox.Show("İleri tarihli bir aralık seçilemez!", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking().ToList()
                .Where(ob => ob.KullaniciId == _kullanici.Id)
                .Where(ob => ob.Tarih.Day >= baslangicTarihi.Day && ob.Tarih.Day <= bitisTarihi.Day)
                .OrderByDescending(ob => ob.Tarih.Day)
                .ToList();
            dgvOgunlerOzeti.DataSource = ogunBilgisiList;

            var ogunBesinViewList = new List<OgunBesinView>();
            foreach (var ogunBilgisi in ogunBilgisiList)
            {
                if (ogunBilgisi.Besin != null)
                {
                    var ogunBesinView = new OgunBesinView
                    {
                        OgunBilgisiID = ogunBilgisi.Id,
                        OgunAdi = ogunBilgisi.Ogun.Ad,
                        BesinAdi = ogunBilgisi.Besin.Ad,
                        Protein = ogunBilgisi.Besin.Protein,
                        Yag = ogunBilgisi.Besin.Yag,
                        Karbonhidrat = ogunBilgisi.Besin.Karbonhidrat,
                        Tarih = ogunBilgisi.Tarih,
                        Kalori = ogunBilgisi.Besin.Kalori,
                        Porsiyon = ogunBilgisi.Porsiyon
                    };

                    ogunBesinViewList.Add(ogunBesinView);
                }
            }
            dgvOgunlerOzeti.DataSource = ogunBesinViewList;
            OrtalamaDegerleriHesapla();
        }

        private void OrtalamaDegerleriHesapla()
        {
            DateTime baslangicTarihi = dtpTakvimBaslangic.Value;
            DateTime bitisTarihi = dtpTakvimBitis.Value;
            pbKarbonhidrat.Value = 0;
            pbProtein.Value = 0;
            pbYag.Value = 0;
            pbKalori.Value = 0;

            decimal toplamKarbonhidrat = 0;
            decimal toplamProtein = 0;
            decimal toplamYag = 0;
            int toplamKalori = 0;

            foreach (var ogunBilgisi in ogunBilgisiList)
            {
                if (ogunBilgisi.Besin != null)
                {
                    toplamProtein += ogunBilgisi.Besin.Protein * ogunBilgisi.Porsiyon;
                    toplamKarbonhidrat += ogunBilgisi.Besin.Karbonhidrat * ogunBilgisi.Porsiyon;
                    toplamYag += ogunBilgisi.Besin.Yag * ogunBilgisi.Porsiyon;
                    toplamKalori += ogunBilgisi.Besin.Kalori * ogunBilgisi.Porsiyon;
                }
            }

            // Ortalama değerleri hesapla
            int gunSayisi = (bitisTarihi - baslangicTarihi).Days + 1;
            decimal ortalamaKarbonhidrat = toplamKarbonhidrat / gunSayisi;
            decimal ortalamaProtein = toplamProtein / gunSayisi;
            decimal ortalamaYag = toplamYag / gunSayisi;
            int ortalamaKalori = toplamKalori / gunSayisi;

            //Günlük alınan karbonhidrat değerleri için
            pbKarbonhidrat.Maximum = 125;
            pbKarbonhidrat.Value = Math.Min((int)ortalamaKarbonhidrat, pbKarbonhidrat.Maximum);
            lblKarbonhidrat.Text = $"Ortalama Karbonhidrat: {ortalamaKarbonhidrat:N2} gram";

            //Günlük alınan protein değerleri için
            pbProtein.Maximum = 50;
            pbProtein.Value = Math.Min((int)ortalamaProtein, pbProtein.Maximum);
            lblProtein.Text = $"Ortalama Protein: {ortalamaProtein:N2} gram";

            //Günlük alınan yağ değerleri için
            pbYag.Maximum = 60;
            pbYag.Value = Math.Min((int)ortalamaYag, pbYag.Maximum);
            lblYag.Text = $"Ortalama Yağ: {ortalamaYag:N2} gram.";

            //Günlük alınan kalori değerleri için
            pbKalori.Maximum = 1750;
            pbKalori.Value = Math.Min((int)ortalamaKalori, pbKalori.Maximum);
            lblToplamKalori.Text = $"Ortalama Kalori: {ortalamaKalori} kcal.";
        }

    }
}











