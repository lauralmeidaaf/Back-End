using Sesi.Model;


class Program
{
    public static void Main()
    {
        //criando uma varivel aluno1 e instanciando da classe aluno
        //ou seja, estamos criando nosso objeto
        var Pantera = new Aluno();
        //atribuindo um valor ao atributo nome do aluno1 
        
       
        Pantera.tamanho = 1m;
        Pantera.peso = "120kg";
        Pantera.cor ="Preta";
        Pantera.especie="comum";
        Pantera.alimentacao ="carnivora";
        //chamando o metodo da classe aluno
        Pantera.correr();
        Pantera.cacar();
        Pantera.reproduzir();


    }
}