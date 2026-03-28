using DesignPatterns.BusinessLogicObjects.Figures;

namespace DesignPatterns.BusinessLogicObjects.Comparers;

public class ShapePerimeterComparer : IComparer<Shape>
{
    public int Compare(Shape? x, Shape? y)
    {
        if (x is null || y is null) return 0;
        return x.GetPerimeter().CompareTo(y.GetPerimeter());
    }
}
