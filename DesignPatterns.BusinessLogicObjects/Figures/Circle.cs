using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Circle : IShape
{
    private double _radius;

    public string Name => "Circle";

    public double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The radius cannot be less than zero");
            }
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}
