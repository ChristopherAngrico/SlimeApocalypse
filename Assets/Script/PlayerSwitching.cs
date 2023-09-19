using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitching : MonoBehaviour
{

    public KeyCode keyToSwitch;

    private bool onCooldown = false;

    public float switchingTime;
    void Update()
    {
        if (Input.GetKeyDown(keyToSwitch) )
        {
                Debug.Log("key E is pressed ");
            if (!onCooldown)
            {
                Debug.Log("Start Switching Player");
                StartCoroutine(SwitchPlayer());
            }
        }
        
    }

    IEnumerator SwitchPlayer()
    {
        //weapon stuff here
        onCooldown = true;

        Debug.Log("Switching Player");
        // get all child and flip the enabled value
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(!child.gameObject.activeSelf);
        }
        yield return new WaitForSeconds(switchingTime);
        onCooldown = false;
    }
}
