using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthBar;

    private Collision collision;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
        }

        if (currentHealth <= 0)
        {
            Debug.Break();
        }

    }

    void TakeDamage(int damage) {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
