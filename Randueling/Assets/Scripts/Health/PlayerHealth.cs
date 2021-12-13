using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthBar;

    private Collision collision;

    private GameObject playerManager;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            TakeDamage(1);
        }

        if (currentHealth <= 0)
        {
            if(gameObject.tag == "PlayerOne")
            {
                //player two wins
                playerManager.GetComponent<PlayerManager>().WhoWins(2);
            }
            else
            {
                //player one wins
                playerManager.GetComponent<PlayerManager>().WhoWins(1);
            }
            SceneManager.LoadScene(4);
        }

    }

    void TakeDamage(int damage) {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
