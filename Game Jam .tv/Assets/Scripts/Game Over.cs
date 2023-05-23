using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] Color32 deathText = new Color32 (176, 52, 52, 255);
    [SerializeField] Color32 deathBlackScreen = new Color32 (0, 0, 0, 255);

    SpriteRenderer spriteRenderer01;
    SpriteRenderer spriteRenderer02;

    private void Start() {
        spriteRenderer01 = GetComponent<SpriteRenderer>();
        spriteRenderer02 = GetComponent<SpriteRenderer>();
    }

    bool isDead = false;
}
