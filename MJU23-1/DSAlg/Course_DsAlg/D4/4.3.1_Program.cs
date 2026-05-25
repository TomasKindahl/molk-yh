using System.Collections;

namespace Ovn_4_3_1
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
            public int CompareTo(Rectangle? other) {
                double area = Area(), oarea = other.Area();
                if(area < oarea)
                {
                    return -1;
                }
                else if(area > oarea)
                {
                    return 1;
                }
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2, 3);
            Rectangle r2 = new Rectangle(3, 5);
            Rectangle r3 = new Rectangle(1, 6);
            List<Rectangle> rl = new List<Rectangle>() { r3, r2, r1 };
            foreach (Rectangle r in rl) Console.WriteLine(r);
            Console.WriteLine();
            rl.Sort(); // Detta hänger sig!
            foreach (Rectangle r in rl) Console.WriteLine(r);
        }
    }
}
