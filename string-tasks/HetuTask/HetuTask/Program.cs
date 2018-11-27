using System;

namespace HetuTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHetu = Intro();
            string check = HetuChecker(strHetu);
            Console.WriteLine($"{strHetu} Tulostetaan tarkaste: {check}");
            DateChecker(strHetu);
            string strHetuTmp = strHetu.Substring(9);
            if (check == strHetuTmp)
            {
                Console.WriteLine("true");
            }
            else
                Console.WriteLine("false");
        }

        static string Intro()
        {
            Console.WriteLine("Syötä sosiaaliturvatunnus: ");
            return Console.ReadLine();
        }

        static string HetuChecker(string strHetu)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            string strHetuTmp = strHetu.Remove(6, 1);
            int hetuCheck = int.Parse(strHetuTmp.Remove(9));
            //Console.WriteLine(hetuCheck);
            hetuCheck = hetuCheck % 31;
            string x = checkMark[hetuCheck];
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
    }
}
