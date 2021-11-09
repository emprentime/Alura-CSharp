using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 11

            Console.WriteLine("Executando o projeto 11");

            double valorInvestido = 1000;

            /*
             * Para fazer um loop no C#, utilizaremos, inicialmente, a instrução for.
             * O for é uma instrução que possui três partes:
             * A primeira parte é a inicialização, na qual podemos declarar e inicializar uma variável que será utilizada no for;
             * A segunda parte é a condição do loop. Enquanto a condição do loop for verdadeira, o loop continuará executando;
             * A terceira parte é a atualização, na qual podemos atualizar as variáveis que são utilizadas pelo for.
             * Cada uma das partes do for é separada por um ;.
             * Fonte: https://www.caelum.com.br/apostila-csharp-orientacao-objetos/estruturas-de-repeticao#repetindo-um-bloco-de-codigo
             */

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine(
                    "Após " + contadorMes +
                    " meses, você terá R$" + valorInvestido);
            }

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
