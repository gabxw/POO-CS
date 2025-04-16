using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Interface
{
    interface ICalculadoraBase
    {
        double soma(int num1, int num2);
        double subtracao();
        double divisao();
        double multiplicao();
    }
}
