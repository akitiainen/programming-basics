using System;
using System.Linq;

namespace StringTask3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = Title();
            list = LOL(list);
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static string[] Title()
        {
            string s = "THE RISE OF THE PLANET OF THE APES";
            s = s.ToUpper();
            string[] x = s.Split(' ');
            return x;
        }

        static string[] LOL(string[] x)
        {
            string s = string.Empty;
            string[] a = new string[] {"THE", "OF", "A", "TO", "AND", "BUT", "FOR", "AT", "BY", "FROM"};
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {

                }
            }
            return x;
        }
    }
}
