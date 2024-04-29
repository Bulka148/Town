using UnityEngine;

public class PHeathSystem : MonoBehaviour
{
    private float maxHealth = 20;
    private float currentHealth;

    public void TakeDamage(float amount = 1)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            Death();
        }
    }

    public void ChangeHealthAmount(float amount)
    {
        maxHealth = amount;
    }

    private void Death()
    {
        Debug.Log("You Dead!!!");
    }
}