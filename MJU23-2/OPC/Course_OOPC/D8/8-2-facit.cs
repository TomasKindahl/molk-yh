namespace d8_ovn2_generics
{
    internal class Program
    {
        class Vec<T>
        {
            T[] arr;
            public Vec(int size, T defaultvalue)
            {
                arr = new T[size];
                for (int i = 0; i < arr.Length; i++) arr[i] = defaultvalue;
            }
            public T GetAt(int index) => arr[index];
            public void SetAt(int index, T newValue) => arr[index] = newValue;
            public override string ToString()
            {
                string res = $"{arr[0]}";
                for (int i = 1; i < arr.Length; i++)
                    res += $"; {arr[0]}";
                return res;
            }
        }
        class Point
        {
            public int x, y;
            public Point(int x, int y) { this.x = x; this.y = y; }
            public override string ToString() => $"({x} {y})";
        }
        static void Main(string[] args)
        {
            Vec<int> iv = new Vec<int>(5, 0);
            Console.WriteLine(iv);
            Vec<string> sv = new Vec<string>(5, "tjata");
            Console.WriteLine(sv);
            Vec<Point> pv = new Vec<Point>(4, new Point(0, 0));
            Console.WriteLine(pv);
        }
    }
}
