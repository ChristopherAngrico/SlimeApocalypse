using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherFire : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == LayerMask.NameToLayer("Fire")){
            FireLeftOver s_FireLeftOver = other.GetComponent<FireLeftOver>();
            float playFireAnimation = 1;
            s_FireLeftOver.PauseAndPlayFireAnimation(playFireAnimation);
        }

    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.layer == LayerMask.NameToLayer("Fire")){
            FireLeftOver s_FireLeftOver = other.GetComponent<FireLeftOver>();
            float pauseFireAnimation = 0;
            s_FireLeftOver.PauseAndPlayFireAnimation(pauseFireAnimation);
        }
    }
}
