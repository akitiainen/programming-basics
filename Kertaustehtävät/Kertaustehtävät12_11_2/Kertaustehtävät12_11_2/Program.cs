using System;

namespace Kertaustehtävät12_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int i = 0;
            int guess;
            int number = rnd.Next(1, 101);
            Console.WriteLine("Minäpä tiedän luvun väliltä 1-100, jota sinä et tiedä!");
            while(true)
            {
                i++;
                while(!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Virheellinen syöte!");
                    i--;
                }
                if (guess < 1 || guess > 100)
                    Console.WriteLine("Epäkelpo luku!");
                else if (guess == number)
                {
                    Console.WriteLine($"Oikein! Arvauksia yhteensä: {i}");
                    break;
                }
                else if (guess < number)
                    Console.WriteLine("Lukuni on isompi!");
                else
                    Console.WriteLine("Lukuni on pienempi!");
            }

        }
    }
}
