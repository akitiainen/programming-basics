using System;

namespace StringTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something ");
            string input = Console.ReadLine();
            string tupni = input;

            for (int i = 0; i < input.Length; i++)
            {
                string x = input[i].ToString();
                tupni.Insert(input.Length-1-i, x);
            }
            Console.WriteLine(tupni);
        }
    }    
}
