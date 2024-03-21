using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Morada { get; set; }
        public int Pontuacao { get; set; }

        public string TipoDePessoa { get; set; }

        public Pessoa(string nome, DateTime dataNascimento, string morada, string tipo)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Morada = morada;
            this.Pontuacao = 0;
            this.TipoDePessoa = tipo;
        }
        public int Idade()
        {
            //Verifica se a data atual e o mes atual é o mesmo de hoje e manda uma mensagem de parabens
            if (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day == DataNascimento.Day)
            {
                System.Windows.Forms.MessageBox.Show("Parabéns " + Nome + "!!", "Parabéns", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            //Verifica se a data de nascimento é maior que a data atual e retorna a idade
            if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
            {
                return DateTime.Now.Year - DataNascimento.Year - 1;
            }
            else
            {
                return DateTime.Now.Year - DataNascimento.Year;
            }

        }

        public void Pontuar()
        {
            //cria uma pontuação random de 0 a 100

            Random random = new Random();
            Pontuacao = random.Next(0, 100);
        }

        public override string ToString()
        {
            return $"{Nome}({DataNascimento.Day}/{DataNascimento.Month}/{DataNascimento.Year}= {Idade()} anos) : {Pontuacao}";
        }


        

        public virtual string DadosAluno()
        {
            //Dados do aluno com informação do Nome, Data de Nascimento, Pontuação
            return $"{Nome} : \n\t" +
                $"Data de nascimento: {DataNascimento.Day}/{DataNascimento.Month}/{DataNascimento.Year}\n\t" +
                $"Idade: {Idade()} \n\t" +
                $"Pontuação: {Pontuacao} \n\t";


        }

    }


}   

