using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sepet spt = new Sepet();
            Ekmek ekmek = new Ekmek("Ekmek", 1.50, "Tahıllı", 250);
            spt.urunEkle(ekmek);
            CepTelefonu cep = new CepTelefonu("Note 10", 1500, "Samsung");
            spt.urunEkle(cep);
            MessageBox.Show(spt.toplamTutar().ToString());
        }
    }
}
