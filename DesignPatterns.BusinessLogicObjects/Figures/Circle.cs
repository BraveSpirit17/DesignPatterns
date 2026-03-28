namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Circle : Shape
{
    private double _radius;

    public override string Name => "Circle";

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

    public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}
