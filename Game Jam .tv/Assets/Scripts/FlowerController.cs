using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlowerController : MonoBehaviour
{
    public bool pickedUpFlower;

    public void PickUpFlower()
    {
        if (!pickedUpFlower)
        {
            pickedUpFlower = true;
            SceneManager.LoadScene(2);
        }
    }
}
