/// <summary>
/// Interface of the existing classes
/// </summary>
public interface IComputerPart
{
    void Accept(IComputerPartVisitor computerPartVisitor);
}
