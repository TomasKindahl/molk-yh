using System;
using System.Collections.Generic;
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

namespace StarMap_1
{
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
                return $"({x}, {y})";
            }
            static public Point operator + (Point P1, Point P2)
            {
                return new Point(P1.x + P2.x, P1.y + P2.y);
            }
            static public Point operator -(Point P1, Point P2)
            {
                return new Point(P1.x - P2.x, P1.y - P2.y);
            }
            static public Point operator *(Point P1, Point P2)
            {
                return new Point(P1.x * P2.x, P1.y * P2.y);
            }
            static public Point operator *(Point P1, double factor)
            {
                return new Point(P1.x * factor, P1.y * factor);
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
            protected Point point;
            protected Rotation rotation;
            public Shape(Point P, Rotation R)
            {
                point = P; rotation = R;
            }
            override public string ToString()
            {
                return $"position = {point}, rotation = {rotation}";
            }
            virtual public void Print(TextBlock Output)
            {
                Output.Text += $"{ToString()}\n";
            }
            abstract public void Draw(Grid grid, Point offset, Point scale);
        }
        class Circle : Shape
        {
            double radius;
            public Circle(double Rad, Point P, Rotation R) : base(P, R)
            {
                radius = Rad;
            }
            override public string ToString()
            {
                return $"Circle radius = {radius}, {base.ToString()}";
            }
            override public void Print(TextBlock Output)
            {
                Output.Text += $"{ToString()}\n";
            }
            override public void Draw(Grid grid, Point offset, Point scale)
            {
                Point P = point * scale + offset;
                Ellipse E = new Ellipse();
                E.Fill = Brushes.Wheat;
                E.HorizontalAlignment = HorizontalAlignment.Left;
                E.VerticalAlignment = VerticalAlignment.Bottom;
                E.Width = radius*3;
                E.Height = radius*3;
                E.Margin = new Thickness(P.x - radius * 1.5, 0, 0, P.y - radius * 1.5);
                grid.Children.Add(E);
            }
        }
        class Line : Shape
        {
            double thickness;
            Point start;
            public Line(double Thick, Point S, Point P, Rotation R) : base(P, R)
            {
                thickness = Thick;
                start = S;
            }
            override public string ToString()
            {
                return $"Line thickness = {thickness}, start = {start}, {base.ToString()}";
            }
            override public void Print(System.Windows.Controls.TextBlock Output)
            {
                Output.Text += $"{ToString()}\n";
            }
            override public void Draw(Grid grid, Point offset, Point scale)
            {
                var L = new System.Windows.Shapes.Line();
                Point Start = (start * scale) + offset;
                Point End = (point * scale) + offset;
                L.Stroke = Brushes.Blue;
                L.HorizontalAlignment = HorizontalAlignment.Left;
                L.VerticalAlignment = VerticalAlignment.Bottom;
                L.StrokeThickness = thickness;
                L.X1 = Start.x;
                L.X2 = End.x;
                L.Y1 = -Start.y;
                L.Y2 = -End.y;
                grid.Children.Add(L);
            }
        }
        class Rect : Shape
        {
            double height, width;
            public Rect(double H, double W, Point P, Rotation R) : base(P, R)
            {
                height = H; width = W;
            }
            override public string ToString()
            {
                return $"Rectangle height = {height}, width = {width}, {base.ToString()}";
            }
            override public void Print(System.Windows.Controls.TextBlock Output)
            {
                Output.Text += $"{ToString()}\n";
            }
            override public void Draw(Grid grid, Point offset, Point scale)
            {
                Rectangle R = new Rectangle();
                Point P = point * scale + offset;
                R.Fill = Brushes.DarkSlateBlue;
                R.HorizontalAlignment = HorizontalAlignment.Left;
                R.VerticalAlignment = VerticalAlignment.Bottom;
                R.Height = height;
                R.Width = width;
                R.Margin = new Thickness(P.x, 0, 0, P.y);
                grid.Children.Add(R);
            }
        }
        class Label : Shape
        {
            string content;
            public Label(string C, Point P, Rotation R) : base(P, R)
            {
                content = C;
            }
            override public void Draw(Grid grid, Point offset, Point scale)
            {
                TextBlock TB = new TextBlock();
                Point P = point * scale + offset;
                TB.Text = content;
                TB.HorizontalAlignment = HorizontalAlignment.Left;
                TB.VerticalAlignment = VerticalAlignment.Bottom;
                TB.Foreground = Brushes.Yellow;
                TB.Margin = new Thickness(P.x, 0, 0, P.y);
                grid.Children.Add(TB);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DebugArea.Text = "";
            DebugArea.Text += "==== Test and Draw Polygons ====\n";
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rect(400, 400, new Point(0, 0), new Rotation(5)));
            // Lines;
            shapes.Add(new Line(2, new Point(90, 5), new Point(68, 15), new Rotation(0)));
            shapes.Add(new Line(2, new Point(68, 15), new Point(66, 36), new Rotation(0)));
            shapes.Add(new Line(2, new Point(66, 36), new Point(91, 46), new Rotation(0)));
            shapes.Add(new Line(2, new Point(91, 46), new Point(87, 64), new Rotation(0)));
            shapes.Add(new Line(2, new Point(87, 64), new Point(58, 47), new Rotation(0)));
            shapes.Add(new Line(2, new Point(66, 36), new Point(58, 47), new Rotation(0)));
            shapes.Add(new Line(2, new Point(58, 47), new Point(40, 48), new Rotation(0)));
            shapes.Add(new Line(2, new Point(40, 48), new Point(25, 49), new Rotation(0)));
            shapes.Add(new Line(2, new Point(25, 49), new Point(7, 37), new Rotation(0)));
            // Stars:
            shapes.Add(new Circle(3.0, new Point(90, 5), new Rotation(0)));  // Psi
            shapes.Add(new Circle(2.0, new Point(68, 15), new Rotation(0))); // 
            shapes.Add(new Circle(5.0, new Point(66, 36), new Rotation(0))); // Phecda
            shapes.Add(new Circle(4.5, new Point(91, 46), new Rotation(0))); // Merak
            shapes.Add(new Circle(5.5, new Point(87, 64), new Rotation(0))); // Dubhe
            shapes.Add(new Circle(4.0, new Point(58, 47), new Rotation(0))); // Megrez
            shapes.Add(new Circle(5.0, new Point(40, 48), new Rotation(0))); // Alioth
            shapes.Add(new Circle(4.5, new Point(25, 49), new Rotation(0))); // Mizar
            shapes.Add(new Circle(4.5, new Point(7, 37), new Rotation(0)));  // Alkaid
            // Labels:
            shapes.Add(new Label("Dubhe", new Point(82, 66), new Rotation(0)));
            shapes.Add(new Label("Merak", new Point(86, 40), new Rotation(0)));
            shapes.Add(new Label("Phecda", new Point(60, 30), new Rotation(0)));

            Point offset = new Point(10, 10);
            Point scale = new Point(4, 4);
            foreach (Shape s in shapes)
            {
                if (s != null)
                    s.Draw(MainGrid, offset, scale);
            }

            /* -------- tests --------
            DebugArea.Text += "==== Test Point and Rotation ====\n";
            Point P = new Point(2.3, 12.4);
            DebugArea.Text += ($"P = <{P.x}, {P.y}>\n");
            Rotation R = new Rotation(23.4);
            DebugArea.Text += ($"R = [{R.angle}]\n");
            */
        }
        private void AppFastKey(object sender, KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.D)
            {
                switch (DebugArea.Visibility)
                {
                    case Visibility.Visible:
                        DebugArea.Visibility = Visibility.Hidden;
                        break;
                    default:
                        DebugArea.Visibility = Visibility.Visible;
                        break;
                }
            }
        }
    }
}
