using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetUygulamasi.PL.View
{
    public class OgunBesinView
    {
        public int OgunBilgisiID { get; set; }
        public string OgunAdi {  get; set; }
        public string BesinAdi { get; set; }
        public decimal Protein { get; set; }
        public decimal Yag { get; set; }
        public decimal Karbonhidrat { get; set; }
        public int Kalori { get; set; }
        public DateTime Tarih { get; set; }
        public int Porsiyon { get; set; }

        public string KategoriAdi { get; set; }
    }
}
