namespace ovn_3_2_3
{
    internal class Program
    {
        static void IntInit(out int variable, int positiveValue)
        {
            if (positiveValue < 0)
                variable = 0;
            else 
                variable = positiveValue;
        }
        static void Main(string[] args)
        {
            int a, b = 2;
            IntInit(out a, b);
            Console.WriteLine($"a = {a}, b = {b}");
            int c, d = -2;
            IntInit(out c, d);
            Console.WriteLine($"c = {c}, d = {d}");
        }
    }
}
