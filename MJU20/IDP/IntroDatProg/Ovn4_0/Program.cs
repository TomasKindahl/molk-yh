using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn4_0
{
    class Program
    {
        static bool isPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int primeCandidate;
            do
            {
                Console.Write("Ange ett tal: ");
                primeCandidate = int.Parse(Console.ReadLine());
                if(isPrime(primeCandidate))
                {
                    Console.WriteLine("Talet {0} är ett primtal", primeCandidate);
                }
                else
                {
                    Console.WriteLine("Talet {0} är INTE ett primtal", primeCandidate);
                }
            } while (primeCandidate != 0);
        }
    }
}
