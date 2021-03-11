using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class CepTelefonu:Urun
    {
        public string Ozellikler { get; set; }
        public string Marka { get; set; }
        public override double kdvUygula()
        {
            return Fiyat * 2.0;
        }

        public CepTelefonu(string ad, double fiyat,string marka)
        {
            this.urunAdi = ad;
            this.Fiyat = fiyat;
            this.Marka = marka;
        }
    }
}
