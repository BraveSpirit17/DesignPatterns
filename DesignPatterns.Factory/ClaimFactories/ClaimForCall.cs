namespace DesignPatterns.Factory.ClaimFactories;

public class ClaimForCall : IClaim
{
    public string Operation()
    {
        return "ClaimForCall";
    }
}