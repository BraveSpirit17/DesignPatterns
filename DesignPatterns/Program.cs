using DesignPatterns.BusinessLogicObjects.Figures;
using DesignPatterns.BusinessLogicObjects.Interfaces;
using DesignPatterns.BusinessLogicObjects.Payments;
using DesignPatterns.Factory;

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

List<IShape> shapes = new()
{
    new Circle(3.6),
    new Rectangle(5, 3),
    new Triangle(3, 4, 6),
    new Squar(7)
};

foreach (var shape in shapes)
{
    Console.WriteLine(ShapeCalculator.PrintShapeInfo(shape));
    Console.WriteLine("---");
}

Console.ReadKey();