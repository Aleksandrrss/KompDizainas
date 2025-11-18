using System.Collections;
using UnityEngine;
using TMPro;

public class TypingEffect : MonoBehaviour
{
    public TextMeshProUGUI textUI;
    [TextArea] public string fullText;
    public float typingSpeed = 0.04f;

    void OnEnable()
    {
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        textUI.text = "";
        foreach (char c in fullText)
        {
            textUI.text += c;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}
