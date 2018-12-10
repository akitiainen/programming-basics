using System;

namespace HetuTask
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (Operator())
            {
                case 1:
                    {
                        do
                        {
                            string strHetu = Intro();
                            if (DateChecker(strHetu))
                            {
                                string check = HetuChecker(strHetu);
                                bool isReal = (FinalChecker(check, strHetu.Substring(10)));
                                PrintData(isReal);
                                break;
                            }
                        }
                        while (true);
                    }
                    break;
                case 2:
                    {

                    }
                    break;
            }
            
        }

        static int Operator()
        {
            Console.WriteLine("1. Tarkastaa henkilötunnuksen oikeellisuuden.\n2. Henkilötunnusgeneraattori.");
            return int.Parse(Console.ReadLine());
        }

        static string Intro()
        {
            Console.Write("Syötä sosiaaliturvatunnus: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// tarkastemerkki tallennettu stringiin checkMark,
        /// strHetuTmp:ssä poistettu välimerkki,
        /// hetuCheck laskee tarkastemerkin,
        /// tarkaste merkki tallentuu stringiin x
        /// </summary>
        /// <param name="strHetu"></param>
        /// <returns></returns>
        static string HetuChecker(string strHetu)
        {
            string checkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            string strHetuTmp = strHetu.Remove(6, 1);
            int hetuCheck = int.Parse(strHetuTmp.Remove(9));
            hetuCheck = hetuCheck % 31;
            string x = checkMark[hetuCheck].ToString();
            return x;
        }

        /// <summary>
        /// tarkistaa onko hetun päivämäärä mahdollinen
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        static bool DateChecker(string A)
        {
            int day = int.Parse(A.Substring(0, 2));
            int month = int.Parse(A.Substring(2, 2));
            int year = int.Parse(A.Substring(4, 2));

            try
            {
                DateTime d = new DateTime(year, month, day);
            }
            catch 
            {
                Console.WriteLine("Päivämäärä on virheellinen");
                return false;
            }
            return true;
        }

        /// <summary>
        /// vertaa hetun viimeistä merkkiä tarkastemerkkiin
        /// </summary>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <returns></returns>
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
