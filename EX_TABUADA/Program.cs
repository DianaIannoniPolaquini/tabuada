using System;

namespace EX_TABUADA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int i;

            Console.WriteLine("Qual tabuada você deseja?");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int n);

            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n*i}");
            }
        }
    }
}
