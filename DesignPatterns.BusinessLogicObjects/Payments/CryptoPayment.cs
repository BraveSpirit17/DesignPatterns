namespace DesignPatterns.BusinessLogicObjects.Payments;

public class CryptoPayment : Payment
{
    public string WalletAddress { get; set; }

    public override void ProcessPayment()
    {
        Console.WriteLine($"Send {Amount} in cryptocurrency to a wallet {WalletAddress}");
    }
}
