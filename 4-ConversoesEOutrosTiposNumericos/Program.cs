using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 4
            Console.WriteLine("Executando projeto 4");
            double salario;
            salario = 1200.50;

            //O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro;
            /*
             * Cast, no contexto de C#, é um método pelo qual um valor é convertido de um tipo de dado para outro.
             * O cast é uma conversão de tipos explícita pela qual o compilador é informado sobre a conversão
             * e a possibilidade de perda de dados do resultado.
             * Fonte: https://celsokitamura.com.br/cast-conversao-de-tipos-convertendo-um-tipo-de-dado-em-outro/
             */
            // Abaixo estamos fazendo um Cast da variável salario
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável de 64 bits
            long idade;
            idade = 130000000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variável de 16 bits
            short quantidadeProdutos;
            quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            // Sempre que utilizarmos variáveis do tipo float é necessário colocarmos o sufixo f no final do número
            // Exemplo: 1.80f
            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }

    }
}
