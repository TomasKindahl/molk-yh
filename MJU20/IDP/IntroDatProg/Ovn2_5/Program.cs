using System;
using System.Globalization;

namespace Ovn2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett tal: ");
            int num = int.Parse(Console.ReadLine());
            if(num < 0)
            {
                Console.WriteLine("Talet är negativt.");
            }
            if (num > 0)
            {
                Console.WriteLine("Talet är positivt.");
            }
            if (num == 0)
            {
                Console.WriteLine("Talet är lika med noll.");
            }
        }
    }
}
