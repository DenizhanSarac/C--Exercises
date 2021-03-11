using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            label1.Text = e.Node.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Just Node or Parents.
            /*TreeNode ekle = new TreeNode("Linux");
            treeView1.Nodes.Add(ekle);

            ekle = new TreeNode("Windows");
            treeView1.Nodes.Add(ekle);

            TreeNode cocuk1 = new TreeNode("C#");
            TreeNode cocuk2 = new TreeNode("C++");
            TreeNode cocuk3 = new TreeNode("Asp.net");

            TreeNode[] arr=new TreeNode[]{cocuk1,cocuk2,cocuk3};
            ekle = new TreeNode("Programlama Dilleri", arr);
            treeView1.Nodes.Add(ekle);*/
            
            //Child
            for(int i=1;i<=10;i++)
            {
                treeView1.Nodes.Add(i.ToString());
                for(int k=1;k<=3;k++)
                {
                    treeView1.Nodes[i - 1].Nodes.Add(k.ToString()); // Child
                }
            }
            //Düğümleri Gösterme.
            for (int j = 0; j < treeView1.Nodes.Count; j++)
                listBox1.Items.Add(treeView1.Nodes[j]);
        }
    }
}
