using CodeMonkey.HealthSystemCM;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StompFireDamage : MonoBehaviour
{
    private bool isBurning;
    HealthSystem healthSystem;
    private void Start()
    {
        StartCoroutine(Damage());
    }
    public void StartBurning(bool isBurning, HealthSystem healthSystem)
    {
        this.isBurning = isBurning;
        this.healthSystem = healthSystem;
    }
    private IEnumerator Damage()
    {
        while (true)
        {
            if (isBurning)
            {
                healthSystem.Damage(2);
            }
            yield return new WaitForSeconds(0.1f);
        }


    }

}
