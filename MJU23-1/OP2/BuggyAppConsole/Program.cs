namespace BuggyAppConsole
{
    internal class Program
    {
        static double sumofInverses(int from, int to)
        {
            double sum = 0;
            for(int i = from; i < to; i++)
                sum += 1/i;
            return sum;
        }
        static void Main(string[] args)
        {
            double sum_10_100 = sumofInverses(10, 100);
            Console.WriteLine(sum_10_100);
        }
    }
}
