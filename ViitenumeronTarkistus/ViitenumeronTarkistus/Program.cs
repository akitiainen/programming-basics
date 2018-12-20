using System;

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
                    string refNumber = RefNumber();
                    string tmpRefNumber = Reverse(refNumber.Substring(0,refNumber.Length-1));
                    string checkNumber = CheckNumberCreator(tmpRefNumber);
                    if (CheckNumberChecker(refNumber.Substring(refNumber.Length - 1, 1), checkNumber) == true)
                    {
                        PrintTrue(refNumber);
                    }
                    else
                        PrintFalse();
                    break;

                case 2:
                    Console.Clear();
                    string refNumberBase = Shit();
                    tmpRefNumber = Reverse(refNumberBase);
                    checkNumber = CheckNumberCreator(tmpRefNumber);
                    refNumber = Conjoiner(refNumberBase, checkNumber);
                    refNumber = SpaceMaker(refNumber);
                    Console.WriteLine($"Viitenumerosi on {refNumber}.");
                    break;

                case 3:
                    Console.Clear();
                    string basePart = Piss();
                    int amount = Piss2();
                    Console.WriteLine(amount);
                    break;
            }
        }

        static void Intro()
        {
            Console.WriteLine("1. ohjelma tarkistaa kotimaisen viitenumeron\n2. luo kotimaisen viitenumeron\n3. luo halutun määrän viitenumeroita ja tallentaa ne tekstitiedostoon");
        }

        static string RefNumber()
        {
            Console.Write("Syötä viitenumero: ");
            return Console.ReadLine();
        }

        static string Shit()
        {
            Console.WriteLine("Kirjoita viitenumeron perusosa ilman tarkistenumeroa: ");
            return Console.ReadLine();
        }

        static string Piss()
        {
            Console.WriteLine("Kirjoita viitenumeron perusosa: ");
            return Console.ReadLine();
        }

        static int Piss2()
        {
            int i;
            do
            {
                Console.Write("Kuinka monta viitenumeroa haluat luoda: ");
                while (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.Clear();
                    Console.WriteLine("Syöte ei ole numero!");
                    Console.Write("Kuinka monta viitenumeroa haluat luoda: ");
                }
                if(i < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Luku ei voi olla pienempi kuin 1.");
                }
            }
            while (i < 1);
            return i;
        }

        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string CheckNumberCreator(string x)
        {
            string checkMark = string.Empty;
            int sum = 0;
            int[] list = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                list[i] = int.Parse(x.Substring(i, 1));
            }

            for (int i = 0; i < list.Length; i++)
            {
                if(i % 3 == 0)
                {
                    list[i] = list[i] * 7;
                }
                else if(i % 3 == 1)
                {
                    list[i] = list[i] * 3;
                }
                else
                {
                    list[i] = list[i];
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            int difference = (int)(Math.Ceiling(sum / 10.0d)*10);
            checkMark = (difference-sum).ToString();
            return checkMark;
        }

        static string Conjoiner(string s1, string s2)
        {
            return s1 + s2;
        }

        static string SpaceMaker(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (i >= 5 && i%5 == 0)
                    s=s.Insert(s.Length-i, " ");                
            }
            return s;
        }

        static bool CheckNumberChecker(string s1, string s2)
        {
            if (s1 == s2)
                return true;
            else
                return false;
        }

        static void PrintTrue(string s)
        {
            Console.WriteLine($"{s} - OK");
        }

        static void PrintFalse()
        {
            Console.WriteLine("Viitenumero on väärin!");
        }
    }
}