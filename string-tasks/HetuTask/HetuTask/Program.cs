using System;

namespace HetuTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHetu = Intro();
            DateChecker(strHetu);
            char check = HetuChecker(strHetu);
            Console.WriteLine($"Hetu: {strHetu} Tarkaste: {check}");
        }

        static string Intro()
        {
            Console.WriteLine("Syötä sosiaaliturvatunnus: ");
            return Console.ReadLine();
        }

        static char HetuChecker(string strHetu)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            string strHetuTmp = strHetu.Remove(6, 1);
            int hetuCheck = int.Parse(strHetuTmp.Remove(9));
            //Console.WriteLine(hetuCheck);
            hetuCheck = hetuCheck % 31;
            char x = checkMark[hetuCheck];
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
