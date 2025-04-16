using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05herança
{
    class Colaborador : Pessoa
    {
        protected string? Cargo;
        protected double Salario;

        public Colaborador(string nome , int idade, string cargo, double salario) : base(nome, idade)
        {
            Cargo = cargo;
            Salario = salario;

            ApresentarPessoa();
            ApresentarColaborador();
        }

        public void ApresentarColaborador()
        {
            Console.WriteLine($"cargo: {Cargo}, salario: {Salario:C}");
        }

    }
}
