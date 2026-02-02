using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class GlitchImageUI : MonoBehaviour
{
    [Header("Timing")]
    public float minGlitchInterval = 1f;
    public float maxGlitchInterval = 3f;
    public float minGlitchDuration = 0.05f;
    public float maxGlitchDuration = 0.2f;

    [Header("Glitch Settings")]
    public float jitterAmount = 5f; // pixeles de movimiento
    public float rotationAmount = 5f; // grados
    public Color[] glitchColors;

    private Image image;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Color originalColor;

    void Awake()
    {
        image = GetComponent<Image>();
        originalPosition = image.rectTransform.anchoredPosition;
        originalRotation = image.rectTransform.localRotation;
        originalColor = image.color;

        if (glitchColors == null || glitchColors.Length == 0)
            glitchColors = new Color[] { Color.red, Color.cyan, Color.magenta, Color.white };
    }

    void OnEnable()
    {
        StartCoroutine(GlitchRoutine());
    }

    IEnumerator GlitchRoutine()
    {
        while (true)
        {
            float waitTime = Random.Range(minGlitchInterval, maxGlitchInterval);
            yield return new WaitForSeconds(waitTime);

            float glitchTime = Random.Range(minGlitchDuration, maxGlitchDuration);
            float elapsed = 0f;

            Color glitchColor = glitchColors[Random.Range(0, glitchColors.Length)];

            while (elapsed < glitchTime)
            {
                // TEMBLOR / JITTER
                Vector3 offset = new Vector3(
                    Random.Range(-jitterAmount, jitterAmount),
                    Random.Range(-jitterAmount, jitterAmount),
                    0
                );
                image.rectTransform.anchoredPosition = originalPosition + offset;

                // ROTACIÓN SUTIL
                float angle = Random.Range(-rotationAmount, rotationAmount);
                image.rectTransform.localRotation = Quaternion.Euler(0, 0, angle);

                // CAMBIO DE COLOR
                image.color = Color.Lerp(originalColor, glitchColor, Random.Range(0.5f, 1f));

                elapsed += Time.deltaTime;
                yield return null;
            }

            // RESET
            image.rectTransform.anchoredPosition = originalPosition;
            image.rectTransform.localRotation = originalRotation;
            image.color = originalColor;
        }
    }
}
