using System;

namespace ArrayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ohjelma arpoo 100 lukua 0 ... 50 väiltä ja ilmoittaa luvuista saadun keskiarvon.");
            decimal[] iT = new decimal[100];
            Random rnd = new Random();

            //lukujen arvonta ja taulukon tulostus
            for (int i = 0; i < iT.Length; i++)
            {
                iT[i] = rnd.Next(51);
                Console.WriteLine($"{i + 1}.\t{iT[i]}");
            }

            decimal sum = 0;
            //laske summa ja keskiarvo
            for (int i = 0; i < iT.Length; i++)
            {
                sum = sum + iT[i];
            }
            decimal avrg = sum / 100;

            //tulosta keskiarvo
            Console.WriteLine($"Ka. = {avrg}");
        }
    }
}
