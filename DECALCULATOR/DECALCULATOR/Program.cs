using DECALCULATOR;
using DECALCULATOR.Classes;
using DECALCULATOR.Operacoes;

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
    Console.WriteLine("5 => Par/Impar");
    Console.WriteLine("6 => Sair");
    Console.WriteLine("Opção: ");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Menu.MenuSomar();
            break;
        case "2":
            Menu.MenuSubtrair();
            break;
        case "3":
            Menu.MenuDividir();
            break;
        case "4":
            Menu.MenuMultiplicar();
            break;
        case "5":
            Menu.MenuPar();
            break;
        case "6":
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
