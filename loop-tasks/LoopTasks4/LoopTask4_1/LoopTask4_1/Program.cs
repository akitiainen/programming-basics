using System;

namespace loopTask4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber;
            rndNumber = rnd.Next();

            Console.WriteLine("Ohjelma tulostaa 10 arvottua kokonaisluka ja niiden neliöjuuret.");
            Console.WriteLine("#\tRND\tSQRT");
            for (int i = 0; i < 10; i++)
            {
                rndNumber = rnd.Next(1, 10);
                Console.WriteLine($"{i + 1}.\t{rndNumber}\t{Math.Sqrt(rndNumber)}");
            }
        }
    }
}
