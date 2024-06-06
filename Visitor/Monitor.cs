/// <summary>
/// Concrete element - one of the existing class, which need additional functionality
/// </summary>
public class Monitor : IComputerPart
{
    /// <summary>
    /// Method with double dispatching
    /// </summary>
    /// <param name="computerPartVisitor"></param>
    public void Accept(IComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}
