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
    public partial class YoneticiRaporForm : Form
    {
        private readonly Repository<Kullanici> KullaniciRepository;
        private readonly Repository<OgunBilgisi> OgunBilgiRepository;
        public YoneticiRaporForm(Repository<Kullanici> kullaniciRepository, Repository<OgunBilgisi> ogunBilgiRepository)
        {
            InitializeComponent();
            KullaniciRepository = kullaniciRepository;
            OgunBilgiRepository = ogunBilgiRepository;
            cmbKullanicilar.DataSource = KullaniciRepository.HepsiniGetir().ToList();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {            
            dgvRapor.DataSource = OgunBilgiRepository.HepsiniEgarLoadingleGetir().AsNoTracking().ToList()
                .Where(ob => ob.KullaniciId == ((Kullanici)(cmbKullanicilar.SelectedItem)).Id)
                .Where(ob => ob.Tarih.Day == dtpTarih.Value.Day).ToList();
        }
    }
}
