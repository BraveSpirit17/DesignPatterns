using BusinessLogicObjects.Claims;

namespace Strategy.Claims;

public interface IClaimStrategy
{
    Claim CreateApplication(string systemKey);
}