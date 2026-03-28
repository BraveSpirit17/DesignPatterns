using DesignPatterns.BusinessLogicObjects.Figures;

namespace DesignPatterns.BusinessLogicObjects.Comparers;

public class ShapeAreaComparer : IComparer<Shape>
{
    public int Compare(Shape? x, Shape? y)
    {
        if (x is null || y is null) return 0;
        return x.GetArea().CompareTo(y.GetArea());
    }
}
