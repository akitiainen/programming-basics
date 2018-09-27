using System;

namespace IfTask_LipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee maatalousnäyttelyn lipun hinnan");
            int originalPrice = 16;
            double discount = 0;
            Console.WriteLine("Oletko varusmies k/e: ");
            string userInput = Console.ReadLine();

            if (userInput == "k")
                discount = 0.5;


            else
            {
                Console.WriteLine("Oletko opiskelija k/e: ");
                userInput = Console.ReadLine();
                if (userInput == "k")
                {
                    Console.WriteLine("Oletko mtk:n jäsen k/e: ");
                    userInput = Console.ReadLine();
                    if (userInput == "k")
                        discount = 0.45;
                    else
                        discount = 0.6;
                }
                else
                    Console.WriteLine("Syötä ikä");
                    
            }
            Console.WriteLine($"Lippusi hinta on {originalPrice * discount:C}");
        }
    }
    
}
