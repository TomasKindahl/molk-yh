namespace opc1_d3_3_1_ovn_1
{
    internal class Program
    {
        abstract class Shape
        {
            private double centerX, centerY, rotation;
            public Shape(double X, double Y, double rotation)
            {
                this.centerX = X; this.centerY = Y; this.rotation = rotation;
            }
            public abstract string Kind();
            public abstract double Area();
            public abstract double Circumference();
        }
        class Rectangle : Shape
        {
            private double height, width;
            public Rectangle(double X, double Y, double rotation, double height, double width)
                : base(X, Y, rotation)
            {
                this.height = height; this.width = width;
            }
            public override string Kind() => "rektangel";
            public override double Area() => height * width;
            public override double Circumference() => 2 * (height + width);
        }
        class Circle : Shape
        {
            private double radius;
            public Circle(double X, double Y, double rotation, double radius)
                : base(X, Y, rotation)
            {
                this.radius = radius;
            }
            public override string Kind() => "cirkel";
            public override double Area() => Math.PI * radius * radius;
            public override double Circumference() => 2 * Math.PI * radius;
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(X: 0, Y: 0, rotation: 30, width: 20, height: 10));
            shapes.Add(new Circle(X: 2, Y: 12, rotation: 0, radius: 6));
            // shapes.Add(new Shape(X: 4, Y: -3, rotation: 30));
            foreach (Shape s in shapes)
            {
                Console.WriteLine($"{s.Kind()}, area={s.Area()}, omkrets={s.Circumference()}");
            }
        }
    }
}