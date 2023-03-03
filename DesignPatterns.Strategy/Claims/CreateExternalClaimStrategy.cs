namespace DesignPatterns.BusinessLogicObjects.Claims;

public class CreateExternalClaimStrategy : IClaimStrategy
{
    public Claim CreateApplication(string systemKey)
    {
        return new Claim
        {
            Token = systemKey,
            StateType = 11,
            ClaimTracker = 19,
            TechnicalSupportLine = 11
        };
    }
}