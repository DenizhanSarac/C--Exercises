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
namespace EmlakKayıtProgramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Siteler;Integrated Security=True");
        private void veriGetir()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand kmt = new SqlCommand("Select * From sitebilgi", baglan);
            SqlDataReader oku = kmt.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem liste = new ListViewItem();
                liste.Text = oku["id"].ToString();
                liste.SubItems.Add(oku["site"].ToString());
                liste.SubItems.Add(oku["alsat"].ToString());
                liste.SubItems.Add(oku["oda"].ToString());
                liste.SubItems.Add(oku["metre"].ToString());
                liste.SubItems.Add(oku["fiyat"].ToString());
                liste.SubItems.Add(oku["blok"].ToString());
                liste.SubItems.Add(oku["numara"].ToString());
                liste.SubItems.Add(oku["adsoyad"].ToString());
                liste.SubItems.Add(oku["telefon"].ToString());
                liste.SubItems.Add(oku["notlar"].ToString());
                listView1.Items.Add(liste);
            }
            baglan.Close();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Zambak")
            {
                btnzambak.BackColor = Color.Yellow;
                btngul.BackColor = Color.Gray;
                btnmenekse.BackColor = Color.Gray;
                btnpapatya.BackColor = Color.Gray;
            }
                
            if (comboBox1.Text == "Papatya")
            {
                btnpapatya.BackColor = Color.Yellow;
                btngul.BackColor = Color.Gray;
                btnmenekse.BackColor = Color.Gray;
                btnzambak.BackColor = Color.Gray;
            }
                
            if (comboBox1.Text == "Menekşe")
            {
                btnpapatya.BackColor = Color.Gray;
                btngul.BackColor = Color.Gray;
                btnmenekse.BackColor = Color.Yellow;
                btnzambak.BackColor = Color.Gray;
            }
               
            if (comboBox1.Text == "Gül")
            {
                btnpapatya.BackColor = Color.Gray;
                btngul.BackColor = Color.Yellow;
                btnmenekse.BackColor = Color.Gray;
                btnzambak.BackColor = Color.Gray;
            }
               
            
        }

        private void btngoruntule_Click(object sender, EventArgs e)
        {
            veriGetir();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt=new SqlCommand("insert into sitebilgi (site,alsat,oda,metre,fiyat,blok,numara,adsoyad,telefon,notlar) values('"+comboBox1.Text.ToString()+"','"+comboBox2.Text.ToString()+"','"+comboBox3.Text.ToString()+"','"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+comboBox4.Text.ToString()+"','"+textBox6.Text.ToString()+"','"+textBox4.Text.ToString()+"','"+textBox5.Text.ToString()+"','"+textBox3.Text.ToString()+"')",baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            veriGetir();

            
        }
        int id = 0;
        private void btnsil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt=new SqlCommand("Delete from sitebilgi where id=('" +id+  "')",baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            veriGetir();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id=int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            comboBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBox4.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[7].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[9].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void btmduzelt_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("update sitebilgi set site='" + comboBox1.Text.ToString() + "',alsat='" + comboBox2.Text.ToString() + "',oda='" + comboBox3.Text.ToString() + "',metre='" + textBox1.Text.ToString() + "',fiyat='" + textBox2.Text.ToString() + "',blok='" + comboBox4.Text.ToString() + "',numara='" + textBox6.Text.ToString() + "',adsoyad='" + textBox4.Text.ToString() + "',telefon='" + textBox5.Text.ToString() + "',notlar='" + textBox3.Text.ToString() + "' where id=" + id + "", baglan);
            kmt.ExecuteNonQuery();
            baglan.Close();
            veriGetir();
        }
    }
}
