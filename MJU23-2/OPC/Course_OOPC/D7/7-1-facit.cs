namespace d7_ovn1_vektorer
{
    internal class Program
    {
        struct Point2D
        {
            public double X, Y;
            public Point2D(double x, double y) { X = x; Y = y; }
            public override string ToString() => $"({X} {Y})";
            public static Point2D operator +(Point2D P, Point2D Q)
                => new Point2D(P.X + Q.X, P.Y + Q.Y);
            public static Point2D operator -(Point2D P)
                => new Point2D(-P.X, -P.Y);
            public static Point2D operator -(Point2D P, Point2D Q)
                => P + -Q;
            public static double Sqr(double X) => X * X;
            public double Distance(Point2D other)
            {
                return Math.Sqrt(Sqr(this.X-other.X) + Sqr(this.Y - other.Y));
            }
        }
        static void Main(string[] args)
        {
            Point2D P1 = new Point2D(2, -1);
            Point2D P2 = new Point2D(3, 2);
            // P3 = P1 + P2 ==> P3.X = P1.X+P2.X, P3.Y = P1.Y+P2.Y
            // P3 = (2+3, -1+2) = (5, 1)
            Point2D P3 = P1 + P2;
            Console.WriteLine(P3);
            Point2D P4 = -P1;
            Console.WriteLine(P4);
            Point2D P5 = P1 - P2;
            Console.WriteLine(P5);
            Point2D P6 = new Point2D(0, 1);
            Point2D origo = new Point2D(0, 0);
            double dist = P6.Distance(origo);
            Console.WriteLine(dist);
            Point2D P8 = new Point2D(1, 1);
            dist = P8.Distance(origo);
            Console.WriteLine(dist);

            /* 3.1.2
            Point2D P1 = new Point2D(4, 9);
            Point2D P2 = P1;
            Console.WriteLine(P2);
            P1.X = 666;
            Console.WriteLine(P2);
            */
            /* 3.1.1
            Point2D P = new Point2D(2, 3);
            Console.WriteLine(P);
            */
        }
    }
}
