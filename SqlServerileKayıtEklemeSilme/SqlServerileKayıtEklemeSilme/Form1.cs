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

namespace SqlServerileKayıtEklemeSilme
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        private void veriGetir()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from kitaplar",baglan);
            SqlDataReader read= komut.ExecuteReader();
            while(read.Read())
            {
                ListViewItem ekle=new ListViewItem();
                ekle.Text=read["id"].ToString();
                ekle.SubItems.Add(read["kitapad"].ToString());
                ekle.SubItems.Add(read["yazar"].ToString());
                ekle.SubItems.Add(read["yayınevi"].ToString());
                ekle.SubItems.Add(read["sayfasayısı"].ToString());

                listView1.Items.Add(ekle);
            }
            baglan.Close();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
             veriGetir();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO kitaplar (kitapad,yazar,yayınevi,sayfasayısı) values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"','"+textBox4.Text.ToString()+"')",baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriGetir();
            TextTemizle();
        
        }
        private void TextTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        int id = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM kitaplar where id=(" + id + ")", baglan);
            komut.ExecuteNonQuery();
            TextTemizle();
            baglan.Close();
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text=(listView1.SelectedItems[0].SubItems[1].Text);
            textBox2.Text = (listView1.SelectedItems[0].SubItems[2].Text);
            textBox3.Text = (listView1.SelectedItems[0].SubItems[3].Text);
            textBox4.Text = (listView1.SelectedItems[0].SubItems[4].Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update kitaplar set kitapad='"+textBox1.Text.ToString()+"',yazar='"+textBox2.Text.ToString()+"',yayınevi='"+textBox3.Text.ToString()+"', sayfasayısı='"+textBox4.Text.ToString()+"' where id=" +id+ "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            veriGetir();
        }
    }
}
