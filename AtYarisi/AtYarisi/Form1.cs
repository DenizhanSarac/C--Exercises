using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();
            int firsthw,secondhw,thirdhw;
            firsthw= pictureBox1.Width;
            secondhw = pictureBox2.Width;
            thirdhw = pictureBox3.Width;

            int bitisuzakligi = label4.Left;

            pictureBox1.Left= pictureBox1.Left+rastgele.Next(5,16);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 16);

            if(pictureBox1.Left>pictureBox2.Left + 5 && pictureBox1.Left>pictureBox3.Left)
            {
                label6.Text = "First Horse riding first line.";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left)
            {
                label6.Text = "Second Horse riding first line.";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left)
            {
                label6.Text = "Third Horse riding first line.";
            }



            if (firsthw+pictureBox1.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("First Horse Arrived.");
                label6.Text = "First Horse winner !!!";

            }
            else if (secondhw+pictureBox2.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("Second Horse Arrived");
                label6.Text = "Second Horse winner !!!";
            }
            else if (thirdhw + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("Third Horse Arrived");
                label6.Text = "Third Horse winner !!!";
            }
        
        }
    }
}
