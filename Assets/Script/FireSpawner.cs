using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpawner : MonoBehaviour
{
    public float fireSpawnRateInSecond;
    // how many fire to spawn per each spawn
    public int fireCountPerSpawn;
    // Start is called before the first frame update
    public Transform firstSpawnTransform;
    public Transform secondSpawnTransform;
    public GameObject fireObj;

    void Start()
    {
        StartCoroutine(StartSpawnFire());

    }

    // Update is called once per frame
    void Update()
    {


    }

    IEnumerator StartSpawnFire()
    {
        while (true)
        {
            for (int i = 0; i < fireCountPerSpawn; i++)
            {
                // get random pos
                float minX = Mathf.Min(firstSpawnTransform.position.x, secondSpawnTransform.position.x);
                float maxX = Mathf.Max(firstSpawnTransform.position.x, secondSpawnTransform.position.x);

                float minY = Mathf.Min(firstSpawnTransform.position.y, secondSpawnTransform.position.y);
                float maxY = Mathf.Max(firstSpawnTransform.position.y, secondSpawnTransform.position.y);
                float randomX = Random.Range(minX, maxX);
                float randomY = Random.Range(minY, maxY);

                Instantiate(fireObj, new Vector3(randomX,randomY), fireObj.transform.rotation);

                // spawn the shit
                Debug.Log(string.Format("Spawning fire {0} at ({1},{2})", i + 1, randomX, randomY));
            }
            yield return new WaitForSeconds(fireSpawnRateInSecond);
        }
    }
}

