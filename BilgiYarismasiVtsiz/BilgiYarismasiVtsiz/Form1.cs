using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasiVtsiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sorusay, dogru = 0, yanlis = 0, sure=20;
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sure = 20;
            sorusay++;
            label2.Text = sorusay.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            switch (sorusay)
            {
                case 1:
                    {
                        richTextBox1.Text = "Mustafa Kemal Kaç yılında doğmuştur?";
                        button1.Text = "1880";
                        button2.Text = "1881";
                        button3.Text = "1882";
                        button4.Text = "1884";
                        label6.Text = "1881";
                        break;
                    }
                case 2:
                    {
                        richTextBox1.Text = "Denizhan Kaç yılında doğmuştur?";
                        button1.Text = "1990";
                        button2.Text = "1995";
                        button3.Text = "1998";
                        button4.Text = "1985";
                        label6.Text = "1998";

                        break;
                    }
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label4.Text = button1.Text;
            if (label6.Text == button1.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
                
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label4.Text = button2.Text;
            if (label6.Text == button2.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label4.Text = button3.Text;
            if (label6.Text == button3.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            label4.Text = button4.Text;
            if (label6.Text == button4.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = Convert.ToInt32(label10.Text);
            sure -= 1;
            label10.Text = sure.ToString();
            if(sure ==0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                timer1.Enabled = false;
                yanlis++;
                label7.Text = yanlis.ToString();
            }
        }
    }
}
