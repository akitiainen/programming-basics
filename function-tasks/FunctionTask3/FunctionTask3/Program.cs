using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFromRange(0, 50);
            Print();
        }

        static int NumberFromRange(int lowerBound, int upperBound)
        {
            bool isNumber;
            int input;

            do
            {
                Console.Write($"Syötä luku alueelta {lowerBound} ... {upperBound}: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);

                if (isNumber && input >= lowerBound && input <= upperBound)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine($"väärä syöte!");
                }

            }
            while (true);
        }

        static void Print()
        {
            Console.WriteLine("Lukusi on kelvollinen!");
        }
    }
}
