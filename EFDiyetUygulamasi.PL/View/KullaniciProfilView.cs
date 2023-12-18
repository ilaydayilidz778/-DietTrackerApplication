using EFDiyetUygulamasi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.PL.View
{
    public class KullaniciProfilView
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Sifre { get; set; }

        public string  Ad { get; set; }

        public string Soyad { get; set; }

        public int Boy { get; set; }

        public decimal Kilo { get; set; }

        public int Yas { get; set; }

        public Cinsiyet Cinsiyet { get; set; }
    }
}
