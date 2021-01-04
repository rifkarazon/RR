using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HamburgerOtomasyonu
{
    public class Menuler
    {

     
      
                

        public string MenuAd { get; set; }

        public decimal Fiyat { get; set; }

        public static List<Menuler> MenuListesi = new List<Menuler>()
        {
            new Menuler {MenuAd = "Whooper", Fiyat=20},
            new Menuler {MenuAd = "McChicken", Fiyat=15},
            new Menuler {MenuAd = "Texas Smokehouse", Fiyat=35},
        };
        public Boyut MenuBoyu { get; set; }

        public int Adet { get; set; }
        public override string ToString()
        {
            return MenuAd;
        }
    }
}
