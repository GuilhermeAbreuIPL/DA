using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }

        private void buttonPontuar_Click(object sender, EventArgs e)
        {
            if (listBoxPessoas.SelectedItem != null)
            {
                Pessoa pessoa = (Pessoa)listBoxPessoas.SelectedItem;
                pessoa.Pontuar();
                listBoxPessoas.Items[listBoxPessoas.SelectedIndex] = pessoa;
            }

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            //Proteção para não adicionar pessoas sem nome, data de naascimento impossivel e morada
            if (textBoxNome.Text == "" || monthCalendarNascimento.SelectionRange.Start > DateTime.Now || textBoxMorada.Text == "")
            {
                if(monthCalendarNascimento.SelectionRange.Start > DateTime.Now)
                {
                    MessageBox.Show("Data de nascimento impossivel");
                    return;
                }
                else {
                    MessageBox.Show("Preencha todos os campos corretamente");
                    return;
                }
            
            }
            else {
                //cria uma pessoa com nome, data de nascimento e morada
                Pessoa pessoa = new Pessoa(textBoxNome.Text, monthCalendarNascimento.SelectionRange.Start, textBoxMorada.Text);
                listBoxPessoas.Items.Add(pessoa);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
