namespace OPC1_uppg_2_4_4_facit
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
            for(int k = 2; k < 20; k++) {
                if(IsPrime(k))
                {
                    Console.WriteLine($"{k} is a prime number");
                }
            }
        }
    }
}