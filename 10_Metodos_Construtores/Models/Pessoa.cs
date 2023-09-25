namespace Models
{
    public class Pessoa
    {
        //atributos da class Pessoa

        public string nome { get; set;}

        private int idade { get; set; }

        private string email { get; set;}

        private int anoNascimento{ get; set;}



    //método construtor da class Pessoa

        public Pessoa (string nomePessoa, int idadePessoa, string emailPessoa)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = emailPessoa;
            this.anoNascimento = DateTime.Now.Year - idade;
        }


        //metodo da class Pessoa

        public void Cantar()
        {
            Console.WriteLine($"{nome} está cantando");
        }

        public void Informacoes()
        {
            Console.WriteLine($"Ela tem {idade} anos, tem {idade} anos de idade e nasceu no ano de {anoNascimento}");

           
           
        }
    }

}