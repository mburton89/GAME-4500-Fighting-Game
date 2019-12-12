using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public static HealthManager Instance;

    public float p1Health;
    public Image p1HealthBar;

    private void Awake()
    {
        Instance = this;
    }

    public void DecreaseHealth(float amountToDecrease)
    {
        p1Health -= amountToDecrease;
        p1HealthBar.fillAmount = p1Health;
    }
}
