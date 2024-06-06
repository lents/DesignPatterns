/// <summary>
/// Concrete buyer
/// </summary>
public class Buyer : IBuyer
{
    private IEcommerceMediator mediator;

    public Buyer(IEcommerceMediator mediator)
    {
        this.mediator = mediator;
        mediator.RegisterBuyer(this);
    }

    public void PlaceOrder(Order order)
    {
        mediator.ProcessOrder(order);
    }

    public void ReceiveOrderStatus(string orderId, string status)
    {
        // Update buyer's order status and notify the buyer
    }
}
