namespace BuggyArrayRotate
{
    internal class Program
    {
        static void PrintArray(int[] arr)
        {
            Console.Write("["+arr[0]);
            for(int i = 1; i < arr.Length; i++)
            {
                Console.Write(", "+arr[i]);
            }
            Console.WriteLine("]");
        }
        static void RotateArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i+1];
            }
        }
        static void Main(string[] args)
        {
            int[] marr = { 2, 3, 5, 7, 11, 13, 17 };
            PrintArray(marr);
            RotateArray(marr);
            PrintArray(marr);
        }
    }
}