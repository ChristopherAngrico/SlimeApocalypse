using CodeMonkey.HealthSystemCM;
using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [HideInInspector] public GameObject targetTree;
    [HideInInspector] public GameObject targetPlayer;
    public float attackDistance;
    public float attackCooldown;
    public int damage;
    public int damageToPlayer;
    [HideInInspector]public bool enemyAttacking = false;

    public HealthSystem healthSystem;
    public GameObject healthUI;
    private Coroutine lastAttackCoroutine = null;
    [HideInInspector]public float distanceToTree;

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, attackDistance);
    }
    // Start is called before the first frame update
    public void Start()
    {
        targetTree = GameObject.FindWithTag("TreeOfLife");
        targetPlayer = GameObject.FindWithTag("Player");
        // set variables for the AI
        GetComponent<AIPath>().endReachedDistance = attackDistance;
        GetComponent<AIDestinationSetter>().target = targetTree.transform;
        // set health
        healthSystem = GetComponent<HealthSystemComponent>().GetHealthSystem();
        healthSystem.OnDead += _OnEnemyDead;
        if (GetType().Name != "FireLeftOver") healthUI.SetActive(false);

    }

    // Update is called once per frame
    public void Update()
    {
        FlipSlime();
        distanceToTree = Vector2.Distance(targetTree.transform.position, transform.position);
        if (distanceToTree <= attackDistance)
        {

            // only start attack routine once!
            if (!enemyAttacking)
            {
                enemyAttacking = true;
                lastAttackCoroutine = StartCoroutine(attackCoroutine());
            }
        }
        else
        {
            if (lastAttackCoroutine != null)
            {
                StopCoroutine(lastAttackCoroutine);
                enemyAttacking = false;
            }
        }
    }
    private void FlipSlime()
    {
        float findDirection = transform.position.x - targetTree.transform.position.x;
        if (findDirection > 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else{
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    virtual public void Attack()
    {

    }

    public void OnEnemyDeath()
    {

    }
    private void _OnEnemyDead(object sender, System.EventArgs e)
    {
        Debug.Log("Enemy is killed");
        OnEnemyDeath();
        Destroy(gameObject);
    }

    public void DamageEnemy(float damage)
    {
        Debug.Log("Enemy Damaged: " + damage);
        healthSystem.Damage(damage);
        // set active at first damage
        if (GetType().Name != "FireLeftOver") healthUI.SetActive(true);
    }

    private IEnumerator attackCoroutine()
    {
        while (true)
        {
            Attack();
            yield return new WaitForSeconds(attackCooldown);
        }
    }

}
