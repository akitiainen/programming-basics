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
                PrintStars(numbers[i]);
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
    }
}
