using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject currentGameobject;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("VEIKIA");
        currentGameobject.SetActive(false);
    }
}
