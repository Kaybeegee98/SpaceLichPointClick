using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Typewriter : MonoBehaviour
{
    [SerializeField] private float typewriterSpeed = 14f;

    public void Run(string textToType, Text textLabel) {
        StartCoroutine(TypeText(textToType, textLabel));
    }

    private IEnumerator TypeText(string textToType, Text textLabel) {
        yield return new WaitForSeconds(2);

        float t = 0;
        int charIndex = 0;

        while (charIndex < textToType.Length) {
            t += Time.deltaTime * typewriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length);

            textLabel.text = textToType.Substring(0, charIndex);

            yield return null;
        }

        textLabel.text = textToType;
    }
}
