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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EFDiyetUygulamasi.PL
{
    public partial class OgunlerimForm : Form
    {
        private readonly Kullanici _kullanici;
        private readonly Repository<OgunBilgisi> OgunBilgileriRepository;
        List<OgunBilgisi> ogunBilgisiList;
        public OgunlerimForm(Kullanici kullanici, Repository<OgunBilgisi> ogunBilgileriRepository)
        {
            _kullanici = kullanici;
            OgunBilgileriRepository = ogunBilgileriRepository;
            InitializeComponent();
            dgvOgunler.AutoGenerateColumns = false;

            dtpTakvim.MinDate = new DateTime(2023, 1, 1);
            dtpTakvim.MaxDate = DateTime.Now;

            // ogunBilgisiList'i başlat
            ogunBilgisiList = new List<OgunBilgisi>();

            OgunleriYukle();
            ProgressBarDeğerleriniGuncelle();
        }
        private void dtpTakvim_ValueChanged(object sender, EventArgs e)
        {
            OgunleriYukle();
            ProgressBarDeğerleriniGuncelle();
        }

        private void OgunleriYukle()
        {
            ogunBilgisiList = OgunBilgileriRepository
                .HepsiniEgarLoadingleGetir()
                .AsNoTracking()
               .Where(ob => ob.KullaniciId == _kullanici.Id && ob.Tarih.Day == dtpTakvim.Value.Day)
               .ToList();

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
                        Kalori = ogunBilgisi.Besin.Kalori,
                        Tarih = ogunBilgisi.Tarih,
                        Porsiyon = ogunBilgisi.Porsiyon
                    };

                    ogunBesinViewList.Add(ogunBesinView);
                }
            }
            dgvOgunler.DataSource = ogunBesinViewList;
        }

        private void ProgressBarDeğerleriniGuncelle()
        {
            //Başlangıçta sıfır değerlerini atayalım
            pbKarbonhidrat.Value = 0;
            pbProtein.Value = 0;
            pbYag.Value = 0;
            pbKalori.Value = 0;

            decimal toplamKarbonhidrat = 0;
            decimal toplamProtein = 0;
            decimal toplamYag = 0;
            int toplamKalori = 0;

            ogunBilgisiList = OgunBilgileriRepository.HepsiniEgarLoadingleGetir().AsNoTracking()
               .Where(ob => ob.KullaniciId == _kullanici.Id && ob.Tarih.Date == dtpTakvim.Value.Date)
               .ToList();

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

            //Günlük alınan karbonhidrat değerleri için
            pbKarbonhidrat.Maximum = (int)KarbonhidratHesapla(_kullanici);
            pbKarbonhidrat.Value = Math.Min((int)toplamKarbonhidrat, pbKarbonhidrat.Maximum);
            decimal kalanKarbonhidrat = pbKarbonhidrat.Maximum - toplamKarbonhidrat;
            if (kalanKarbonhidrat >= 0)
            {
                lblKarbonhidrat.Text = $"Alınan Karbonhidrat Miktarı: {toplamKarbonhidrat} gram. " +
                   $"\n Alınması Gereken Karbonhidrat Miktarı: {kalanKarbonhidrat} gram";
            }
            else
            {

                lblKarbonhidrat.Text = $"Alınması gereken karbonhidrat miktarı maksimum ({(int)KarbonhidratHesapla(_kullanici)} gram) değeri aştı. " +
                  $"\nAlınan Karbonhidrat Miktarı :{toplamKarbonhidrat} gram";
            }

            //Günlük alınan protein değerleri için
            pbProtein.Maximum = (int)ProteinHesapla(_kullanici);
            pbProtein.Value = Math.Min((int)toplamProtein, pbProtein.Maximum);
            decimal kalanProtein = pbProtein.Maximum - toplamProtein;
            if (kalanProtein >= 0)
            {
                lblProtein.Text = $"Alınan Protein Miktarı: {toplamProtein} gram. " +
                    $"\n Alınması Gereken Protein Miktarı: {kalanProtein} gram";
            }
            else
            {
                lblProtein.Text = $"Alınması gereken protein miktarı maksimum ({(int)ProteinHesapla(_kullanici)} gram) değeri aştı. " +
                    $"\nAlınan Protein Miktarı :{toplamProtein}gram";
            }

            //Günlük alınan yağ değerleri için
            pbYag.Maximum = (int)YagHesapla(_kullanici);
            pbYag.Value = Math.Min((int)toplamYag, pbYag.Maximum);
            decimal kalanYag = pbYag.Maximum - toplamYag;
            if (kalanYag >= 0)
            {
                lblYag.Text = $"Alınan Yağ Miktarı: {toplamYag} gram. " +
                   $"\n Alınması Gereken Yağ Miktarı: {kalanYag} gram";
            }
            else
            {
                lblYag.Text = $"Alınması gereken yağ miktarı maksimum ({(int)YagHesapla(_kullanici)} gram) değeri aştı. " +
                  $"\nAlınan Yağ Miktarı :{toplamYag} gram";

            }

            //Günlük alınan kalori değerleri için
            pbKalori.Maximum = (int)KaloriHesapla(_kullanici);
            pbKalori.Value = Math.Min(toplamKalori, pbKalori.Maximum);
            decimal kalanKalori = pbKalori.Maximum - toplamKalori;
            if (kalanKalori >= 0)
            {
                lblToplamKalori.Text = $"Alınan Kalori Miktarı: {toplamKalori} kcal. " +
                   $"\n Alınması Gereken Kalori Miktarı: {kalanKalori} kcal";
            }
            else
            {
                lblToplamKalori.Text = $"Alınması gereken kaolri miktarı maksimum ({(int)KaloriHesapla(_kullanici)} kcal) değeri aştı. " +
                  $"\nAlınan Kalori Miktarı :{toplamKalori} kcal";
            }
        }

        public decimal KaloriHesapla(Kullanici kullanici)
        {
            if (kullanici.KullaniciProfil.Cinsiyet == DAL.Enums.Cinsiyet.Erkek)
            {
                return 66.5m + (13.75m * kullanici.KullaniciProfil.Kilo) + (5 * kullanici.KullaniciProfil.Boy) - (6.77m * kullanici.KullaniciProfil.Yas);
            }
            else
            {
                return 655.1m + (9.56m * kullanici.KullaniciProfil.Kilo) + (1.85m * kullanici.KullaniciProfil.Boy) - (4.67m * kullanici.KullaniciProfil.Yas);
            }
        }

        public decimal ProteinHesapla(Kullanici kullanici)
        {
            if (kullanici.KullaniciProfil.Cinsiyet == DAL.Enums.Cinsiyet.Erkek)
            {
                return kullanici.KullaniciProfil.Kilo * 0.8m;
            }
            else
            {
                return kullanici.KullaniciProfil.Kilo * 0.7m;
            }
        }

        public decimal YagHesapla(Kullanici kullanici)
        {
            if (kullanici.KullaniciProfil.Cinsiyet == DAL.Enums.Cinsiyet.Erkek)
            {
                return kullanici.KullaniciProfil.Kilo * 0.5m;
            }
            else
            {
                return kullanici.KullaniciProfil.Kilo * 0.4m;
            }
        }

        public decimal KarbonhidratHesapla(Kullanici kullanici)
        {
            if (kullanici.KullaniciProfil.Cinsiyet == DAL.Enums.Cinsiyet.Erkek)
            {
                return kullanici.KullaniciProfil.Kilo * 3;
            }
            else
            {
                return kullanici.KullaniciProfil.Kilo * 2;
            }
        }

    }
}
















