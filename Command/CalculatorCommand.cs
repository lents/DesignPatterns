/// <summary>
/// The 'ConcreteCommand' class
/// </summary>
public class CalculatorCommand : Command
{
    char @operator;
    int operand;
    Calculator calculator;
    // Constructor
    public CalculatorCommand(Calculator calculator,
        char @operator, int operand)
    {
        this.calculator = calculator;
        this.@operator = @operator;
        this.operand = operand;
    }
    // Gets operator
    public char Operator
    {
        set { @operator = value; }
    }
    // Get operand
    public int Operand
    {
        set { operand = value; }
    }
    // Execute new command
    public override void Execute()
    {
        calculator.Operation(@operator, operand);
    }
    // Unexecute last command
    public override void UnExecute()
    {
        calculator.Operation(Undo(@operator), operand);
    }
    // Returns opposite operator for given operator
    private char Undo(char @operator)
    {
        switch (@operator)
        {
            case '+': return '-';
            case '-': return '+';
            case '*': return '/';
            case '/': return '*';
            default:
                throw new
         ArgumentException("@operator");
        }
    }
}
