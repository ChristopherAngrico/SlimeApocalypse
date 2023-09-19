using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WaveSystem : MonoBehaviour
{
    private float timeCounter;
    private int time;
    private float delayTimeSpawn;
    public static event EventHandler<OnWaveSystemEventArgs> OnWaveSystem;
    public class OnWaveSystemEventArgs
    {
        public float delaySpawningTime;
    }
    private void FixedUpdate()
    {
        timeCounter += Time.deltaTime;
        time = Mathf.FloorToInt(timeCounter);
        Wave();
    }
    private void Wave()
    {
        //First Wave
        if (time == 0)
        {
            delayTimeSpawn = 8f;
        }
        if(time == 60)
        {
            delayTimeSpawn = 5f;
        }
        if(time == 120)
        {
            delayTimeSpawn = 2f;
        }
        OnWaveSystem?.Invoke(this, new OnWaveSystemEventArgs
        {
            delaySpawningTime = delayTimeSpawn
        });
    }
}
