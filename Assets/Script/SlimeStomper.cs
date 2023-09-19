using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SlimeStomper : Enemy
{
    public ParticleSystem fireParticle;
    

    private Animator animator;
    enum State
    {
        isRunning,
        triggerAttack
    }
    private new void Start()
    {
        base.Start();
        animator = GetComponentInChildren<Animator>();
    }
    private void FixedUpdate()
    {
        Run();
    }
    private void Run()
    {
        if (distanceToTree <= attackDistance)
        {
            animator.SetBool(State.isRunning.ToString(), false);
            
        }
        else
        {
            animator.SetBool(State.isRunning.ToString(), true);
            
        }
    }
    override public void Attack()
    {
        StartCoroutine(_Attack());
    }
    IEnumerator _Attack()
    {
        animator.SetBool(State.triggerAttack.ToString(), true);
        yield return new WaitForSeconds(1.2f);
        animator.SetBool(State.triggerAttack.ToString(), false);
    }
}