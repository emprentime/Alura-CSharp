using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 13
            Console.WriteLine("Executando o projeto 13");

            // Escrevendo asterisco com o BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }

            // Uma forma diferente de fazer o desenho de asteríscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                    Console.Write("*");
                Console.WriteLine();
            }

            /*
             *  Break – O comando break é usado em laços de repetição while, do/while, for e com os comandos switch/case.
             *  Quando usado em laço de repetição, causa uma interrupção imediata do mesmo, continuando a execução do programa na próxima linha após o laço.
             *  Isso ocorre caso a condição imposta seja atendida.
             *  
             *  Fonte: https://www.devmedia.com.br/conceitos-finais-do-for-e-comandos-break-e-continue-lacos-de-repeticoes-estrutura-da-linguagem-parte-3/18872
             */

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
