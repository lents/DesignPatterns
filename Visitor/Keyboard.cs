
// Element

// ConcreteElement
public class Keyboard : IComputerPart
{
    public void Accept(IComputerPartVisitor computerPartVisitor)
    {
        computerPartVisitor.Visit(this);
    }
}
