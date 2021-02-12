using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klavye_Kontrol_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Klavyeden Nesne Kaydırma Oyunu
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X; //Form üzerinde x lokasyonu aktarma
            int y = pictureBox1.Location.Y; //Form üzerinde y lokasyonu aktarma

            if(e.KeyCode==Keys.D)//Klavyeden D tuşuna basılması
            {
                x += 5; // Lokasyon artırma
            }
            if (e.KeyCode == Keys.A)//Klavyeden A tuşuna basılması
            {
                x -= 5; // Lokasyon Azaltma
            }
            if (e.KeyCode == Keys.W)//Klavyeden W tuşuna basılması
            {
                y -= 5; // Lokasyon Azaltma
            }
            if (e.KeyCode == Keys.S)//Klavyeden S tuşuna basılması
            {
                y += 5; // Lokasyon Azaltma
            }
            if(pictureBox1.Right >=label1.Left) //Picturebox'un Sağ tarafının Labelin sol tarafından büyük olması 
            {
                label1.BackColor = Color.Red;
                label2.BackColor = Color.White;
            }
            if (pictureBox1.Left <= label2.Right)//Picturebox'un Sol tarafının Labelin Sağ tarafından büyük olması 
            {
                label1.BackColor = Color.White;
                label2.BackColor = Color.Red;
            }
            if (pictureBox1.Bottom >= label3.Top)//Picturebox'un Alt tarafının Labelin Üst tarafından büyük olması 
            {
                label3.BackColor = Color.Red;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
            }
            if (pictureBox1.Top <= label4.Bottom)//Picturebox'un Üst tarafının Labelin Alt tarafından büyük olması 
            {
                label4.BackColor = Color.Red;
                label3.BackColor = Color.White;
                label1.BackColor = Color.White;
                label2.BackColor = Color.White;
            }
            pictureBox1.Location = new Point(x, y); //Yeni Lokasyon Aktarma
        }
    }
}
