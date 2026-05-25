namespace d7_ovn2_swap_init
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 2;
            Console.WriteLine($"i = {i}, j = {j}");
            IntSwap(ref i, ref j);
            Console.WriteLine($"i = {i}, j = {j}");

            int[] ia = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            for(int ix = 1; ix < ia.Length; ix++)
            {
                IntSwap(ref ia[ix-1], ref ia[ix]);
            }
            foreach(int ix in ia)
                Console.Write(ix + " ");
            Console.WriteLine();

            int a, b = 2;
            IntInit(out a, ref b);
            Console.WriteLine($"a = {a}, b = {b}");
            int a2, b2 = -2;
            IntInit(out a2, ref b2);
            Console.WriteLine($"a2 = {a2}, b2 = {b2}");
        }

        private static void IntSwap(ref int i, ref int j)
        {
            int temp = i; i = j; j = temp;
        }
        private static void IntInit(out int a, ref int b)
        {
            if (b > 0) { a = b; }
            else { a = 0; }
        }
    }
}
