namespace ovn_6r_1_1
{
    internal class Program
    {
        static long FactorialRecursive(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException($"Factorial negative argument: {-1}");
            if (n == 0) return 1;
            return n * FactorialRecursive(n - 1);
        }
        static long FactorialIterative(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException($"Factorial negative argument: {-1}");
            long res = 1;
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }
        static long TriangularRecursive(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException($"Triangular negative argument: {-1}");
            if (n == 0) return 0;
            return n + TriangularRecursive(n - 1);
        }
        static long TriangularIterative(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException($"Triangular negative argument: {-1}");
            long res = 0;
            for (int i = 1; i <= n; i++) res += i;
            return res;
        }
        static long TriangularFormula(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException($"Triangular negative argument: {-1}");
            return (n * n + n) / 2 ;
        }
        static void Main(string[] args)
        {
            for (int val = -1; val <= 10; val++)
            {
                try
                {
                    Console.Write($"fact({val}) = {FactorialRecursive(val)} (recursive), ");
                    Console.WriteLine($"fact({val}) = {FactorialIterative(val)} (iterative)");
                } catch (ArgumentOutOfRangeException e) { 
                    Console.WriteLine($"Factorial not defined for {val}!");
                }
                try
                {
                    Console.Write($"tria({val}) = {TriangularRecursive(val)} (recursive), ");
                    Console.Write($"tria({val}) = {TriangularIterative(val)} (iterative), ");
                    Console.WriteLine($"tria({val}) = {TriangularFormula(val)} (formula)");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"Triangular not defined for {val}!");
                }
            }
        }
    }
}
