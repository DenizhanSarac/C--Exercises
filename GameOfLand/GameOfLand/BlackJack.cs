using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace GameOfLand
{
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        int sayac = 0;
        int toplam = 0;
        int toplam2 = 0;
        int oyuncu=0, bilgisayar=0;
        string[] dosyalar = Directory.GetFiles(@"C:\Users\dnzhn\Desktop\Kağıt\", "*.png");
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;

            if (sayac == 1)
            {
                int a1, a2;
                a1 = rast.Next(1, 11);
                a2 = rast.Next(1, 11);
                label1.Text = a1.ToString();
                label2.Text = a2.ToString();
                toplam = a1 + a2;
                label10.Text = toplam.ToString();
            }
            if (sayac == 2)
            {
                int a3;
                a3 = rast.Next(1, 11);
                toplam += a3;
                label3.Text = a3.ToString();
                label10.Text = toplam.ToString();

            }
            if (sayac == 3)
            {
                int a4;
                a4 = rast.Next(1, 11);
                toplam += a4;
                label4.Text = a4.ToString();
                label10.Text = toplam.ToString();
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b1, b2;
            b1 = rast.Next(1, 11);
            b2 = rast.Next(1, 11);
            toplam2 = b1 + b2;
            label5.Text = b1.ToString();
            label6.Text = b2.ToString();
            label11.Text = toplam2.ToString();

            if (toplam2 < 16)
            {
                int b3;
                b3 = rast.Next(1, 11);
                label7.Text = b3.ToString();
                toplam2 += b3;
                label11.Text = toplam2.ToString();
            }
            if (toplam2 < 16)
            {
                int b4;
                b4 = rast.Next(1, 11);
                label8.Text = b4.ToString();
                toplam2 += b4;
                label11.Text = toplam2.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button3.Enabled = false;

            if (toplam > toplam2 && toplam <= 21)
            {
                oyuncu += 10;
                label18.Text = oyuncu.ToString();
            }
            if (toplam2 > toplam && toplam2 <= 21)
            {
                bilgisayar += 10;
                label19.Text = bilgisayar.ToString();
            }
            if (toplam2 > 21 && toplam > 21)
            {
                label18.Text = oyuncu.ToString();
                label19.Text = bilgisayar.ToString();
            }
            if (toplam2 <= 21 && toplam > 21)
            {
                bilgisayar += 10;
                label19.Text = bilgisayar.ToString();
            }
            if (toplam <= 21 && toplam2 > 21)
            {
                oyuncu += 10;
                label18.Text = oyuncu.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        
    }
}
