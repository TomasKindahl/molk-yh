using System.ComponentModel;

namespace ovn_3_3_2
{
    internal class Program
    {
        class IntRing
        {
            List<int> list;
            int pointer;
            public IntRing()
            {
                list = new List<int>();
                pointer = 0;
            }
            public void Add(int val)
            {
                if (pointer == list.Count)
                    list.Add(val);
                else
                    list.Insert(pointer, val);
            }
            public void Add(int[] vals)
            {
                foreach (int val in vals) Add(val);
            }
            public void Next()
            {
                pointer++;
                if (pointer == list.Count) pointer = 0;
            }
            public int Length
            {
                get => list.Count;
            }
            public override string ToString()
            {
                if (list.Count == 0)
                    return $"(empty ring)";
                string res = $"Ring({list[pointer]}";
                for (int i = 1; i < list.Count; i++)
                {
                    int ix = (pointer + i) % list.Count;
                    res += $", {list[ix]}";
                }
                res += ")";
                return res;
            }
        }
        static void Main(string[] args)
        {
            IntRing intRing = new IntRing();
            Console.WriteLine(intRing); // (empty ring)
            intRing.Add([2, 3, 5]);
            Console.WriteLine(intRing); // Ring(5, 3, 2)

            intRing.Next();
            Console.WriteLine(intRing); // Ring(3, 2, 5)

            intRing.Next();
            Console.WriteLine(intRing); // Ring(2, 5, 3)
            intRing.Add(7);
            Console.WriteLine(intRing); // Ring(7, 2, 3, 5)
        }
    }
}
