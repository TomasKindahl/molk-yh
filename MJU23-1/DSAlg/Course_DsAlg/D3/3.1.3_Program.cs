using System.Collections;

namespace Ovn_3_1_3
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 0) return IsPrime(-n);
            if (n < 2) return false;
            for (int i = 2; i*i <= n; i++) { 
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            Queue<int> primeQueue = new Queue<int>();
            Queue<int> otherQueue = new Queue<int>();
            for (int i = 0; i < 20; i++)
            {
                int r = rand.Next(1, 100);
                if(IsPrime(r))
                    primeQueue.Enqueue(r);
                else otherQueue.Enqueue(r);
                Console.Write(r+" ");
            }
            Console.WriteLine();
            Console.WriteLine("---- primes ----");
            while (primeQueue.Count > 0)
            {
                int n = primeQueue.Dequeue();
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---- non-primes ----");
            while (otherQueue.Count > 0)
            {
                int n = otherQueue.Dequeue();
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
