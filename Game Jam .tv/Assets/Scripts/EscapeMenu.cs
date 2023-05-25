using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    public void Setup() 
    {
        gameObject.SetActive(true);
    }

    public void backToGame()
    {
        gameObject.SetActive(false);
    }
}
