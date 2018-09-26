using System;

namespace ifTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program sorts three numbers ascending order");
            Console.Write("Input first digit: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            Console.Write("Input second digit: ");
            userInput = Console.ReadLine();
            int number1 = int.Parse(userInput);
            Console.Write("Input third digit: ");
            userInput = Console.ReadLine();
            int number2 = int.Parse(userInput);

            if (number > number1)
            {
                if (number1 > number2)
                    Console.WriteLine($"Your inputs are {number2}, {number1}, {number}");
                else
                {
                    if (number > number2)
                        Console.WriteLine($"Your inputs are {number1}, {number2}, {number}");
                    else
                        Console.WriteLine($"Your inputs are {number1}, {number}, {number2}");
                }
            }
            else
            {
                if (number2 > number1)
                    Console.WriteLine($"Your inputs are {number}, {number1}, {number2}");
                else
                {
                    if(number2>number)
                        Console.WriteLine($"Your inputs are {number}, {number2}, {number1}");
                    else
                        Console.WriteLine($"Your inputs are {number2}, {number}, {number1}");
                }

            }

            
        }
    }
}
