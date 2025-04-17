using exercicio01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    class Produto
    {
        private string? _nome;
        private double _valor;
        private string? _formaPag;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }

        }

        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }

        }

        public string FormaPag
        {
            get { return _formaPag; }
            set { _formaPag = value; }

        }

        public Produto(string nome, double valor, string formapag)
        {
            _nome = nome;
            _formaPag = formapag;
            Valor = valor;

            Desconto();
            
        }
        public void Desconto()
        {
            if(_valor >= 500 && _formaPag?.ToLower() == "pix")
            {
                _valor -= _valor * 0.10;
            }
        }

        public void ApresentarProduto()
        {
            Console.WriteLine($"Nome: {_nome}");
            Console.WriteLine($"valor: {_valor:C}");
            Console.WriteLine($"forma de pagamento: {_formaPag}");
        }

    }
}