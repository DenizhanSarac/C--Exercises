using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace System_Net_Library
{
    public partial class WebSitesiIpAdresiBulma : Form
    {
        public WebSitesiIpAdresiBulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                IPHostEntry siteismi = Dns.GetHostEntry(textBox1.Text);
                IPAddress[] ip = siteismi.AddressList;
                textBox2.Text = ip[0].ToString();
                ListViewItem ekle = new ListViewItem();
                ekle.Text = textBox1.Text.ToString();
                ekle.SubItems.Add(textBox2.Text.ToString());
                listView1.Items.Add(ekle);
                textBox1.Clear();
                textBox2.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("Böyle Bir Site Bulunamadı.");
            }
        }
    }
}
