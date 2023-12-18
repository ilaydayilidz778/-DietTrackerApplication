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
    public partial class YoneticiForm : Form
    {
        Repository<Kullanici> KullaniciRepository = new();
        Repository<OgunBilgisi> OgunBilgileriRepository = new();
        Repository<Besin> BesinRepository = new();
        Repository<Kategori> KategoriRepository = new();
        public YoneticiForm()
        {
            InitializeComponent();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            YoneticiKullaniciForm yoneticiKullaniciForm = new YoneticiKullaniciForm(KullaniciRepository, OgunBilgileriRepository);
            yoneticiKullaniciForm.ShowDialog();
        }

        private void btnBesin_Click(object sender, EventArgs e)
        {
            YoneticiBesinForm yoneticiBesinForm = new YoneticiBesinForm(BesinRepository, KategoriRepository);
            yoneticiBesinForm.ShowDialog();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            YoneticiRaporForm yoneticiRaporForm = new YoneticiRaporForm(KullaniciRepository, OgunBilgileriRepository);
            yoneticiRaporForm.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            YoneticiKategoriForm yoneticiKategoriForm = new YoneticiKategoriForm(KategoriRepository);
            yoneticiKategoriForm.ShowDialog();
        }
    }
}
