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
            int letterCounter = 0;
            for (int i = 0; i < S.Length; i++)
            {
                
                if (S[i].ToString() == "L")
                {
                    Console.WriteLine(S[i]);
                    letterCounter++;
                }
            }
            Console.WriteLine($"Your input '{S}' has {letterCounter} letter L's");
        }
    }
}
