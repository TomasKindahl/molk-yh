namespace ovn_5_1_1
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
        delegate void PrintState(int x); // Ny TYP för metoder på formen void X(int x)
        static void Main(string[] args)
        {
            PrintState ps = PrintIsZero; // Tilldela ps metoden PrintZero
            for (int i = 0; i < 4; i++)
            {
                ps(i);
            }
            ps = PrintSquare; // Tilldela ps metoden PrintSquare
            for (int i = 0; i < 4; i++)
            {
                ps(i);
            }
            ps = PrintIsEven; // Tilldela ps metoden PrintIsEven
            for (int i = 0; i < 4; i++)
            {
                ps(i);
            }
        }
    }
}
