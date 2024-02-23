public class DiscountApproval
{
    private DiscountApproval? _nextHandler;

    public DiscountApproval SetNext(DiscountApproval handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual bool Handle(Order order, double proposedDiscount)
    {
        Console.WriteLine($" Order with client code {order.ClientCode} and  {order.ProductCode} got discount {proposedDiscount}");
        return _nextHandler?.Handle(order, proposedDiscount) ?? false;
    }
}
