public class program
{
    public static void Main()
    {
        try{
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"voce digitou o numero {numero}" );
            int resultado = 10 / numero;
            Console.WriteLine($"o resultado é" + resultado);
        } 
        //tratando exceçao de overflow estouro de campo
        catch(OverflowException)
        {
            Console.WriteLine("este numero inteiro é maior que o suportado");
        }
        //tratando exceçao de erro de formato
        catch(FormaException)
        {
            Console.WriteLine("Erro digite um numero inteiro");
        }

        //catch é o tratamento do erro normalmente colocamos as mensagens de acordo
        // com o tipo do erro, para mekhor compreensão

        catch(Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro : {ex.Message}");
        }
        //0 finally é um bloco executado independente se ocorrer ou nao
        finally {
            Console.WriteLine($"entrando no finally");
        }
    }
}