using System.Collections;

namespace Ovn_3_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Stack<int> S = new Stack<int>();
            for (int i = 0; i < 5; i++)
            {
                int r = rand.Next(1, 100);
                S.Push(r);
                Console.Write(r + " ");
            }
            Console.WriteLine();
            while (S.Count > 0)
            {
                int n = S.Pop();
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
