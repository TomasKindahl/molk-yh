using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XArr7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            // Register 10 random values in an array:
            int[] rval = new int[10];
            for (int i = 0; i < 10; i++)
            {
                rval[i] = R.Next(1, 11);
            }
            // Make statistics over the random values:
            int[] stat = new int[11];
            for (int i = 1; i < 10; i++)
            {
                stat[rval[i]] = stat[rval[i]]+1;
            }
            // Write the statistics:
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("antal {0}:or: {1}", i, stat[i]);
            }
        }
    }
}