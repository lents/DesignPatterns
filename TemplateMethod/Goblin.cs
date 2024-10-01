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
