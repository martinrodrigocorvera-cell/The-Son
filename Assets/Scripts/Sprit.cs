using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Sprit : MonoBehaviour
{
    public float intensidadTemblor = 2f; // cuánto se mueve
    public float velocidad = 0.02f;       // rapidez del temblor
    public float parpadeoMin = 2f;      // alfa mínimo
    public float parpadeoMax = 0f;        // alfa máximo

    private RectTransform rectTransform;
    private Image image;
    private Vector3 posicionOriginal;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
        posicionOriginal = rectTransform.anchoredPosition;
    }

    void OnEnable()
    {
        StartCoroutine(Terror());
    }

    IEnumerator Terror()
    {
        while (true)
        {
            // TEMBLOR
            Vector3 offset = new Vector3(
                Random.Range(-intensidadTemblor, intensidadTemblor),
                Random.Range(-intensidadTemblor, intensidadTemblor),
                0
            );
            rectTransform.anchoredPosition = posicionOriginal + offset;

            // PARPADEO
            if (image != null)
            {
                Color c = image.color;
                c.a = Random.Range(parpadeoMin, parpadeoMax);
                image.color = c;
            }

            yield return new WaitForSeconds(velocidad);
        }
    }
}
