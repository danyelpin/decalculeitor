using DECALCULATOR.Classes;

bool loop = true;

do
{
    Console.Clear();
    Console.WriteLine("=-=-=-=-=-=-=-=-=-= DECALCULEITOR =-=-=-=-=-=-=-=-=-=");
    Console.WriteLine("---Escolha uma das opções abaixo---");
    Console.WriteLine("1 => Somar");
    Console.WriteLine("2 => Subtrair");
    Console.WriteLine("3 => Dividir");
    Console.WriteLine("4 => Multiplicar");
    Console.WriteLine("5 => Sair");
    Console.WriteLine("Opção: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            // Somar();
            Uteis.AguardarTecla();
            break;
        case "2":
            //  Subtrair();
            Uteis.AguardarTecla();
            break;
        case "3":
            //  Dividir();
            Uteis.AguardarTecla();
            break;
        case "4":
            // Multiplicar();
            Uteis.AguardarTecla();
            break;
        case "5":
            loop = false;
            Console.WriteLine("Saindo...");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            Uteis.AguardarTecla();
            break;
    }

}
while (loop);