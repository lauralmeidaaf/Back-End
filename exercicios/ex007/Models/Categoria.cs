namespace Models
{

    public class Categoria
    {

        public int idCategoria { get; set; }
        private string nome { get; set; }

        public Categoria(string nomeCategoria)
        {
            this.nome = nomeCategoria;
        }
    }
}