using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScreenMusic : MonoBehaviour
{
    [SerializeField]AudioSource _audio;
    void Start()
    {
        _audio.Play();  
    }
}
