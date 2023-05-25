using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeMenu : MonoBehaviour
{
    public void activeSetup() 
    {
        gameObject.SetActive(true);
    }

    public void backToGame()
    {
        gameObject.SetActive(false);
    }
}
