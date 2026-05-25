using System;
using System.Collections.Generic;

namespace shapes
{
    class Program
    {
        class Rectangle
        {
            private double centerX, centerY, rotation;
            private double height, width;
            public Rectangle(double X, double Y, double rotation, double height, double width)
            {
                centerX = X; centerY = Y; this.rotation = rotation;
                this.height = height; this.width = width;
            }
            public string Kind() => "rektangel";
            public double Area() => height * width;
            public double Circumference() => 2 * (height + width);
        }
        class Circle
        {
            private double centerX, centerY, rotation;
            private double radius;
            public Circle(double X, double Y, double rotation, double radius)
            {
                centerX = X; centerY = Y; this.rotation = rotation;
                this.radius = radius;
            }
            public string Kind() => "cirkel";
            public double Area() => Math.PI * radius * radius;
            public double Circumference() => 2 * Math.PI * radius;
        }
        public static void Main(string[] args)
        {
            List<Object> objects = new List<Object>();
            objects.Add(new Rectangle(X: 0, Y: 0, rotation: 30, width: 20, height: 10));
            objects.Add(new Circle(X: 2, Y: 12, rotation: 0, radius: 6));
            foreach (Object o in objects) {
                if(o is Rectangle r)
                    Console.WriteLine(r.Kind());
                else if(o is Circle c)
                    Console.WriteLine(c.Kind());
            }
        }
    }
}
