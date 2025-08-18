using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECALCULATOR.Classes
{
    internal class Uteis
    {
        public static decimal Arredonda(decimal numero)
        {
            const int NUMERO_DECIMAIS = 2;

            return Math.Round(numero, NUMERO_DECIMAIS);
        }
    }
}
