namespace Models
{
    public class SaldoBancario
    {
        private string nome{get; set;}
        private decimal saldo{get; set;}


        public SaldoBancario(string nomePessoa)
            
            {
                this.nome = nomePessoa;
            }




            public void CONSULTARSALDO()
            {
                Console.WriteLine($"Seu saldo atual é de {saldo} !!!");
            }




            public void DEPOSITAR(decimal valor)
            {
                saldo + = valor;
                if(valor > 0);
            }




            public void SACAR(decimal valor)
            {
                saldo - = retirarValor;
                if(saldo <= retirarValor);
                else
                {Console.WriteLine($"Seu saldo é negativo para a retirada do valor!!!");}
            }
    }
}