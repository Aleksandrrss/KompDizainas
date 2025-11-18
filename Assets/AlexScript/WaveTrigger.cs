using UnityEngine;
using TMPro;

public class WaveTrigger : MonoBehaviour
{
    public WaveSpawner waveSpawner;
    public TextMeshProUGUI waveText;

    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!triggered && other.CompareTag("Player"))
        {
            triggered = true;
            waveSpawner.StartWaveSequence();
            waveText.text = "Wave 1";
        }
    }
}
