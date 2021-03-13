using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wordaktar = Microsoft.Office.Interop.Word;
using System.Reflection;
namespace Word___1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Temel Word'e yazı ekleme komutu.
            wordaktar.Application word = new wordaktar.Application();
            word.Visible = true;
            wordaktar.Document worddoc;
            object wordobj = System.Reflection.Missing.Value;
            worddoc = word.Documents.Add(ref wordobj);
            word.Selection.TypeText(richTextBox1.Text);
        }
    }
}
