using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05herança
{
    class Pessoa
    {
        protected string? Nome;
        protected int Idade;

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ApresentarPessoa()
        {
            Console.WriteLine($"nome: {Nome}, idade: {Idade}");
        }
    }
}
