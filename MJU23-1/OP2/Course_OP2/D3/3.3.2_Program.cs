using System.ComponentModel;

namespace ovn_3_3_2
{
    internal class Program
    {
        class Ring<T>
        {
            List<T> list;
            int pointer;
            public Ring()
            {
                list = new List<T>();
                pointer = 0;
            }
            public void Add(T val)
            {
                if (pointer == list.Count)
                    list.Add(val);
                else
                    list.Insert(pointer, val);
            }
            public void Add(T[] vals)
            {
                foreach (T val in vals) Add(val);
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
            Ring<int> intRing = new Ring<int>();
            Console.WriteLine(intRing); // (empty ring)
            intRing.Add([2, 3, 5]);
            Console.WriteLine(intRing); // Ring(5, 3, 2)

            intRing.Next();
            Console.WriteLine(intRing); // Ring(3, 2, 5)

            intRing.Next();
            Console.WriteLine(intRing); // Ring(2, 5, 3)
            intRing.Add(7);
            Console.WriteLine(intRing); // Ring(7, 2, 3, 5)

            Ring<string> strRing = new Ring<string>();
            Console.WriteLine(strRing); // (empty ring)
            strRing.Add(["ole", "dole", "doff"]);
            Console.WriteLine(strRing); // Ring(5, 3, 2)

            strRing.Next();
            Console.WriteLine(strRing); // Ring(3, 2, 5)

            strRing.Next();
            Console.WriteLine(strRing); // Ring(2, 5, 3)
            strRing.Add("kinke");
            Console.WriteLine(strRing); // Ring(7, 2, 3, 5)
        }
    }
}
