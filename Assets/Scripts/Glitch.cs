using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class Glitch : MonoBehaviour
{
    [Header("Timing")]
    public float minGlitchInterval = 1f;
    public float maxGlitchInterval = 3f;
    public float minGlitchDuration = 0.1f;
    public float maxGlitchDuration = 0.25f;

    [Header("Glitch Settings")]
    [Range(0f, 1f)] public float charReplaceChance = 0.35f;
    [Range(0f, 1f)] public float artifactChance = 0.2f;
    public float jitterAmount = 1.5f;

    [Header("Characters")]
    public string glitchChars = "@#$%&*?/";
    public string artifactChars = "█▓▒░▄▀▌▐";

    [Header("Color Settings")]
    public Color baseColor = new Color(1f, 0f, 0.56f);
    public Color[] glitchColors = new Color[] { Color.red, Color.magenta, Color.cyan, Color.white };

    private TMP_Text text;
    private Coroutine glitchCoroutine;

    void Awake()
    {
        text = GetComponent<TMP_Text>();
        if (text == null)
        {
            Debug.LogError("No se encontró TextMeshPro o TextMeshProUGUI en este GameObject.");
            enabled = false;
            return;
        }
        text.color = baseColor;
    }

    void OnEnable()
    {
        if (glitchCoroutine != null)
            StopCoroutine(glitchCoroutine);

        glitchCoroutine = StartCoroutine(GlitchRoutine());
    }

    void OnDisable()
    {
        if (glitchCoroutine != null)
            StopCoroutine(glitchCoroutine);

        glitchCoroutine = null;


        if (text != null)
        {
            text.ForceMeshUpdate();
            text.color = baseColor;
        }
    }

    IEnumerator GlitchRoutine()
    {
        while (true)
        {
            float waitTime = Random.Range(minGlitchInterval, maxGlitchInterval);
            yield return new WaitForSeconds(waitTime);

            float glitchTime = Random.Range(minGlitchDuration, maxGlitchDuration);
            float elapsed = 0f;


            string currentText = text.text;

Color flashColor = glitchColors[Random.Range(0, glitchColors.Length)];
text.color = flashColor;

            while (elapsed < glitchTime)
            {
                ApplyGlitch(currentText);
                elapsed += Time.deltaTime;
                yield return null;
            }


            text.text = currentText;
            text.color = baseColor;
            text.ForceMeshUpdate();
        }
    }

    void ApplyGlitch(string currentText)
    {
        if (string.IsNullOrEmpty(currentText))
            return;

        char[] chars = currentText.ToCharArray();
        StringBuilder newText = new StringBuilder(chars.Length * 2);

        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] == ' ')
            {
                newText.Append(' ');
                continue;
            }

            if (Random.value < artifactChance)
            {
                char artifact = artifactChars[Random.Range(0, artifactChars.Length)];
                newText.Append($"<color=#{RandomColor()}>{artifact}</color>");
                continue;
            }

            if (Random.value < charReplaceChance)
            {
                char glitchChar = glitchChars[Random.Range(0, glitchChars.Length)];
                newText.Append($"<color=#{RandomColor()}>{glitchChar}</color>");
            }
            else
            {
                newText.Append(chars[i]);
            }
        }

        text.text = newText.ToString();
        text.ForceMeshUpdate();

        TMP_TextInfo textInfo = text.textInfo;

        for (int i = 0; i < textInfo.characterCount; i++)
        {
            if (!textInfo.characterInfo[i].isVisible)
                continue;

            int materialIndex = textInfo.characterInfo[i].materialReferenceIndex;
            int vertexIndex = textInfo.characterInfo[i].vertexIndex;

            if (materialIndex >= textInfo.meshInfo.Length)
                continue;

            Vector3[] vertices = textInfo.meshInfo[materialIndex].vertices;

            if (vertexIndex + 3 >= vertices.Length)
                continue;

            Vector3 jitter = new Vector3(
                Random.Range(-jitterAmount, jitterAmount),
                Random.Range(-jitterAmount, jitterAmount),
                0
            );

            vertices[vertexIndex + 0] += jitter;
            vertices[vertexIndex + 1] += jitter;
            vertices[vertexIndex + 2] += jitter;
            vertices[vertexIndex + 3] += jitter;
        }

        for (int i = 0; i < textInfo.meshInfo.Length; i++)
        {
            textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;
            text.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
        }
    }

    string RandomColor()
    {
        Color c = glitchColors[Random.Range(0, glitchColors.Length)];
        return ColorUtility.ToHtmlStringRGB(c);
    }
}