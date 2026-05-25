using System.Drawing;
using System.Net.Http.Headers;
using System.Text;

namespace OPC1_uppg_2_7_1_facit
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
                return Math.Sqrt(xdiff * xdiff + ydiff * ydiff);
            }
            public static Point operator *(Point p, double c)
                => new Point(c * p.x, c * p.y);
            public static Point operator /(Point p, double c)
                => new Point(p.x / c, p.y / c);
        }
        class Shape
        {
            public Point centerpoint;
            public double rotation;
            public Color color;
            public Shape(Point centerpoint, double rotation)
            {
                this.centerpoint = centerpoint;
                this.rotation = rotation;
            }
            public override string ToString()
                => $"<Shape center={centerpoint}, rotation={rotation}°>";
            public string getAttrString()
                => $"<center={centerpoint}, rotation={rotation}°";
            public void Rotate(double angle)
            {
                rotation += angle;
                rotation = rotation % 360;
            }
            public void Move(Point XYoff)
                => centerpoint += XYoff;
            public void SetColor(Color color)
                => this.color = color;
        }
        class Rectangle : Shape
        {
            double width, height;
            public Rectangle(Point center, double rotation, double width, double height)
                : base(center, rotation)
            {
                this.width = width; this.height = height;
            }
            public override string ToString()
                => $"<Rectangle {getAttrString()}, width={width}, height={height}";
        }
        class Ellipse : Shape
        {
            double A, B;
            public Ellipse(Point center, double rotation, double A, double B)
                : base(center, rotation)
            {
                this.A = A; this.B = B;
            }
            public override string ToString()
                => $"<Ellipse {getAttrString()}, majoraxis={A}, minoraxis={B}";
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Shape s1 = new Shape(new Point(0, 0), 30);
            Console.WriteLine(s1);
            Rectangle rect = new Rectangle(new Point(10, 4), 60, 2.5, 3.5);
            Console.WriteLine(rect);
            Ellipse ell = new Ellipse(new Point(5, 7), 60, .5, 3.5);
            Console.WriteLine(ell);
        }
    }
}