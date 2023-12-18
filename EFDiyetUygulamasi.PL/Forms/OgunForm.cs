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
    public partial class OgunForm : Form
    {
        private readonly Kullanici _kullanici;
        private readonly Repository<Kategori> KategorilerRepository;
        private readonly Repository<Ogun> OgunlerRepository;
        private readonly Repository<Besin> BesinlerRepository;
        private readonly Repository<OgunBilgisi> OgunBilgileriRepository;

        // seçilenOgun nesnesine birden fazla event ve metod içerisinden erişim sağlamak için class içerisinde tanımladık.
        private Ogun secilenOgun;
        public OgunForm
            (
            Kullanici kullanici,
            Repository<Kategori> kategoriRepository,
            Repository<Ogun> ogunRepository,
            Repository<Besin> besinlerRepository,
            Repository<OgunBilgisi> ogunBilgileriRepository
            )
        {
            InitializeComponent();
            dtpTakvim.MinDate = new DateTime(2023, 1, 1);
            dtpTakvim.MaxDate = DateTime.Now;   
            dtpTakvim.Format = DateTimePickerFormat.Short;
            _kullanici = kullanici;
            KategorilerRepository = kategoriRepository;
            OgunlerRepository = ogunRepository;
            BesinlerRepository = besinlerRepository;
            OgunBilgileriRepository = ogunBilgileriRepository;

            //dgvYemekler DataGridView tablosunun otomatik colon oluşturma özelliğini devre dışı bıraktık.
            dgvYemekler.AutoGenerateColumns = false;
            dgvOgunBilgisi.AutoGenerateColumns = false;

            //comboBox ve DataGridView verilerini yükledik.
            VerileriYukle();
            //seçilen ogun bilgisi, terih vee yemeğe göre dgvOgunBilgisi DataGridView verilerini yükledik.
            SecilenYemekleriYukle();
        }

        private void SecilenYemekleriYukle()
        {
            secilenOgun = (Ogun)cboOgunler.SelectedItem;
            dgvOgunBilgisi.DataSource = OgunBilgileriRepository
                .HepsiniEgarLoadingleGetir()
                .AsNoTracking()
                .Where(ob =>
                ob.KullaniciId == _kullanici.Id &&
                ob.Tarih.Day == dtpTakvim.Value.Day &&
                ob.OgunId == secilenOgun.Id)
                .ToList();
        }

        private void VerileriYukle()
        {
            cboOgunler.DataSource = OgunlerRepository.HepsiniGetir().ToList(); ;
            cboKategoriler.DataSource = KategorilerRepository.HepsiniGetir().ToList();
        }

        private void cboKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            var seciliKategori = (Kategori)cboKategoriler.SelectedItem;
            dgvYemekler.DataSource = BesinlerRepository.HepsiniGetir().Where(b => b.KategoriId == seciliKategori.Id).ToList();
            pbYemekGorseli.ImageLocation = seciliKategori.ResimYolu;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgunBilgisi ogunBilgileri = new OgunBilgisi();
            Besin secilenBesin = (Besin)dgvYemekler.SelectedRows[0].DataBoundItem;

            if (secilenBesin == null)
            {
                MessageBox.Show("Lütfen eklemek istediğiniz yemeği seçiniz");
                return;
            }

            if (DateTime.Now.Date < dtpTakvim.Value.Date)
            {
                MessageBox.Show("İleri tarihli bir öğüne ekleme yapılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ogunBilgileri.KullaniciId = _kullanici.Id;
            ogunBilgileri.BesinId = secilenBesin.Id;
            ogunBilgileri.OgunId = secilenOgun.Id;
            ogunBilgileri.Tarih = dtpTakvim.Value;
            ogunBilgileri.Porsiyon = (int)nudPorsiyon.Value;

            if (BesinKaydiVarMi(ogunBilgileri))
            {
                MessageBox.Show("Bu besin, seçili tarih, öğün ve kategoride zaten mevcut. " +
                                "İşlemi güncelleme veya farklı bir besin seçerek tekrar deneyiniz.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OgunBilgileriRepository.Ekle(ogunBilgileri);
            SecilenYemekleriYukle();

            MessageBox.Show("Öğün Bilgisi Eklendi", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cboOgunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecilenYemekleriYukle();
        }

        private void dtpTakvim_ValueChanged(object sender, EventArgs e)
        {
            SecilenYemekleriYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvOgunBilgisi.SelectedRows.Count > 0)
            {
                OgunBilgisi guncellenecek = (OgunBilgisi)dgvOgunBilgisi.SelectedRows[0].DataBoundItem;

                Besin secilenBesin = (Besin)dgvYemekler.SelectedRows[0].DataBoundItem;
                guncellenecek.KullaniciId = _kullanici.Id;
                guncellenecek.BesinId = secilenBesin.Id;
                guncellenecek.OgunId = secilenOgun.Id;
                guncellenecek.Tarih = dtpTakvim.Value;
                guncellenecek.Porsiyon = (int)nudPorsiyon.Value;

                OgunBilgileriRepository.Guncelle(guncellenecek);
                SecilenYemekleriYukle();

                MessageBox.Show("Öğün Bilgisi Güncellendi", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvOgunBilgisi.SelectedRows.Count > 0)
            {
                OgunBilgisi silinecek = (OgunBilgisi)dgvOgunBilgisi.SelectedRows[0].DataBoundItem;
                OgunBilgileriRepository.Sil(silinecek.Id);
                MessageBox.Show("Öğün Bilgisi Başarıyla Silindi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SecilenYemekleriYukle();
        }

        private void dgvOgunBilgisi_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvOgunBilgisi.SelectedRows.Count > 0)
            {
                OgunBilgisi gosterilecek = (OgunBilgisi)dgvOgunBilgisi.SelectedRows[0].DataBoundItem;

                dtpTakvim.Value = gosterilecek.Tarih;
                cboOgunler.SelectedItem = gosterilecek.Ogun;

                ((OgunBilgisi)(cboKategoriler.SelectedItem)).Besin.KategoriId = gosterilecek.Besin.KategoriId;

                if (gosterilecek.Besin != null)
                {
                    foreach (DataGridViewRow row in dgvYemekler.Rows)
                    {
                        if (row.DataBoundItem is Besin besin && besin == gosterilecek.Besin)
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }

                nudPorsiyon.Value = gosterilecek.Porsiyon;
            }
        }
        private bool BesinKaydiVarMi(OgunBilgisi yeniOgunBilgisi)
        {
            return OgunBilgileriRepository.HepsiniGetir()
                .Any(ob => ob.KullaniciId == _kullanici.Id &&
                           ob.Tarih == yeniOgunBilgisi.Tarih &&
                           ob.OgunId == yeniOgunBilgisi.OgunId &&
                           ob.BesinId == yeniOgunBilgisi.BesinId);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}













































