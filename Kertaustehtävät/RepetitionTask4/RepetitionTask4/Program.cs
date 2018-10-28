using System;

namespace RepetitionTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            decimal difference = 0;
            decimal division = 0;
            decimal multiplication = 0;
            decimal input01;
            decimal input02;
            
            
            Console.WriteLine("This program asks user two numbers and performs basic aritmethic functions with given numbers.");
            Console.Write("Enter first number: ");

            while (!decimal.TryParse(Console.ReadLine(), out input01))
            {
                Console.WriteLine("Not a number!");
            }

            Console.Write("Enter second number: ");
            while (!decimal.TryParse(Console.ReadLine(), out input02))
            {
                Console.WriteLine("Not a number!");
            }

            sum = input01 + input02;
            difference = input01 - input02;
            multiplication = input01 * input02;
            division = input01 / input02;
            

            Console.WriteLine($"{input01} + {input02} = {sum.ToString("F")}");
            Console.WriteLine($"{input01} - {input02} = {difference.ToString("F")}");
            Console.WriteLine($"{input01} * {input02} = {multiplication.ToString("F")}");
            Console.WriteLine($"{input01} / {input02} = {division.ToString("F")}");

        }
    }
}
