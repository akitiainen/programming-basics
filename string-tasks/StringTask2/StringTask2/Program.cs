using System;

namespace StringTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something: ");
            string S = Console.ReadLine();
            S = MyReplace(S);
            Console.WriteLine(S);
        }

        static string MyReplace(string str)
        {
            return str.Replace('e', '@');
        }
    }
}
