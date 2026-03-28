namespace DesignPatterns.BusinessLogicObjects.Payments;

public class CreditCardPayment : Payment
{
    public string CardNumber { get; set; }

    public override void ProcessPayment()
    {
        Console.WriteLine($"Card processing {CardNumber} amount {Amount}");
    }

    public override string GetDescription()
    {
        return $"{base.GetDescription()} (Card: {CardNumber})";
    }
}