/// <summary>
/// Concrete commerce mediator
/// </summary>
public class EcommerceMediator : IEcommerceMediator
{
    private List<Buyer> buyers = new List<Buyer>();
    private List<Seller> sellers = new List<Seller>();

    // Constructor to initialize dependencies

    public void NotifyBuyerOrderStatus(string orderId, string status)
    {
        Console.WriteLine("SendNotificationToBuyer(orderId, status)");
    }

    public void NotifySellerLowStock(string productId, int remainingStock)
    {
        Console.WriteLine("notificationSystem.SendLowStockNotificationToSeller(productId, remainingStock)");
    }

    public void ProcessOrder(Order order)
    {
        Console.WriteLine("orderManager.ProcessOrder(order)");
    }

    public void RegisterSeller(Seller seller)
    {
        sellers.Add(seller);
    }

    public void RegisterBuyer(Buyer buyer)
    {
        buyers.Add(buyer);
    }
}
