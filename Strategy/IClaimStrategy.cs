namespace Strategy;

public interface IClaimStrategy
{
    Claim CreateApplication(string systemKey);
}