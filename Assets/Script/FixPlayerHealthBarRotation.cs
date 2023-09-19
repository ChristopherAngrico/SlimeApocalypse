using System.Collections;
using System.Collections.Generic;
using System.Security;
using Unity.Mathematics;
using UnityEngine;

public class FixPlayerHealthBarRotation : MonoBehaviour
{
    [SerializeField] private GameObject g_Player;
    private void Update()
    {
        Quaternion getPlayerRotation = g_Player.transform.rotation;
        if (getPlayerRotation.y == 180)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
    }
}
