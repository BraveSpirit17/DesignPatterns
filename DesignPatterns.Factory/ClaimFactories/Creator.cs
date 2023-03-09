namespace DesignPatterns.Factory.ClaimFactories;

public abstract class Creator
{
    public abstract IClaim FactoryMethod();

    public string SomeOperation()
    {
        var product = FactoryMethod();

        return product.Operation();
    }
}