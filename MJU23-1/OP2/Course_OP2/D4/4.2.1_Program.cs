using System.Collections;
namespace ovn_4_2_1
{
    // Simple business object.
    public class Rectangle
    {
        double width, height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double Area() => width * height;
        public override string ToString() => $"[rect W={width} H={height}]";
    }
    public class ShapeList : IEnumerable
    {
        private Rectangle[] shapeList;
        public ShapeList(Rectangle[] shapes)
        {
            shapeList = new Rectangle[shapes.Length];
            for (int i = 0; i < shapes.Length; i++)
            {
                shapeList[i] = shapes[i];
            }
        }
        public ShapeListEnum GetEnumerator()
            => new ShapeListEnum(shapeList);
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
    public class ShapeListEnum : IEnumerator
    {
        public Rectangle[] shapeList;
        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;
        public ShapeListEnum(Rectangle[] shapes)
            => shapeList = shapes;
        public bool MoveNext()
        {
            position++;
            return position < shapeList.Length;
        }
        public void Reset()
            => position = -1;
        object IEnumerator.Current { get => Current; }
        public Rectangle Current
        {
            get
            {
                try
                {
                    return shapeList[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            Rectangle[] shapeArray = new Rectangle[3] {
                new Rectangle(10, 30),
                new Rectangle(2, 3),
                new Rectangle(7, 4),
            };
            ShapeList shapeList = new ShapeList(shapeArray);
            foreach (Rectangle r in shapeList)
                Console.WriteLine(r);
        }
    }
}
