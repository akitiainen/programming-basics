using System;

namespace StringTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita jotain: ");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != input[input.Length-1-i])
                {
                    Console.WriteLine($"{input} ei ole palindromi!");
                    break;
                }
            }
            Console.WriteLine($"{input} on palindromi!");
        }
    }    
}
