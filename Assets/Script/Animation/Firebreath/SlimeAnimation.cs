
using UnityEngine;

namespace Firebreath
{
    public class SlimeAnimation : MonoBehaviour
    {
        private SlimeFireBreath s_SlimeFireBreath;
        private Animator anim;
        enum State
        {
            isRunning,
            triggerAttack,
            Die
        }
        private void Start()
        {
            s_SlimeFireBreath = GetComponentInParent<SlimeFireBreath>();
            anim = GetComponent<Animator>();
        }
        private void Update()
        {
            Run();
            Attack();
        }
        private void Run()
        {
            //If slime is not onAttack state means slime move
            if (!s_SlimeFireBreath.enemyAttacking)
            {
                anim.SetBool(State.isRunning.ToString(), true);
            }
            else
            {
                anim.SetBool(State.isRunning.ToString(), false);
            }
        }

        private void Attack()
        {
            if (s_SlimeFireBreath.attackState)
            {
                anim.SetBool(State.triggerAttack.ToString(), true);
            }
            else
            {
                anim.SetBool(State.triggerAttack.ToString(), false);
            }
        }
    }
}
