namespace DesignPatterns.BusinessLogicObjects.Claims;

public interface IClaimStrategy
{
    Claim CreateApplication(string systemKey);
}