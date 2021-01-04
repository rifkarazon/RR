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

        public static List<Menuler> MenuListesi = new List<Menuler>();
        public override string ToString()
        {
            return MenuAd;
        }
    }
}
