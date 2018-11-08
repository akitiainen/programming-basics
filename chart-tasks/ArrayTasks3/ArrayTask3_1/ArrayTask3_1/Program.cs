using System;

namespace ArrayTask3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] raffle = new int[10];
            RndRaffle(ref raffle);
        }

        static void RndRaffle (ref int[] arrRaffle)
        {
            Random rnd = new Random();

            for (int i = 0; i < arrRaffle.Length; i++)
            {
                arrRaffle[i] = rnd.Next(21);
                Console.WriteLine($"{i}.\t{arrRaffle[i]:d2}");
            }
        }

    }
}
