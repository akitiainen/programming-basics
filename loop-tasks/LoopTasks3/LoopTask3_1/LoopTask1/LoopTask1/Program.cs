using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program solves factorials");
            int number = 0;
            int i = 1;
            int fact = 1;

            //checks that the number is positive number
            do
            {
                Console.Write("Input a number: ");
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);

                if (number <= 0)
                {
                    Console.WriteLine("Input error!");
                }
            }
            while (number <= 0);
            //calculate factorial 1 * 2 * 3 * ... * n
            //while (i<= number)
            //{
            //    fact = fact * i;
            //    i = i + 1;
            //}
            for (i = 1; i <= number; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"{number}! = {fact}");
        }
    }
}
