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
            for (int i = 0; i < inputTmp.Length; i++)
            {
                if (char.IsSeparator(inputTmp[i]))
                {
                    inputTmp.Trim(inputTmp[i]);
                }
            }
            Console.WriteLine(inputTmp);

            for (int i = 0; i < inputTmp.Length; i++)
            {
                //if (char.IsSeparator(input[i]))
                
                    
                

                if (inputTmp[i] != inputTmp[inputTmp.Length - 1 - i])
                {
                    Console.WriteLine($"{input} ei ole palindromi!");
                    break;
                }
            }
        }
    }    
}
