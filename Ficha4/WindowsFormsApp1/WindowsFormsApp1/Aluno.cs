using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     class Aluno:Pessoa
    {

        public String NumeroAluno { get; set; }

        public String Curso { get; set; }

        public Aluno(string NumeroAluno, string Curso, string nome, DateTime dataNascimento, string morada, string tipo) : base(nome, dataNascimento, morada, tipo)
        {
            this.NumeroAluno = NumeroAluno;
            this.Curso = Curso;
            
            
        }

        public override string DadosAluno()
        {
            // Chame o método na classe base para obter os dados da pessoa
            string dadosPessoa = base.DadosAluno();

            // Adicione os dados específicos do aluno (número do aluno e curso)
            return $"{dadosPessoa}\n\t" +
                   $"Numero do aluno: {NumeroAluno}\n\t" +
                   $"Curso: {Curso}";
        }
    }
}
