using System;

namespace LoopTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program adds the sums of even and odd numbers");
            int number = 0;
            int i = 0;
            int evenSum = 0;
            int oddSum = 0;

            do
            {
                Console.Write("Input a number: ");
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                    Console.WriteLine("Väärä syöte!");
            }
            while (number == 0);

            if(number>0)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i; //evenSum += i;
                }
                else
                {
                    oddSum = oddSum + i;
                }
                i++;
            }
            else
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum - i; //evenSum += i;
                }
                else
                {
                    oddSum = oddSum - i;
                }
                i--;
            }
            Console.WriteLine($"The sum of even numbers is {evenSum}");
            Console.WriteLine($"The sum of odd numbers is {oddSum}");
        }
    }
}
