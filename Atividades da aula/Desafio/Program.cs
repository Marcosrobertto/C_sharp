using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
             // Desafio

            Console.WriteLine("-------------");
            Console.WriteLine("  Boa Tarde  ");
            Console.WriteLine("-------------");

            Console.WriteLine("Qual a idade do nadador?");
            int IdadeNadador = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(IdadeNadador >=5 && IdadeNadador <=7) {
                Console.WriteLine("Você compete na categoria Infantil A");
            }else if(IdadeNadador >=8 && IdadeNadador <=10) {
                Console.WriteLine("Você compete na categoria Infantil B");
            }else if(IdadeNadador >=11 && IdadeNadador <=13) {
                Console.WriteLine("Você compete na categoria Juveniel A");
            }else if(IdadeNadador >=14 && IdadeNadador <=17) {
                Console.WriteLine("Você compete na categoria Juveniel B");
            }else if(IdadeNadador >=18) {
                Console.WriteLine("Você compete na categoria Sênior");
            }else {
                Console.WriteLine("Você é muito novo para participar da competição");
            }
        }
    }
}
