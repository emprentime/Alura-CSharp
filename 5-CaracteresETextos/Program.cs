using System;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 5

            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");
            // Quando usamos o tipo char é necessário utilizarmos aspas simples para que não ocorra erro
            char primeiraLetra = 'a'; // Obs: Não podemos deixar uma variável do tipo char vazia, ex: char primeiraLetra = '';
            Console.WriteLine(primeiraLetra);
            primeiraLetra = ' '; // Podemos deixar um caractere de espaço, pois espaço é diferente de vazio


            // internamente, a variável char é representada como número, caberia usar um número de 16 bits.

            //Abaixo iremos fazer um cast e com isso iremos converter o valor 65 para A.
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra); // Resultado: A

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra); // Resultado: B

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra); // Resultado: C

            /*
             * Nós vimos que 65 pode ser A , no entanto, esses retornos são definições existentes que a linguagem C#
             * segue. Isto respeita a Ascii table (Tabela de American Standard Code).
             * Trata-se de uma tabela com vários caracteres - entre eles encontraremos não apenas letras, mas também números,
             * cedilha, e caracteres especiais. 
             * Temos também a representação númerica, em número decimal. Na tabela, veremos que 61 é o sinal de igual (=).
               Observação:
             * A linguagem C# é utilizada em diferentes nichos, desde aplicações do mercado financeiro, como do governo, até internet das coisas.
             * Quando temos uma placa pequena, sem muitos recursos, trabalhamos mais próximo do hardware.
             * A variável char será importante nesses casos, por exemplo, quando formos mandar um caractere para um display bem pequeno.
             * Para entender as diferentes possibilidades de uso, nós encontraremos esses recursos.
             * Mas dependendo do mundo que você trabalha, não faz sentido.
             * INSTRUTOR(A): Guilherme Matheus Costa
             */
            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra); // Resultado: =




            // Abaixo estamos criando uma variável do tipo string (texto) e para esse tipo de váriavel podemos deixá-la vazia
            // Ex: string titulo = "";
            string titulo = "Alura Cursos de tecnologia - Curso de C# parte 1: Primeiros passos " + 2021;
            Console.WriteLine(titulo);

            // Precisamos usar o arroba na frente das aspas para podemos construir uma string com quebra de linhas 
            string cursosProgramacao = 
@"- .NET
- Java
- JavaScript";
            Console.WriteLine(cursosProgramacao);


            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            // O comando abaixo serve para lermos alguma informação que o usuário digita na tela.
            Console.ReadLine();
        }
    }
}
