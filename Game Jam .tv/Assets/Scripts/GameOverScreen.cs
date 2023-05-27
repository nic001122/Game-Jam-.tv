using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    // Methods
    
    public void Setup() 
    {
        gameObject.SetActive(true);
    }

    public void restartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void mainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
