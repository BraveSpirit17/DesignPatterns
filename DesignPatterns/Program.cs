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

Console.ReadKey();