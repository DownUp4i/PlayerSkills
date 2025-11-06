public class Health 
{
    public int CurrentHealth { get; private set; } = 20;
    public int MaxHealth { get; private set; } = 100;

    public void ChangeHealth (int health)
    {
        CurrentHealth = health;

        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }
}
