using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Intro();
            int counter = VowelCounter(input);
            PrintData(input, counter);
        }

        static string Intro()
        {
            Console.Write("kirjoita jotakin: ");
            return Console.ReadLine();
        }

        static int VowelCounter(string userInput)
        {
            string vowels = "AEIOUYÅÄÖ";
            string inputTmp = userInput.ToUpper();
            int c = 0;
            for (int i = 0; i < vowels.Length; i++)
            {
                for (int j = 0; j < userInput.Length; j++)
                {
                    if (inputTmp[j] == vowels[i])
                    {
                        c++;
                    }
                }
            }
            return c;
        }

        static void PrintData(string word, int number)
        {
            Console.WriteLine($"Sanassa {word} on {number} vokaalia!");
        }
    }
}
