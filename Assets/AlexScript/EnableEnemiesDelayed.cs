using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEnemiesDelayed : MonoBehaviour
{
    [Header("Enemies to enable after delay")]
    public List<GameObject> enemiesToEnable = new List<GameObject>();

    [Header("Delay in seconds")]
    public float delay = 2f;

    private void Start()
    {
        StartCoroutine(EnableAfterDelay());
    }

    private IEnumerator EnableAfterDelay()
    {
        yield return new WaitForSeconds(delay);

        foreach (var enemy in enemiesToEnable)
        {
            if (enemy != null)
            {
                enemy.SetActive(true);
            }
        }
    }
}
