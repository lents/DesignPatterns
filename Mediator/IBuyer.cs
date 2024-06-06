/// <summary>
/// Byer Interface
/// </summary>
public interface IBuyer
{
    void PlaceOrder(Order order);
    void ReceiveOrderStatus(string orderId, string status);
}
