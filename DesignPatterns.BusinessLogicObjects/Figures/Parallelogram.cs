using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Parallelogram : IShape
{
    public string Name => "Parallelogram";

    public double A { get; set; }

    public double B { get; set; }

    public double H { get; set; }

    public Parallelogram(double a, double b, double h)
    {
        if (a <= 0 || b <= 0 || h <= 0)
            throw new ArgumentException("All sides must be positive");

        (A, B, H) = (a, b, h);
    }

    public double GetArea() => A * H;
    public double GetPerimeter() => 2 * (A + B);
}
