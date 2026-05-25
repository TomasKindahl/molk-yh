using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace OPC1_uppg_2_6_1_facit
{
    internal class Program
    {
        class Point
        {
            public double x, y;
            public Point(double x, double y)
            {
                this.x = x; this.y = y;
            }
            public override string ToString()
                => $"\u27E8{x},{y}\u27E9";
            public static Point operator -(Point p1)
                => new Point(-p1.x, -p1.y);
            public static Point operator +(Point p1, Point p2)
                => new Point(p1.x + p2.x, p1.y + p2.y);
            public static Point operator -(Point p1, Point p2)
                => p1 + -p2;
            public double distance(Point other)
            {
                double xdiff = x - other.x;
                double ydiff = y - other.y;
                return Math.Sqrt(xdiff*xdiff+ydiff*ydiff);
            }
            public static Point operator *(Point p, double c)
                => new Point(c * p.x, c * p.y);
            public static Point operator /(Point p, double c)
                => new Point(p.x / c, p.y / c);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Point p1 = new Point(2, 3);
            Console.WriteLine($"p1 = {p1}");
            Console.WriteLine($"-p1 = {-p1}");
            Point p2 = new Point(4,-2);
            Console.WriteLine($"p2 = {p2}");
            Console.WriteLine($"p1+p2 = {p1 + p2}");
            Console.WriteLine($"p1*2 = {p1 * 2}");
            Console.WriteLine($"p1/2 = {p1 / 2}");
            Console.WriteLine($"p1.distance(p2) = {p1.distance(p2)}");
        }
    }
}