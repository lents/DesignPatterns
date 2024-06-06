/// <summary>
/// Visitor with additional functionality
/// </summary>
public class ComputerPartDiagnosticVisitor : IComputerPartVisitor
{
    public void Visit(Keyboard keyboard)
    {
        Console.WriteLine("Diagnostic Keyboard.");
    }
    public void Visit(Monitor monitor)
    {
        Console.WriteLine("Diagnostic Monitor.");
    }
}
