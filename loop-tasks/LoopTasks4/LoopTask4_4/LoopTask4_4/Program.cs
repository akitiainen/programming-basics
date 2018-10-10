using System;

namespace LoopTask4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rndNumber;
            int n;
            int kr = 0;
            int kl = 0;
            Console.WriteLine("Tämä ohjelma simuloi kolikon heittoa\n");
            Console.Write("Syötä numero montako kertaa haluat kolikkoa heitettävän: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                rndNumber = rnd.Next(2);
                if (rndNumber == 1)
                {
                    kr = kr + 1;
                }
                else
                {
                    kl = kl + 1;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine($"Kruuna heitettiin {kr} kertaa");
            Console.WriteLine($"Klaava heitettiin {kl} kertaa");
        }
    }
}
