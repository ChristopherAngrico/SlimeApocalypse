using System.Collections;
using System.Collections.Generic;
using CodeMonkey.HealthSystemCM;
using Unity.VisualScripting;
using UnityEngine;

public class FireLeftOver : MonoBehaviour
{
    Vector2 originalFireScale;
    public int hitCountToDestroy;
    private int currentHitCount;
    public List<Transform> fireSpreadPos;
    public float fireSpreadRateInSecond;
    public float fireAttackRateInSecond;
    private Animator animator;
    public AnimationClip animationClip;

    private bool attack;
    private HealthSystem healthSystem;
    [SerializeField] private int burnDamage;
    void Start()
    {
        originalFireScale = transform.localScale;
        StartCoroutine(SpreadFire());
        animator = GetComponent<Animator>();
        animator.speed = 0;
    }
    
    private void FixedUpdate()
    {
        // Check fire animation is finish or not
        CheckFireAnimation();
    }
    IEnumerator SpreadFire()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireSpreadRateInSecond);
            // choose random spawn 
            int idx = Random.Range(0, fireSpreadPos.Count);
            Vector2 spawnPos = fireSpreadPos[idx].position;
            // spawn
            Instantiate(gameObject, spawnPos, Quaternion.identity);
        }
    }
    public void DamageFire()
    {
        currentHitCount++;
        float scale = (float)(hitCountToDestroy - currentHitCount) / (float)hitCountToDestroy;
        transform.localScale = scale * originalFireScale;

        if (currentHitCount == hitCountToDestroy)
        {
            Destroy(gameObject);
        }
    }
    public void FireAttack(bool attack, HealthSystem healthSystem)
    {
        if (!gameObject.activeSelf)
        {
            gameObject.SetActive(true);
        }
        StartCoroutine(FireAttackPlayer());
        this.attack = attack;
        this.healthSystem = healthSystem;
    }
    private IEnumerator FireAttackPlayer()
    {
        while (true)
        {
            yield return new WaitForSeconds(fireAttackRateInSecond);
            if (attack == true)
            {
                if (healthSystem != null)
                {
                    Debug.Log("Player damaged by fire");
                    healthSystem.Damage(burnDamage);
                }
            }
        }
    }
    public void PauseAndPlayFireAnimation(float animationState)
    {
        animator.speed = animationState;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            animator.speed = 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Water"))
        {
            animator.speed = 0;
        }
    }

    private void CheckFireAnimation()
    {

        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !animator.IsInTransition(0))
        {
            Destroy(gameObject);
        }
    }
}
