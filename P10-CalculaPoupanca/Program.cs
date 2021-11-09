using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 10

            Console.WriteLine("Executando projeto 10 - Calcula poupança.");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                // As próximas três linhas de código abaixo são equivalentes
                // contadorMes = contadorMes + 1;
                // contadorMes += 1;
                contadorMes++;

                /*
                 * Observação:
                 * Quando usamos +=, o compilador vai somar +1 com a variável à esquerda e guardará o novo valor em contadorMes.
                 * Se executarmos o código, teremos o mesmo comportamento do código.
                 * Nós estamos somando apenas 1, mas também existe um forma mais apropriada de escrevermos isso,
                 * substituindo +1 por ++. Com isso repetimos a tarefa de incremetar +1 e novamente, salvamos na variável.
                 * Continuaremos tendo o mesmo comportamento do código, porém, quando incrementamos +1 é estranho escrevermos desta forma.
                 * No entanto, ao somarmos uma quantidade maior, torna-se importante usar +=, como +2 ou + 3.
                 * 
                 * O while aceita receber dois valores, true e false. O valor true mantém o loop em execução, já o false o finaliza.
                 * Esses valores podem ser resultados de uma expressão como contador <= 10.
                 * 
                 * INSTRUTOR(A): Guilherme Matheus Costa
                 */

            }

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
