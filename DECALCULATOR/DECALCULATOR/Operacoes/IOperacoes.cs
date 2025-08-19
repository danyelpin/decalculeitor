namespace DECALCULATOR.Operacoes;

internal abstract class AOperacoes
{
    public static List<string> Logs { get; private set; } = new List<string>();

    public virtual decimal Calcula(decimal numero1, decimal numero2)
    {
        Logs.Add($"{numero1} {GetType().Name} {numero2}");
        return 0;
    }
}
