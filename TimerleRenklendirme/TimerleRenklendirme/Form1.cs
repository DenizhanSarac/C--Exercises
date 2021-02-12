using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerleRenklendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if(checkBox1.Checked==true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.White;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Black;
                }
            }
            if (checkBox2.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Red;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Yellow;
                }
            }
            if (checkBox3.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.BlueViolet;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.BlueViolet;
                    button4.BackColor = Color.Blue;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Blue;
                    button2.BackColor = Color.BlueViolet;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.BlueViolet;
                }
            }
            if (checkBox4.Checked == true)
            {
                if (saniye % 10 == 0)
                {
                    button1.BackColor = Color.Yellow;
                    button2.BackColor = Color.Navy;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Navy;
                }
                if (saniye % 10 == 5)
                {
                    button1.BackColor = Color.Navy;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Navy;
                    button4.BackColor = Color.Yellow;
                }
            }
            
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
