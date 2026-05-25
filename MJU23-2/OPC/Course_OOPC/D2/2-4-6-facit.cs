namespace OPC1_uppg_2_4_6_facit
{
    internal class Program
    {
        static List<int> SelectOdd(List<int> L)
        {
            List<int> res = new List<int>();
            foreach (int i in L)
            {
                if (i % 2 == 1)
                    res.Add(i);
            }
            return res;
        }
        static void Main(string[] args)
        {
            List<int> numl = new List<int> { 2, 3, 4, 8, 11, 23, 32, 35 };
            foreach(int k in SelectOdd(numl))
                Console.Write($"{k}, ");
        }
    }
}