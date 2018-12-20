using System;

namespace ArrayAndFunctionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 5, 10, 7, 3 };
            for (int i = 0; i < numbers.Length; i++)
            {
                string asterisks = getNAsterisks(numbers[i]);
                Console.WriteLine(asterisks);
            }
        }

        static string getNAsterisks(int n)
        {
            string res = string.Empty;
            for (int i = 0; i < n; i++)
            {
                res += '*';
            }
            return res;
        }
    }
}
