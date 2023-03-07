namespace DesignPatterns.Factory.ClaimFactories;

public class ExternalClaim : IClaim
{
    public string Operation()
    {
        return "ExternalClaim";
    }
}