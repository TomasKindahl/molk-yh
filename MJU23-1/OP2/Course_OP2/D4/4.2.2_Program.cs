using System.Collections;

namespace ovn_4_2_2
{
    internal class Program
    {
        class MyStack<T> : IEnumerable<T>
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
            public MyStackEnum<T> GetEnumerator()
                => new MyStackEnum<T>(stack);
            IEnumerator IEnumerable.GetEnumerator()
                => GetEnumerator();
            IEnumerator<T> IEnumerable<T>.GetEnumerator()
                => GetEnumerator();
        }
        class MyStackEnum<T> : IEnumerator<T>
        {
            List<T> stack;
            int pos;
            public MyStackEnum(List<T> stack) { 
                this.stack = stack;
                pos = -1;
            }
            public bool MoveNext()
            {
                pos++;
                return (pos < stack.Count);
            }
            public void Reset()
            {
                pos = -1;
            }
            void IDisposable.Dispose()
            {
                
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            public T Current
            {
                get
                {
                    try
                    {
                        return stack[pos];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            MyStack<string> ms = new MyStack<string>();
            foreach (string s in new string[] { "doff", "mxyzptlk", "dole", "ole" })
                ms.Push(s);
            foreach(string s in ms) 
                Console.WriteLine(s);
            for (int i = 0; i < ms.Count; i++)
                Console.WriteLine($"{i}: {ms.GetAt(i)}");
            ms.RemoveAt(1);
            for (int i = 0; i < ms.Count; i++)
                Console.WriteLine($"{i}: {ms.GetAt(i)}");

        }
    }
}
