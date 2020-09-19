using System;
public class HealthSystem
{
    public int health { get; set; }

    public int healthMax = 100;

    // Start is called before the first frame update
    void Start()
    {
        setHealth(100);
        // Debug.Log("Health: " + getHealth());
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            // Debug.Log("Blue Knight is dead!");
        }
    }

    public void setHealth(int health)
    {
        this.health = health;
    }

    public int getHealth()
    {
        return this.health;
    }

    // public event Action OnHealthZero;

    public void Damage(int damageAmount)
    {
        health -= damageAmount;

        if (health > 0) { return; }

        if (health < 0)
        {
            health = 0;
            // Debug.Log("Player Health: " + health);
            // OnHealthZero?.Invoke();
        }
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax)
        {
            health = healthMax;
        }
    }
}
