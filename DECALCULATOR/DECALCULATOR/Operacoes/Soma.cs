using DECALCULATOR.Classes;

namespace DECALCULATOR.Operacoes;

internal class Soma : AOperacoes
{
    public decimal Calcula(decimal numero1, decimal numero2)
    {
        base.Calcula(numero1, numero2);
        return Uteis.Arredonda(numero1 + numero2);
    }
}
