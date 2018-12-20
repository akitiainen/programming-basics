using System;

namespace Kertaustehtävät12_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02 = 0;
            int sum = 0;
            Console.WriteLine("Ohjelma kysyy lukuja kunnes syötät kaksi samaa lukua peräkkäin.");
            Console.WriteLine("Syötä luku:");
            while (true)
            {
                
                while (!int.TryParse(Console.ReadLine(), out num01))
                {
                    Console.WriteLine("Virhe! Syötä luku!");
                }
                sum = sum + num01;
                if (num01 == num02)
                {
                    Console.WriteLine(sum);
                    break;
                }
                else
                    num02 = num01;
            }
        }
    }
}
