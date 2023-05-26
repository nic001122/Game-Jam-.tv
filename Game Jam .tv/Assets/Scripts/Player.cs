using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player: MonoBehaviour
{
    [SerializeField] public float deathDelay = 2f;
    [SerializeField] public int maxHealth = 100;
    [SerializeField] public int currentHealth;

    public bool escapeIsOn = false;

    public GameManager1 gameManager1;
    public EscapeMenu escape;
    public GameOverScreen gameOverScreen;
    public HealthBar healthBar;
    public GameObject pauseMenu;

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
