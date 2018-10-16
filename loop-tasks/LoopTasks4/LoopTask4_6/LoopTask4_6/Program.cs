using System;

namespace LoopTask4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber;
            int counter = 0;
            for (int i = 0; i < 1000; i++)
            {
                rndNumber = rnd.Next(1, 7);
                if(rndNumber == 6)
                {
                    counter = counter + 1;
                }
                
            }
            Console.WriteLine($"Kuutonen heitettiin {counter} kertaa.");
        }
    }
}
