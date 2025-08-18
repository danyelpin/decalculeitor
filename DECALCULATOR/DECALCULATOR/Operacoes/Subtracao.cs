using DECALCULATOR.Operacoes;

namespace DECALCULATOR;

public class Subtracao : IOperacoes
{
    public decimal Calcula(decimal numero1, decimal numero2)
    {
        return numero1 - numero2;
    }
}