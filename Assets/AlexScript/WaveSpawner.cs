using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.FPS.Game;

[System.Serializable]
public class Wave
{
    public string WaveName;
    public GameObject[] EnemiesToSpawn;
    public Transform[] SpawnPoints;
}

public class WaveSpawner : MonoBehaviour
{
    public List<Wave> Waves;
    public float timeBetweenWaves = 5f;
    public TextMeshProUGUI waveText;

    private int currentWaveIndex = 0;
    private bool isSpawning = false;

    

    public void StartWaveSequence()
    {
        if (!isSpawning)
        {
            StartCoroutine(BeginWaveSequence());
        }
    }

    IEnumerator BeginWaveSequence()
    {
        isSpawning = true;

        while (currentWaveIndex < Waves.Count)
        {
            
            if (waveText != null)
            {
                waveText.text = $"Wave {currentWaveIndex + 1}";
            }

            Wave wave = Waves[currentWaveIndex];

            
            for (int i = 0; i < wave.EnemiesToSpawn.Length; i++)
            {
                GameObject enemy = Instantiate(wave.EnemiesToSpawn[i], wave.SpawnPoints[i].position, Quaternion.identity);

                
            }

            
            yield return new WaitUntil(() =>
                FindAnyObjectByType<Unity.FPS.AI.EnemyManager>().NumberOfEnemiesRemaining == 0);

            
            yield return new WaitForSeconds(timeBetweenWaves);

            currentWaveIndex++;
        }

        
        if (waveText != null)
        {
            waveText.text = "SIMULIACIJA BAIGTA. Sveikiname!";
        }

        
        Unity.FPS.Game.AllObjectivesCompletedEvent completedEvent = new Unity.FPS.Game.AllObjectivesCompletedEvent();
        Unity.FPS.Game.EventManager.Broadcast(completedEvent);
    }

}
