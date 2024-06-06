/// <summary>
/// Visitor interface
/// </summary>
public interface IComputerPartVisitor
{
    void Visit(Keyboard keyboard);
    void Visit(Monitor monitor);
}
