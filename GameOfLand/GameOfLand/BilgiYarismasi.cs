using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GameOfLand
{
    public partial class BilgiYarismasi : Form
    {
        public BilgiYarismasi()
        {
            InitializeComponent();
        }
        
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=bilgiyarisma;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        int zaman = 20;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 20;


            btnA.BackColor = DefaultBackColor;
            btnB.BackColor = DefaultBackColor;
            btnC.BackColor = DefaultBackColor;
            btnD.BackColor = DefaultBackColor;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Text = "Sonraki Soru";
            sayac++;
            labelsoru.Text = sayac.ToString();
            if(sayac==1)
            {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("Select * from sorular order by NEWID()", baglan);
            SqlDataReader oku = kmt.ExecuteReader();
            while(oku.Read())
            {
                btnA.Text = (oku["A"].ToString());
                btnB.Text = (oku["B"].ToString());
                btnC.Text = (oku["C"].ToString());
                btnD.Text = (oku["D"].ToString());
                labeldogru.Text = (oku["dogru"].ToString());
                textBox1.Text = (oku["soru"].ToString());
                btnsonraki.Enabled = false;
            }
            baglan.Close();
            }
            if(sayac==2)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand("Select * from sorular1 order by NEWID()", baglan);
                SqlDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["A"].ToString());
                    btnB.Text = (oku["B"].ToString());
                    btnC.Text = (oku["C"].ToString());
                    btnD.Text = (oku["D"].ToString());
                    labeldogru.Text = (oku["dogru"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    btnsonraki.Enabled = false;
                }
                baglan.Close();
            }
            if(sayac==3)
            {
                baglan.Open();
                SqlCommand kmt = new SqlCommand("Select * from sorular2 order by NEWID()", baglan);
                SqlDataReader oku = kmt.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["A"].ToString());
                    btnB.Text = (oku["B"].ToString());
                    btnC.Text = (oku["C"].ToString());
                    btnD.Text = (oku["D"].ToString());
                    labeldogru.Text = (oku["dogru"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    btnsonraki.Enabled = false;
                }
                baglan.Close();
            }
            if(sayac==4)
            {
                timer1.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = false;
                button1.Visible = true;
                btnsonraki.Text = "Bitirdiniz!!!";
                MessageBox.Show("Aldığınız Puan" + puan);
                
            }
           

        }

        private void BilgiYarismasi_Load(object sender, EventArgs e)
        {
            labelsoru.Text = sayac.ToString();
            button1.Visible = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if(btnA.Text==labeldogru.Text)
            {
                puan += 10;
                labelpuan.Text = puan.ToString();
                btnA.BackColor = Color.Green;
            }
            else
            {
                puan -= 10;
                labelpuan.Text = puan.ToString();
                btnA.BackColor = Color.Red;
            }
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == labeldogru.Text)
            {
                puan += 10;
                labelpuan.Text = puan.ToString();
                btnB.BackColor = Color.Green;
            }
            else
            {
                puan -= 10;
                labelpuan.Text = puan.ToString();
                btnB.BackColor = Color.Red;
            }
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == labeldogru.Text)
            {
                puan += 10;
                labelpuan.Text = puan.ToString();
                btnC.BackColor = Color.Green;
            }
            else
            {
                puan -= 10;
                labelpuan.Text = puan.ToString();
                btnC.BackColor = Color.Red;
            }
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == labeldogru.Text)
            {
                puan += 10;
                labelpuan.Text = puan.ToString();
                btnD.BackColor = Color.Green;
            }
            else
            {
                puan -= 10;
                labelpuan.Text = puan.ToString();
                btnD.BackColor = Color.Red;
            }
            btnsonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            labelzaman.Text = zaman.ToString();
            if(zaman == 0)
            {
                timer1.Enabled = false;
                btnsonraki.Enabled = true;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                puan -= 10;
                labelpuan.Text = puan.ToString();
            }
        }
    }
}
