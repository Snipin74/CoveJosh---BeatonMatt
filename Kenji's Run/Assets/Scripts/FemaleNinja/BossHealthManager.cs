﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthManager : MonoBehaviour {

    public float CurrentHealth;
    public float MaxHealth;


    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    private void Update()
    {
       
        if(CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void applyDamage(int amount)
    {

        CurrentHealth -= amount;
    }
}
