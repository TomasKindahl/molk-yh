namespace OPC1_uppg_2_4_3_facit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i < 12; i++)
                Console.WriteLine($"{i} {Math.Sqrt(i)} {Math.Sin(i)}");
        }
    }
}