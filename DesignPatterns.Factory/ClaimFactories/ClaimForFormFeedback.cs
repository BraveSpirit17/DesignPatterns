namespace DesignPatterns.Factory.ClaimFactories;

public class ClaimForFormFeedback : IClaim
{
    public string Operation()
    {
        return "ClaimForFormFeedback";
    }
}