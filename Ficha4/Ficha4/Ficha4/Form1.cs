using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNomes.Text != "")
            {
                listBoxNomes.Items.Add(textBoxNomes.Text);
                textBoxNomes.Text = "";
            }
            else
            {
                MessageBox.Show("ERRO, Insira um nome");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            List<coisas> coisas = new List<coisas>();
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                coisas c = new coisas(listBoxNomes.Items[r.Next(0, listBoxNomes.Items.Count)].ToString());
                c.inventarValores();
                coisas.Add(c);
            }
            listBoxBalburdia.DataSource = coisas;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            foreach (coisas c in listBoxBalburdia.Items)
            {
                c.inventarValores();
            }
            listBoxBalburdia.DataSource = null;
            listBoxBalburdia.DataSource = listBoxBalburdia.Items;

        }
    }
}
