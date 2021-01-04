using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
   public class Siparis
    {
   
        public decimal Ciro { get; set; }
        public int ToplamSiparis { get; set; }
        public decimal EkstraMalzeme { get; set; }
        public int SatilanUrun { get; set; }
        public string SiparisAdi{ get; set; }

        public string Boyut { get; set; }
   



        public decimal Fiyat { get; set; }

        public decimal SiparisAdet { get; set; }

        public static List<Siparis> SiparisListesi = new List<Siparis>();

        public override string ToString()
        {
            return SiparisAdi;
        }
    }
}
