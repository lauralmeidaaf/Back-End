//O namespace é um novo que usaremos para fazer referência quando uarmos
//em outras classes
namespace Sesi.Model
{
    //declarando nossa classe aluno 

    public class Aluno
    {
        //declarando nossos atributos (propriedade) da classe

        public string nome { get; set;}
        
        public int idade { get; set; }

        public string turma { get; set; }

        private int nrFaltas { get; set; }

        //criando um metodo
        public void Apresentar()
        {
            Console.WriteLine($"Ola meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma}!!!");
        }

        public void AdicionarFaltas(int nr)
        {
            nrFaltas = nrFaltas + nr;
        }

        public void ResumirFaltas()
        {
            Console.WriteLine($"{nome} voce tem {nrFaltas} faltas")
        }

        public void JustificarFaltas(int nr)
        {
            nrFaltas = nrFaltas - nr;
        }


    }
}