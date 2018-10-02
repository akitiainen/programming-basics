using System;

namespace LoopTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program solves factorials");
            Console.Write("Input a number: ");
            int number = Console.Read();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}");
            }
        }
    }
}
