﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    [SerializeField]
    private float health;
    [SerializeField]
    private float maxHealth;
    [SerializeField]
    private Image healthBarImage;

    private void Start()
    {
        health = maxHealth;
    }

    public void Update()
    {
        healthBarImage.fillAmount = (1 / maxHealth) * health;
    }

    [ContextMenu("Mas")]
    public void AddHealth(float amount)
    {
        health += amount;
        if(health > maxHealth)
        {
            health = maxHealth;
        }

        else if (health < 0)
        {
            health = 0;
        }

        //UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        healthBarImage.fillAmount = (1 / maxHealth) * health;
    }

    
}
