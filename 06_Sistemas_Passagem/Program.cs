﻿class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Bem-vindo ao SesiBus");
        Console.WriteLine("----------------------");
        Console.WriteLine("Contamos com 42 lugares disponiveis");

        Menu();
        
    }

    public static void Menu()
    {
        string opcao = "";

        do {
            Console.WriteLine("######## MENU ########");
            Console.WriteLine("1 - Para comprar passagem");
            Console.WriteLine("2 - Para poltronas Disponiveis");
            Console.WriteLine("0 - Para fechar o sistema");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao) {
                case "0":
                Console.WriteLine("Obrigado, volte sempre!!!");
                System.Threading.Thread.Sleep(1000);
                break;
                case "1":
                CompraPassagem()
                break

                break;
                case "2":

                default:
                Console.WriteLine("Opção inválida");
                break;
            }

        } while (opcao != "0");
    }
    public static void CompraPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens= int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro:");
            string nome = Console.ReadLine();
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome)
}




















































































































































































































































































































































































































































































