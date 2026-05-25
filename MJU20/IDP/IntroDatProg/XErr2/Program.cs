using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace XErr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in grader i Celsius: ");
            double centigrades;
            while(!double.TryParse(Console.ReadLine(), out centigrades))
            {
                Console.WriteLine("Felaktig inmatning!");
                Console.WriteLine("Mata in grader i Celsius: ");
            }
            Console.WriteLine("Det blir {0} grader Fahrenheit", centigrades * 1.8 + 32);
        }
    }
}
