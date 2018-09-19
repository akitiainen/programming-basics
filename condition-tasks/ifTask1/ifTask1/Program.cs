using System;

namespace ifTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines if a number is positive, negative or a zero");
            Console.Write("Input a number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            if (number == 0)
                Console.WriteLine($"Your number {number} is zero");
            else if (number<0)
                Console.WriteLine($"Your number {number} is negative");
            else
                Console.WriteLine($"Your number {number} is positive");
        }
    }
}
