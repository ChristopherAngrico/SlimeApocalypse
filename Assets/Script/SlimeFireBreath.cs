using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeFireBreath : Enemy
{
    public ParticleSystem fireBreathParticle;
    public float fireBreathRotateOffset;
    public bool attackState;
    [SerializeField] AudioSource src;


    ParticleSystem.EmissionModule em;
    // Start is called before the first frame update
    private new void Start()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
        base.Start();
        em = fireBreathParticle.emission;
        em.enabled = false;
    }
    private new void Update()
    {
        base.Update();
        targetPlayer = GameObject.FindGameObjectWithTag("Player");
    }
    override public void Attack()
    {
        StartCoroutine(_Attack());
    }
    IEnumerator _Attack()
    {
        attackState = true;
        em.enabled = true;
        //Find the distance between slime and target
        float distanceToPlayer = Vector2.Distance(targetPlayer.transform.position, transform.position);

        if (distanceToTree < distanceToPlayer)
        {
            AttackLogic(targetTree);
            // attack the tree
            TreeOfLife treeOfLife = targetTree.GetComponent<TreeOfLife>();
            treeOfLife.AttackTree(damage);
        }
        else
        {
            AttackLogic(targetPlayer);
            PlayerHealth playerHealth = targetPlayer.GetComponent<PlayerHealth>();
            playerHealth.AttackPlayer(damageToPlayer);
        }
        yield return new WaitForSeconds(2);
        attackState = false;
        em.enabled = false;
        src.Stop();
    }

    private void AttackLogic(GameObject target)
    {
        // rotate breath to the tree / player
        Vector2 difference = target.transform.position - transform.position;

        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        fireBreathParticle.transform.rotation = Quaternion.Euler(0, 0, angle + fireBreathRotateOffset);
    }
}
