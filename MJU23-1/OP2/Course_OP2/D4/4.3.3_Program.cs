namespace ovn_4_3_3
{
    internal class Program
    {
        public delegate double binop(double a1, double a2);
        public static double add(double a1, double a2) => a1 + a2;
        public static double multiply(double a1, double a2) => a1 * a2;
        static double accumulate(double[] array, binop accum)
        {
            double res = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                res = accum(array[i], res);
            }
            return res;
        }
        static void Main(string[] args)
        {
            double[] da2 = { 1, 2, 3, 4, 5 };
            Console.WriteLine(accumulate(da2, add));
            Console.WriteLine(accumulate(da2, multiply));
            Console.WriteLine(accumulate(da2, (x, y) => x + y));
            Console.WriteLine(accumulate(da2, (x, y) => x * y));
        }
    }
}
