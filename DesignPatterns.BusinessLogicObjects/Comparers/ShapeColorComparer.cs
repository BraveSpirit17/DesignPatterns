using DesignPatterns.BusinessLogicObjects.Figures;

namespace DesignPatterns.BusinessLogicObjects.Comparers;

public class ShapeColorComparer : IComparer<Shape>
{
    public int Compare(Shape? x, Shape? y)
    {
        if (x is null || y is null) return 0;
        return string.Compare(x.Color.Name, y.Color.Name, StringComparison.Ordinal);
    }
}
