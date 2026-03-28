namespace DesignPatterns.BusinessLogicObjects.Figures;

public class Square : Shape
{
    private int _a;

    public override string Name => "Squar";

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

    public Square(int a)
    {
        A = a;
    }

    public override double GetArea() => Math.Pow(A, 2);
    public override double GetPerimeter() => 4 * A;
}
