using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Rectangle : IShape
{
    public string Name => "Rectangle";

    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Dimensions must be positive");

        (Width, Height) = (width, height);
    }

    public double GetArea() => Width * Height;
    public double GetPerimeter() => 2 * (Width + Height);
}
