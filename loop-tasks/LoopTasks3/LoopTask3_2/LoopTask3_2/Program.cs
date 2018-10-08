using System;

namespace LoopTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee N ensimmäistä lukua yhteen");
            int number = 0;
            int i = 1;
            int sum = 0;
            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());
                if(number <= 0)
                {
                    Console.WriteLine("Input error!");
                }
            }
            while (number <= 0);
            for (i = 1; i <= number; i++)
            {
                sum += i;
            }
            
            Console.WriteLine($"Luvun {number} ensimmäisten lukujen summa on {sum}");
        }
    }
}
