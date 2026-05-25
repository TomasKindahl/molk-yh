namespace ovn_3_1_3
{
    internal class Program
    {
        struct Point2D
        {
            public double X, Y;
            public Point2D(double x, double y) { X = x; Y = y; }
            public override string ToString()
                => $"({X} {Y})";
            static public Point2D operator +(Point2D p1, Point2D p2)
                => new Point2D(p1.X + p2.X, p1.Y + p2.Y);
            static public Point2D operator -(Point2D p)
                => new Point2D(-p.X, -p.Y);
            static public Point2D operator -(Point2D p1, Point2D p2)
                => p1 + -p2;
            public double Distance(Point2D other)
            {
                double Sqr(double x) => x * x;
                return Math.Sqrt(Sqr(this.X - other.X) + Sqr(this.Y - other.Y));
            }
        }
        static void Main(string[] args)
        {
            Point2D P1 = new Point2D(2, -1);
            Point2D P2 = new Point2D(3, 2);
            Console.WriteLine($"{P1} + {P2} =  {P1 + P2}");
            Console.WriteLine($"-{P1} = {-P1}");
            Console.WriteLine($"{P1} - {P2} =  {P1 - P2}");
            Console.WriteLine($"{P1}.Distance({P2}) = {P1.Distance(P2)}");
        }
    }
}
