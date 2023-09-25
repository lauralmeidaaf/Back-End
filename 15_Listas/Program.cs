using System.Collections.Generic;
using Sesi.Models;

public class Program
{
    public static void Main()
    {
        List<int> listaNumeros = new List<int>();

        //adicionar elementos à lista
        listaNumeros.Add(10); // posição [0]
        listaNumeros.Add(20); // posição [1]
        listaNumeros.Add(30); // posição [2]

        //acessando os dados da lista pelo índice
        Console.WriteLine(listaNumeros[0]);

        //contagem de elementos 
        Console.WriteLine($"Neste momento temos {listaNumeros.Count} elementos");

        listaNumeros.Add(55); //posição [3]
        Console.WriteLine($" Neste momento temos {listaNumeros.Count} elementos");

        ///////////////////////////////////////////////////
        
        Console.WriteLine("####################################")

        List<string> listaNomes = new List<string>();

        //Adicionando elementos a lista
        listaNomes.Add("Laura"); //posição [0]
        listaNomes.Add("Lauany"); //posição [1]
        listaNomes.Add("Lopes"); //posição [2]

        Console.WriteLine(listaNomes[2]);
        Console.WriteLine($"Nesse momento temos {listaNomes.Count} elementos");
        //criando uma lista de numeros ja atribuindo valores
        Lista<int> numeros = new List<int> { 1, 2, 3 , 4, 5};
        Console.WriteLine($"Quantidade de elementos na lista números: {numeros.Count}");
        numeros.Remove(2); //remover o elemento 2
        numeros.RemoveAt(1); //remover o elemento no índice 1
        numeros.RemoveRange(2, 2); // remover 2 elementos a partir do indice 2

        //substituindo informações do item da lista 
        numeros[0] = 100;

        //Iterando sobre todos os itens da lista
        foreach(int item in numeros)
        {
            Console.WriteLine(item);
        }

        //criando uma lista com objeto da classe aluno
        List<Aluno> listaAlunos = new List<Aluno>();

        //adicionando um novo aluno a minha lista
        Aluno novoAluno = new Aluno("Pedro", 16);
        listaAlunos.Add(novoAluno);

        listaAlunos.Add(new Aluno("Patricia", 17));
        listaAlunos.Add(new Aluno("Bob", 17));

        //Exibindo lista de Alunos
        Console.WriteLine("Lista Alunos:");
        foreach(T item in listaAlunos)
        {
            Console.WriteLine($"Nome do aluno: {item.nome} tem {item.idade} anos");
        }

        //criando em uma nova lista por nome
        var ordenacao = from aluno in listaAlunos
                        where aluno.idade == 17
                        orderby aluno.nome
                        select aluno.nome;

        foreach (var aluno in ordenacao)
        {
            Console.WriteLine(aluno);
        }

        //LQN utilizando sintaxe de metodo 
        var consulta = listaAlunos 
                        .where(aluno => aluno.idade == 17)
                        .orderby(novoAluno => novoAluno.nome)
        foreach (var aluno in consulta)
        {
            Console.WriteLine(aluno.nome);
        }


    }

    

}