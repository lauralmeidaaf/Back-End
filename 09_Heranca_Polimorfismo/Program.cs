//classe pai que será herdada pelo filho 
// super classe

class Animal
{
    public string cor {get; set;}

    public void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}



/* Classe filha que herda do pai */

class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo")
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando")
    }
}



class Program
{
    public static Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.EmitirSom();


        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}