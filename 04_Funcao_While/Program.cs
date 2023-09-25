//função em javascript
//function nomeFuncao (nome) {//}

//funcao metodo em C#
//public static string NomeFuncao(String nome) {//}

class Sesi
{
public static void Main()
{
MostrarMensagem("Seja bem-vindo");
MostrarMensagem(" SESI / SENAI ");

double potencia = Potenciacao(4)
Console.Writeline($"Potenciação {potencia}")
}

public static void MostrarMensagem(string mensagem)
{
    Console.WriteLine(mensagem);
}



public static double Potenciacao(int num){
    double resultado = Math.Pow(num, 4);
    return resultado;


}


public static void ContagemRegressiva(int n)
{
    Console.WriteLine(mensagem);
}





public static void JogoQuerNrSouEu()
{
    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * *");
    Console.WriteLine("               Bem Vindo ao Jogo               ");
    Console.WriteLine("Sorteie um numero de 1 a 20, tente adivinha-lo");
    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * *");
    Console.WriteLine("");//linha em branco

    Random rnd = new Random();
    int nrSorteado = rnd.next(20);
    int nrDigitado = -1

    do{
        Console.WriteLine("Digite um n°");
        nrDigitado = int.Parse(Console.ReadLine());
        if (nrDigitado > nrSorteado)
        Console.WriteLine("O numero digitado é MAIOR que o sorteado");
    else if (nrDigitado != nrSorteado)
    Console.WriteLine("O numero digitado é MENOR que o sorteado");
      }while (nrDigitado != nrSorteado);

    Console.WriteLine("Parabens você acertou")
}
}