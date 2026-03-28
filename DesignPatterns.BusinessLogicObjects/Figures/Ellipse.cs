namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Ellipse : Shape
{
    public override string Name => "Ellipse";

    public double A { get; set; }

    public double B { get; set; }

    public Ellipse(double a, double b)
    {
        if (a <= 0 || b <= 0)
            throw new ArgumentException("All sides must be positive");

        (A, B) = (a, b);
    }

    public override double GetArea() => Math.PI * A * B;
    public override double GetPerimeter() => Math.PI * (3 * (A + B) - Math.Sqrt((3 * A + B) * (A + 3 * B)));
}
