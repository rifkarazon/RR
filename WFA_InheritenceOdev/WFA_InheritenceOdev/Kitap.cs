using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_InheritenceOdev
{
   public class Kitap:Urun
    {
        public string Yazar { get; set; }
         public string  Yayimci { get; set; }
        public string Kitapadi { get; set; }
        public string KapakTuru { get; set; }
        public string Dil { get; set; }
        public string Cevirmen { get; set; }
        public string BaskiSayisi { get; set; }
        public string BaskiYili { get; set; }

        public string Tur { get; set; }
        public string AltTur { get; set; }
    }
}
