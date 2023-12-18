using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.DAL.Entities
{
    public class Kategori
    {
        public int Id { get; set; }

        public string Ad { get; set; } = null!;

        public string? ResimYolu { get; set; } = null!; 

        public virtual List<Besin> Besinler { get; set; } = null!;

        public override string ToString()
        {
            return Ad;
        }

    }
}
