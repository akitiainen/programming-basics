using System;

namespace StringTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            string S = Console.ReadLine();
            Console.WriteLine($"Your input {S} has {S.Length} characters");
        }
    }
}
