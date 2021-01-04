using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HastaneRandevuOdev
{
    public class Randevu
    {
        public string Tckn { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Doktor Doktor { get; set; }
        public Brans Brans { get; set; }
        public string Saat { get; set; }
        public DateTime Tarih { get; set; }
        public static List<Randevu> RandevularListesi = new List<Randevu>();
       
    }
}
