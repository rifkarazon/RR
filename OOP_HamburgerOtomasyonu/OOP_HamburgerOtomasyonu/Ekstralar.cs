using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Ekstralar
    {
   
        public string EkstraAd { get; set; }

        public decimal Fiyat { get; set; }

        public static List<Ekstralar> EkstraListesi = new List<Ekstralar>()
        {
            new Ekstralar {EkstraAd = "Cheddar", Fiyat=3m},
            new Ekstralar {EkstraAd = "Ketçap", Fiyat=1m},
            new Ekstralar {EkstraAd = "Hardal", Fiyat=1.5m},
            new Ekstralar {EkstraAd = "Barbekü", Fiyat=2m},
        };

        public override string ToString()
        {
            return EkstraAd;
        }
    }
}
