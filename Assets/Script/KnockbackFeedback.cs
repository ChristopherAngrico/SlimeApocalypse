using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KnockbackFeedback : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField]private float strength, delay ;
    public void PlayFeedBack(GameObject sender)
    {
        StopAllCoroutines();
        Vector2 direction = (transform.position - sender.transform.position).normalized;
        rb.AddForce(direction * strength, ForceMode2D.Impulse );
        StartCoroutine(Reset());
    }
    IEnumerator Reset()
    {
        yield return new WaitForSeconds(delay);
        rb.velocity = Vector2.zero;
    }
}
