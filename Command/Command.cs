
/// <summary>
/// User presses calculator buttons
/// Undo 4 commands
/// Redo 3 commands
/// Wait for user
/// </summary>
public abstract class Command
{
    public abstract void Execute();
    public abstract void UnExecute();
}
