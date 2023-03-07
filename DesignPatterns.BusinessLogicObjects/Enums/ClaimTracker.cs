using System.ComponentModel;

namespace DesignPatterns.BusinessLogicObjects.Enums;

public enum ClaimTracker : byte
{
    [Description("")]
    None = 0,
        
    /// <summary>
    /// Улучшение
    /// </summary>
    [Description("Улучшение")]
    Improvement = 1,
        
    /// <summary>
    /// Инциденты
    /// </summary>
    [Description("Инциденты")]
    Incidents = 2
}