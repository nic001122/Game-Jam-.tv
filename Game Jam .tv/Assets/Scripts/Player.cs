using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    // Serialize Field Variables

    [SerializeField] public float deathDelay = 2f;
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int currentHealth;

    // bools

    public bool escapeIsOn = false;

    // classes

    public GameManager1 gameManager1;
    public GameOverScreen gameOverScreen;
    public HealthBar healthBar;
    public GameObject pauseMenu;

    // Start & Update

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(2);
        }

        if (Input.GetKeyDown(KeyCode.I)) 
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (escapeIsOn)
            {
                BackToGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (currentHealth <= 0)
        {
            gameOverScreen.Setup();
            //FindObjectOfType<GameManager1>().gameOver();
            Destroy(gameObject, deathDelay);
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
            TakeSpikeDamage(100); 
       }
       
    }

    // Pause Menu

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        escapeIsOn = true;
        Time.timeScale = 0f;
    }

    public void BackToGame()
    {
        pauseMenu.SetActive(false);
        escapeIsOn = false;
        Time.timeScale = 1f;
    }   
}
