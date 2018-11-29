using System;

namespace HetuGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string date = Intro();
                date = Cleaner(date);
                if (DateChecker(date))
                {
                    string end = EndGenerator();
                    Console.WriteLine(end);
                    break;
                }
            }
            while (true);
        }

        static string Intro()
        {
            Console.Write("Syötä syntymäpäivä muodossa pp/kk/vvvv: ");
            return Console.ReadLine();
        }

        static string Cleaner(string x)
        {
            x = x.Replace("/", "");
            return x;
        }

        static bool DateChecker(string d)
        {
            int day = int.Parse(d.Substring(0, 2));
            int month = int.Parse(d.Substring(2, 2));
            int year = int.Parse(d.Substring(4, 4));

            try
            {
                DateTime dd = new DateTime(year, month, day);
            }
            catch
            {
                Console.WriteLine("Päivämäärä on virheellinen");
                return false;
            }
            return true;
        }

        static string EndGenerator()
        {
            Random end = new Random();

            int[] endArray = new int[3];
            for (int i = 0; i < 3; i++)
            {
                if (endArray[i] == 0)
                    endArray[i] = end.Next(9);
                else if (endArray[i] == 1)
                    endArray[i] = end.Next(10);
                else
                    endArray[i] = end.Next(2, 10);
            }
            return endArray.ToString();
        }

       
    }
}
