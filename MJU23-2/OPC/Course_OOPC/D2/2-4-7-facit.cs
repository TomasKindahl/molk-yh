namespace OPC1_uppg_2_4_7_facit
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            List<int> primes = new List<int>() { 2 };
            for(int i = 0; i < 10; i++)
            {
                int next = primes[primes.Count-1]+1;
                while (!IsPrime(next))
                    next += 1;
                primes.Add(next);
            }
            foreach(int p in primes)
            {
                Console.Write($"{p}, ");
            }
            Console.WriteLine();
        }
    }
}