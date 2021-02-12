using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        int ben = 0, pc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
                
                int a = rast.Next(1, 7);
                label3.Text = a.ToString();
                int b = rast.Next(1, 7);
                label4.Text = b.ToString();
                ben += a + b;
                label16.Text = ben.ToString();
                label6.Text = (a + b).ToString();
                button1.Enabled = false;
                button2.Enabled = true;
                
        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            int a = rast.Next(1, 7);
            label10.Text = a.ToString();
            int b = rast.Next(1, 7);
            label9.Text = b.ToString();
            pc += a + b;
            label17.Text = pc.ToString();
            label7.Text = (a + b).ToString();
            button1.Enabled = true;


            if (ben > 100 && ben>pc)
            {
                MessageBox.Show("Birinci Oyuncu Kazandı...");
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else if(pc>100 && pc>ben)
            {
                MessageBox.Show("İkinci Oyuncu Kazandı...");
                button1.Enabled = false;
                button2.Enabled = false;
            }
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
