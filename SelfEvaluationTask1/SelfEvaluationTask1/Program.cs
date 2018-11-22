using System;

namespace SelfEvaluationTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostaa tähtiä");
            int [] numbers = new int[] {2,5,10,7,3};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(GetStars(numbers[i]));
            }
            
        }

        static void PrintStars(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        static string GetStars(int length)
        {
            string returnStars = "";
            for (int i = 0; i < length; i++)
            {
                returnStars = $"{returnStars}*";
            }
            return returnStars;
        }
    }
}
