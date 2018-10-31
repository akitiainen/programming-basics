using System;

namespace ChartTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hinnasto");
            decimal[] productPrice = new decimal[] {7.96m, 72.00m, 99.90m};
            int[] productAmount = new int[] {1, 3, 2};
            decimal[] productTotalPrice = new decimal[3];

            for (int i = 0; i < productTotalPrice.Length; i++)
            {
                productTotalPrice[i] = productPrice[i] * productAmount[i];
                Console.WriteLine($"Tuote {i + 1}: {productTotalPrice[i]:c}");
            }


        }
    }
}
