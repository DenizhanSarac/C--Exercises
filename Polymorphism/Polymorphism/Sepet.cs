using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Sepet: Urun
    {
        private List<Urun> urunler = new List<Urun>();
        public double toplamTutar()
        {
            double toplamFiyat = 0;
            foreach (Urun item in urunler)
            {
                toplamFiyat += item.kdvUygula();
            }
            return toplamFiyat;
        }
        public void urunEkle(Urun yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
