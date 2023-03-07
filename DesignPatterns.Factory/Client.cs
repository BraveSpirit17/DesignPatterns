using DesignPatterns.Factory.ClaimFactories;

namespace DesignPatterns.Factory;

public class Client
{
    public void Main()
    {
        Console.WriteLine("ClaimForCallCreator.");
        LineBreak();
        ClientCode(new ClaimForCallCreator());
            
        LineBreak();

        Console.WriteLine("ClaimForFormFeedbackCreator.");
        LineBreak();
        ClientCode(new ClaimForFormFeedbackCreator());
    }

    #region Private methods

    private void ClientCode(Creator creator)
    {
        Console.WriteLine($"Creator - {creator.SomeOperation()}");
    }

    private void LineBreak()
    {
        Console.WriteLine("\n");
    }

    #endregion
}