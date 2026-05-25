namespace ovn_5_1_2
{
    internal class Program
    {
        static void PrintIsZero(int x)
        {
            string adv = "";
            if (x != 0) adv = "not ";
            Console.WriteLine($"{x} is {adv}zero");
        }
        static void PrintSquare(int x)
        {
            Console.WriteLine($"the square of {x} is {x * x}");
        }
        static void PrintIsEven(int x)
        {
            string adj = "odd";
            if (x % 2 == 0) adj = "even";
            Console.WriteLine($"{x} is {adj}");
        }
        // Ny TYP PrintState för metoder på formen void X(int x) { ... }
        delegate void PrintState(int x);
        static void Main(string[] args)
        {
            List<PrintState> printStates = new List<PrintState> {
                PrintIsZero,
                PrintSquare,
                PrintIsEven
            };

            foreach (var ps in printStates)
            {
                for (int i = 0; i < 4; i++)
                {
                    ps(i);
                }
            }
        }
    }
}
