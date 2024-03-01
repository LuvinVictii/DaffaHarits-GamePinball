using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class BlinkingText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public float blinkInterval = 0.5f; // Interval between blinks in seconds

    private void Start()
    {
        // Start the blinking coroutine
        StartCoroutine(BlinkRoutine());
    }

    private IEnumerator BlinkRoutine()
    {
        while (true)
        {
            // Toggle the visibility of the text object
            text.enabled = !text.enabled;

            // Wait for the blink interval
            yield return new WaitForSeconds(blinkInterval);
        }
    }
}
