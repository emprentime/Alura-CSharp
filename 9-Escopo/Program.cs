﻿using System;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Projeto 9
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "João NÃO está acompanhado";
            }

            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.WriteLine("A execução acabou. tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
