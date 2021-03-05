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
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=Pansiyon;Integrated Security=True");
        int id;
        private void ShowData()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand kmt = new SqlCommand("Select * From musteri", baglan);
            SqlDataReader oku = kmt.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["Ad"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["GTarih"].ToString());
                ekle.SubItems.Add(oku["CTarih"].ToString());
                ekle.SubItems.Add(oku["Hesap"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }
        public void TextTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            dateTimePicker2.ResetText();
            dateTimePicker1.ResetText();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("INSERT INTO musteri(Ad,Soyad,Telefon,OdaNo,GTarih,CTarih,Hesap) Values(@ad,@soyad,@telefon,@odano,@Gtarih,@Ctarih,@hesap)",baglan);
            kmt.Parameters.AddWithValue("@ad", textBox1.Text);
            kmt.Parameters.AddWithValue("@soyad", textBox2.Text);
            kmt.Parameters.AddWithValue("@telefon", textBox3.Text);
            kmt.Parameters.AddWithValue("@odano",textBox4.Text);
            kmt.Parameters.AddWithValue("@Gtarih", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            kmt.Parameters.AddWithValue("@ctarih", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            kmt.Parameters.AddWithValue("@hesap", textBox5.Text);
            kmt.ExecuteNonQuery();
            baglan.Close();
            ShowData();

        }

        private void frmKayit_Load(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox4.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[5].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[7].Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("Update musteri set Ad=@uad, Soyad=@usoyad,Telefon=@utelefon,OdaNo=@uodano,GTarih=@ugtarih,CTarih=@uctarih,Hesap=@uhesap where id=@uid ", baglan);
            kmt.Parameters.AddWithValue("@uad", textBox1.Text);
            kmt.Parameters.AddWithValue("@usoyad", textBox2.Text);
            kmt.Parameters.AddWithValue("@utelefon", textBox3.Text);
            kmt.Parameters.AddWithValue("@uodano", textBox4.Text);
            kmt.Parameters.AddWithValue("@ugtarih", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
            kmt.Parameters.AddWithValue("@uctarih", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
            kmt.Parameters.AddWithValue("@uhesap", textBox5.Text);
            kmt.Parameters.AddWithValue("@uid", id);
            kmt.ExecuteNonQuery();
            baglan.Close();
            ShowData();
            TextTemizle();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("Delete From musteri where id=@did", baglan);
            kmt.Parameters.AddWithValue("@did", id);
            kmt.ExecuteNonQuery();
            baglan.Close();
            ShowData();
            TextTemizle();
        }
    }
}
