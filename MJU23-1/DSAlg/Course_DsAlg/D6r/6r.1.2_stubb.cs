namespace ovn_6r_1_2_stubb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LispList<int> lisplist = new LispList<int>([2, 3, 5, 7, 11, 13]);
            Console.WriteLine($"{lisplist}");
            Console.WriteLine($"{lisplist.ToStringIterative()}");
            Console.WriteLine($"len = {lisplist.Length()}");
            Console.WriteLine($"len = {lisplist.LengthIterative()}");
        }
        class LispList<T>
        {
            public T value;
            public LispList<T> next;
            public LispList(T value, LispList<T> next)
            {
                this.value = value;
                this.next = next;
            }
            public LispList(T[] array, int index=0)
            {
                if (index >= array.Length)
                    throw new IndexOutOfRangeException("Too short array when creating list");
                this.value = array[index];
                if (index == array.Length - 1)
                {
                    this.next = null;
                }
                else {
                    this.next = new LispList<T>(array, index+1);
                }
            }
            // ToString (recursive):
            public override string ToString()
            {
                string res = $"{value}";
                if (next != null)
                    res += $", {next.ToString()}";
                return res;
            }
            // Length (recursive): 
            public int Length()
            {
                int len = 1;
                // NYI: Lägg till kod här, snegla på ToString (recursive)!
                return len;
            }
            // ToStringIterative:
            public string ToStringIterative()
            {
                string res = $"{value}";
                LispList<T> nx = next;
                while (nx != null)
                {
                    res += $", {nx.value}";
                    nx = nx.next;
                }
                return res;

            }
            // LengthIterative: 
            public int LengthIterative()
            {
                int len = 1;
                // NYI: Lägg till kod här, snegla på ToStringIterative!
                return len;
            }
        }
    }
}
