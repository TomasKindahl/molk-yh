namespace d8_ovn4_sort_rect
{
    internal class Program
    {
        class Rectangle : IComparable<Rectangle>
        {
            double width, height;
            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }
            public double Area() => width * height;
            public override string ToString() => $"[rect W={width} H={height}]";
            public int CompareTo_v1(Rectangle? other)
            {
                if (other == null) return 1;
                double thisA = this.Area() ;
                double otherA = other.Area() ;
                if (thisA > otherA) return 1;
                else if (thisA == otherA) return 0;
                return -1;
            }
            public int CompareTo(Rectangle? other)
            {
                if (other == null) return 1;
                double thisH = this.height;
                double otherH = other.height;
                if (thisH > otherH) return 1;
                else if (thisH == otherH) return 0;
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2, 4); // 8
            Rectangle r2 = new Rectangle(3, 5); // 15
            Rectangle r3 = new Rectangle(1, 6); // 6
            List<Rectangle> rl = new List<Rectangle>() { r3, r2, r1 };
            foreach (Rectangle r in rl) Console.WriteLine(r);
            Console.WriteLine();
            rl.Sort();
            foreach (Rectangle r in rl) Console.WriteLine(r);
        }
    }
}
