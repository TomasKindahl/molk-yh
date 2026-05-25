using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Starmap_0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Point
        {
            public double x, y;
            public Point(double X, double Y)
            {
                x = X; y = Y;
            }
            override public string ToString()
            {
                return $"({x},{y})";
            }
        }
        class Rotation
        {
            public double angle;
            public Rotation(double Angle)
            {
                angle = Angle;
            }
            override public string ToString()
            {
                return $"{angle}";
            }
        }
        abstract class Shape
        {
            public Point point;
            public Rotation rotation;
            override public string ToString()
            {
                return $"pos={point}, rot={rotation}";
            }
            abstract public void Draw(Grid grid);
        }
        class Circle : Shape
        {
            public double radius;
            public Circle(double Radius, Point P, Rotation R)
            {
                radius = Radius; point = P; rotation = R;
            }
            override public string ToString()
            {
                return $"Circle radius={radius}, {base.ToString()}";
            }
            override public void Draw(Grid grid)
            {
                // https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.ellipse?view=windowsdesktop-6.0
            }
        }
        class Line : Shape
        {
            double thickness, length;
            public Line(double Thick, double Len, Point P, Rotation R)
            {
                thickness = Thick;
                length = Len;
            }
            override public string ToString()
            {
                return $"Line thickness = {thickness}, length = {length}, {base.ToString()}";
            }
            override public void Draw(Grid grid)
            {

            }
        }
        class Rect : Shape
        {
            double height, width;
            public Rect(double H, double W, Point P, Rotation R)
            {
                height = H; width = W;
                point = P;
                rotation = R;
            }
            override public string ToString()
            {
                return $"Rectangle height = {height}, width = {width}, {base.ToString()}";
            }
            override public void Draw(Grid grid)
            {
                // https://docs.microsoft.com/en-us/dotnet/api/system.windows.shapes.rectangle?view=windowsdesktop-6.0
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            Circle c1 = new Circle(10, new Point(10, 3), new Rotation(10));
            Circle c2 = new Circle(10, new Point(10, 3), new Rotation(10));
            Circle c3 = new Circle(10, new Point(10, 3), new Rotation(10));
            Shape[] shapes = new Shape[] { c1, c2, c3 };
            Console.Text = "";
            foreach(Shape sh in shapes)
            {
                Console.Text += $"{sh}\n";
                sh.Draw(MainGrid);
            }
        }
    }
}
