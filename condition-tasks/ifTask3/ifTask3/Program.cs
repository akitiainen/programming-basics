using System;

namespace ifTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program defines if a number if positive or negative and if a number is even or odd");
            Console.Write("Input a number: ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number == 0)
                    Console.WriteLine("Your number is zero!");
                else if (number < 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine($"Your number {number} is negative and even!");
                    else
                        Console.WriteLine($"Your number {number} is negative and odd!");
                }
                else
                {
                    if (number % 2 == 0)
                        Console.WriteLine($"Your number {number} is positive and even!");
                    else
                        Console.WriteLine($"Your number {number} is positive and odd!");
                }
            }
            else
                Console.WriteLine("Wrong input!");
        }
    }
}
