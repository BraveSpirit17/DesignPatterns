using DesignPatterns.BusinessLogicObjects.Enums;

namespace DesignPatterns.BusinessLogicObjects.Claims;

public class ClaimDto
{
    public string Email { get; set; }
    
    public string Description { get; set; }
    
    public string Subject { get; set; }

    public ClaimTracker ClaimTracker { get; set; }
}