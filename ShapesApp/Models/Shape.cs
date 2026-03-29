using System.Drawing;

namespace ShapesApp.Models;

public abstract class Shape : IComparable<Shape>, ICloneable
{
    public abstract string Name { get; }

    public Color Color { get; set; }

    public List<string> Tags { get; set; } = new();

    public virtual object Clone()
    {
        var clone = (Shape)MemberwiseClone();
        clone.Tags = [.. Tags];
        return clone;
    }

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

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(this, obj)) return true;

        if (obj is not Shape other) return false;

        return Color == other.Color &&
               Math.Abs(GetArea() - other.GetArea()) < 0.0001;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Color, Math.Round(GetArea(), 4));
    }

    public override string ToString()
    {
        return $"{Name}: Area = {GetArea():F2}, Perimeter = {GetPerimeter():F2}";
    }
}
