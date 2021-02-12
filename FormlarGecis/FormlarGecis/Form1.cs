using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarGecis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kad;
            int pw;
            kad = Convert.ToString(Kad.Text);
            pw = Convert.ToInt32(Pw.Text);
            if(pw==1234 || kad=="admin")
            {
                Form yeni = new Form();
                yeni.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Hatalı Giriş...";
                label3.Visible = true;
                Kad.Clear();
                Pw.Clear();
            }
        }
    }
}
