using System;

namespace ifTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program sorts out if the number is even or odd");
            Console.Write("Input a number: ");
            string userInput = Console.ReadLine();
            int number = 0;
            bool isNumber = int.TryParse(userInput, out number);

            if (isNumber)
            {
                if (number % 2 == 0)
                    Console.WriteLine($"Number {number} is even");
                else
                    Console.WriteLine($"Number {number} is odd");
            }
            else
                Console.WriteLine("Wrong input!");
        }
    }
}
