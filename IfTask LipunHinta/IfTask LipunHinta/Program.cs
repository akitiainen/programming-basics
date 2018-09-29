﻿using System;

namespace IfTask_LipunHinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä ohjelma laskee maatalousnäyttelyn lipun hinnan");
            int originalPrice = 16;
            double discount = 0;
            int age = 0;
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
                        discount = 0.6;
                    else
                        discount = 0.45;
                }
                else
                {
                    
                    Console.WriteLine("Syötä ikä: ");
                    string userInput1 = Console.ReadLine();
                    bool isNumber = int.TryParse(userInput1, out age);
                    if (isNumber)
                    {
                        if (age < 7)
                        {
                            discount = 1;
                        }
                        else if ((age < 7 || age > 15) && age < 65)
                        {
                            Console.WriteLine("Oletko mtk:n jäsen k/e: ");
                            userInput = Console.ReadLine();
                            if (userInput == "k")
                                discount = 0.15;
                        }
                        else
                        {
                            discount = 0.5;
                        }
                    }
                    else Console.WriteLine("Väärä syöte!");
                }
            }
            Console.WriteLine($"Lippusi hinta on {originalPrice - originalPrice * discount:C}");
        }
    }
    
}
