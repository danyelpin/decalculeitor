using DECALCULATOR.Operacoes;

public class Divisao : IOperacoes
{
    public decimal Calcula(decimal numero1, decimal numero2)
    {
        if (numero2 == 0)
            return 0;

        return numero1 / numero2;
    }
}
