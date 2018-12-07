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
                    string dateTmp = date.Remove(4, 2);
                    string end = EndGenerator();
                    string checkMark = CheckMarkGenerator(dateTmp, end);
                    PrintData(date, end, checkMark);
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

            string[] endArray = new string[3];
            for (int i = 0; i < 3; i++)
            {
                endArray[i] = end.Next(10).ToString();
                if (endArray[0] == "9")
                    i--;
                else if (endArray[2] == "0" || endArray[2] == "1")
                    i--;
   
            }            
            Console.WriteLine();
            string endString = "";
            for (int i = 0; i < 3; i++)
            {
                endString += endArray[i].ToString();
            }
            return endString;
        }       

        static string CheckMarkGenerator(string date, string end)
        {
            string checkMarkList = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            string strHetu = date + end;
            int hetuCheck = int.Parse(strHetu);
            hetuCheck = hetuCheck % 31;
            string x = checkMarkList[hetuCheck].ToString();
            return x;
        }

        static void PrintData(string a, string b, string c)
        {
            int year = int.Parse(a.Substring(4));
            string hetu;
            if (year < 1900)
                hetu = a.Remove(4,2) + "+" + b + c;
            else if (year < 2000)
                hetu = a.Remove(4,2) + "-" + b + c;
            else
                hetu = a.Remove(4,2) + "A" + b + c;
            Console.WriteLine($"Henkilötunnuksesi on {hetu}");
        }
    }
}
