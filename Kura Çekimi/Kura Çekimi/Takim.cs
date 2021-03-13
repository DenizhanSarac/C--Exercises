using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kura_Çekimi
{
    public class Takim
    {
        private string takimIsmi;
        private string takimUlke;

        public Takim(string isim,string ulke)
        {
            this.takimIsmi = isim;
            this.takimUlke = ulke;
        }

        public string teamName
        {
            get { return takimIsmi; }
            set { takimIsmi = value; }
        }

        public string teamCountry
        {
            get { return takimUlke; }
            set { takimUlke = value; }
        }

        public override string ToString()
        {
            return takimIsmi + " - " + takimUlke;
        }
    }
}
