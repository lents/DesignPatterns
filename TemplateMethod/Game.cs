public abstract class Enemy
{
    public void PerformAttack()
    {
        ApproachPlayer();
        AttackPlayer();
        SaySomething();
        RunAway();
    }

    private void ApproachPlayer()
    {
        Console.WriteLine("Approaching the player");
    }

    protected abstract void AttackPlayer();

    protected virtual void SaySomething()
    { }

    private void RunAway()
    {
        Console.WriteLine("Running away");
    }
}

public class Goblin : Enemy
{
    protected override void AttackPlayer()
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
    protected override void AttackPlayer()
    {
        Console.WriteLine("Attacking from distance");
    }
}