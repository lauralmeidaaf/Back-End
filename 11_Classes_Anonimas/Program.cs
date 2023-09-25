public class Program
{

    public static void Main()
    {
        //Criando uma class anônima (class sem definição inicial)
        var pessoa1 = new {
            nome = "João",
            idade = 17 
        };

        var pessoa2 = new {
            nome = "Maria",
            email = "maria@aluno.senai.br"
        };

        Console.WriteLine($" A pessoa1 é {pessoa1.nome} e tem {pessoa1.idade} anos");
        Console.WriteLine($" A pessoa1 é {pessoa2.nome} e tem {pessoa2.email} anos");

       // pessoa1.nome = "Douglas";

       var carro1 = new{
        marca = "Toyota",
        modelo = "Corolla",
        ano = "2019",
       };

        var carro2 = new{
        marca = "Hyundai",
        modelo = "Creta",
        ano = "2018",
       };

        Console.WriteLine($" A marca {carro1.marca} no ano de {carro1.ano} produziu o modelo {carro1.modelo}");
        Console.WriteLine($" A marca {carro2.marca} no ano de {carro2.ano} produziu o modelo {carro2.modelo}");



    }
}