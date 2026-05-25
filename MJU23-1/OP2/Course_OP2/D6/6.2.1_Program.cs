namespace ovn_6_2_1
{
    public static class IntExt
    {
        public static bool IsPrime(this int n)
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 15; i++)
            {
                if(i.IsPrime()) Console.WriteLine(i);
            }
        }
    }
}
