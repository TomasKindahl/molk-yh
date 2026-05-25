namespace OPC1_uppg_2_4_2_facit
{
    internal class Program
    {
        static int Sign(int x)
        {
            if (x < 0) return -1;
            else if (x == 0) return 0;
            else return 1;
        }
        static void Main(string[] args)
        {
            for(int i  = -1; i < 2; i++) {
                Console.WriteLine($"{i} {Sign(i)}");
            }
        }
    }
}