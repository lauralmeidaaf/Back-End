//receber nome
Console.WriteLine("Nome?");

string nome = Console.ReadLine();
Console.WriteLine($"Nome {nome}");


//armazenar nota

Console.WriteLine("Nota 1:");
int nota1 = int.Parse(Console.ReadLine());

Console.WriteLine("Nota 2:");
int nota2 = int.Parse(Console.ReadLine());

Console.WriteLine("Nota 3:");
int nota3 = int.Parse(Console.ReadLine());



int media = (nota1 + nota2 + nota3) /3;

string resposta = (media >=7) ? $" a nota é {media}, o aluno {nome} foi aprovado" : $" a nota é {media}, o aluno {nome} foi reprovado";
Console.WriteLine(resposta);







