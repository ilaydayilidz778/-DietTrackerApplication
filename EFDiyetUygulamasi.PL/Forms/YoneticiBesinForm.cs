using EFDiyetUygulamasi.BL.Repositories;
using EFDiyetUygulamasi.DAL.Entities;
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
    public partial class YoneticiBesinForm : Form
    {
        //Repository<Besin> BesinRepository = new();
        //Repository<Kategori> KategoriRepository = new();
        private readonly Repository<Besin> BesinRepository;
        private readonly Repository<Kategori> KategoriRepository;

        public YoneticiBesinForm(Repository<Besin> besinRepository, Repository<Kategori> kategoriRepository)
        {
            BesinRepository = besinRepository;
            KategoriRepository = kategoriRepository;
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            cmbKategori.DataSource = KategoriRepository.HepsiniGetir().ToList();
            dgvBesinler.DataSource = BesinRepository.HepsiniGetir().ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            int Kalori = (int)nudKalori.Value;
            decimal Protein = nudProtein.Value;
            decimal Karbonhidrat = nudKarbonhidrat.Value;
            decimal Yag = nudYag.Value;

            if (ad == "")
            {
                MessageBox.Show("Lütfen Besin Adını giriniz!");
                return;
            }
            Besin eklenecek = new Besin() { Ad = ad, Kalori = Kalori, Protein = Protein, Karbonhidrat = Karbonhidrat, Yag = Yag, KategoriId = ((Kategori)cmbKategori.SelectedItem).Id };

            BesinRepository.Ekle(eklenecek);
            MessageBox.Show("Besin başarıyla eklendi");
            VerileriYukle();
        }

        private void dgvBesinler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Besin secilen = (Besin)dgvBesinler.SelectedRows[0].DataBoundItem;

            txtAd.Text = secilen.Ad;
            nudKalori.Value = secilen.Kalori;
            nudProtein.Value = secilen.Protein;
            nudKarbonhidrat.Value = secilen.Karbonhidrat;
            nudYag.Value = secilen.Yag;
            // Data Grid View'da seçilen besinin Kategori Adıyla string olarak eşleşen combobox elemanının indexini verir.
            int index = cmbKategori.FindStringExact(secilen.Kategori.Ad);
            cmbKategori.SelectedIndex = index;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Besin guncellenecek = (Besin)dgvBesinler.SelectedRows[0].DataBoundItem;

            guncellenecek.Ad = txtAd.Text;
            guncellenecek.Kalori = (int)nudKalori.Value;
            guncellenecek.Protein = nudProtein.Value;
            guncellenecek.Karbonhidrat = nudKarbonhidrat.Value;
            guncellenecek.Yag = nudYag.Value;
            guncellenecek.KategoriId = ((Kategori)(cmbKategori.SelectedItem)).Id;

            BesinRepository.Guncelle(guncellenecek);

            VerileriYukle();

            MessageBox.Show("Besin başarıyla güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Besin silinecek = (Besin)dgvBesinler.SelectedRows[0].DataBoundItem;

            BesinRepository.Sil(silinecek.Id);

            VerileriYukle();

            MessageBox.Show("Besin başarıyla silindi");
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
