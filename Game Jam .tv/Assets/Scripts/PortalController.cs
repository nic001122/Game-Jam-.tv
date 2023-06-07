using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalController : MonoBehaviour
{
    public bool playerWentThrough;
    public int Scenes;

    public DepressionBar depressionBar;
    public Player player;

    public void GoThroughPortal()
    {
        if (!playerWentThrough)
        {
            playerWentThrough = true;
            SceneManager.LoadScene(2);
        }
    }
}
