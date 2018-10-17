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
            Console.Write("Input a number: ");
            num = int.Parse(Console.ReadLine());
        }

    }
}
