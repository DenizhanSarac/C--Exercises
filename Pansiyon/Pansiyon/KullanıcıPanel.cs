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

namespace Pansiyon
{
    public partial class KullanıcıPanel : Form
    {
        public KullanıcıPanel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Pansiyon;Integrated Security=True");       
        private void KullanıcıPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String a, b;
            SqlCommand kmt = new SqlCommand("Select * From yonetici", baglanti);
            SqlDataReader oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                a = oku["Kad"].ToString();
                b = oku["Sifre"].ToString();
                if (a == textBox1.Text && b == textBox2.Text)
                {
                    frmKayit frm = new frmKayit();
                    frm.Show();
                    this.Hide();
                   
                }
                else
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!! ");
            }
            baglanti.Close();
        }
    }
}
