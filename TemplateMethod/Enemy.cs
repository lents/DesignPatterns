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
