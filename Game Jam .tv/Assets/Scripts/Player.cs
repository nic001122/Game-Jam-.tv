using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    [SerializeField] public float deathDelay = 2f;
    public int maxHealth = 50;
    public int currentHealth;

    public bool escapeIsOn = false;

    public GameManager1 gameManager1;
    public EscapeMenu escape;
    public GameOverScreen gameOverScreen;
    public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        spriteRenderer01 = GetComponent<SpriteRenderer>();
        spriteRenderer02 = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(20);
        }

        if (Input.GetKeyDown(KeyCode.I)) 
        {
            TakeDamage(100);
        }
        
        if (Input.GetKeyDown(KeyCode.Escape) && escapeIsOn == false)
        {
            escape.activeSetup();
            Time.timeScale = 0;
            escapeIsOn = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && escapeIsOn == true)
        {
            escape.backToGame();
            Time.timeScale = 1;
            escapeIsOn = false;
        }

        if (currentHealth <= 0)
        {
            gameOverScreen.Setup();
            //FindObjectOfType<GameManager1>().gameOver();
            Destroy(gameObject, deathDelay);
        }
    }

    public void TakeDamage (int damage) 
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void TakeSpikeDamage(int spikeDamage)
    {
        currentHealth -=spikeDamage;

        healthBar.SetHealth(currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D other) {
       if (other.tag == "Spike") 
       {
            TakeSpikeDamage(100); 
       }
       
    }

    [SerializeField] Color32 deathText = new Color32 (176, 52, 52, 255);
    [SerializeField] Color32 deathBlackScreen = new Color32 (0, 0, 0, 255);

    SpriteRenderer spriteRenderer01;
    SpriteRenderer spriteRenderer02;
}
