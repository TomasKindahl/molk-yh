namespace d8_ovn4_delegates
{
    internal class Program
    {
        delegate bool Larger(Rectangle r1, Rectangle r2);
        static bool LargerHeight(Rectangle r1, Rectangle r2)
        {
            return r1.height > r2.height;
        }
        static bool LargerArea(Rectangle r1, Rectangle r2)
        {
            return r1.Area() > r2.Area();
        }
        static List<Rectangle> InsertionSort(List<Rectangle> list, Larger isLarger)
        {
            List<Rectangle> result = new List<Rectangle>(list);
            for (int i = 0; i < result.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (isLarger(result[j - 1], result[j]))
                    {
                        Rectangle temp = result[j - 1];
                        result[j - 1] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }
        class Rectangle
        {
            public double width, height;
            public Rectangle(double width, double height)
            {
                this.width = width; this.height = height;
            }
            public double Area() => width * height;
            public override string ToString() => $"[rect W={width} H={height}]";
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(1, 5); // 5
            Rectangle r2 = new Rectangle(4, 3); // 12
            Rectangle r3 = new Rectangle(3, 2); // 6
            List<Rectangle> rects = new List<Rectangle>() { r1, r2, r3 };
            foreach (Rectangle r in rects) Console.WriteLine(r);
            Console.WriteLine();
            List<Rectangle> sorth = InsertionSort(rects, LargerHeight);
            foreach (Rectangle r in sorth) Console.WriteLine(r);
            Console.WriteLine();
            List<Rectangle> sorta = InsertionSort(rects, LargerArea);
            foreach (Rectangle r in sorta) Console.WriteLine(r);
        }
    }
}
