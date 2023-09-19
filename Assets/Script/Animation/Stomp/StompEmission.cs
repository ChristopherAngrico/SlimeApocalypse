using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompEmission : MonoBehaviour
{
    public ParticleSystem fireParticle;
    public CircleCollider2D circleCollider;
    private ParticleSystem.EmissionModule em;
    private void Start()
    {
        em = fireParticle.emission;
        em.enabled = false;
    }
    private IEnumerator Emission()
    {
        em.enabled = true;
        circleCollider.enabled = true;
        yield return new WaitForSeconds(1f);
        em.enabled = false;
        //After emission disable still have some emission remaining
        StartCoroutine(DisableCollider());
    }

    private IEnumerator DisableCollider()
    {
        yield return new WaitForSeconds(0.3f);
        circleCollider.enabled = false;
    }
}
