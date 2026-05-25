using System.Runtime.ExceptionServices;

namespace ovn_6_1_4
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static IEnumerable<int> Primes(int from, int to)
        {
            for (int i = from; i <= to; i++)
                if (IsPrime(i)) yield return i;
        }
        static void Main(string[] args)
        {
            foreach (int i in Primes(1, 12)) Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
