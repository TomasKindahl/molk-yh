using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] stat = new int[7];
            // SLumpa 100 tärningskast:
            for (int i = 1; i <= 100; i++)
            {
                int r = rand.Next(1, 7);
                stat[r] = stat[r] + 1;
                Console.Write("{0}, ", r);
            }
            // Skriv ut statistik:
            Console.WriteLine();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("{0}: {1}", i, stat[i]);
            }
        }
    }
}
