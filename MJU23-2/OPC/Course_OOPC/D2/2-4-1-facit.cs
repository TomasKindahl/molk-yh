namespace OPC1_uppg_2_4_1_facit
{
    internal class Program
    {
        static int Sqr(int x) => x * x;
        static int Cube(int x) => x * Sqr(x);
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++) {
                Console.WriteLine($"{i} {Sqr(i)} {Cube(i)}");
            }
        }
    }
}