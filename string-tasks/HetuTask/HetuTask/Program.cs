using System;

namespace HetuTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHetu = Intro();
            DateChecker(strHetu);
            string check = HetuChecker(strHetu);
            bool isReal = (FinalChecker(check, strHetu.Substring(10))) ;
            PrintData(isReal);
        }

        static string Intro()
        {
            Console.Write("Syötä sosiaaliturvatunnus: ");
            return Console.ReadLine();
        }
        
        static string HetuChecker(string strHetu)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            string strHetuTmp = strHetu.Remove(6, 1);
            int hetuCheck = int.Parse(strHetuTmp.Remove(9));
            hetuCheck = hetuCheck % 31;
            string x = checkMark[hetuCheck].ToString();
            return x;
        }

        static void DateChecker(string A)
        {
            int day = int.Parse(A.Substring(0, 2));
            int month = int.Parse(A.Substring(2, 2));
            int year = int.Parse(A.Substring(4, 2));

            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static bool FinalChecker(string letter1, string letter2)
        {
            if (letter2 == letter1)
                return true;
            else
                return false;
        }

        static void PrintData(bool data)
        {
            if(data)
                Console.WriteLine("Hetu on oikea!");
            else
                Console.WriteLine("Hetu on väärä!");
        }
    }
}
