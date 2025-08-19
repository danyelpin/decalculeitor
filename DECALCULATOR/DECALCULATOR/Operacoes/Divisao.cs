using DECALCULATOR.Classes;
using DECALCULATOR.Operacoes;

internal class Divisao : AOperacoes
{
    public decimal Calcula(decimal numero1, decimal numero2)
    {
        base.Calcula(numero1, numero2);

        if (numero2 == 0)
            return 0;

        return Uteis.Arredonda(numero1 / numero2);
    }
}
