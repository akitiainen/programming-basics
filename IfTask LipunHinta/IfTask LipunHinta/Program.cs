using System;

namespace IfTask_LipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee maatalousnäyttelyn lipun hinnan");
            Console.WriteLine("Oletko varusmies k/e: ");
            string userInput = Console.ReadLine();

            if (userInput == "k")
                Console.WriteLine("Alennuksesi on 50%");
            else
            {
                Console.WriteLine("Oletko opiskelija k/e: ");
                userInput = Console.ReadLine();

                if (userInput == "k")
                    Console.WriteLine("Oletko mtk:n jäsen k/e: ");
                userInput = Console.ReadLine();
            }
        }
    }
}
