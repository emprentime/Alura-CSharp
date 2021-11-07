using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 3
            Console.WriteLine("Executando projeto 3 Criando variáveis ponto flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;

            Console.WriteLine(idade); // resultado 7.5

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade); // resultado 1

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade); // resultado 1,6666666666666667

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
