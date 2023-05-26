using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{

    // classes

    public Player playerHealth;
    public Image fillImage;
    private Slider slider;

    // Awake (used awake for performance reasons) & Update

    private void Awake() {
        slider = GetComponent<Slider>();
    }

    private void Update() {
        float fillValue = playerHealth.currentHealth / playerHealth.maxHealth;
        slider.value = fillValue;
    }
}
