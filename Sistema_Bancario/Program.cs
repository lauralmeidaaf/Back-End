using Models;
public class Program{
    public static void Main()
    {
        Console.WriteLine($"Nome?");

        Menu();
    }

    public static void Menu()
    {
        SistemaBancario pessoa1 = new SistemaBancario(Console.ReadLine());
        string opcao = " ";
        do

        {
            Console.WriteLine("----------MENU-----------");
            Console.WriteLine(" 1 - CONSULTAR SALDO");
            Console.WriteLine(" 2 - DEPOSITAR");
            Console.WriteLine(" 3 - SACAR");
            Console.WriteLine(" 4 - SAIR");
            opcao = Console.ReadLine();
            Console.Clear();


            switch (opcao){

            case "0":

        Console.WriteLine("volte sempre");
        System.Threading.Thread.Sleep(1000); 
        break;

        case "1":
        pessoa1.CONSULTARSALDO();
        break;

        case "2":
    Console.WriteLine($"Digite o valor para depositar ");
    decimal VALORDEPOSITADO = decimal.Parse(Console.ReadLine());
    pessoa1.DEPOSITAR(VALORDEPOSITADO);
    break;

    case "3":
    Console.WriteLine($"Digite o valor para sacar");
    decimal VALORDESAQUE = decimal.Parse(Console.ReadLine());
    pessoa1.SACAR(VALORDESAQUE);
    break;

    default:
    Console.WriteLine("Opçâo invalida");
    break;
}
} while (opcao != "0");
}
}
