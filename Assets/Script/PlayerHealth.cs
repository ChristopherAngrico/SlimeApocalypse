using System;
using System.Collections;
using System.Collections.Generic;
using CodeMonkey.HealthSystemCM;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private HealthSystem healthSystem;
    public delegate void OnPlayerDie();
    public static event OnPlayerDie OnDying;

    void Start()
    {
        healthSystem = GetComponent<HealthSystemComponent>().GetHealthSystem();
    }
    private void Update()
    {
        PlayerDie();
    }
    private void PlayerDie()
    {
        if (healthSystem.GetHealth() == 0)
        {
            OnDying?.Invoke();
        }
    }
    public void AttackPlayer(int damage)
    {
        healthSystem.Damage(damage);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Fire"))
        {
            other.GetComponent<FireLeftOver>().FireAttack(true, healthSystem);
        }
        if (other.gameObject.CompareTag("Stomp"))
        {
            other.GetComponent<StompFireDamage>().StartBurning(true, healthSystem);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Fire"))
        {
            other.GetComponent<FireLeftOver>().FireAttack(false, null);
        }
        if (other.gameObject.CompareTag("Stomp"))
        {
            other.GetComponent<StompFireDamage>().StartBurning(false, healthSystem);
        }
    }

}
