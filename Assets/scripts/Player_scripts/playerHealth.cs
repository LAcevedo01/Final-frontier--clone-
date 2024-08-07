using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int health;

    public healthbar healthBar;
    public movement movement;
    public Animator animator; // Reference to the Animator component that controls the player's animations

    private bool isAlive = true;

    void Start()
    {
        health = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (!isAlive)
        {
            movement.enabled = false;
        }
    }

    public void Recievedamage(int damage)
    {
        if (!isAlive)
        {
            return;
        }

        health -= damage;
        healthBar.SetHealth(health);

        if (health <= 0)
        {
            isAlive = false;
            health = 0;

            movement.enabled = false;

            // Stop the walking animation
            animator.SetBool("isWalking", false);
            You_Died_Script.youDiedDisplayed = true;

            // Call any necessary death functionality here, such as playing a death animation or disabling player input
        }
    }
}
