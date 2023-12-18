using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.DAL.Entities
{
    public class OgunBilgisi
    {
        public int Id { get; set; }

        // Kullanıcı ile ilişkiyi temsil eden alan
        public int KullaniciId { get; set; }
        public virtual Kullanici Kullanici { get; set; } = null!;

        // Öğünler ile ilişkiyi temsil eden alan
        public int OgunId { get; set; } 
        public virtual Ogun Ogun { get; set; } = null!;

        public virtual DateTime Tarih { get; set; }

        public int BesinId { get; set; }

        public virtual Besin Besin { get; set; } = null!;

        public int Porsiyon { get; set; }
    }
}
