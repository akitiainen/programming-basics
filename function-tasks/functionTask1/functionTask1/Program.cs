using System;

namespace functionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Functions - Task 1.\n");

            int n;
            while (true)
            {
                Console.Write("Tähtien lukumäärä: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine($"Luku {n} ei ole sallittu luku");
                }
                else
                {
                    break;
                }
            }
            string asterisks = getNAsterisks(n);
            Console.WriteLine(asterisks);
            Console.ReadKey();
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
