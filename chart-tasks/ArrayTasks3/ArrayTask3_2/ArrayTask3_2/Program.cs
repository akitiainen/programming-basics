using System;

namespace ArrayTask3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] raffle = new int[10, 20];
            RndRaffle(ref raffle);
        }

        static void RndRaffle(ref int[,] arrRaffle)
        {
            Random rnd = new Random();

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    arrRaffle[x, y] = rnd.Next(101);
                    Console.WriteLine($"{x} {y}\t{arrRaffle[x, y]:d2} ");
                }
            }
            
        }
    }
}
