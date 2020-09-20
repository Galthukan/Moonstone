public class PlayerHealth
{
    public int Health { get; private set; } = 100;
    private int HealthMax { get; set; } = 100;

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;

        if (Health < 0)
        {
            Health = 0;
        }
    }

    public void Heal(int healAmount)
    {
        Health += healAmount;

        if (Health > HealthMax)
        {
            Health = HealthMax;
        }
    }
}