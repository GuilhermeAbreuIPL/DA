using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Professor:Pessoa
    {
        public String Disciplina { get; set; }

        public Professor(string Disciplina, string nome, DateTime dataNascimento, string morada, string tipo) : base(nome, dataNascimento, morada, tipo)
        {
            this.Disciplina = Disciplina;
            
        }

        public override string DadosAluno()
        {
            // Chame o método na classe base para obter os dados da pessoa
            string dadosPessoa = base.DadosAluno();

            // Adicione os dados específicos do aluno (número do aluno e curso)
            return $"{dadosPessoa}\n\t" +
                   $"Disciplina: {Disciplina}";
        }


    }
}
