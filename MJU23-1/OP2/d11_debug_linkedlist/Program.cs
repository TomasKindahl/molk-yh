namespace d11_debug_linkedlist
{
    internal class Program
    {
        class LinkedList<T>
        {
            T value;
            LinkedList<T> next;
            public LinkedList (T value, LinkedList<T> next)
            {
                this.value = value;
                this.next = next;
            }
            public LinkedList(T[] values)
            {
                this.value = values[0];
                if (values.Length == 1) {
                    this.next = null;
                }
                else
                {
                    this.next = new LinkedList<T>(values[1..]);
                }
            }
            public override string ToString()
            {
                string res = $"{value} ";
                if (next.next == null)
                {
                    return res;
                }
                else
                {
                    res += $"{next}";
                    return res;
                }
            }
        }
        static void Main(string[] args)
        {
            LinkedList<int> lli1 = new LinkedList<int>([2, 3, 5, 7, 11]);
            Console.WriteLine(lli1);
            LinkedList<int> lli2 = new LinkedList<int>([0]);
            Console.WriteLine(lli2);
        }
    }
}
