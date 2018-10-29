using System;

namespace FunctionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            int indx = 0;
            Console.WriteLine("Syötä 10 lukua");
            Console.WriteLine($"Suurin luku oli {LargestNumber(ref indx)} oli {indx}.");
        }

        static int LargestNumber(ref int indx)
        {
            int largestNumber = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i+1}.");
                int input = int.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("väärä syöte, syötä positiivinen luku");
                    i--;
                }

                if (input > largestNumber)
                {
                    largestNumber = input;
                    indx = i + 1;
                }
            }
            return largestNumber;
        }
    }
}
