using System;

namespace StringTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita jotain: ");
            string input = Console.ReadLine();
            string inputTmp = input.ToUpper();
            inputTmp = inputTmp.Replace(" ", "");

            for (int i = 0; i < inputTmp.Length; i++)
            {
                if (inputTmp[i] != inputTmp[inputTmp.Length - 1 - i])
                {
                    Console.WriteLine($"{input} ei ole palindromi!");
                    break;
                }
                else if(i == inputTmp.Length-1)
                {
                    Console.WriteLine($"{input} on palindromi");
                }
            }
        }
    }    
}
