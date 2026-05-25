using System.Xml;

namespace MJU23v_DTP_T4
{
    public class IntMath
    {
        /// <summary>
        /// Computes the n:th power of x
        /// </summary>
        /// <param name="x">the base</param>
        /// <param name="n">the exponent</param>
        /// <returns>x<sup>n</sup></returns>
        public static long Pow(int x, int n)
        {
            long res = 1;
            while(n > 0)
            {
                if (n % 2 == 0) { x = x * x; n = n / 2; }
                else { res *= x; n--; }
            }
            return res;
        }
        /// <summary>
        /// Computes the factorial of n, n!=1*2*3*...*n
        /// </summary>
        /// <param name="n">the argument</param>
        /// <returns>n!</returns>
        /// <exception cref="ArgumentOutOfRangeException">on negative arguments</exception>
        public static long Fact(int n)
        {
            long res = 1;
            if (n < 0) throw new ArgumentOutOfRangeException($"ERROR: Factorial on negative number {n}");
            for (int i = 1; i <= n; i++) res *= i;
            return res;
        }
        /// <summary>
        /// Computes the triangle number of n, i.e. 1+2+3+...+n
        /// </summary>
        /// <param name="n"></param>
        /// <returns>the triangle number</returns>
        public static long Tria(int n)
        {
            long res = 1;
            if (n < 0) 
                return -Tria(-n);
            for (int i = 1; i <= n; i++) res += i;
            return res;
        }
        /// <summary>
        /// Computes the greatest common divisor of m and n, that is the largest
        /// number g, which divides m and n without left-over
        /// </summary>
        /// <param name="m">first number</param>
        /// <param name="n">second number</param>
        /// <returns>the GCD, the greatest common divisor</returns>
        /// <exception cref="ArgumentOutOfRangeException">if m or n are zero or negative</exception>
        public static long GCD(int m, int n)
        {
            if (m <= 0 || n < 0)
                throw new ArgumentOutOfRangeException($"ERROR: GCD on negative number {m}, {n}");
            if (n == 0) return m;
            if (m == 0) return n;
            return GCD(n, m % n);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pow:
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 2; j <= 5; j++)
                    Console.Write(IntMath.Pow(j, i)+" ");
                Console.WriteLine();
            }

            // Tria, Fact:
            for (int i = 0; i <= 19; i++)
            {
                Console.WriteLine(i + " " + IntMath.Tria(i) + " " + IntMath.Fact(i));
            }

            // GCD:
            Console.Write("  ");
            for (int j = 1; j < 10; j++)
                Console.Write(j + " ");
            Console.WriteLine();
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + " ");
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(IntMath.GCD(j, i) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}