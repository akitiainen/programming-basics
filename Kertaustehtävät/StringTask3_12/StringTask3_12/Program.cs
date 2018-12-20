using System;
using System.Linq;

namespace StringTask3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = Title();
            
        }

        static string[] Title()
        {
            string s = "THE RISE OF THE PLANET OF THE APES";
            string[] x = s.Split(' ');
            return x;
        }
    }
}
