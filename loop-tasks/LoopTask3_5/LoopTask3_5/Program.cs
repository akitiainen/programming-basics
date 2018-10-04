using System;

namespace LoopTask3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int i = 1;
            int evenSum = 0;
            int oddSum = 0;

            Console.WriteLine("This program adds the sums of even and odd numbers");
            Console.Write("Input a number: ");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                while (i <= number)
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
                    break;
                }
            }
            else
            {
                while (i >= number)
                {
                    if (i % 2 == 0)
                    {
                        evenSum = evenSum - i;
                    }
                    else
                    {
                        oddSum = oddSum - i;
                    }
                    i++;
                }
            }
            Console.WriteLine($"The sum of even numbers is {evenSum}");
            Console.WriteLine($"The sum of odd numbers is {oddSum}");
        }
    }
}
