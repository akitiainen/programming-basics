using System;
using System.Globalization;


namespace ArrayAndFunctionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string[] names = new string[] { "MacBook Air", "Jolla", "Nokia" };
            decimal[] prices = new decimal[] { 928.90m, 349.00m, 99.80M };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i].PadRight(15)}{prices[i].ToString("C", CultureInfo.CurrentCulture)}");
            }
        }
    }
}
