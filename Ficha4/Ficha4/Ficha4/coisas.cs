using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha4
{
    internal class coisas
    {
        private string nome;

        private List<int> valores;

        private int totalValores;

        public coisas(string nome)
        {
            this.nome = nome;
            valores = new List<int>();
            totalValores = 0;
        }

        public void inventarValores()
        {
            Random r = new Random();
            valores.Add(r.Next(1, 100));
            totalValores++;
        }

        public override string ToString()
        {
            int somatorioValores = 0;
            foreach (int i in valores)
            {
                somatorioValores += i;
            }
            return nome + " -> valores = " + somatorioValores;
        }

    }
}
