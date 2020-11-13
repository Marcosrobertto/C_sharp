using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atividade 3

            Console.WriteLine("-------------");
            Console.WriteLine("  Boa Tarde  ");
            Console.WriteLine("-------------");

            Console.WriteLine("Qual é o seu salário?");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            if(salario <500){
                Console.WriteLine("Seu salário é de: " + (salario*1.3 + " R$."));
            }else{
                Console.WriteLine("Seu salário é de: " + salario + " R$. Então você não tem direito ao aumento.");
            }





        }
    }
}
