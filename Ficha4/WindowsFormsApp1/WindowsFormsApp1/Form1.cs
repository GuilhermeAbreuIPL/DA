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

        //função para limpar todos os campos apos ser adicionada uma pessoa, aluno, etc
        private void LimparCampos()
        {
            textBoxNome.Text = "";
            monthCalendarNascimento.SetDate(DateTime.Now);
            textBoxMorada.Text = "";
            textBoxNumeroAluno.Text = "";
            textBoxCurso.Text = "";
            textBoxDificuldade.Text = "";
            textBoxDisciplina.Text = "";
        }

        private void buttonPontuar_Click(object sender, EventArgs e)
        {
            if (listBoxPessoas.SelectedItem != null && listBoxPessoas.SelectedItem is Pessoa)
            {
                Pessoa pessoa = (Pessoa)listBoxPessoas.SelectedItem;
                pessoa.Pontuar();
                listBoxPessoas.Items[listBoxPessoas.SelectedIndex] = pessoa;
            }
            else
            {
                MessageBox.Show("Selecione uma pessoa");
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
                Pessoa pessoa = new Pessoa(textBoxNome.Text, monthCalendarNascimento.SelectionRange.Start, textBoxMorada.Text, "Pessoa");
                listBoxPessoas.Items.Add(pessoa);

                //limpa os campos apos adicionar uma pessoa
                LimparCampos();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonAluno_Click(object sender, EventArgs e)
        {
            //Proteção para não adicionar pessoas sem nome, data de naascimento impossivel, morada, numero de aluno e curso
            if (textBoxNumeroAluno.Text == "" || textBoxCurso.Text == "" || textBoxNome.Text == "" || monthCalendarNascimento.SelectionRange.Start > DateTime.Now || textBoxMorada.Text == "")
            {
                //Proteção para não adicionar pessoas com data de nascimento impossivel
                if (monthCalendarNascimento.SelectionRange.Start > DateTime.Now)
                {
                    MessageBox.Show("Data de nascimento impossivel");
                    return;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente");
                    return;
                }

            }
            else
            {

                Aluno aluno = new Aluno(textBoxNumeroAluno.Text, textBoxCurso.Text, textBoxNome.Text, monthCalendarNascimento.SelectionRange.Start, textBoxMorada.Text, "aluno");
                listBoxPessoas.Items.Add(aluno);

                //limpa os campos apos adicionar um aluno
                LimparCampos();
            }

        }


        private void listBoxPessoas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpa os dados do cargo quando a pessoa é alterada
            textBoxCargo.Text = "";

            if (listBoxPessoas.SelectedIndex != -1 && listBoxPessoas.SelectedItem is Pessoa)
            {
                Pessoa pessoa = (Pessoa)listBoxPessoas.SelectedItem;
                textBoxDados.Text = pessoa.DadosAluno();

            }
            else
            {
                textBoxDados.Text = ""; // Limpa o campo de dados se nenhuma pessoa estiver selecionada
            }
        }

        private void buttonCargo_Click(object sender, EventArgs e)
        {


            if (listBoxPessoas.SelectedItem != null)
                textBoxCargo.Text = ((Pessoa)listBoxPessoas.SelectedItem).TipoDePessoa;
            else
            {
                MessageBox.Show("Selecione uma pessoa");
            }
        }

        private void buttonAlunoEspecial_Click(object sender, EventArgs e)
        {
            //insere um aluno especial
            if (textBoxNumeroAluno.Text == "" || textBoxCurso.Text == "" || textBoxNome.Text == "" || monthCalendarNascimento.SelectionRange.Start > DateTime.Now || textBoxMorada.Text == "" || textBoxDificuldade.Text == "")
            {
                if (monthCalendarNascimento.SelectionRange.Start > DateTime.Now)
                {
                    MessageBox.Show("Data de nascimento impossivel");
                    return;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente");
                    return;
                }

            }
            else
            {
                AlunoEspecial alunoEspecial = new AlunoEspecial(textBoxDificuldade.Text, textBoxNumeroAluno.Text, textBoxCurso.Text, textBoxNome.Text, monthCalendarNascimento.SelectionRange.Start, textBoxMorada.Text, "Aluno Especial");
                listBoxPessoas.Items.Add(alunoEspecial);

                //limpa os campos apos adicionar um aluno especial
                LimparCampos();
            }
        }

        private void buttonProfessor_Click(object sender, EventArgs e)
        {
            //insere um professor
            if (textBoxDisciplina.Text == "" || textBoxNome.Text == "" || monthCalendarNascimento.SelectionRange.Start > DateTime.Now || textBoxMorada.Text == "")
            {
                if (monthCalendarNascimento.SelectionRange.Start > DateTime.Now)
                {
                    MessageBox.Show("Data de nascimento impossivel");
                    return;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente");
                    return;
                }

            }
            else
            {
                Professor professor = new Professor(textBoxDisciplina.Text, textBoxNome.Text, monthCalendarNascimento.SelectionRange.Start, textBoxMorada.Text, "Professor");
                listBoxPessoas.Items.Add(professor);

                //limpa os campos apos adicionar um professor
                LimparCampos();
            }
        }
    }
}
