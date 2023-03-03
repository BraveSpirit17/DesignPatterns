namespace Strategy;

public class ClaimContext
{
    private IClaimStrategy _strategy;

    public ClaimContext()
    {
    }

    public ClaimContext(IClaimStrategy strategy)
    {
        _strategy = strategy;
    }
    
    public void SetStrategy(IClaimStrategy strategy)
    {
        _strategy = strategy;
    }

    public Claim ExecuteStrategy(string systemKey)
    {
        return _strategy.CreateApplication(systemKey);
    }
}