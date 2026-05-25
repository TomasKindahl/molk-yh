using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XArr5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            int[] rval = new int[10];
            for (int i = 0; i < 10; i++)
            {
                rval[i] = R.Next(1, 11);
            }
            for (int i = 0; i < 10; i++)
            {
                if (rval[i] % 3 == 0)
                {
                    Console.WriteLine("{0}: {1}", i, rval[i]);
                }
            }
        }
    }
}
