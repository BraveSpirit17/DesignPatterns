using DesignPatterns.BusinessLogicObjects.Interfaces;

namespace DesignPatterns;

public class OrderService(ILogger logger)
{
    private readonly ILogger _logger = logger;

    public void CreateOrder()
    {
        _logger.Log("Order created");
    }
}
