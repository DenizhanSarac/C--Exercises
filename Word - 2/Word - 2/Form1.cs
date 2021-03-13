using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using System.Reflection;

namespace Word___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object omissing = System.Reflection.Missing.Value;
            object dokumansonu = "\\endofdoc";

            word.Application olustur;
            word.Document icerik;
            olustur = new word.Application();
            olustur.Visible = true;
            icerik = olustur.Documents.Add(ref omissing);

          /*  word.Paragraph paragraf1;
            paragraf1 = icerik.Content.Paragraphs.Add(ref omissing);
            paragraf1.Range.Text = "Birinci Paragraf";
            paragraf1.Range.Font.Bold = 1; // kalınlık
            paragraf1.Format.SpaceAfter = 20;
            paragraf1.Range.InsertParagraphAfter();*/

            word.Paragraph paragraf2;
            object orng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            paragraf2 = icerik.Content.Paragraphs.Add(ref orng);
            paragraf2.Range.Text = "İkinci Paragraf.";
            paragraf2.Range.InsertParagraphAfter();

            word.Table olusturtablo;
            word.Range wrdrng = icerik.Bookmarks.get_Item(ref dokumansonu).Range;
            olusturtablo = icerik.Tables.Add(wrdrng, 3, 5, ref omissing, ref omissing);
            olusturtablo.Range.ParagraphFormat.SpaceAfter = 10;
            int r, c;
            string strText;
            for (r = 0; r <=3; r++)
            {
                for (c = 0; c <= 5; c++)
                {
                    strText = "Satır" + r + "Sütun" + c;
                    olusturtablo.Cell(r, c).Range.Text = strText;
                }
                olusturtablo.Rows[1].Range.Font.Bold = 1;
                olusturtablo.Rows[1].Range.Font.Italic = 2;
            }
        }
    }
}
