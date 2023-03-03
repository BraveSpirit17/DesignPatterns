using BusinessLogicObjects.Claims;

namespace Strategy.Claims;

public class CreateClaimForFormFeedbackStrategy : IClaimStrategy
{
    public Claim CreateApplication(string systemKey)
    {
        return new Claim
        {
            Token = systemKey,
            StateType = 17,
            ClaimTracker = 2,
            TechnicalSupportLine = 11
        };
    }
}