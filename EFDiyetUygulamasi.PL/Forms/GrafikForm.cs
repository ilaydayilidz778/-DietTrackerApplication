using EFDiyetUygulamasi.BL.Repositories;
using EFDiyetUygulamasi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace EFDiyetUygulamasi.PL
{
    public partial class GrafikForm : Form
    {
        private readonly Kullanici Kullanici;
        private readonly Repository<OgunBilgisi> OgunBilgileriRepository;

        public GrafikForm(Kullanici kullanici, Repository<OgunBilgisi> ogunBilgileriRepository)
        {
            InitializeComponent();
            dtpBaslangic.MinDate = new DateTime(2023, 1, 1);
            dtpBaslangic.MaxDate = DateTime.Now;

            dtpBitis.MinDate = new DateTime(2023, 1, 1);
            dtpBitis.MaxDate = DateTime.Now;
            Kullanici = kullanici;
            OgunBilgileriRepository = ogunBilgileriRepository;
            dtpBaslangic.Value = DateTime.Now.AddDays(-7);
            GrafikCiz();
        }


        private void GrafikCiz()
        {
            chrtGrafik.Series["Kalori"].Points.Clear();
            chrtGrafik.Series["Protein"].Points.Clear();
            chrtGrafik.Series["Yağ"].Points.Clear();
            chrtGrafik.Series["KarbonHidrat"].Points.Clear();

            var x = OgunBilgileriRepository
            .HepsiniEgarLoadingleGetir().AsNoTracking()
            .Where(x => x.Tarih.Date >= dtpBaslangic.Value.Date && x.Tarih.Date <= dtpBitis.Value.Date && x.KullaniciId == Kullanici.Id)
            .ToList();

            if (x != null && x.Count > 0)
            {
                // Her bir gün için toplam kaloriyi hesapla ve sadece bir etiket ekleyerek sütun grafiği oluştur
                foreach (var groupedItem in x.GroupBy(item => item.Tarih.Date))
                {
                    var totalKalori = groupedItem.Sum(a => a.Besin.Kalori * a.Porsiyon);
                    var totalProtein = Convert.ToDouble(groupedItem.Sum(a => a.Besin.Protein * a.Porsiyon));
                    var totalYag = Convert.ToDouble(groupedItem.Sum(a => a.Besin.Yag * a.Porsiyon));
                    var totalKarbonHidrat = Convert.ToDouble(groupedItem.Sum(a => a.Besin.Karbonhidrat * a.Porsiyon));

                    // Sütun grafiği ekle
                    var pointKalori = new DataPoint(groupedItem.Key.ToOADate(), totalKalori);
                    pointKalori.AxisLabel = groupedItem.Key.ToShortDateString(); // Tarih formatını belirt
                    pointKalori.Label = totalKalori + " kcal";

                    var pointProtein = new DataPoint(groupedItem.Key.ToOADate(), totalProtein);
                    pointProtein.AxisLabel = groupedItem.Key.ToShortDateString(); // Tarih formatını belirt
                    pointProtein.Label = totalProtein + " gram";

                    var pointYag = new DataPoint(groupedItem.Key.ToOADate(), totalYag);
                    pointProtein.AxisLabel = groupedItem.Key.ToShortDateString(); // Tarih formatını belirt
                    pointYag.Label = totalYag + " gram";

                    var pointKarbonHidrat = new DataPoint(groupedItem.Key.ToOADate(), totalKarbonHidrat);
                    pointProtein.AxisLabel = groupedItem.Key.ToShortDateString(); // Tarih formatını belirt
                    pointKarbonHidrat.Label = totalKarbonHidrat + " gram";

                    chrtGrafik.Series["Kalori"].Points.Add(pointKalori);
                    chrtGrafik.Series["Protein"].Points.Add(pointProtein);
                    chrtGrafik.Series["Yağ"].Points.Add(pointYag);
                    chrtGrafik.Series["KarbonHidrat"].Points.Add(pointKarbonHidrat);

                }
            }
            else
            {
                MessageBox.Show("Seçilen tarihler arasında veri bulunamadı.");
            }
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpBaslangic.Value;
            DateTime bitisTarihi = dtpBitis.Value; ;
            if (baslangicTarihi > bitisTarihi)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden büyük olamaz!");
                return;
            }
            GrafikCiz();
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpBaslangic.Value;
            DateTime bitisTarihi = dtpBitis.Value; ;
            if (baslangicTarihi > bitisTarihi)
            {
                MessageBox.Show("Bitiş Tarihi Başlangıç Tarihinden büyük olamaz!");
                return;
            }
            GrafikCiz();
        }


    }
}
