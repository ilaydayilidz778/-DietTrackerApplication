using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDiyetUygulamasi.DAL.Enums;
using Microsoft.EntityFrameworkCore;

namespace EFDiyetUygulamasi.DAL.Entities
{
    public class KullaniciProfil
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        
        [Range(120, 250, ErrorMessage = "Boy değeri 120 ile 250 arasında olmalıdır.")]
        public int Boy { get; set; }
        
        [Range(35, 250, ErrorMessage = "Kilo değeri 35 ile 250 arasında olmalıdır.")]
        [Precision(5,2)]
        public decimal Kilo { get; set; }
        
        [Range(25, 45, ErrorMessage = "Yaş değeri 25 ile 45 arasında olmalıdır.")]
        public int Yas { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        
    }
}
