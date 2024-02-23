// Wait for user


public interface ISeller
{
    void AddProduct(Product product);
    void ReceiveLowStockNotification(string productId, int remainingStock);
}
