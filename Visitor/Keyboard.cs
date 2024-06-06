/// <summary>
/// Concrete element - one of the existing class, which need additional functionality
/// </summary>
public class Keyboard : IComputerPart
{
    public void Accept(IComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}
