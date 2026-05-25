using System.Runtime.ExceptionServices;

namespace ovn_6_1_3
{
    internal class Program
    {
        static IEnumerable<int> NonDivisibles(int from, int to)
        {
            for (int i = from; i <= to; i++)
                if (i % 2 != 0 && i % 3 != 0) yield return i;
        }
        static void Main(string[] args)
        {
            foreach (int i in NonDivisibles(1, 12)) Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
