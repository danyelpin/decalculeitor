namespace DECALCULATOR.Classes;

internal class Uteis
{
    public static decimal Arredonda(decimal numero)
    {
        const int NUMERO_DECIMAIS = 2;

        return Math.Round(numero, NUMERO_DECIMAIS);
    }

    public static void AguardarTecla()
    {
        Console.WriteLine("Aperte qualquer tecla para continuar...");
        Console.ReadKey();
    }
}
