using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
        // Atividade 1

            Console.WriteLine("-------------");
            Console.WriteLine("Boa Tarde");
            Console.WriteLine("-------------");

            Console.WriteLine("Qual é a sua idade?");
            int Idade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Idade em Meses: " + (Idade * 12));
            Console.WriteLine("Idade em Dias: " + (Idade * 365));
            Console.WriteLine("Idade em Horas: " + (Idade * 365 * 24));
            Console.WriteLine("Idade em Minutos: " + (Idade * 365 * 24 * 60));

        }
    }
}
