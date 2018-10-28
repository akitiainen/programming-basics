using System;
using System.Linq;

namespace RepetitionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program repeats whatever you write as many times as your writing has letters.");
            Console.Write("Write something: ");
            string input = Console.ReadLine();
            int numberOfLetters = input.Count(char.IsLetterOrDigit);
            numberOfLetters = numberOfLetters + input.Count(char.IsPunctuation);

            for (int i = 1; i <= numberOfLetters; i++)
            {
                Console.WriteLine($"{i}. {input}");
            }
        }
    }
}
