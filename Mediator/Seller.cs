/// <summary>
/// Concrete seller
/// </summary>
public class Seller : ISeller
{
    private IEcommerceMediator mediator;

    public Seller(IEcommerceMediator mediator)
    {
        this.mediator = mediator;
        mediator.RegisterSeller(this);
    }

    public void AddProduct(Product product)
    {
        // Add the product to the seller's inventory and notify the inventory manager
    }

    public void ReceiveLowStockNotification(string productId, int remainingStock)
    {
        // Handle low stock situation and update inventory
    }
}