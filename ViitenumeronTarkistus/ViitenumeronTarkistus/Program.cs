﻿using System;

namespace ViitenumeronTarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.Clear();
                    string refNumber = Input();
                    LOL(refNumber);
                    break;
            }
        }

        static void Intro()
        {
            Console.WriteLine("1. ohjelma tarkistaa kotimaisen viitenumeron\n2. luo kotimaisen viitenumeron\n3. luo halutun määrän viitenumeroita ja tallentaa ne tekstitiedostoon");
        }

        static string Input()
        {
            Console.Write("Syötä viitenumero: ");
            return Console.ReadLine();
        }

        static void LOL(string x)
        {
            int[] list = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                list[i] = int.Parse(x.Substring(i, 1));
            }

            for (int i = 0; i < list.Length; i++)
            {
                if(i == 0)
                {
                    list[i] = list[i];
                }
                else if(i == 1)
                {
                    list[i] = list[i] * 3; 
                }
                else
                {
                    list[i] = list[i] * 7;
                }
                Console.WriteLine(list[i]);
            }
        }
    }
}