using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLand
{
    public partial class Dunya : Form
    {
        public Dunya()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Dunya_Load(object sender, EventArgs e)
        {

        }

        private void Dunya_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;
            int y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.D && x < 680)
                x += 5;
            else if (e.KeyCode == Keys.A && x > 0)
                x -= 5;
            else if (e.KeyCode == Keys.W && y < 580)
                y -= 5;
            else if (e.KeyCode == Keys.S && y > 0)
                y += 5;

            pictureBox1.Location = new Point(x, y);

            if(pictureBox1.Location.X >= soru1.Location.X-10 && pictureBox1.Location.Y<=soru1.Location.Y )
            {
                if(sayac==0)
                { 
                label4.Text = "Türkiye Kaç Coğrafi bölgeye ayrılır ?";
                label5.Text = "5";
                label6.Text = "6";
                label7.Text = "7";
                label8.Text = "8";
                label9.Text = "7";
                }
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label10.Text = label5.Text;
            if(label10.Text==label9.Text)
            {
                sayac++;
                label11.Text = sayac.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label10.Text = label6.Text;
            if (label10.Text == label9.Text)
            {
                sayac++;
                label11.Text = sayac.ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label10.Text = label7.Text;
            if (label10.Text == label9.Text)
            {
                sayac++;
                label11.Text = sayac.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label10.Text = label8.Text;
            if (label10.Text == label9.Text)
            {
                sayac++;
                label11.Text = sayac.ToString();
            }
        }
    }
}
