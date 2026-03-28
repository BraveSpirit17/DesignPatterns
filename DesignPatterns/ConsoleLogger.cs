using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns;

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"[LOG]: {message}");
    public void LogError(Exception ex) => Console.WriteLine($"[ERROR]: {ex.Message}", ConsoleColor.Red);
}
