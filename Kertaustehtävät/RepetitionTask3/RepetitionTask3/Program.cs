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
            Console.WriteLine("Enter your numbers: ");
            do
            {
                
                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Not a number!");
                }

                sum = sum + input;
            }
            while (input != -1);

            Console.WriteLine($"The sum of your numbers is {sum}!");
        }
    }
}
