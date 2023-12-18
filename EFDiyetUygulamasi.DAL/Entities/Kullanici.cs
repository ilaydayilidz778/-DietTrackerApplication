using EFDiyetUygulamasi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.DAL.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Email { get; set; } = null!;
        
       
        public string Sifre { get; set; } = null!;
        
        public virtual KullaniciProfil KullaniciProfil { get; set; } = null!;

        public virtual List<OgunBilgisi> OgunBilgiler { get; set; } = null!;

        public override string ToString()
        {
            return KullaniciProfil.Ad + " " + KullaniciProfil.Soyad;
        }
    }
}
