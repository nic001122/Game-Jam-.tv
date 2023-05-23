using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public ParticleSystem deathEffect;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(20);
        }

        if (currentHealth <= 0)
        {

            deathEffect.Play();
            Destroy(gameObject);
        }
    }

    void TakeDamage (int damage) 
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
