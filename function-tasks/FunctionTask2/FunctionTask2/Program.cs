using System;

namespace FunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Intro(out x, out y);
            PrintData(SmallerNumber(x,y));
        }

        static void Intro(out int num01, out int num02)
        {
            Console.Write("Input 1: ");
            num01 = int.Parse(Console.ReadLine());
            Console.Write("Input 2: ");
            num02 = int.Parse(Console.ReadLine());
        }

        static string SmallerNumber(int a, int b)
        {
            if (a < b)
                return $"Number {a} is smaller than number {b}";
            else if (a > b)
                return $"Number {b} is smaller than number {a}";
            else
                return "Numbers have the same value";
        }

        static void PrintData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
