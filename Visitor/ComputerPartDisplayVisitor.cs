/// <summary>
/// Visitor with additional functionality
/// </summary>
public class ComputerPartDisplayVisitor : IComputerPartVisitor
{
    public void Visit(Keyboard keyboard)
    {
        Console.WriteLine("Displaying Keyboard.");
    }
    public void Visit(Monitor monitor)
    {
        Console.WriteLine("Displaying Monitor.");
    }
}
