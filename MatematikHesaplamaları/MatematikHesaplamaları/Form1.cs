using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikHesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int birkenar,alan,cevre;
            birkenar = Convert.ToInt32(textBox1.Text);

            alan = birkenar * birkenar;
            cevre = 4 * birkenar;

            label4.Text = cevre.ToString();
            label6.Text = alan.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox2.Visible = false;
            label1.Text = "KARE";
            panel1.Visible = true;
            button3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Dikdörtgen";
            label2.Text = "Kısa Kenar:";
            panel1.Visible = true;
            button4.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kisa, uzun, dcevre, dalan;
            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            dalan = kisa * uzun;
            dcevre = (2 * kisa) + (2 * uzun);
            label4.Text = dcevre.ToString();
            label6.Text = dalan.ToString();
        }
    }
}
