using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECALCULATOR.Classes
{
    internal class Uteis
    {
        public static void AguardarTecla()
        {
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static decimal ReceberNumero(string msg)
        {
            Console.WriteLine(msg);
            return decimal.Parse(Console.ReadLine());

        }

    }
}
