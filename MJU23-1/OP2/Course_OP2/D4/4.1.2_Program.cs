namespace ovn_4_1_2
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
            public T GetAt(int index) => stack[index];
            public void RemoveAt(int index) => stack.RemoveAt(index);
        }
        static void Main(string[] args)
        {
            MyStack<string> ms = new MyStack<string>();
            foreach (string s in new string[] { "doff", "mxyzptlk", "dole", "ole" })
                ms.Push(s);
            for (int i = 0; i < ms.Count; i++)
                Console.WriteLine($"{i}: {ms.GetAt(i)}");
            ms.RemoveAt(1);
            for (int i = 0; i < ms.Count; i++)
                Console.WriteLine($"{i}: {ms.GetAt(i)}");
        }
    }
}
