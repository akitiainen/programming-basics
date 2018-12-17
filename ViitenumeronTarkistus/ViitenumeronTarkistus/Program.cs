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