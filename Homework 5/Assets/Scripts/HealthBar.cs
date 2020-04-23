using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fillIn;

    private void Start()
    {
        slider.value = 100;
        fillIn.color = gradient.Evaluate(1f);
    }

    public void setHealth(int health) {
        slider.value = health;
        fillIn.color = gradient.Evaluate(health * 1f / 100);
    }
}
