using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECALCULATOR.Operacoes
{
    internal class Multiplicacao : IOperacoes
    {
        public decimal Calcula(decimal numero1, decimal numero2)
        {
            return numero1 * numero2;
        }
    }
}
