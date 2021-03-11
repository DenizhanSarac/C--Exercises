using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Urun
    {
        public string urunAdi { get; set; }
        public double Fiyat { get; set; }
        public virtual double kdvUygula() 
        {
            return Fiyat * 1.8;
        }
        public Urun() { }

        public Urun(string ad, double fiyat)
        {
            urunAdi = ad;
            Fiyat = fiyat;
        }
    }
}
