using DECALCULATOR.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DECALCULATOR.Classes
{
    internal class Menu
    {
        public static void MenuSomar()
        {
            decimal numero1 = Uteis.ReceberNumero("Informe o primeiro número: ");
            decimal numero2 = Uteis.ReceberNumero("Informe o segundo número: ");

            Console.WriteLine($"Resultado: {new Soma().Calcula(numero1, numero2)}");
            Uteis.AguardarTecla();
        }

        public static void MenuSubtrair()
        {
            decimal numero1 = Uteis.ReceberNumero("Informe o primeiro número: ");
            decimal numero2 = Uteis.ReceberNumero("Informe o segundo número: ");

            Console.WriteLine($"Resultado: {new Subtracao().Calcula(numero1, numero2)}");
            Uteis.AguardarTecla();
        }

        public static void MenuDividir() 
        {
            decimal numero1 = Uteis.ReceberNumero("Informe o primeiro número: ");
            decimal numero2 = Uteis.ReceberNumero("Informe o segundo número: ");

            Console.WriteLine($"Resultado: {new Divisao().Calcula(numero1, numero2)}");
            Uteis.AguardarTecla();
        }

        public static void MenuMultiplicar()
        {
            decimal numero1 = Uteis.ReceberNumero("Informe o primeiro número: ");
            decimal numero2 = Uteis.ReceberNumero("Informe o segundo número: ");

            Console.WriteLine($"Resultado: {new Multiplicacao().Calcula(numero1, numero2)}");
            Uteis.AguardarTecla();
        }
    }
}
