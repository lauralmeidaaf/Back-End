namespace Animal.Model
{
    public class Pantera
    {
        public decimal tamanho{ get; set; }
        public int peso{ get; set; }
        public string cor{ get; set;}
        public string especie{ get; set;}
        public string alimentaca{ get; set;}
    
 public void Apresentar ()
    {
        Console.WriteLine($"A {nome} da especie {especie}, pode chegar aos {idade} e pode medir {comprimento}");
    }
    public void Correr ()
    {
        Console.WriteLine($"A pantera corre? {sim ou não}");
    }
     public void Ccacar ()
    {
        Console.WriteLine($"A pantera caca? {sim ou não}");
    }
     public void Reproduzirr ()
    {
        Console.WriteLine($"A pantera se reproduz? {sim ou não}");
    }
}
}