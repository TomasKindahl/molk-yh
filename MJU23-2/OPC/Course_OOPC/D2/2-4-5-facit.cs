namespace OPC1_uppg_2_4_5_facit
{
    internal class Program
    {
        static List<int> fiblist = new List<int> { 0, 1 };
        static int Fib(int n)
        {
            if (n < 0)
                return -1;
            else if (n < fiblist.Count)
                return fiblist[n];
            else
            {
                while (n >= fiblist.Count) 
                    fiblist.Add(Fib(n-1)+Fib(n-2));
                return Fib(n);
            }
        }
        static void Main(string[] args)
        {
            for(int i = 0; i < 6; i++) {
                Console.WriteLine($"{i} {Math.Pow(2,i)} {Fib((int)Math.Pow(2, i))}");
            }
        }
    }
}