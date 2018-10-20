using System;

namespace FunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Intro(out x);
        }

        static void Intro(out int num)
        {
            Console.Write("Input a number between 0-50: ");
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.Clear();
                Console.WriteLine("Input error");
                Console.Write("Input a number: ");
            }
        }
    }
}
