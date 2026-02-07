using System.Collections;
using UnityEngine;
using TMPro;

public class Texto : MonoBehaviour
{
    public float intensidadRojo;
    public float intensidadOtro;
    public float velocidad;

    [Range(0f, 1f)]
    public float sombreadoInferior;

    string textoAnterior;

    public bool ex = false;
    public bool sta;

    private TMP_Text textMesh;
    private RectTransform rectTransform;

    Vector3[][] verticesBase;

    void Awake()
    {
        sombreadoInferior = 0.4f;
        textMesh = GetComponent<TMP_Text>();
        rectTransform = textMesh.GetComponent<RectTransform>();
    }

    void OnEnable()
    {
        StopAllCoroutines();
        StartCoroutine(InicioSeguro());
    }

    IEnumerator InicioSeguro()
    {
        while (textMesh.textInfo == null || textMesh.textInfo.characterCount == 0)
        {
            textMesh.ForceMeshUpdate();
            yield return null;
        }

        InicializarVerticesBase();
        StartCoroutine(AnimarTexto());
    }

    void LateUpdate()
    {
        if (textMesh.text != textoAnterior)
        {
            textoAnterior = textMesh.text;
            textMesh.ForceMeshUpdate();
            InicializarVerticesBase();
        }
    }

    void InicializarVerticesBase()
    {
        TMP_TextInfo textInfo = textMesh.textInfo;

        verticesBase = new Vector3[textInfo.meshInfo.Length][];
        for (int i = 0; i < textInfo.meshInfo.Length; i++)
            verticesBase[i] = textInfo.meshInfo[i].vertices.Clone() as Vector3[];
    }

    IEnumerator AnimarTexto()
    {
        if (sta) yield break;

        while (true)
        {
            if (string.IsNullOrEmpty(textMesh.text) || verticesBase == null)
            {
                yield return null;
                continue;
            }

            textMesh.ForceMeshUpdate();
            TMP_TextInfo textInfo = textMesh.textInfo;

            Color32 colorTexto = textMesh.color;
            float intensidadActual =
                (colorTexto.r == 255 && colorTexto.g == 0 && colorTexto.b == 0)
                ? intensidadRojo
                : intensidadOtro;

            Vector3 cursorOffset = Vector3.zero;

            if (ex && !(colorTexto.r == 255 && colorTexto.g == 0 && colorTexto.b == 0))
            {
                RectTransformUtility.ScreenPointToWorldPointInRectangle(
                    rectTransform, Input.mousePosition, null, out Vector3 mousePos);

                Vector3 dir = (rectTransform.position - mousePos).normalized;
                cursorOffset = dir * 30f;
            }

            for (int i = 0; i < textInfo.characterCount; i++)
            {
                if (!textInfo.characterInfo[i].isVisible)
                    continue;

                int materialIndex = textInfo.characterInfo[i].materialReferenceIndex;
                int vertexIndex = textInfo.characterInfo[i].vertexIndex;

                Vector3[] vertices = textInfo.meshInfo[materialIndex].vertices;
                Vector3[] baseVerts = verticesBase[materialIndex];
                Color32[] colors = textInfo.meshInfo[materialIndex].colors32;

                Vector3 offset = new Vector3(
                    Random.Range(-intensidadActual, intensidadActual),
                    Random.Range(-intensidadActual, intensidadActual),
                    0
                ) + cursorOffset;

                // Movimiento glitch
                for (int v = 0; v < 4; v++)
                    vertices[vertexIndex + v] = baseVerts[vertexIndex + v] + offset;

                // Colores dinámicos
                Color32 colorArriba = colorTexto;
                Color32 colorAbajo = new Color32(
                    (byte)(colorArriba.r * sombreadoInferior),
                    (byte)(colorArriba.g * sombreadoInferior),
                    (byte)(colorArriba.b * sombreadoInferior),
                    colorArriba.a
                );

                // Inferior
                colors[vertexIndex + 0] = colorAbajo;
                colors[vertexIndex + 3] = colorAbajo;

                // Superior
                colors[vertexIndex + 1] = colorArriba;
                colors[vertexIndex + 2] = colorArriba;
            }

            for (int i = 0; i < textInfo.meshInfo.Length; i++)
            {
                textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;
                textInfo.meshInfo[i].mesh.colors32 = textInfo.meshInfo[i].colors32;
                textMesh.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
            }

            yield return new WaitForSeconds(velocidad);
        }
    }
}
