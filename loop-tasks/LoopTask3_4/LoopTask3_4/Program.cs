using System;

namespace LoopTask3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee positiivisten ja negatiivisten lukujen summat");
            int number = 0;
            int i = 0;
            int negSum = 0;
            int posSum = 0;

            do
            {
                Console.Write("Syötä luku: ");
                number = int.Parse(Console.ReadLine());
                if(number==0)
                {
                    Console.WriteLine("Väärä syöte!");
                }
            }
            while (number==0);
            {

                if (number > 0)
                {
                    for (i = 0; i <= number; i++)
                    {
                        posSum += i;
                    }
                    Console.WriteLine($"Positiivisten lukujen summa: {posSum}");
                }
                else
                {
                    for (i = 0; i >= number; i--)
                    {
                        negSum -= i;
                    }
                    Console.WriteLine($"Negatiivisten lukujen summa: {negSum}");
                }
            }
        }
    }
}
