using System;

namespace RepetitionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program repeats whatever you write five times.");
            Console.Write("Write something: ");
            string input = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(input);
            }
        }
    }
}
