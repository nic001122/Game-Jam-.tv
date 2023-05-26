using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    //bools

    bool gameHasEnded = false;
    
    // Game Over

    public void gameOver()
    {   
        if (gameHasEnded == false)
        {   
            gameHasEnded = true;
            Debug.Log("Game Over");
        }

    }
}
