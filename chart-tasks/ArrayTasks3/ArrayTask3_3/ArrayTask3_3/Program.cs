using System;

namespace ArrayTask3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
            int[] arrT_1 = RndArray(10);
            int[] arrT_2 = RndArray(10);
            int[] arrT_3 = ComparingArray(arrT_1, arrT_2);
            PrintData(arrT_1, "arrT_1");
            PrintData(arrT_2, "arrT_2");
            PrintData(arrT_3, "arrT_3");

        }

        static void Intro()
        {
            Console.WriteLine("\t01  02  03  04  05  06  07  08  09  10");
            Console.WriteLine("\t--------------------------------------");
        }

        /// <summary>
        /// Fill array with random numbers
        /// Set array lenght
        /// Return filled array
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Compares indexes of arrays arrT_1 and arrT_2
        /// Fills arrT_3 with the larger index
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        static int [] ComparingArray(int [] array1, int [] array2)
        {
            int[] arrT = new int[array1.Length];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > array2[i])
                    arrT[i] = array1[i];
                else
                    arrT[i] = array2[i];
            }
            return arrT;
        }

        static void PrintData(int[] arrX, string label)
        {
            Console.Write($"{label}: ");
            for (int i = 0; i < arrX.Length; i++)
            {
                Console.Write($"{arrX[i]:d2}  ");
            }
            Console.WriteLine();
        }
    }
}
