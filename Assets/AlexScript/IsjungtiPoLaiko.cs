using UnityEngine;
using System.Collections;

public class IsjungtiPoLaiko : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(IsjungtiPoSekundziu(10f));
    }

    IEnumerator IsjungtiPoSekundziu(float sekundes)
    {
        yield return new WaitForSeconds(sekundes);
        gameObject.SetActive(false);
    }
}
