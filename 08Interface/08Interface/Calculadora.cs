using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface
{
    class Calculadora : ICalculadoraBase, ICalculadoraAvancada
    {

        public double Cosseno()
        {
            throw new NotImplementedException();
        }

        public double divisao()
        {
            throw new NotImplementedException();
        }

        public double multiplicao()
        {
            throw new NotImplementedException();
        }

        public double Seno()
        {
            throw new NotImplementedException();
        }

        public double soma(int num1, int num2)
        {
            return (num1 + num2);
        }

        public double subtracao()
        {
            throw new NotImplementedException();
        }

        public double Tangente()
        {
            throw new NotImplementedException();
        }
    }
}

