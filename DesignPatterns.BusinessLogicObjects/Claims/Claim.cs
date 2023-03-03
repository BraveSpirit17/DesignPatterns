namespace BusinessLogicObjects.Claims;

public class Claim
{
    // public string Email { get; set; }
    // public string Phone { get; set; }
    // public string Person { get; set; }
    // public string Description { get; set; }
    // public string Post { get; set; }
    // public string Subject { get; set; }
    // public string Url { get; set; }
    // public string RegistryNumber { get; set; }
    // public string OrganizationName { get; set; }
    // public string Inn { get; set; }
    // public string Kpp { get; set; }

    #region Common fields

    public string Token { get; set; }
    public int StateType { get; set; }
    public int ClaimTracker { get; set; }
    public int TechnicalSupportLine { get; set; }

    #endregion

    public override string ToString()
    {
        return $"Token: {Token}. StateType: {StateType}. ClaimTracker: {ClaimTracker}. TechnicalSupportLine: {TechnicalSupportLine}.";
    }
}