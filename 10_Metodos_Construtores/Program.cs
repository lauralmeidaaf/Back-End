using Models;

public class Program
{

    public static void Main()
    {
        //criando um objeto da classe Pessoa
        //instanciando sem um método construtor

       /* Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Laura Almeida";
        pessoa1.idade = 16;
        pessoa1.Cantar();

        //alternativa para criação de um objeto sem construtor 
        Pessoa pessoa2 = new Pessoa{
            nome = "Lauany Almeida",
            idade = 16,
        };
        pessoa2.Cantar();
    */
    Pessoa pessoa1 = new Pessoa("Laura Almeida" , 16, "lauraalmeida@portalsesisp.org.br");
    pessoa1.Cantar();
    pessoa1.Informacoes();

    Pessoa pessoa2 = new Pessoa("Lauany Almeida" , 16, "lauany.almeida@portalsesisp.org.br");
    pessoa2.Cantar();
    pessoa2.Informacoes();

    Pessoa pessoa3 = new Pessoa("Maria Eduarda" , 16, "mariaeduarda.covre@portalsesisp.org.br");
    pessoa3.Cantar();
    pessoa3.Informacoes();


    }

}