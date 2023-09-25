using System.Data.Common;

namespace Models
{

    public class Pedido
    {
        public int idPedido { get; set; }
        private decimal valor { get; set; }

        private int quantidade { get; set; }

        private string endereco { get; set; }

        private string metodoDePagamento { get; set; }

        private string tempoEstimadoDeEspera { get; set; }



        public Pedido(decimal valorPedido,  int quantidadePedido,
         string enderecoPedido, string metodoDePagamentoPedido, string tempoEstimadoDeEsperaPedido)
        {

            this.valor = valorPedido;
            this.endereco = enderecoPedido;
            this.metodoDePagamento = metodoDePagamentoPedido;
            this.tempoEstimadoDeEspera = tempoEstimadoDeEsperaPedido;


        }
    }
}