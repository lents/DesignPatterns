public abstract class Enemy
{
    /// <summary>
    /// Шаблонный  метод
    /// </summary>
    public void PerformAttack()
    {
        ApproachPlayer();
        DoAttackPlayer();
        SaySomething();
        RunAway();
    }
    /// <summary>
    /// Операция1, которая уже имеет реализацию,
    /// общая для всех подклассов
    /// </summary>
    private void ApproachPlayer()
    {
        Console.WriteLine("Approaching the player");
    }
    /// <summary>
    /// Операция , которая должна быть переопределена в подклассе
    /// Do - префикс говорящий о том что операция должна быть переопределена в классе потомке
    /// </summary>
    protected abstract void DoAttackPlayer();
    /// <summary>
    /// Хук, который может так и оставаться пустой заглушкой, 
    /// а может расширить алгоритм дополнительной функциональностью
    /// </summary>
    protected virtual void SaySomething()
    { }
    /// <summary>
    /// Операция2, которая уже имеет реализацию,
    /// общая для всех подклассов
    /// </summary>
    private void RunAway()
    {
        Console.WriteLine("Running away");
    }
}

public class Goblin : Enemy
{
    protected override void DoAttackPlayer()
    {
        Console.WriteLine("Attacking in melee");
    }

    protected override void SaySomething()
    {
        Console.WriteLine("DIE human!");
    }
}

public class Archer : Enemy
{
    protected override void DoAttackPlayer()
    {
        Console.WriteLine("Attacking from distance");
    }
}