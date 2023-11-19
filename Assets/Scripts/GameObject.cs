using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextFadeAnimation : MonoBehaviour
{
    public float fadeDuration = 2f; // Duration of the fade animation in seconds

    private Text textComponent;
    private Color originalColor;

    void Start()
    {
        textComponent = GetComponent<Text>();
        originalColor = textComponent.color;

        // Start the fade animation
        StartCoroutine(FadeText());
    }

    IEnumerator FadeText()
    {
        float timer = 0f;

        while (timer < fadeDuration)
        {
            timer += Time.deltaTime;

            // Calculate the alpha value based on the time elapsed
            float alpha = Mathf.Lerp(1f, 0f, timer / fadeDuration);

            // Apply the new color with adjusted alpha
            textComponent.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);

            yield return null; // Wait for the next frame
        }

        // Make sure the final color is fully transparent
        textComponent.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
    }
}
