using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] Transform attackPoint;
    [SerializeField] Vector2 size;
    [SerializeField] LayerMask enemyLayer;
    Collider2D enemyWithinAttackRange;
    [SerializeField] float damageReceived = 20f;
    // [SerializeField] KnockbackFeedback knockback;
    public AudioSource src;
    Animator anim;
    float delayTime = 0.42f;
    [SerializeField] private Player player;
    public bool disableAttack;
    private void Awake()
    {
        anim = GetComponentInParent<Animator>();
    }
    private void Update()
    {
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            enemyWithinAttackRange = Physics2D.OverlapCapsule(attackPoint.position, size, 0, 0, enemyLayer);
            if (!disableAttack)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    if (enemyWithinAttackRange != null)
                    {
                        enemyWithinAttackRange.GetComponent<Enemy>().DamageEnemy(damageReceived);
                        anim.SetTrigger("TriggerAttack");
                        StartCoroutine(DelayAllInput());
                    }
                    else
                    {
                        anim.SetTrigger("TriggerAttack");
                        StartCoroutine(DelayAllInput());
                    }
                }
            }
        }

    }

    private IEnumerator DelayAllInput()
    {
        disableAttack = true;
        src.Play();
        yield return new WaitForSeconds(delayTime);
        disableAttack = false;
    }
}
