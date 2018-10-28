using System;

namespace RepetitionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input;
            Console.WriteLine("This program asks user for numbers and adds them togethger. To end the program enter '-1'.");
            do
            {
                Console.Write("Enter a number: ");
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Not a number!");
                    Console.Write("Enter a number: ");
                }

                sum = sum + input;
            }
            while (input != -1);

            Console.WriteLine(sum);
        }
    }
}
