using ShapesApp.Models;

namespace ShapesApp.Comparers;

public class ShapePerimeterComparer : IComparer<Shape>
{
    public int Compare(Shape? x, Shape? y)
    {
        if (ReferenceEquals(x, y)) return 0;
        if (x is null) return -1;
        if (y is null) return 1;

        return x.GetPerimeter().CompareTo(y.GetPerimeter());
    }
}
