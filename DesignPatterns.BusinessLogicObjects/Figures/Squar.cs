using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Squar : IShape
{
    private int _a;

    public string Name => "Squar";

    public int A
    {
        get => _a;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The A cannot be less than zero");
            }
            _a = value;
        }
    }

    public Squar(int a)
    {
        A = a;
    }

    public double GetArea() => Math.Pow(A, 2);
    public double GetPerimeter() => 4 * A;
}
