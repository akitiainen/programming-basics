using System;

namespace LoopTask4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int number;
            Console.WriteLine("Tämä ohjelma tulostaa kertotaulun luvuille 1-9");
            Console.WriteLine("\n");
            Console.Write("Syötä luku: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Väärä syöte!");
                Console.WriteLine("Syötä luku: ");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Luvun {number} kertotaulu on");
            Console.WriteLine("\n");
            for (i = 1; i <= 9; i++)
            {
                Console.Write("{0} * {1} = {2} \n", number, i, number * i);
            }
            
        }
    }
}
