using System;

namespace ArrayTask_Lotto_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lottery = new int[40];
            Intro();
            RndLotteryNumbers(ref lottery, 7, 1);
            RndExtraNumber(ref lottery, 1, 2);
            PrintLottery(lottery);
        }

        static void Intro()
        {
            Console.WriteLine("Arvotaan loton numerot");
            Console.WriteLine("Paina jotain näppäintä aloittaaksesi arvonnan");
            Console.ReadKey();
        }

        static void RndLotteryNumbers (ref int[] arrLottery, int amount, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                int rndNumber = rnd.Next(40);
                if (arrLottery[rndNumber] == 0)
                    arrLottery[rndNumber] = value;
                else
                    i--;
            }
        }

        static void RndExtraNumber(ref int[] arrLottery, int amount, int value)
        {
            Random rnd = new Random();
            for (int i = 0; i < amount; i++)
            {
                int rndNumber = rnd.Next(40);
                if (arrLottery[rndNumber] == 0)
                    arrLottery[rndNumber] = value;
                else
                    i--;
            }
        }

        static void PrintLottery(int[] arrLottery)
        {
            Random rnd = new Random();
            Console.Write("Arvottiin oikeat numerot: ");
            for (int i = 0; i < arrLottery.Length; i++)
            {
                if (arrLottery[i] == 1)
                    Console.Write($"{i + 1}  ");
            }

            for (int i = 0; i < arrLottery.Length; i++)
            {
                if (arrLottery[i] == 2)
                    Console.WriteLine($"\nLisänumero: {i+1}");
            }

            Console.WriteLine($"Plussanumero: {rnd.Next(40)+1}");
        }
    }
}
