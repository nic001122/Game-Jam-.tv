using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealControl : MonoBehaviour
{
    public Player player;
    public HealthBar healthBar;
    // Start is called before the first frame update
    public void Heal()
    {
        player.currentHealth = player.maxHealth;
        healthBar.SetMaxHealth(player.maxHealth);
        Destroy(gameObject);
    }
}
