using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Abstração
{
    class Pessoa : Acoes
    {
        public override void andar()
        {
            Console.WriteLine("Andando...");
        }

        public override void falar()
        {
            Console.WriteLine("falando...");
        }
    }
}
