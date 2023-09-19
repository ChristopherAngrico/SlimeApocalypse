using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCalculation
{
    int currentHealth;
    public HealthCalculation(int maxHealth){
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageReceived){
        currentHealth -= damageReceived;
    }

    public int GetCurrenHealth(){
        if(currentHealth <= 0)
            return 0;
        return currentHealth;
    }
}
