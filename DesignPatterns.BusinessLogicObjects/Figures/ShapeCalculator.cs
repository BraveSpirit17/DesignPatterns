using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns.BusinessLogicObjects.Figures;

public static class ShapeCalculator
{
    public static string PrintShapeInfo(IShape shape)
    {
        return $"Name: {shape.Name} Perimeter: {shape.GetPerimeter():F2} Area: {shape.GetArea():F2}";
    }
}
