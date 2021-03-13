using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kura_Çekimi
{
    public partial class Form1 : Form
    {
        List<Takim> takimlar;
        List<ListBox> torbalar = new List<ListBox>();
        List<ListBox> gruplar = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Takim yenitakim = null;

            takimlar = new List<Takim>();

            yenitakim = new Takim("Bayern Munich", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Chelsea", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Barcalone", "Spain");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Real Madrid", "Spain");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Liverpool", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester City", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Manchester United", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Arsenal", "England");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atletico Madrid", "Spain");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Beşiktaş", "Turkey");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("PSG", "France");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Malsiya", "France");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lyon", "France");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lille", "France");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Ajax", "Neterlands");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Dinoma Kiev", "Kiev");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Inter", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Milan", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Juventus", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Sevilla", "Spain");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Dortmund", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Leipsig", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Zenit", "Russia");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Lazio", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Atalanta", "Italy");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Porta", "Portugal");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Galatasaray", "Turkey");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Salzburg", "Avusturya");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Krasnodar", "Russia");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Olimpiakos", "Greek");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Mönchengladbach", "Germany");
            takimlar.Add(yenitakim);
            yenitakim = new Takim("Rennes", "France");
            takimlar.Add(yenitakim);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            List<int> secilenTakimlar = new List<int>();
            for (int j = 0; j < 4; j++)
            {
                secilenTakimlar.Clear();
                for (int i = 0; i < 8; i++)
                {
                    int secilen = rast.Next(0, takimlar.Count / 4);

                    if (secilenTakimlar.Contains(secilen))
                    {
                        i--;
                    }
                    else
                    {
                        secilenTakimlar.Add(secilen);
                    }

                }
                bool ayniulkedentakimlar = false;
                for (int k = 0; k < 8; k++)
                {
                    ayniulkedentakimlar = ayniulkedentakimlarvarmi(gruplar[k], torbalar[j].Items[secilenTakimlar[k]] as Takim);
                    if (ayniulkedentakimlar)
                        break;
                }
                    if (!ayniulkedentakimlar)
                    {
                        lsgrupA.Items.Add(torbalar[j].Items[secilenTakimlar[0]] as Takim);
                        lsgrupB.Items.Add(torbalar[j].Items[secilenTakimlar[1]] as Takim);
                        lsgrupC.Items.Add(torbalar[j].Items[secilenTakimlar[2]] as Takim);
                        lsgrupD.Items.Add(torbalar[j].Items[secilenTakimlar[3]] as Takim);
                        lsgrupE.Items.Add(torbalar[j].Items[secilenTakimlar[4]] as Takim);
                        lsgrupF.Items.Add(torbalar[j].Items[secilenTakimlar[5]] as Takim);
                        lsgrupG.Items.Add(torbalar[j].Items[secilenTakimlar[6]] as Takim);
                        lsgrupH.Items.Add(torbalar[j].Items[secilenTakimlar[7]] as Takim);

                    }
                    else 
                    {
                        j--; 
                    }
                }
            }
        
        private bool ayniulkedentakimlarvarmi(ListBox grup, Takim takim)
        {
            bool durum = false;
            for (int i = 0; i <grup.Items.Count; i++)
            {
                Takim gruptakim = grup.Items[i] as Takim;
                if(gruptakim.teamCountry==takim.teamCountry)
                {
                    durum = true;
                    break;
                }
            }
            return durum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            List<int> secilentakimlar = new List<int>();
            for (int i = 0; i <takimlar.Count; i++)
            {
                int secilentakim = rastgele.Next(0, takimlar.Count);
                if(secilentakimlar.Contains(secilentakim))
                {
                    i--;
                }
                else
                {
                    secilentakimlar.Add(secilentakim);
                }
            }
            for (int i = 0; i < secilentakimlar.Count; i++)
            {
                if(i<8)
                {
                    lstorba1.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if(i<16)
                {
                    lstorba2.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else if (i < 24)
                {
                    lstorba3.Items.Add(takimlar[secilentakimlar[i]]);
                }
                else
                {
                    lstorba4.Items.Add(takimlar[secilentakimlar[i]]);
                }
            }
            torbalar.Add(lstorba1);
            torbalar.Add(lstorba2);
            torbalar.Add(lstorba3);
            torbalar.Add(lstorba4);

            gruplar.Add(lsgrupA);
            gruplar.Add(lsgrupB);
            gruplar.Add(lsgrupC);
            gruplar.Add(lsgrupD);
            gruplar.Add(lsgrupE);
            gruplar.Add(lsgrupF);
            gruplar.Add(lsgrupG);
            gruplar.Add(lsgrupH);
            

        }
    }
}
