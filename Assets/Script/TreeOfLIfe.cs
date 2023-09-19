using CodeMonkey.HealthSystemCM;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeOfLife : MonoBehaviour
{
    // Start is called before the first frame update

    private HealthSystem healthSystem;
    void Start()
    {

        healthSystem = GetComponent<HealthSystemComponent>().GetHealthSystem();
        healthSystem.OnDead += TreeOnDead;
    }

    private void TreeOnDead(object sender, System.EventArgs e)
    {
        Debug.Log("Tree of life is dead");
    }
    public void AttackTree(int damage)
    {
        Debug.Log("Tree of life attacked with damage: " + damage);
        healthSystem.Damage(damage);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Stomp"))
        {
            collision.GetComponent<StompFireDamage>().StartBurning(true, healthSystem);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Stomp"))
        {
            collision.GetComponent<StompFireDamage>().StartBurning(false, healthSystem);
        }
    }
}
