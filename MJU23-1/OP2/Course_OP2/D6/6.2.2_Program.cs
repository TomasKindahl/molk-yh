namespace ovn_6_2_3
{
    public static class IntExt
    {
        public static bool IsNotDivisible(this int n, int m) => n % m != 0;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                if (i.IsNotDivisible(3)) Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
