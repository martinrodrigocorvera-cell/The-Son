using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Rune : MonoBehaviour
{
    public float rn;
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
    public GameObject sp2;
    public GameObject item;
    public Material outlineMaterial;
    public bool int2;
    public GameObject hw;
    public GameObject rn1;
    public GameObject rn2;
    public GameObject rn3;
    public GameObject rn4;
    private List<GameObject> outlineObjects = new List<GameObject>();
private Dictionary<MeshRenderer, Material[]> originalMaterials = new Dictionary<MeshRenderer, Material[]>();
GameObject outlineRoot;

    void Update()
    {
        playst = play.playst;
        xbox = play.xbox;
        idioma = dt.idioma;

        if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && !hw.activeInHierarchy)
        {
            rn1.SetActive(false);
            rn2.SetActive(false);
            rn3.SetActive(false);
            rn4.SetActive(false);
            item.SetActive(true);
            textox.text = "";
            textojx.text = "";
            textokx.text = "";
            textocx.text = "";
            textorx.text = "";
            sp.SetActive(false);
            if(rn == 1)
            {
                rn1.SetActive(true);
            }
            if(rn == 2)
            {
                rn2.SetActive(true);
            }
            if(rn == 3)
            {
                rn3.SetActive(true);
            }
            if(rn == 4)
            {
                rn4.SetActive(true);
            }
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

        if (nameLower.Contains("Quad"))
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
    if (other.CompareTag("Player") && !hw.activeInHierarchy)
    {
        intering = true;
if(playst == true)
{
    if(idioma == "ingles")
    {
        textox.text = "Take Rune <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "español")
    {
        textox.text = "Coger Runa <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "frances")
    {
        textox.text = "Prendre la rune <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "aleman")
    {
        textox.text = "Rune nehmen <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "italiano")
    {
        textox.text = "Prendere la runa <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "portugues")
    {
        textox.text = "Pegar runa <sprite name=\"pixel_art_small\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "japones")
    {
        textox.text = "";
        textojx.text = "ルーンを取る <sprite name=\"pixel_art_small\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "룬을 받다 <sprite name=\"pixel_art_small\">";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "拿取符文 <sprite name=\"pixel_art_small\">";
        textorx.text = "";
    }
    if(idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Взять руну <sprite name=\"pixel_art_small\">";
    }
}

if(xbox == true)
{
   if(idioma == "ingles")
    {
        textox.text = "Take Rune <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "español")
    {
        textox.text = "Coger Runa <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "frances")
    {
        textox.text = "Prendre la rune <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "aleman")
    {
        textox.text = "Rune nehmen <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "italiano")
    {
        textox.text = "Prendere la runa <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "portugues")
    {
        textox.text = "Pegar runa <sprite name=\"A\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "japones")
    {
        textox.text = "";
        textojx.text = "ルーンを取る <sprite name=\"A\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "룬을 받다 <sprite name=\"A\">";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "拿取符文 <sprite name=\"A\">";
        textorx.text = "";
    }
    if(idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Взять руну <sprite name=\"A\">";
    }
}

if(xbox == false && playst == false)
{
   if(idioma == "ingles")
    {
        textox.text = "Take Rune <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "español")
    {
        textox.text = "Coger Runa <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "frances")
    {
        textox.text = "Prendre la rune <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "aleman")
    {
        textox.text = "Rune nehmen <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "italiano")
    {
        textox.text = "Prendere la runa <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "portugues")
    {
        textox.text = "Pegar runa <sprite name=\"E\">";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "japones")
    {
        textox.text = "";
        textojx.text = "ルーンを取る <sprite name=\"E\">";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "coreano")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "룬을 받다 <sprite name=\"E\">";
        textocx.text = "";
        textorx.text = "";
    }
    if(idioma == "chino")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "拿取符文 <sprite name=\"E\">";
        textorx.text = "";
    }
    if(idioma == "ruso")
    {
        textox.text = "";
        textojx.text = "";
        textokx.text = "";
        textocx.text = "";
        textorx.text = "Взять руну <sprite name=\"E\">";
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

