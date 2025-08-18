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
            break;
        case "2":
          //  Subtrair();
            break;
        case "3":
          //  Dividir();
            break;
        case "4":
            // Multiplicar();
            break;
        case "5":
            loop = false;
            Console.WriteLine("Saindo...");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

}
while (loop);