using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 8
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            //int quantidadePessoas = 1;
            //bool acompanhado = quantidadePessoas >= 2;
            string passeLivre = "Azul";
            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado == true || passeLivre == "Azul")
            {
                Console.WriteLine("João pode entrar :)");
            }
            else
            {

                Console.WriteLine("João não pode entrar :(");
            }

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
