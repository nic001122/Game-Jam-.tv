using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DepressionBar : MonoBehaviour
{
    public Slider hpSliderDepression;

    public void SetMaxHealthDepression(int health)
    {
        hpSliderDepression.maxValue = health;
        hpSliderDepression.value = health;
    }

    public void SetHealthDepression(int health)
    {
        hpSliderDepression.value = health;
    }
}
