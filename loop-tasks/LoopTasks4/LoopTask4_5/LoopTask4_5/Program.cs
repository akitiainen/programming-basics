using System;

namespace LoopTask4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkauksen rivisi on:\n");
            Random rnd = new Random();
            for (int i = 1; i <= 13; i++)
            {
                rnd.NextDouble();
                Console.WriteLine($"{rnd}");
                {

                }
            }
            
            
        }
    }
}
