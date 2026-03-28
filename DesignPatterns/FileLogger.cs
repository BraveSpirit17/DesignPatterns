using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns;

public class FileLogger : ILogger
{
    public void Log(string message) => File.AppendAllText("log.txt", $"{message} + {Environment.NewLine}");
    public void LogError(Exception ex) => Log($"ERROR: {ex.Message}");
}
