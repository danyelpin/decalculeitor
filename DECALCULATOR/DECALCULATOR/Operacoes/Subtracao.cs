using DECALCULATOR.Classes;
using DECALCULATOR.Operacoes;

namespace DECALCULATOR;

internal class Subtracao : AOperacoes
{
    public decimal Calcula(decimal numero1, decimal numero2)
    {
        base.Calcula(numero1, numero2);
        return Uteis.Arredonda(numero1 - numero2);
    }
}