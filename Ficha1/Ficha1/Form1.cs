using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_Button_Click(object sender, EventArgs e)
        {
            String horas = DateTime.Now.ToLongTimeString();
            label_hours.Text = horas;
            button_hours.BackColor = Color.Green;
            button_hours.ForeColor = Color.Red;
        }
    }
}
