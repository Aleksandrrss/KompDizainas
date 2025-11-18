using UnityEngine;

public class OnEntry : MonoBehaviour
{
    public GameObject door;
    public GameObject key;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("VEIKIA");
        if (key.activeSelf == false)
        {
            door.SetActive(false);
        }
    }
}
