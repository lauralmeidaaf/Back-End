namespace Models
{

    public class Cliente
    {
        public int idCliente { get; set; }
        private string nome { get; set; }
        private string email { get; set; }

        private int cpf { get; set; }

        private int telefone { get; set; }

        private int cep { get; set; }

        private string referencias { get; set; }

        private string senha { get; set; }

        private string rua { get; set; }

        private string bairro { get; set; }

        private decimal numero { get; set; }



       

        public Cliente (string nomeCliente, string emailCliente, int cpfCliente, int telefoneCliente, int cepCliente, string referenciasCliente,
          string senhaCliente, string ruaCliente, string bairroCliente, decimal numeroCliente)
        {
            this.nome = nomeCliente;
            this.email = emailCliente;
            this.cpf = cpfCliente;
            this.telefone = telefoneCliente;
            this.cep = cepCliente;
            this.referencias = referenciasCliente;
            this.senha = senhaCliente;
            this.rua = ruaCliente;
            this.bairro = bairroCliente;
            this.numero = numeroCliente;

        }

    }
}