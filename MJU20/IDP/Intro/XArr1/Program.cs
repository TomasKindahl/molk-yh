using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XArr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", R.Next(1, 11));
            }
        }
    }
}
