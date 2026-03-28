using DesignPatterns.BusinessLogicObjects.Comparers;
using DesignPatterns.BusinessLogicObjects.Figures;
using DesignPatterns.BusinessLogicObjects.Payments;
using DesignPatterns.Factory;
using System.Drawing;

new Client().Main();

Console.WriteLine();

Payment[] payments = [
    new CreditCardPayment { Amount = 100, CardNumber = "1234-5678" },
    new CryptoPayment { Amount = 0.5m, WalletAddress = "0xABC123" }
    ];

foreach (var payment in payments)
{
    payment.ProcessPayment();
    Console.WriteLine(payment.GetDescription());
    Console.WriteLine("---");
}

Console.WriteLine();

List<Shape> shapes = new()
{
    new Circle(5) { Color = Color.AliceBlue },
    new DesignPatterns.BusinessLogicObjects.Figures.Rectangle(4, 6) { Color = Color.Beige },
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