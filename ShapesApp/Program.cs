using ShapesApp.Comparers;
using ShapesApp.Models;
using System.Drawing;

List<Shape> shapes = new()
{
    new Circle(5) { Color = Color.AliceBlue },
    new ShapesApp.Models.Rectangle(4, 6) { Color = Color.Beige },
    new Triangle(3, 4, 5) { Color = Color.CadetBlue },
    new Square(4) { Color = Color.Gainsboro },
    new Circle(2) { Color = Color.Wheat },
    new Ellipse(10, 2) { Color = Color.LightYellow },
    new Circle(3) { Color = Color.AliceBlue },
    new Square(5) { Color = Color.AliceBlue }
};

shapes.ForEach(Console.WriteLine);

shapes.Sort();

Console.WriteLine("\n=== Sorted by color ===");
shapes.ForEach(Console.WriteLine);

shapes.Sort(new ShapeAreaComparer());
shapes.Sort(new ShapePerimeterComparer());
shapes.Sort(new ShapeColorComparer());

Console.ReadKey();