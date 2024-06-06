public class GlobalDiscountApproval : DiscountApproval
{  
    public override bool Handle(Order order, double proposedDiscount)
    {
        if (proposedDiscount < 30)
        {
            ApprovalInfo("GlobalDiscountApproval", true);
            return true;
        }


        ApprovalInfo("GlobalDiscountApproval", false);
        return base.Handle(order, proposedDiscount);
    }
}
