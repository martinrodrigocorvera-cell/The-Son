using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.EventSystems;

public class Doors : MonoBehaviour
{
public Player play;
public bool freeze;
public TMP_Text texto;
public TMP_Text textoj;
public TMP_Text textok;
public TMP_Text textoc;
public TMP_Text textor;
public bool intering;
public bool ing;
public bool open;
public Animator anim;
public bool lockx;
public bool sp;
public BoxCollider me;
public GameObject sound;
public string idioma;
public Data but;
public Player ply;
public AudioClip opend;
public AudioClip slam;
public AudioClip closd;
public AudioSource audioSource;
public bool stick;
public bool xbox;
public bool playst;
public GameObject llor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        stick = ply.stick;
        xbox = ply.xbox;
        playst = ply.playst;
        idioma = but.idioma;
        if(lockx == true && intering == true && llor.activeInHierarchy)
        {
         if(idioma == "ingles")
         {
         texto.text = "The Door is Locked";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "La Puerta esta Bloqueada";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "La porte est verrouillee";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "Die Tur ist verschlossen";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "la porta e chiusa";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "a porta esta trancada";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "ドアは施錠されています";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "문이 잠겨 있어요";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "门被锁了";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "дверь заперта";
         }
        }

        if(intering == true && lockx == false)
        {
              if(ing == true)
              {
                texto.text = "";
              }

              if(open == false)
              {
              if(ing == false && xbox == true && playst == false)
              {
         if(idioma == "ingles")
         {
         texto.text = "Open <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Abrir <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "ouvre <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "offne <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "aprire <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "abrir <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "開ける <sprite name=\"A\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "열려 있는 <sprite name=\"A\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "打开 <sprite name=\"A\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "открыть <sprite name=\"A\">";
         }
         }
              if(ing == false && xbox == false && playst == true)
              {
         if(idioma == "ingles")
         {
         texto.text = "Open <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Abrir <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "ouvre <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "offne <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "aprire <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "abrir <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "開ける <sprite name=\"pixel_art_small\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "열려 있는 <sprite name=\"pixel_art_small\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "打开 <sprite name=\"pixel_art_small\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "открыть <sprite name=\"pixel_art_small\">";
         }
         }
              if(ing == false && xbox == false && playst == false)
              {
         if(idioma == "ingles")
         {
         texto.text = "Open <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Abrir <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "ouvre <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "offne <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "aprire <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "abrir <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "開ける <sprite name=\"E\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "열려 있는 <sprite name=\"E\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "打开 <sprite name=\"E\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "открыть <sprite name=\"E\">";
         }
              }
freeze = play.freeze;
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && ing == false && freeze == false)
              {
               audioSource.PlayOneShot(opend);
               sound.SetActive(true);
               ing = true;
               if(open = false)
               {
               anim.SetTrigger("cl1");
               }
               if(open = true)
               {
               anim.SetTrigger("op1");
               }
               Invoke("openx", 1f);
              }

              }

              if(open == true && ing == false)
              {
              if(ing == false && xbox == true && playst == false)
              {
         if(idioma == "ingles")
         {
         texto.text = "Close <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Cerrar <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "ferme <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "schließen <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "chiudere <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "feche <sprite name=\"A\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "近い <sprite name=\"A\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "닫다 <sprite name=\"A\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "关闭 <sprite name=\"A\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "закрыть <sprite name=\"A\">";
         }
              }
              if(ing == false && xbox == false && playst == true)
              {
         if(idioma == "ingles")
         {
         texto.text = "Close <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Cerrar <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "ferme <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "schließen <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "chiudere <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "feche <sprite name=\"pixel_art_small\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "近い <sprite name=\"pixel_art_small\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "닫다 <sprite name=\"pixel_art_small\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "关门 <sprite name=\"pixel_art_small\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "закрыть <sprite name=\"pixel_art_small\">";
         }
              }
              if(ing == false && xbox == false && playst == false)
              {
         if(idioma == "ingles")
         {
         texto.text = "Close <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Cerrar <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "ferme <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "schließen <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "chiudere <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "feche <sprite name=\"E\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "近い <sprite name=\"E\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "닫다 <sprite name=\"E\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "关门 <sprite name=\"E\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "закрыть <sprite name=\"E\">";
         }
              }
              if(ply.freeze == true)
              {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
              }
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && ing == false)
              {
               audioSource.PlayOneShot(closd);
               sound.SetActive(true);
               ing = true;
               if(open = true)
               {
               anim.SetTrigger("cl1");
               }
                if(open = false)
               {
               anim.SetTrigger("op1");
               }
               Invoke("closex", 1f);
              }
              }
        }
    }
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player") && ply.freeze == false)
    {
        intering = true;
    }
if (other.gameObject.CompareTag("llorona") && sp == false)
{
    Llorona llorona = other.gameObject.GetComponent<Llorona>();
    float animSpeed = 1f;
    float openDelay = 1f;
    if (llorona.mode == 3)
    {
        audioSource.PlayOneShot(slam);
        animSpeed = 3f;
        openDelay = 0.3f;
    }
    if (llorona.mode == 2)
    {
        audioSource.PlayOneShot(opend);
        animSpeed = 1.5f;
        openDelay = 0.5f;
    }
    if (llorona.mode == 1)
    {
        audioSource.PlayOneShot(opend);
        animSpeed = 1f;
        openDelay = 1f;
    }
    anim.speed = animSpeed;
    anim.SetTrigger("op1");
    Invoke(nameof(openx), openDelay);
    me.isTrigger = true;
}
}
void OnCollisionEnter(Collision other2)
{
    if (other2.gameObject.CompareTag("llorona") && sp == false)
    {
       anim.SetTrigger("op1");
       Invoke("openx", 1f);
       me.isTrigger = true;
    }
}

void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
        intering = false;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
    }
    if (other.CompareTag("llorona"))
    {
        me.isTrigger = false;
    }
}
public void openx()
{
    ing = false;
    open = true;
    sound.SetActive(false);
}
public void closex()
{
    sound.SetActive(false);
    ing = false;
    open = false;
}
}
