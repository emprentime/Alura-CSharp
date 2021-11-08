using System;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 6
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;
            idade = 40;
            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);
            /*
             * Como vimos no código acima, nós atribuímos o valor 32 para variável idade e depois criamos a variável idadeGustavo
             * e atribuimos o valor da variável idade para ela. Logo em seguida, alteramos o valor da variável idade para 40 e exibimos os valores das variáveis
             * idade e idadeGustavo. Podemos perceber que os valores saíram diferentes, isso porque não existe uma conexão entre as duas variáveis.
            */
            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
