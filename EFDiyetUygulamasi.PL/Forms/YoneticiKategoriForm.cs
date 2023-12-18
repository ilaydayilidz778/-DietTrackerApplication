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
    public partial class YoneticiKategoriForm : Form
    {
        private readonly Repository<Kategori> KategorilerRepository;
        byte[] secilenResim;
        public YoneticiKategoriForm(Repository<Kategori> kategorilerRepository)
        {
            InitializeComponent();
            KategorilerRepository = kategorilerRepository;
            KategorileriYukle();
        }

        private void KategorileriYukle()
        {
            dgvKategoriler.DataSource = KategorilerRepository.HepsiniGetir();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Ad kısmını doldurunuz.");
                return;
            }
            Kategori secilen = (Kategori)dgvKategoriler.SelectedRows[0].DataBoundItem;
            if (secilen != null)

            {

                secilen.Ad = txtAd.Text.Trim();
                File.Delete(secilen.ResimYolu);
                if (pbKategori.ImageLocation != null)
                {
                    string hedefResimYolu = Path.Combine("Image", $"{secilen.Ad}.png");
                    File.WriteAllBytes(hedefResimYolu, secilenResim);
                    secilen.ResimYolu = hedefResimYolu;
                }
                KategorilerRepository.Guncelle(secilen);
                pbKategori.ImageLocation = null;
                KategorileriYukle();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Ad kısmını doldurunuz.");
                return;
            }
            if (KategorilerRepository.HepsiniGetir().Any(a => a.Ad == txtAd.Text.Trim()))
            {
                MessageBox.Show("Kategori zaten var!");
                return;
            }
            Kategori eklenecek = new Kategori() { Ad = txtAd.Text.Trim() };
            if (pbKategori.ImageLocation != null)
            {
                string hedefResimYolu = Path.Combine("Image", $"{eklenecek.Ad}.png");
                File.WriteAllBytes(hedefResimYolu, secilenResim);
                eklenecek.ResimYolu = hedefResimYolu;
            }
            KategorilerRepository.Ekle(eklenecek);
            pbKategori.ImageLocation = null;
            KategorileriYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Kategori silinecek = (Kategori)dgvKategoriler.SelectedRows[0].DataBoundItem;
            if (silinecek != null)
            {
                KategorilerRepository.Sil(silinecek.Id);
                pbKategori.ImageLocation = null;
                File.Delete(silinecek.ResimYolu);
                KategorileriYukle();
            }
        }

        private void dgvKategoriler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Kategori secilen = (Kategori)dgvKategoriler.SelectedRows[0].DataBoundItem;
            if (secilen != null)
            {
                txtAd.Text = secilen.Ad;
                secilenResim = File.ReadAllBytes(secilen.ResimYolu);
                pbKategori.ImageLocation = secilen.ResimYolu;
            }
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif|Tüm Dosyalar|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string resimYolu = openFileDialog.FileName;
                    secilenResim = File.ReadAllBytes(resimYolu);
                    pbKategori.ImageLocation = resimYolu;
                }
            }
        }
    }
}
