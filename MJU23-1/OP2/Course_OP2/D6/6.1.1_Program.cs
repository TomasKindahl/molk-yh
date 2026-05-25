namespace ovn_6_1_1
{
    internal class Program
    {
        static List<int> CRange(int n)
        {
            List<int> res = new List<int>();
            for(int i = 0; i < n; i++) res.Add(i);
            return res;
        }
        static IEnumerable<int> YRange(int n)
        {
            for (int i = 0; i < n; i++) yield return i;
        }
        static void Main(string[] args)
        {
            foreach (int i in CRange(5))
                Console.Write($"{i} ");
            Console.WriteLine();
            foreach (int i in YRange(5))
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
