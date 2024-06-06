/// <summary>
/// Seller Interface
/// </summary>
public interface ISeller
{
    void AddProduct(Product product);
    void ReceiveLowStockNotification(string productId, int remainingStock);
}
