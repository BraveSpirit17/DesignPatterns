namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Triangle : Shape
{
    public override string Name => "Triangle";

    public int A {  get; set; }

    public int B { get; set; }

    public int C { get; set; }

    public Triangle(int a, int b, int c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("All sides must be positive");

        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Sides do not form a valid triangle");

        (A, B, C) = (a, b, c);
    }

    public override double GetArea()
    {
        var p = GetPerimeter() / 2;

        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    public override double GetPerimeter() => A + B + C;
}
