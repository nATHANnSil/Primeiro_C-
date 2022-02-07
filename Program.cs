// See https://aka.ms/new-console-template for more information

using System;

namespace Programa_Aniversario
{

    class Answers
    {
        //Unused...
    }

    class Introduction
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bem vindo. Digite o seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("\n Abaixo, escreva as respostas:");

            Console.WriteLine("\n Taxa para teste de inglês (TOEFL), em alguns meses, para que eu possa estudar e/ou trabalhar fora.");
            var resp1 = Console.ReadLine();

            Console.WriteLine("\n Microfone, para o computador");
            var resp2 = Console.ReadLine();

            Console.WriteLine("\n Webcam, para o computador");
            var resp3 = Console.ReadLine();

            Console.WriteLine("\n Mouse Pad, para o computador");
            var resp4 = Console.ReadLine();

            Console.WriteLine("\n Mais duas renovações da Academia");
            var resp5 = Console.ReadLine();

            Console.WriteLine("\n Disney +");
            var resp6 = Console.ReadLine();

            Console.WriteLine("\n OBS.: O microfone, a webcam e o mousepad seriam urgente.");

        }
    }

}

