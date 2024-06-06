public class StockClearanceDiscountApproval : DiscountApproval
{
    private readonly HashSet<string> _stockClearanceProducts = new()
    {
        "2"
    };
    public override bool Handle(Order order, double proposedDiscount)
    {
        if (_stockClearanceProducts.Contains(order.ProductCode) && proposedDiscount < 80)
        {
            ApprovalInfo("StockClearanceDiscountApproval", true);
            return true;
        }


        ApprovalInfo("StockClearanceDiscountApproval", false);
        return base.Handle(order, proposedDiscount);
    }
}
