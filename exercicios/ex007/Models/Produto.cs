namespace Models
{

    public class Produto
    {   
        public int idProduto { get; set; }
        private string nome1 {get; set;}
        private string descricao {get; set;}

        private decimal valor {get; set;}

        private string foto {get; set;}

        public Produto (string nome1Produto, string descricaoProduto, decimal valorProduto, string fotoProduto)
        {
            this.nome1 = nome1Produto;
            this.descricao = descricaoProduto;
            this.valor = valorProduto;
            this.foto = fotoProduto;



        }
    }
}