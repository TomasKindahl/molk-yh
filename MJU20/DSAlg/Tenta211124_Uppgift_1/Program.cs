using System;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SparseArray<int> sa = new SparseArray<int>(100);
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                sa[r.Next(100)] = r.Next(100);
            }
            for (int i = 0; i < sa.Length(); i++)
            {
                Console.Write($"{i}:{sa[i]} ");
            }
            Console.WriteLine();

            SparseArray<int> sa2 = new SparseArray<int>(3_000_000_000);
            for (int i = 0; i < 10; i++)
            {
                sa2[(long)r.Next(1_000_000_000) * 3L] = r.Next(100);
            }
            for (long il = 0; il < sa2.Length(); il++)
            {
                var val = sa2[il];
                if (val != 0L)
                    Console.Write($"{il}:{val} ");
            }
            Console.WriteLine();
        }
    }
}
