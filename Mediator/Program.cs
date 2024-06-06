var commerceMediator = new EcommerceMediator();
var buyer = new Buyer(commerceMediator);
var seller = new Seller(commerceMediator);
commerceMediator.RegisterSeller(seller);
commerceMediator.RegisterBuyer(buyer);

commerceMediator.NotifySellerLowStock("1", 2);
commerceMediator.ProcessOrder(new Order());
commerceMediator.NotifyBuyerOrderStatus("1", "Создан");
// Wait for user
Console.ReadKey();

/// <summary>
/// Mediator Interface
/// </summary>
public interface IEcommerceMediator
{
    void NotifyBuyerOrderStatus(string orderId, string status);
    void NotifySellerLowStock(string productId, int remainingStock);
    void ProcessOrder(Order order);
    void RegisterSeller(Seller seller);
    void RegisterBuyer(Buyer buyer);
}
