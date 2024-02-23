public class StockClearanceDiscountApproval : DiscountApproval
{
    private readonly HashSet<string> _stockClearanceProducts = new()
    {
        "2"
    };
    public override bool Handle(Order order, double proposedDiscount)
    {
        if (_stockClearanceProducts.Contains(order.ProductCode) && proposedDiscount < 0.80)
            return true;


        return base.Handle(order, proposedDiscount);
    }
}
