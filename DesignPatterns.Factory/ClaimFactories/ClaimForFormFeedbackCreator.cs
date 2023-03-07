namespace DesignPatterns.Factory.ClaimFactories;

public class ClaimForFormFeedbackCreator : Creator
{
    public override IClaim FactoryMethod()
    {
        return new ClaimForFormFeedback();
    }
}