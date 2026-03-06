using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Invisible : MonoBehaviour
{
    [Header("Control")]
    public bool  active          = true;
    public float transitionSpeed = 2.0f;  // velocidad de fade in/out

    [Header("Distorsion")]
    [Range(0f, 0.03f)] public float distortStrength = 0.008f;
    public float distortSpeed = 1.2f;
    public float distortScale = 4.0f;

    [Header("Aberracion cromatica")]
    [Range(0f, 0.02f)] public float chromaStrength = 0.004f;

    [Header("Apariencia")]
    [Range(0f, 1f)] public float desaturation  = 0.35f;
    public float vignetteStrength = 1.8f;
    public float shimmerSpeed     = 3.0f;
    [Range(0f, 0.2f)] public float shimmerAmt  = 0.06f;

    // ── Privados ──────────────────────────────────────────────────────────────
    private Material effectMat;
    private float    currentIntensity = 0f;

    private static readonly int PropDistortStr  = Shader.PropertyToID("_DistortStrength");
    private static readonly int PropDistortSpd  = Shader.PropertyToID("_DistortSpeed");
    private static readonly int PropDistortScl  = Shader.PropertyToID("_DistortScale");
    private static readonly int PropChroma      = Shader.PropertyToID("_ChromaStrength");
    private static readonly int PropDesat       = Shader.PropertyToID("_Desaturation");
    private static readonly int PropVignette    = Shader.PropertyToID("_VignetteStr");
    private static readonly int PropShimSpd     = Shader.PropertyToID("_ShimmerSpeed");
    private static readonly int PropShimAmt     = Shader.PropertyToID("_ShimmerAmt");
    private static readonly int PropIntensity   = Shader.PropertyToID("_Intensity");

    // ─────────────────────────────────────────────────────────────────────────

    void Awake()
    {
        Shader shader = Shader.Find("Hidden/Invisible");
        if (shader != null)
            effectMat = new Material(shader) { hideFlags = HideFlags.HideAndDontSave };
    }

    void OnDestroy()
    {
        if (effectMat != null) DestroyImmediate(effectMat);
    }

    void Update()
    {
        // Fade suave al activar/desactivar
        float target = active ? 1f : 0f;
        currentIntensity = Mathf.MoveTowards(currentIntensity, target,
                                              Time.deltaTime * transitionSpeed);
    }

    public void SetActive(bool state)
    {
        active = state;
    }

    void OnRenderImage(RenderTexture src, RenderTexture dst)
    {
        if (effectMat == null || currentIntensity <= 0.001f)
        {
            Graphics.Blit(src, dst);
            return;
        }

        effectMat.SetFloat(PropDistortStr, distortStrength);
        effectMat.SetFloat(PropDistortSpd, distortSpeed);
        effectMat.SetFloat(PropDistortScl, distortScale);
        effectMat.SetFloat(PropChroma,     chromaStrength);
        effectMat.SetFloat(PropDesat,      desaturation);
        effectMat.SetFloat(PropVignette,   vignetteStrength);
        effectMat.SetFloat(PropShimSpd,    shimmerSpeed);
        effectMat.SetFloat(PropShimAmt,    shimmerAmt);
        effectMat.SetFloat(PropIntensity,  currentIntensity);

        Graphics.Blit(src, dst, effectMat);
    }
}
