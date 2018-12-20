using System;

namespace ArrayAndFunctionTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            decimal num01 = 1, num02 = 2;
            num01 = Input(num01);
            num02 = Input(num02);
            Addition(num01, num02);
            Substraction(num01, num02);
            Multiplication(num01, num02);
            Division(num01, num02);
        }

        static void Intro()
        {
            Console.WriteLine("Ohjelma suorittaa perusaritmeettiset operaatiot antamillasi luvuilla.\n");
        }

        static decimal Input(decimal d1)
        {
            decimal num;
            Console.Write($"Syötä {d1}. luku: ");
            while (!decimal.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Virhe! Syötä luku: ");
            }
            return num;
        }

        static void Addition(decimal d1, decimal d2)
        {
            Console.WriteLine($"{d1} + {d2} = {(d1 + d2).ToString("F")}");
        }

        static void Substraction(decimal d1, decimal d2)
        {
            Console.WriteLine($"{d1} - {d2} = {(d1 - d2).ToString("F")}");
        }

        static void Multiplication(decimal d1, decimal d2)
        {
            Console.WriteLine($"{d1} * {d2} = {(d1 * d2).ToString("F")}");
        }

        static void Division(decimal d1, decimal d2)
        {
            Console.WriteLine($"{d1} / {d2} = {(d1 / d2).ToString("F")}");
        }
    }
}
