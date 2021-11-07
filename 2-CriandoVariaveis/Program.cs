using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aula 02
            Console.WriteLine("Executando projeto 2 - Criando Variáveis.");

            // Abaixo iremos declarar a variável idade utilizando o tipo inteiro (int)
            int idade;

            // Abaixo iremos atribuir um valor a variável idade
            idade = 30;

            // Abaixo iremos exibir o valor da variável idade
            Console.WriteLine(idade);

            // Abaixo iremos alterar o valor da variável idade
            idade = 10;
            Console.WriteLine(idade);

            // Abaixo iremos atribuir o resultado do cálculo de 10 + 5 * 2
            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            // Abaixo iremos utilizar os parênteses para priorizarmos primeiro o cálculo 10 + 5 e só depois multiplicar por 2
            idade = (10 + 5) * 2;
            Console.WriteLine(idade);

            // Concatenando uma mensagem com o valor da variável idade
            Console.WriteLine("Sua idade é " + idade + "!");

            /* Observação:
             * A diferença entre o comando Console.Write e Console.WriteLine é que o primeiro pula linha e o segundo não.
            */

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}