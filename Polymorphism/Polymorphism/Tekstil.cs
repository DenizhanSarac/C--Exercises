using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Tekstil: Urun
    {
        public string kumasTuru { get; set; }
        public int Beden { get; set; }
        public string ureticiFirma { get; set; }
        public override double kdvUygula()
        {
            return Fiyat * 2.5;
        }

        public Tekstil(string ad, double fiyat,string kumasturu,int beden)
        {
            this.urunAdi = ad;
            this.Fiyat = fiyat;
            this.kumasTuru = kumasturu;
            this.Beden = beden;
        }
        

    }
}
