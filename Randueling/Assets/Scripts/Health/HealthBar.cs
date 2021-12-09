using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image Fill;

    private void Start()
    {
        if(transform.parent.parent.tag == "PlayerTwo")
        {
            GetComponent<RectTransform>().anchoredPosition += new Vector2(1345.0f, 0);
        }
    }

    public void SetMaxHealth(int health) 
    {
        slider.maxValue = health;
        slider.value = health;

        Fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health) 
    {
        slider.value = health;

        Fill.color = gradient.Evaluate(slider.normalizedValue);

    }

}
