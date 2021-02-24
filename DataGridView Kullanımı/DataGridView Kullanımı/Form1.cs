using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_Kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.Rows.Add();
            i = 0;
            dataGridView1.Rows[i].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[i].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[i].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[i].Cells[3].Value = comboBox1.Text;
            dataGridView1.Rows[i].Cells[4].Value = textBox5.Text;
            dataGridView1.Rows[i].Cells[5].Value = textBox6.Text;
            i++;

        }
    }
}
