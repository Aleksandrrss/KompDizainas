using UnityEngine;

public class IzengusIjungtiTekstoLangeli : MonoBehaviour
{
    public GameObject tekstoLangelis;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(" IzengusIjungtiTekstoLangeli VEIKIA");
        tekstoLangelis.SetActive(true);

    }
}