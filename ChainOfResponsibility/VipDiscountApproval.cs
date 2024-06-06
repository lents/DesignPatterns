public class VipDiscountApproval : DiscountApproval
{
    private readonly HashSet<string> _vipClients = new()
    {
        "1"
    };
    public override bool Handle(Order order, double proposedDiscount)
    {
        if (_vipClients.Contains(order.ClientCode))
        {
            ApprovalInfo("VipDiscountApproval", true);
            return true;
        }

        ApprovalInfo("VipDiscountApproval", false);
        return base.Handle(order, proposedDiscount);
    }
}
