using System.Drawing;

namespace DesignPatterns.BusinessLogicObjects.Figures;

public abstract class Shape : IComparable<Shape>
{
    public abstract string Name { get; }

    public Color Color { get; set; }

    public int CompareTo(Shape? other)
    {
        if (other is null) return 1;

        return Color.ToString().CompareTo(other.Color.ToString()) switch
        {
            0 => GetArea().CompareTo(other.GetArea()),
            var colorResult => colorResult
        };
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name}: Area = {GetArea():F2}, Perimeter = {GetPerimeter():F2}";
    }
}
