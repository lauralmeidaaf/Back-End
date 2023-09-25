class Program
{
    public static void Main()
  
    {
       MostrarMensagem("Digite um número para descobrir o dobro");
       int multiplicacao = Dobro(int.Parse(Console.ReadLine()));
       Console.WriteLine($"O dobro {multiplicacao}");
       MostrarMensagem("Digite um número para descobrir a metade");
       int divisao = Metade(int.Parse(Console.ReadLine()));
       Console.WriteLine($"a metade é {divisao}");
       MostrarMensagem("Digite um número para saber sua tabuada");
       
    }

    public static void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
    public static int Dobro(int valor)
    {
        int resultado = valor * 2;
        return resultado;
    }

    public static int Metade(int meio)
    {
        int resultado = meio / 2;
        return resultado;
    }


    public static void Tabuada(int n)
    {
        int contador = 1;

        while (contador <= 1000)
        {
            Console.WriteLine($"A tabuada de {n} x {contador} é {n * contador}");
            contador++;
        }
    }

    public static void ResumoSalarios()
    {
        int somaSalarios = 0;
        int menorSalario = 100000;
        int maiorSalario = 0;
        int salarioEmpregado = 0;

        do {
            Console.WriteLine("Digite o salário do empregado");
            salarioEmpregado = int.Parse(Console.ReadLine());
            
            if (salarioEmpregado > 0)
            somaSalarios = somaSalarios + salarioEmpregado;
            //somaSalarios += salarioEmpregado;
            if (salarioEmpregado < maiorSalario && salarioEmpregado > 0){
                maiorSalario = salarioEmpregado;}
            
            if (salarioEmpregado < menorSalario){
                menorSalario = salarioEmpregado;}

        } while (salarioEmpregado > 0);

        Console.WriteLine($"A soma dos salários é {somaSalarios} o maior salário é {maiorSalario} e o menor salário é {menorSalario}");
    }
}