namespace ShapesApp.Models;

public class Rectangle : Shape
{
    public override string Name => "Rectangle";

    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0 || height <= 0)
            throw new ArgumentException("Dimensions must be positive");

        (Width, Height) = (width, height);
    }

    public override double GetArea() => Width * Height;
    public override double GetPerimeter() => 2 * (Width + Height);
}
