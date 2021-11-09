using System;

namespace P12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 12
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            /*
             * Nós fizemos uma construção que chamamos de laços for encadeado, são casos em que temos um for dentro de outro. 
             * Temos um primeiro laço que faz a contagem de anos e, dentro, temos outro que faz a contagem por mês.
             * Dentro do primeiro ano nós fazemos a iteração 12 vezes, por causa do contador do mês.
             * Depois, saímos do for e terminamos a execução do for externo e somamos mais +1. 
             * Voltaremos a executar o contadorMes = 1 e vamos somando até chegar aos próximos anos.
             * 
             * INSTRUTOR(A): Guilherme Matheus Costa
             */

            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
