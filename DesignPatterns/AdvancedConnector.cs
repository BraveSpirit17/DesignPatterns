namespace DesignPatterns;

public class AdvancedConnector : BaseConnector
{
    public override async Task ConnectToServer(string hostName, int port)
    {
        Console.WriteLine("Advanced connect to server async");
    }

    //public int ConnectToServer(string hostName, int port)
    //{
    //    Console.WriteLine("Advanced connect to server");
    //    return 0;
    //}
}
