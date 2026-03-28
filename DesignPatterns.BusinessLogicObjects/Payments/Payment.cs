namespace DesignPatterns.BusinessLogicObjects.Payments;

public abstract class Payment
{
    public decimal Amount { get; set; }

    public virtual string GetDescription()
    {
        return $"Payment of {Amount:C}";
    }

    public abstract void ProcessPayment();
}
