namespace DesignPatterns.BusinessLogicObjects.Interfaces;

public interface ILogger
{
    void Log(string message);
    void LogError(Exception ex);
}
