namespace DesignPatterns.Factory.ClaimFactories;

public class ExternalClaimCreator : Creator
{
    public override IClaim FactoryMethod()
    {
        return new ExternalClaim();
    }
}