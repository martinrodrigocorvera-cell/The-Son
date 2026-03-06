using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Water : MonoBehaviour
{
    public bool intering;
    public bool playst;
    public bool xbox;
    public string idioma;
    public TMP_Text textox;
    public TMP_Text textojx;
    public TMP_Text textokx;
    public TMP_Text textocx;
    public TMP_Text textorx;
    public Player play;
    public Data dt;
    public GameObject sp;
    public GameObject item;
    public Material outlineMaterial;
    public bool int2;
    public GameObject rn;
    private List<GameObject> outlineObjects = new List<GameObject>();
private Dictionary<MeshRenderer, Material[]> originalMaterials = new Dictionary<MeshRenderer, Material[]>();
GameObject outlineRoot;

    void Update()
    {
        playst = play.playst;
        xbox = play.xbox;
        idioma = dt.idioma;

        if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && !rn.activeInHierarchy)
        {
            item.SetActive(true);
            textox.text = "";
            textojx.text = "";
            textokx.text = "";
            textocx.text = "";
            textorx.text = "";
            sp.SetActive(false);
        }

    if (intering)
    {
        ApplyOutline();
    }
    else
    {
        RemoveOutline();
    }
}

void ApplyOutline()
{
    if (outlineRoot != null) return;

    MeshRenderer[] renderers = sp.GetComponentsInChildren<MeshRenderer>(true);

    if (renderers.Length == 0) return;

    Bounds combinedBounds = renderers[0].bounds;

    for (int i = 1; i < renderers.Length; i++)
    {
        combinedBounds.Encapsulate(renderers[i].bounds);
    }

    Vector3 modelCenter = combinedBounds.center;

    outlineRoot = new GameObject("OutlineRoot");
    outlineRoot.transform.SetParent(sp.transform);

    outlineRoot.transform.position = modelCenter;
    outlineRoot.transform.rotation = sp.transform.rotation;
    outlineRoot.transform.localScale = Vector3.one * 1.05f;

    int brightLayer = LayerMask.NameToLayer("bright");
    outlineRoot.layer = brightLayer;

    MeshFilter[] meshFilters = sp.GetComponentsInChildren<MeshFilter>(true);

    foreach (MeshFilter mf in meshFilters)
    {
        string nameLower = mf.gameObject.name.ToLower();

        if (nameLower.Contains("cube"))
            continue;

        GameObject newChild = new GameObject("Outline_" + mf.name);
        newChild.transform.SetParent(outlineRoot.transform);

        newChild.transform.position = mf.transform.position;
        newChild.transform.rotation = mf.transform.rotation;
        newChild.transform.localScale = mf.transform.lossyScale;

        newChild.layer = brightLayer;

        MeshFilter newMF = newChild.AddComponent<MeshFilter>();
        newMF.mesh = mf.mesh;

        MeshRenderer newMR = newChild.AddComponent<MeshRenderer>();
        Material newMat = new Material(outlineMaterial);
        newMat.SetColor("_MainColor", Color.black);

        newMR.material = newMat;
        newMR.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        newMR.receiveShadows = false;

        mf.gameObject.SetActive(false);
    }
}

    void RemoveOutline()
    {
        if (outlineRoot != null)
            Destroy(outlineRoot);

        outlineRoot = null;
    }

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player") && !rn.activeInHierarchy)
    {
        intering = true;
if(playst == true)
{
    if(idioma == "ingles")
    {
        textox.text = "Take Holy Water <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "español")
    {
        textox.text = "Coger Agua Bendita <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "frances")
    {
        textox.text = "Prendre de l’eau benite <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "aleman")
    {
        textox.text = "Heiliges Wasser nehmen <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "italiano")
    {
        textox.text = "Prendere acqua santa <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "portugues")
    {
        textox.text = "Pegar agua benta <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "japones")
    {
        textox.text = "";
        textojx.text = "聖水を取る <sprite name=\"pixel_art_small\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "성수를 받다 <sprite name=\"pixel_art_small\">";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "取圣水 <sprite name=\"pixel_art_small\">";
        textorx.text = "";
    }
    if(idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Взять святую воду <sprite name=\"pixel_art_small\">";
    }
}

if(xbox == true)
{
   if(idioma == "ingles")
    {
        textox.text = "Take Holy Water <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "español")
    {
        textox.text = "Coger Agua Bendita <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "frances")
    {
        textox.text = "Prendre de l’eau benite <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "aleman")
    {
        textox.text = "Heiliges Wasser nehmen <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "italiano")
    {
        textox.text = "Prendere acqua santa <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "portugues")
    {
        textox.text = "Pegar agua benta <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "japones")
    {
        textox.text = "";
        textojx.text = "聖水を取る <sprite name=\"A\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "성수를 받다 <sprite name=\"A\">";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "取圣水 <sprite name=\"A\">";
        textorx.text = "";
    }
    if(idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Взять святую воду <sprite name=\"A\">";
    }
}

if(xbox == false && playst == false)
{
   if(idioma == "ingles")
    {
        textox.text = "Take Holy Water <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "español")
    {
        textox.text = "Coger Agua Bendita <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "frances")
    {
        textox.text = "Prendre de l’eau benite <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "aleman")
    {
        textox.text = "Heiliges Wasser nehmen <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "italiano")
    {
        textox.text = "Prendere acqua santa <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "portugues")
    {
        textox.text = "Pegar agua benta <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "japones")
    {
        textox.text = "";
        textojx.text = "聖水を取る <sprite name=\"E\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "성수를 받다 <sprite name=\"E\">";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "取圣水 <sprite name=\"E\">";
        textorx.text = "";
    }
    if(idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Взять святую воду <sprite name=\"E\">";
    }
}
    }
}
void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
    textox.text = "";
    textojx.text = "";
    textokx.text = "";
    textocx.text = "";
    textorx.text = "";
        intering = false;
            ClearOutlineObjects();
            int2 = false;
    }
}
void ClearOutlineObjects()
{
    foreach (Transform t in sp.GetComponentsInChildren<Transform>(true))
    {
        t.gameObject.SetActive(true);
    }
    foreach (GameObject obj in outlineObjects)
    {
        if (obj != null)
            Destroy(obj);
    }

    outlineObjects.Clear();
}
}
