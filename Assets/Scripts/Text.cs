using System.Collections;
using UnityEngine;
using TMPro;

public class Texto : MonoBehaviour
{
    public float intensidadRojo = 2f;
    public float intensidadOtro = 5f;
    public float velocidad = 0.03f;

    public bool ex = false;

    private TMP_Text textMesh;
    private RectTransform rectTransform;

    void Awake()
    {
        textMesh = GetComponent<TMP_Text>();
        rectTransform = textMesh.GetComponent<RectTransform>();
    }

    void OnEnable()
    {
        StartCoroutine(AnimarTexto());
    }

    IEnumerator AnimarTexto()
    {
        while (true)
        {
            textMesh.ForceMeshUpdate();
            TMP_TextInfo textInfo = textMesh.textInfo;

            Color32 color = textMesh.color;
            float intensidadActual = (color.r == 255 && color.g == 0 && color.b == 0) ? intensidadRojo : intensidadOtro;

            Vector3 cursorOffset = Vector3.zero;

            if (ex && !(color.r == 255 && color.g == 0 && color.b == 0))
            {
                Vector3 mousePos;
                RectTransformUtility.ScreenPointToWorldPointInRectangle(rectTransform, Input.mousePosition, null, out mousePos);

                Vector3 dir = (rectTransform.position - mousePos).normalized;

                float distancia = 30f;
                cursorOffset = dir * distancia;
            }

            for (int i = 0; i < textInfo.characterCount; i++)
            {
                if (!textInfo.characterInfo[i].isVisible) continue;

                int materialIndex = textInfo.characterInfo[i].materialReferenceIndex;
                int vertexIndex = textInfo.characterInfo[i].vertexIndex;

                Vector3[] vertices = textInfo.meshInfo[materialIndex].vertices;

                Vector3 offset = new Vector3(
                    Random.Range(-intensidadActual, intensidadActual),
                    Random.Range(-intensidadActual, intensidadActual),
                    0
                );

                offset += cursorOffset;

                vertices[vertexIndex + 0] += offset;
                vertices[vertexIndex + 1] += offset;
                vertices[vertexIndex + 2] += offset;
                vertices[vertexIndex + 3] += offset;
            }

            for (int i = 0; i < textInfo.meshInfo.Length; i++)
            {
                textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;
                textMesh.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
            }

            yield return new WaitForSeconds(velocidad);
        }
    }
}
