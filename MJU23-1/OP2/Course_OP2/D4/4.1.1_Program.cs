using System.Runtime.Intrinsics.X86;

namespace ovn_4_1_1
{
    internal class Program
    {
        class MyStack<T>
        {
            List<T> stack;
            public MyStack() { stack = new List<T>(); }
            public int Count { get { return stack.Count; } }
            public void Push(T item) { stack.Add(item); }
            public T Pop()
            {
                T val = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                return val;
            }
            public bool Contains(T item) => stack.Contains(item);
            public bool Remove(T item) => stack.Remove(item);
            public void Clear() => stack.Clear();
        }
        static void Main(string[] args)
        {
            MyStack<string> ms = new MyStack<string>();
            Console.WriteLine("Initial stack size: " + ms.Count);
            foreach (string s in new string[] { "doff", "mxyzptlk", "dole", "ole" })
                ms.Push(s);
            Console.WriteLine(ms.Count);
            Console.WriteLine("Stack size after adding four items: " + ms.Count);
            if (ms.Contains("mxyzptlk")) { Console.WriteLine("ms contains mxyzptlk!"); }
            if (ms.Remove("mxyzptlk")) { Console.WriteLine("mxyzptlk removed!"); }
            Console.WriteLine("Stack size after removing mxyzptlk: " + ms.Count);
            Console.WriteLine("Emptying stack:");
            while (ms.Count > 0)
            {
                string s = ms.Pop();
                Console.WriteLine("  "+s);
            }
            foreach (string s in new string[] { "hokus", "pokus" })
                ms.Push(s);
            ms.Clear();
            Console.WriteLine("Stack size after clearing: "+ms.Count);
        }
    }
}
