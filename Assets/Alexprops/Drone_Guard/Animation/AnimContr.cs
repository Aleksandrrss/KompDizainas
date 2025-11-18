using UnityEngine;

public class AnimContr : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = 2f; // 2x greičiau nei įprasta
        anim.Play("WakeUp");
    }

}
