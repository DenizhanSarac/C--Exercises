using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioylaHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 10;
        int b = 2;
        int top, fark, bol, carp;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            top = a + b;
            label1.Text = top.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fark = a - b;
            label1.Text = fark.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            bol = a / b;
            label1.Text = bol.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            carp = a * b;
            label1.Text = carp.ToString();
        }
    }
}
