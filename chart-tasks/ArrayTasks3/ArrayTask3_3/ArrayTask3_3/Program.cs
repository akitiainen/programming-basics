using System;

namespace ArrayTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrT_1 = RndArray(10);
            int[] arrT_2 = RndArray(10);
        }

        static int [] RndArray(int length)
        {
            Random rnd = new Random();
            int[] arrT = new int[length];

            for (int i = 0; i < length; i++)
            {
                arrT[i] = rnd.Next(20);
            }
            return arrT;
        }
    }
}
