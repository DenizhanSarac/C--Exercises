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
/*

 * DENİZHAN SARAÇ 
 * PLATFORM: GİTHUB
 * CODE : C#
 * DATE: 20/02/2021
 * CONTENT: DATAGRIDVIEW ADD, DELETE WİTH SQL 
 * maıl: dnzhn.src@outlook.com
 * 
 */

namespace DataGridView_Add.Delete_with_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Kutuphane;Integrated Security=True");
        //Connection.
        private void ShowData(string data)//Shows Data.
        {
            SqlDataAdapter da = new SqlDataAdapter(data,conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //Source.
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            ShowData("Select * From Kitaplar");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            conn.Open(); //Connection Started.
            SqlCommand kmt = new SqlCommand("Insert into Kitaplar (kitapad,yazar,yayınevi,sayfasayısı) values(@tadı,@tyazar,@tyayın,@tsayfa)",conn); // Command created.
            kmt.Parameters.AddWithValue("@tadı", textBox1.Text);
            kmt.Parameters.AddWithValue("@tyazar", textBox2.Text);
            kmt.Parameters.AddWithValue("@tyayın", textBox3.Text);
            kmt.Parameters.AddWithValue("@tsayfa", textBox4.Text);
            kmt.ExecuteNonQuery();
            ShowData("Select * From Kitaplar");
            conn.Close();
            Clear(); 
        }
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, System.EventArgs e) // Delete Code.
        {
            conn.Open(); //Connection Started.
            SqlCommand kmt = new SqlCommand("Delete From Kitaplar where kitapad=@tadi", conn); // Command created.
            kmt.Parameters.AddWithValue("@tadi", textBox5.Text);
            kmt.ExecuteNonQuery();
            ShowData("Select * From Kitaplar");
            conn.Close();
            Clear();
        }

        private void button4_Click(object sender, EventArgs e) // Search Code.
        {
            conn.Open();
            SqlCommand kmt = new SqlCommand("Select * From Kitaplar where  kitapad like '%"+textBox6.Text+"%'", conn); // Command created.
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // Select Rows in Datagridview.
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            string yazar = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            string yayın = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            string sayfasay = dataGridView1.Rows[secili].Cells[4].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = yazar;
            textBox3.Text = yayın;
            textBox4.Text = sayfasay;
            



        }

        private void button5_Click(object sender, EventArgs e) //Update data
        {
            conn.Open();
            SqlCommand kmt=new SqlCommand("update Kitaplar set yazar='"+textBox2.Text+"',yayınevi='"+textBox3.Text+"',sayfasayısı='"+textBox4.Text+"' where kitapad='"+textBox1.Text+"' ",conn);
            kmt.ExecuteNonQuery();
            ShowData("Select * From Kitaplar");
            conn.Close();
        }



    }
}
