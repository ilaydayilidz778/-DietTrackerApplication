using MathNet.Numerics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.DAL.Entities
{
    public class Besin
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Ad { get; set; } = null!;
        public int Kalori { get; set; }

        [Precision(5,1)]
        public decimal Protein {  get; set; }
        [Precision(5, 1)]
        public decimal Yag { get; set; }
        [Precision(5, 1)]
        public decimal Karbonhidrat { get; set; }
        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; } = null!;
        public virtual List<OgunBilgisi> OgunBilgiler { get; set; } = null!;

        public override string ToString()
        {
            return Ad;
        }
    }
}

