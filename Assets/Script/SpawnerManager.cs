using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : MonoBehaviour
{
    [SerializeField] private List<Transform> g_spawnPosition;
    [SerializeField] private GameObject[] g_slime;
    private GameObject g_obj;
    private int valueToFindPosition, valueToSpawnSlime;
    private float delaySpawningTime;
    private WaveSystem waveSystem;
    private void OnEnable()
    {
        delaySpawningTime = 3f;
        StartCoroutine(Spawn());
        WaveSystem.OnWaveSystem += WaveSystem_OnWaveSystem;
    }
    private void OnDisable()
    {
        //Unsubscribe
        WaveSystem.OnWaveSystem -= WaveSystem_OnWaveSystem;
    }
    private void WaveSystem_OnWaveSystem(object sender, WaveSystem.OnWaveSystemEventArgs e)
    {
        delaySpawningTime = e.delaySpawningTime;
    }
    private IEnumerator Spawn()
    {
        while (true)
        {
            //find random spawn position
            valueToFindPosition = Random.Range(0, g_spawnPosition.Count - 1);
            //find random spawn slime type
            valueToSpawnSlime = Random.Range(0, g_slime.Length - 1);

            g_obj = Instantiate(g_slime[valueToSpawnSlime]) as GameObject;
            g_obj.transform.position = g_spawnPosition[valueToFindPosition].position;
            yield return new WaitForSeconds(delaySpawningTime);
        }
    }
}
