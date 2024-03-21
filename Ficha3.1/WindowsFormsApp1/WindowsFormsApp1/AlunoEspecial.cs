using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class AlunoEspecial : Aluno
    {
        // Adicionando o construtor correto e mantendo o campo para a dificuldade
        private string dificuldade;

        // Construtor da classe AlunoEspecial
        public AlunoEspecial(string dificuldade,string NumeroAluno, string Curso, string nome, DateTime dataNascimento, string morada, string tipo) : base(NumeroAluno, Curso, nome, dataNascimento, morada, tipo)
        {
            this.dificuldade = dificuldade;
            
        }

        // Método para retornar a dificuldade do aluno
        public string GetDificuldade()
        {
            return dificuldade;
        }

        // Método para alterar a dificuldade do aluno
        public void SetDificuldade(string dificuldade)
        {
            this.dificuldade = dificuldade;
        }

        // Sobrescrevendo o método DadosAluno para incluir a dificuldade
        public override string DadosAluno()
        {
            // Obtendo os dados do aluno da classe base
            string dadosAluno = base.DadosAluno();

            // Retornando os dados completos do aluno, incluindo a dificuldade
            return $"{dadosAluno}\n" +
                   $"\tDificuldade: {dificuldade}";
        }
    }
}
