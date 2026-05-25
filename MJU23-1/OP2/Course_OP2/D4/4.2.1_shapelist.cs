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
        => new ShapeListEnum(people);
    IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
}