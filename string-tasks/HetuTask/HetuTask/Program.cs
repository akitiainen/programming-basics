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
                        Console.Clear();
                        do
                        {
                            string strHetu = CheckIntro();
                            if (DateChecker(strHetu))
                            {
                                string check = HetuChecker(strHetu);
                                bool isReal = (FinalChecker(check, strHetu.Substring(10)));
                                PrintDataCheck(isReal);
                                break;
                            }
                        }
                        while (true);
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        do
                        {
                            string date = GenIntro();
                            date = Cleaner(date);
                            if (DateChecker(date))
                            {
                                string dateTmp = date.Remove(4, 2);
                                string end = EndGenerator();
                                string checkMark = CheckMarkGenerator(dateTmp, end);
                                PrintDataGen(date, end, checkMark);
                                break;
                            }
                        }
                        while (true);
                    }
                    break;
            }
            
        }

        static int Operator()
        {
            Console.WriteLine("1. Tarkastaa henkilötunnuksen oikeellisuuden.\n2. Henkilötunnusgeneraattori.");
            return int.Parse(Console.ReadLine());
        }
        #region Checker
        static string CheckIntro()
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

        static void PrintDataCheck(bool data)
        {
            if(data)
                Console.WriteLine("Hetu on oikea!");
            else
                Console.WriteLine("Hetu on väärä!");
        }
        #endregion

        #region Generator

        static string GenIntro()
        {
            Console.Write("Syötä syntymäpäivä muodossa pp/kk/vvvv: ");
            return Console.ReadLine();
        }

        static string Cleaner(string x)
        {
            x = x.Replace("/", "");
            return x;
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

        static void PrintDataGen(string a, string b, string c)
        {
            int year = int.Parse(a.Substring(4));
            string hetu;
            if (year < 1900)
                hetu = a.Remove(4, 2) + "+" + b + c;
            else if (year < 2000)
                hetu = a.Remove(4, 2) + "-" + b + c;
            else
                hetu = a.Remove(4, 2) + "A" + b + c;
            Console.WriteLine($"Henkilötunnuksesi on {hetu}");
        }
        #endregion
    }

}
