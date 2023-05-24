using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false;

    public void gameOver()
    {   
        if (gameHasEnded == false)
        {   
            gameHasEnded = true;
            Debug.Log("Game Over");
        }

    }
}
