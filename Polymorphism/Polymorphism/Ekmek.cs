using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Ekmek: Urun
    {
        public string ekmekTuru { get; set; }
        public int Gramaj { get; set; }
        
        public override double kdvUygula()
        {
            return Fiyat * 1.01;
        }

        public Ekmek(string ad, double fiyat, string ekmekturu,int gramaj)
        {
            this.urunAdi = ad;
            this.Fiyat = fiyat;
            this.ekmekTuru = ekmekturu;
            this.Gramaj = gramaj;
        }
    }
}
