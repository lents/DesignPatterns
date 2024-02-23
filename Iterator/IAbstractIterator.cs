// Create iterator
// Skip every other item
// Wait for user

/// <summary>
/// The 'Aggregate' interface
/// </summary>
/// <summary>
/// The 'ConcreteAggregate' class
/// </summary>
/// <summary>
/// The 'Iterator' interface
/// </summary>
public interface IAbstractIterator
{
    Item First();
    Item Next();
    bool IsDone { get; }
    Item CurrentItem { get; }
}
