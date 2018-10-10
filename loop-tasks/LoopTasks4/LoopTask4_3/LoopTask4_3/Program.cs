using System;

namespace LoopTask4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber;
            rndNumber = rnd.Next();

            for (int j = 0; j < 4; j++)
            {
                
                for (int i = 0; i < 5; i++)
                {
                    rndNumber = rnd.Next(50);
                    Console.Write($"{rndNumber} ");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
