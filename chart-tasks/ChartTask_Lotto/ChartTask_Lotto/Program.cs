using System;

namespace ChartTask_Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma arpoo lauantain lottonumerot ja tulostaa arvotut luvut.");
            int[] lottoNumbers = new int[40];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                int rndNumber = rnd.Next(40);
                if (lottoNumbers[rndNumber] == 0)
                    lottoNumbers[rndNumber] = 1;
                else
                    i--;
            }

            while (true)
            {
                int rndNumber = rnd.Next(40);
                if (lottoNumbers[rndNumber] == 0)
                {
                    lottoNumbers[rndNumber] = 2;
                    break;
                }
            }
            int plusNumber = rnd.Next(40)+1;

            Console.Write("Arvottiin oikeat numerot: ");
            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                if(lottoNumbers[i] == 1)
                    Console.Write($"{i+1} ");
               
            }

            for (int i = 0; i < lottoNumbers.Length; i++)
            {
                if (lottoNumbers[i] == 2)
                    Console.WriteLine($"\nLisänumero: {i + 1}");

            }
            Console.WriteLine($"Plussanumero: {plusNumber}");
        }
    }
}
