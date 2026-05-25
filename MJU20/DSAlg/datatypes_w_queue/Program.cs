using dtarr_dsarr;
// using dtarr_dssll;
using dtstack_dsarr;
// using dtstack_dslink;
using dtqueue_dssll;
// using dtqueue_dssll;
using System;

namespace datatypes_w_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Array<int> arr = new Array<int>(new int[] { 2, 3, 5, 7 });
            Console.WriteLine($"arr.Length() = {arr.Length()}");
            Console.WriteLine($"arr = {arr}");

            Array<string> a2 = new Array<string>(new string[] { "ole", "dole", "doff" });
            Console.WriteLine($"{a2}");

            Stack<int> stack = new Stack<int>(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i * i);
                stack.Push(i * i);
            }
            Console.WriteLine($"{stack}");
            while (!stack.isEmpty())
            {
                Console.Write($"{stack.Pop()}, ");
            }
            Console.WriteLine();

            Queue<double> queue = new Queue<double>(10);
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(Math.Sqrt(i));
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{queue.Dequeue()}");
            }
        }
    }
}
