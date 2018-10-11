using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkauksen rivisi on:\n");
            double odds;

            Random rnd = new Random();
            for (int i = 1; i <= 13; i++)
            {
                odds = rnd.NextDouble();
                if(odds <= 0.4)
                {
                    Console.WriteLine($"{i}.\t 1");
                }
                else if(odds <= 0.6)
                {
                    Console.WriteLine($"{i}.\t X");
                }
                else
                {
                    Console.WriteLine($"{i}.\t 2");
                }
            }
        }
    }
}
