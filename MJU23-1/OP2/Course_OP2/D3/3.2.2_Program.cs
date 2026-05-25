namespace ovn_3_2_2
{
    internal class Program
    {
        static (int, int)Swap(int x, int y)
            => (y, x);
        static void Main(string[] args)
        {
            int i = 2, j = 3;
            Console.WriteLine($"i = {i}, j = {j}");
            (i, j) = Swap(i, j);
            Console.WriteLine($"i = {i}, j = {j}");
        }
    }
}
