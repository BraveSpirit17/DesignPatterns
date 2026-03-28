namespace DesignPatterns.BusinessLogicObjects.Interfaces;

public interface IShape
{
    double GetPerimeter();
    double GetArea();
    string Name { get; }
}
