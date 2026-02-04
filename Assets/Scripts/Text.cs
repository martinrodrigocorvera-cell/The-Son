using System.Collections;
using UnityEngine;
using TMPro;

public class Texto : MonoBehaviour
{
    public float intensidadRojo;
    public float intensidadOtro;
    public float velocidad;
    string textoAnterior;

    public bool ex = false;

    private TMP_Text textMesh;
    private RectTransform rectTransform;

    Vector3[][] verticesBase;

    void Awake()
    {
        textMesh = GetComponent<TMP_Text>();
        rectTransform = textMesh.GetComponent<RectTransform>();
    }

void OnEnable()
{
    // Para evitar corutinas duplicadas
    StopAllCoroutines();
    StartCoroutine(InicioSeguro());
}

IEnumerator InicioSeguro()
{
    // Espera hasta que el TMP tenga al menos 1 carácter visible
    while (textMesh.textInfo == null || textMesh.textInfo.characterCount == 0)
    {
        textMesh.ForceMeshUpdate();
        yield return null; // espera 1 frame
    }

    // Inicializa verticesBase correctamente
    TMP_TextInfo textInfo = textMesh.textInfo;
    verticesBase = new Vector3[textInfo.meshInfo.Length][];
    for (int i = 0; i < textInfo.meshInfo.Length; i++)
        verticesBase[i] = textInfo.meshInfo[i].vertices.Clone() as Vector3[];

    // Ahora arranca la animación
    StartCoroutine(AnimarTexto());
}

    void LateUpdate()
    {
        if (textMesh.text != textoAnterior)
        {
            textoAnterior = textMesh.text;
            textMesh.ForceMeshUpdate();

            TMP_TextInfo textInfo = textMesh.textInfo;
            verticesBase = new Vector3[textInfo.meshInfo.Length][];
            for (int i = 0; i < textInfo.meshInfo.Length; i++)
                verticesBase[i] = textInfo.meshInfo[i].vertices.Clone() as Vector3[];
        }
    }

IEnumerator AnimarTexto()
{
    while (true)
    {
        yield return null;

        if (string.IsNullOrEmpty(textMesh.text) || verticesBase == null)
        {
            yield return null;
            continue;
        }

        textMesh.ForceMeshUpdate();
        TMP_TextInfo textInfo = textMesh.textInfo;

            if (verticesBase == null)
            {
                verticesBase = new Vector3[textInfo.meshInfo.Length][];
                for (int i = 0; i < textInfo.meshInfo.Length; i++)
                    verticesBase[i] = textInfo.meshInfo[i].vertices.Clone() as Vector3[];
            }

            Color32 color = textMesh.color;
            float intensidadActual =
                (color.r == 255 && color.g == 0 && color.b == 0)
                ? intensidadRojo
                : intensidadOtro;

            Vector3 cursorOffset = Vector3.zero;

            if (ex && !(color.r == 255 && color.g == 0 && color.b == 0))
            {
                Vector3 mousePos;
                RectTransformUtility.ScreenPointToWorldPointInRectangle(
                    rectTransform, Input.mousePosition, null, out mousePos);

                Vector3 dir = (rectTransform.position - mousePos).normalized;
                cursorOffset = dir * 30f;
            }

for (int i = 0; i < textInfo.characterCount; i++)
{
    if (!textInfo.characterInfo[i].isVisible)
        continue;

    int materialIndex = textInfo.characterInfo[i].materialReferenceIndex;
    int vertexIndex = textInfo.characterInfo[i].vertexIndex;

    if (materialIndex >= verticesBase.Length)
        continue;

    Vector3[] vertices = textInfo.meshInfo[materialIndex].vertices;
    Vector3[] baseVerts = verticesBase[materialIndex];

    if (vertexIndex + 3 >= vertices.Length || vertexIndex + 3 >= baseVerts.Length)
        continue;

    Vector3 offset = new Vector3(
        Random.Range(-intensidadActual, intensidadActual),
        Random.Range(-intensidadActual, intensidadActual),
        0
    );

    offset += cursorOffset;

    vertices[vertexIndex + 0] = baseVerts[vertexIndex + 0] + offset;
    vertices[vertexIndex + 1] = baseVerts[vertexIndex + 1] + offset;
    vertices[vertexIndex + 2] = baseVerts[vertexIndex + 2] + offset;
    vertices[vertexIndex + 3] = baseVerts[vertexIndex + 3] + offset;
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
