namespace ovn_3_2_1
{
    internal class Program
    {
        static void IntSwap(ref int I, ref int J)
        {
            int temp = I; I = J; J = temp;
        }
        static void Main(string[] args)
        {
            int i = 1, j = 2;
            Console.WriteLine($"i = {i}, j = {j}");
            IntSwap(ref i, ref j);
            Console.WriteLine($"i = {i}, j = {j}");

            int[] ia = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            PrintIntArray(ia);            
            for (int x = 0; x < ia.Length-1; x++)
            {
                IntSwap(ref ia[x], ref ia[x+1]);
            }
            PrintIntArray(ia);
        }
        private static void PrintIntArray(int[] ia)
        {
            if (ia.Length <= 0)
                Console.WriteLine();
            string s = $"{ia[0]}";
            for(int i = 1; i < ia.Length; i++) 
                s+= $", {ia[i]}";
            Console.WriteLine(s);
        }
    }
}
