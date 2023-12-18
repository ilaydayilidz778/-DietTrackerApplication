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
    public partial class AnaForm : Form
    {
        private readonly Kullanici _kullanici;
        private readonly Repository<Kullanici> _kullaniciRepository;
        Repository<OgunBilgisi> OgunBilgileriRepository = new();
        Repository<Ogun> OgunRepository = new();
        Repository<Besin> BesinRepository = new();
        Repository<Kategori> KategoriRepository = new();
        public AnaForm(Kullanici kullanici, Repository<Kullanici> kullaniciRepository)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _kullaniciRepository = kullaniciRepository;
        }
        public void FormGoster(Form secilenForm)
        {
            try
            {
                secilenForm.StartPosition = 0;
                Width = secilenForm.Width + 100;
                Height = secilenForm.Height + 100;
                bool durum = false;

                foreach (Form form in this.MdiChildren)
                {
                    if (form.Text == secilenForm.Text)
                    {
                        durum = true;
                        form.Show();
                    }
                    else
                        form.Close();
                }

                if (!durum)
                {
                    secilenForm.MdiParent = this;
                    secilenForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void profilimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGoster(new ProfilForm(_kullanici, _kullaniciRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ogunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGoster(new OgunForm
                    (
                        _kullanici,
                        KategoriRepository,
                        OgunRepository,
                        BesinRepository,
                        OgunBilgileriRepository
                    ));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void ogunlerimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGoster(new OgunlerimForm(_kullanici, OgunBilgileriRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void ogunlerRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGoster(new RaporForm(_kullanici, OgunBilgileriRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
        }

        private void kiyasRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGoster(new KiyasForm(_kullanici, KategoriRepository, OgunRepository, OgunBilgileriRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void grafikRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGoster(new GrafikForm(_kullanici, OgunBilgileriRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void yemekÇeşidiRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormGoster(new YemekCesitForm(
                        _kullanici,
                        KategoriRepository,
                        OgunRepository,
                        BesinRepository,
                        OgunBilgileriRepository));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



       


