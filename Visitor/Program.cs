var parts = new List<IComputerPart>
{
    new Keyboard(),
    new Monitor()
};
var displayer = new ComputerPartDisplayVisitor();
var diagnostic = new ComputerPartDiagnosticVisitor();

foreach (var part in parts)
{
    part.Accept(displayer);
}
foreach (var part in parts)
{
    part.Accept(diagnostic);
}
Console.ReadLine();
