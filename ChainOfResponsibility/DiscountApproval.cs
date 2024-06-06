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

    public void ApprovalInfo(string inf, bool res)
    {
        if (res)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"{inf} had been passed");
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"{inf} had not been passed");
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
