using System;

namespace StringTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            string S = Console.ReadLine();
            S = S.ToUpper();
            for (int i = 0; i < S.Length; i++)
            {
                S.IndexOf(S[i]);
                if(S[i] = "L")
                {
                    Console.WriteLine(S[i]);
                }
            }
        }
    }
}
