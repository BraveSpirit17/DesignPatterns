namespace DesignPatterns;

public class BaseConnector
{
    public virtual async Task ConnectToServer(string hostName, int port)
    {
        Console.WriteLine("Base connect to server async");
    }
}
