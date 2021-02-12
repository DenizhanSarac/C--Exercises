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
namespace DbVeriEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kayıtlar;Integrated Security=True");
        private void DBShow() // VeriTabanı Yordamı
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From Gelenler", baglan);  //Tablo Seçimi:
            SqlDataReader oku = komut.ExecuteReader(); //Verileri Okuma.
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["GFirma"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut= new SqlCommand("INSERT INTO Gelenler(AdSoyad,GFirma) VALUES ('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"')",baglan);  // Verileri Ekleme
            komut.ExecuteNonQuery(); //Execute etme.
            baglan.Close();
            DBShow();
        }
    }
}
