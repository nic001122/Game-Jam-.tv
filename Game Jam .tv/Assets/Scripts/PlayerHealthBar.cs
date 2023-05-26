using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Player playerHealth;
    public Image fillImage;
    private Slider slider;

    private void Awake() {
        slider = GetComponent<Slider>();
    }

    private void Update() {
        float fillValue = playerHealth.currentHealth / playerHealth.maxHealth;
        slider.value = fillValue;
    }
}
