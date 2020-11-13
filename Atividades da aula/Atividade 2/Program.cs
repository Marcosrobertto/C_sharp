using System;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atividade 2

            Console.WriteLine("-------------");
            Console.WriteLine("  Boa Tarde  ");
            Console.WriteLine("-------------");

            Console.WriteLine("Em que ano estamos?");
            int Atual = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Em que ano você nasceu?");
            int Nascimento = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Idade atual: " + (Atual - Nascimento));
            Console.WriteLine("Sua idade em semanas: " + ((Atual - Nascimento)*52));



        }
    }
}
