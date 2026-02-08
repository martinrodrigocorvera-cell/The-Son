using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Sprit : MonoBehaviour
{
    public float intensidadTemblor = 2f;
    public float velocidad = 0.02f;  
    public float parpadeoMin = 2f;   
    public float parpadeoMax = 0f;     

    private RectTransform rectTransform;
    private Image image;
    private Vector3 posicionOriginal;
    public bool flc;

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
            Vector3 offset = new Vector3(
                Random.Range(-intensidadTemblor, intensidadTemblor),
                Random.Range(-intensidadTemblor, intensidadTemblor),
                0
            );
            rectTransform.anchoredPosition = posicionOriginal + offset;

            if(flc == false)
            {
            if (image != null)
            {
                Color c = image.color;
                c.a = Random.Range(parpadeoMin, parpadeoMax);
                image.color = c;
            }
            }

            yield return new WaitForSeconds(velocidad);
        }
    }
}
