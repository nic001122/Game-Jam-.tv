using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    // Serialize Field Variables
    
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int currentHealth;

    [SerializeField] public int currentDepressionHealth;
    [SerializeField] public int maxDepressionHealth = 3;

    // bools

    public bool escapeIsOn = false;

    // classes

    public GameManager1 gameManager1;
    public GameOverScreen gameOverScreen;
    public HealthBar healthBar;
    public DepressionBar depressionBar;
    public PauseMenuScreen pauseMenuScreen;
    public GameObject pauseMenu;

    // Start & Update

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentDepressionHealth = maxDepressionHealth;
        depressionBar.SetMaxHealthDepression(maxDepressionHealth);
    }

    void Update()
    {
        // Player Input

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (!escapeIsOn)
            {   
                pauseMenuScreen.pauseGame();
                Time.timeScale = 0f;
                escapeIsOn = true;
            }
            
            else
            {
                pauseMenuScreen.returnToGame();
                escapeIsOn = false;
            }
        }

        // Death

        if (currentHealth <= 0)
        {
            gameOverScreen.Setup();
            //FindObjectOfType<GameManager1>().gameOver();
            Destroy(gameObject);
        }
    }

    // Everything that has to do with damage

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
            TakeSpikeDamage(maxHealth);
       }    
    }

    private void depressionBarTakeDamage()
    {
        currentDepressionHealth -= 1;

        depressionBar.SetHealthDepression(currentDepressionHealth);
    }
}
