namespace DesignPatterns.Factory.ClaimFactories;

public class ClaimForCallCreator : Creator
{
    public override IClaim FactoryMethod()
    {
        return new ClaimForCall();
    }
}