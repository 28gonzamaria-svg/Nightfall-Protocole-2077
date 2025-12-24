using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public Killstreak killstreak;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
            Die();
    }

    void Die()
    {
        killstreak.AddKill();
        Destroy(gameObject);
    }
}