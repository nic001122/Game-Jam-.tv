using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScreen : MonoBehaviour
{
    public GameObject pauseScreen;

    public bool isPaused = false;
    public void pauseGame()
    {
        pauseScreen.SetActive(true);
        isPaused = true;
    }

    public void returnToGame()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
        isPaused = false;
    }
}
