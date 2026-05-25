using System;
using arr;

namespace genarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Array<int> A = new Array<int>(10);
            for (int i = 0; i < A.Length(); i++)
            {
                if (i == 4)
                    A.Set(i, 66);
                else
                    A.Set(i, 9 - i);
            }
            Console.WriteLine($"A = {A}");

            var SIZE = 10;
            var B = new Array<int>(SIZE);
            B.Print();
            B.Set(5, 12);
            B.Print();
        }
    }
}
