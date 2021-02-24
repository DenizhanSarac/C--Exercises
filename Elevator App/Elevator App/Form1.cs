using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 134)
            {
                label5.BackColor = Color.Blue;
                label6.BackColor = Color.Blue;
            }
            if (pictureBox1.Location.Y < 134)
            {
                label4.BackColor = Color.Blue;
                label7.BackColor = Color.Blue;
            }
            if(label9.Text=="1")
            {
                pictureBox1.Top -= 5;
                if (pictureBox1.Location.Y <= 134)
                {
                    label5.BackColor = Color.Red;
                    label6.BackColor = Color.Red;
                    timer1.Stop();
                }
                
                    
            }
            if (label9.Text == "0")
            {
                pictureBox1.Top += 5;
                if (pictureBox1.Location.Y >= 321)
                {
                    label4.BackColor = Color.Red;
                    label7.BackColor = Color.Red;
                    timer1.Stop();
                }
                if (pictureBox1.Location.Y < 134)
                {
                    label4.BackColor = Color.Blue;
                    label7.BackColor = Color.Blue;
                }

            }
        }
    }
}
