using UnityEngine;

public class CloseDoorOnWave : MonoBehaviour
{
    public GameObject doorToClose;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Bangos zona pasiekta – durys užsidaro.");
            doorToClose.SetActive(true); 
        }
    }
}
