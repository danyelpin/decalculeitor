using DECALCULATOR.Classes;

namespace DECALCULATOR.Operacoes;

internal class Soma : IOperacoes
{
    public decimal Calcula(decimal numero1, decimal numero2)
    {
        return Uteis.Arredonda(numero1 + numero2);
    }
}
