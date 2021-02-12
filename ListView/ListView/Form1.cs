using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //Sql Veritabanı Kütüp.
namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan= new SqlConnection("Data Source=.;Initial Catalog=Ogrenci;Integrated Security=True"); //Veritabanı Bağlantısı:
        private void VerileriGoster()
        {
            baglan.Open(); //Bağlantı başlangıcı
            SqlCommand komut = new SqlCommand("Select * from Ogr",baglan); //İlişkenlendirme.
            SqlDataReader read = komut.ExecuteReader(); //Okuma

            while (read.Read())  //Kırılma Döngüsü: 
            {
                ListViewItem ekle = new ListViewItem(); // List Elemanı:
                ekle.Text = read["AdSoyad"].ToString(); //İlk Eleman Ekleme: 
                ekle.SubItems.Add(read["Sehir"].ToString());
                ekle.SubItems.Add(read["Okul"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close(); // Bağlantı Kapama.
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
