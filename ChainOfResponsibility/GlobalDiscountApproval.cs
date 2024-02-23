public class GlobalDiscountApproval : DiscountApproval
{  
    public override bool Handle(Order order, double proposedDiscount)
    {
        if (proposedDiscount < 0.30)
            return true;


        return base.Handle(order, proposedDiscount);
    }
}
