using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Pessoa
    {
        private string? _nome { get; set; }
        private int _idade { get; set; }
        private string? _cidade { get; set; }

        public Pessoa(string nome, int idade, string cidade)
        {
            _nome = nome;
            _idade = idade;
            _cidade = cidade;
            Menssagem();
        }

        private void Menssagem()
        {
            Console.WriteLine($"Nome: {_nome}, Idade: {_idade}, Cidade: {_cidade}");
        }
    }
}
