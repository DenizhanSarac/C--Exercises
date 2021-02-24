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

namespace DataGridView_With_Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Bilgi;Integrated Security=True");
        //Connection
        private void ShowData(string veriler) //Veriler Çekilir.
        {
            SqlDataAdapter da = new SqlDataAdapter(veriler, conn); //Bağlantı ile ilişkendirme yapılır.
            DataSet ds = new DataSet(); //Datagridview doldurmak için kullanılır.
            da.Fill(ds); // Fill edilir.

            dataGridView1.DataSource = ds.Tables[0]; //Verilerin nereden başlayacağını gösteririr.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData("Select * From Kisiler"); //Sting veriler olarak bu satır gönderilir, ilişkendirme alanında kullanılır.

        }
    }
}
