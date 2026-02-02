using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.EventSystems;

public class Cameras : MonoBehaviour
{
[Range(0f, 1f)] public float probabilidad = 0.1f;
[Range(0f, 1f)] public float probabilidad2 = 0.2f;
public GameObject port;
public TMP_Text textox;
public TMP_Text textox1;
public TMP_Text textox2;
public TMP_Text textox3;
public TMP_Text textox4;
public Color colorNormal;
public bool intering;
public bool mexico;
public TMP_Text texto;
public bool lockx;
public GameObject canv;
public Animator anim;
public float camy;
public GameObject spooky;
public GameObject filter;
public GameObject camx;
public GameObject kitch;
public GameObject living;
public GameObject basem;
public GameObject corr;
public GameObject guest;
public GameObject bath2;
public GameObject my;
public GameObject off;
public GameObject bath;
public GameObject canv2;
public Rigidbody rbd;
public TMP_Text texto2;
public TMP_Text texto3;
public Player player;
public bool freeze;
public bool ñ;
public GameObject menu;
public Buttons button;
public Data dt;
public bool snd;
public TMP_Text texton;
public TMP_Text textoj;
public TMP_Text textok;
public TMP_Text textoc;
public TMP_Text textor;
public TMP_Text texton2;
public TMP_Text textoj2;
public TMP_Text textok2;
public TMP_Text textoc2;
public TMP_Text textor2;
public TMP_Text textoj3;
public TMP_Text textok3;
public TMP_Text textoc3;
public TMP_Text textor3;
public TMP_Text textoj0;
public TMP_Text textok0;
public TMP_Text textoc0;
public TMP_Text textor0;
public string idioma;
public Buttons but;
public bool zxn;
public bool tut;
public bool home;
public GameObject impos;
public GameObject credits;
public GameObject rnxxx;
public AudioClip tns;
public AudioSource audioSource;
public Clock clock;
public EffectFeature ef;
public float night;
public AudioClip btnsn;
public float pow;
public bool xbox;
public bool playst;
public bool kitchb;
public bool livingb;
public bool basemb;
public bool corrb;
public bool guestb;
public bool bath2b;
public bool myb;
public bool offb;
public bool bathb;
public GameObject block;
public AudioListener al;
public GameObject pause;
public Gambling gb;
public bool gbx;
public AudioSource llori;
public AudioSource llori2;
public AudioSource llori3;
public GameObject gameo;
public GameObject setx;
public GameObject norx;
public bool crd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    xbox = player.xbox;
    playst = player.playst;
        pow = clock.power;
        home = player.home;
        idioma = dt.idioma;
        tut = player.tut;
        night = clock.night;
        gbx = gb.dis;
if(camy == 2)
{
if(kitchb == true)
{
block.SetActive(true);
}
if(kitchb == false)
{
block.SetActive(false);
}
}
if(camy == 3)
{
if(livingb == true)
{
block.SetActive(true);
}
if(livingb == false)
{
block.SetActive(false);
}
}
if(camy == 4)
{
if(basemb == true)
{
block.SetActive(true);
}
if(basemb == false)
{
block.SetActive(false);
}
}
if(camy == 5)
{
if(corrb == true)
{
block.SetActive(true);
}
if(corrb == false)
{
block.SetActive(false);
}
}
if(camy == 6)
{
if(guestb == true)
{
block.SetActive(true);
}
if(guestb == false)
{
block.SetActive(false);
}
}
if(camy == 7)
{
if(bath2b == true)
{
block.SetActive(true);
}
if(bath2b == false)
{
block.SetActive(false);
}
}
if(camy == 8)
{
if(myb == true)
{
block.SetActive(true);
}
if(myb == false)
{
block.SetActive(false);
}
}
if(camy == 9)
{
if(offb == true)
{
block.SetActive(true);
}
if(offb == false)
{
block.SetActive(false);
}
}
if(camy == 10)
{
if(bathb == true)
{
block.SetActive(true);
}
if(bathb == false)
{
block.SetActive(false);
}
}
if((Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.JoystickButton0) || Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.JoystickButton2)) && credits.activeInHierarchy)
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
  if(credits.activeInHierarchy)
  {
        mexico = player.mexico;
        if(mexico == false)
        {
        Invoke("st", 2f);
        }
  }
if(canv2.activeInHierarchy || menu.activeInHierarchy)
{
freeze = player.freeze = freeze;
}
if(pow <= 0)
{
 canv.SetActive(true);
 spooky.SetActive(true);
 kitch.SetActive(false);
 living.SetActive(false);
 bath.SetActive(false);
 corr.SetActive(false);
 bath2.SetActive(false);
 off.SetActive(false);
 my.SetActive(false);
 guest.SetActive(false);
 basem.SetActive(false);
 camx.SetActive(true);
                al.enabled = true;
}
snd = button.snd;
        if(intering == true && lockx == false && !menu.activeInHierarchy)
        {
         if(xbox == true)
         {
         if(idioma == "ingles")
         {
         texto.text = "Watch Cameras <sprite name=\"A\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Mirar Camaras <sprite name=\"A\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "Regarde les Cameras <sprite name=\"A\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "Siehe Kameras <sprite name=\"A\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "Guarda le Telecamere <sprite name=\"A\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "Veja Cameras <sprite name=\"A\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj0.text = "カメラを見る <sprite name=\"A\">";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "카메라를 봐 <sprite name=\"A\">";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "查看相机 <sprite name=\"A\">";
         textor0.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "видеть камеры <sprite name=\"A\">";
         }
         }
         if(playst == true)
         {
         if(idioma == "ingles")
         {
         texto.text = "Watch Cameras <sprite name=\"pixel_art_small\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Mirar Camaras <sprite name=\"pixel_art_small\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "Regarde les Cameras <sprite name=\"pixel_art_small\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "Siehe Kameras <sprite name=\"pixel_art_small\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "Guarda le Telecamere <sprite name=\"pixel_art_small\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "Veja Cameras <sprite name=\"pixel_art_small\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj0.text = "カメラを見る <sprite name=\"pixel_art_small\">";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "카메라를 봐 <sprite name=\"pixel_art_small\">";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "查看相机 <sprite name=\"pixel_art_small\">";
         textor0.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "видеть камеры <sprite name=\"pixel_art_small\">";
         }
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Watch Cameras <sprite name=\"E\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Mirar Camaras <sprite name=\"E\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "Regarde les Cameras <sprite name=\"E\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "Siehe Kameras <sprite name=\"E\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "Guarda le Telecamere <sprite name=\"E\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "Veja Cameras <sprite name=\"E\">";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj0.text = "カメラを見る <sprite name=\"E\">";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "카메라를 봐 <sprite name=\"E\">";
         textoc0.text = "";
         textor0.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "查看相机 <sprite name=\"E\">";
         textor0.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "видеть камеры <sprite name=\"E\">";
         }
         }
              if ((Input.GetKeyDown(KeyCode.E) || (playst == true && Input.GetKeyDown(KeyCode.JoystickButton1)) || (xbox == true && Input.GetKeyDown(KeyCode.JoystickButton0))) && lockx == false && freeze == false)
              {
                llori.enabled = false;
                llori2.enabled = false;
                llori3.enabled = false;
                al.enabled = false;
                float rng = Random.value;
        if (rng <= probabilidad && night >= 5)
        {
            port.SetActive(true);
        }
                zxn = false;
                if(zxn == false)
                {
                canv.SetActive(false);
                }
                anim.SetTrigger("z1");
                Invoke("zx", 0.3f);
         Invoke("camfix", 0.3f);
              }
        }
          if (((Input.GetKeyDown(KeyCode.Escape) || (playst == true && Input.GetKeyDown(KeyCode.JoystickButton9)) || (xbox == true && Input.GetKeyDown(KeyCode.JoystickButton7))) && lockx == false && ñ == true) || (snd == true) && ef.enabled == false)
          {
                al.enabled = true;
Cursor.visible = false;
    Cursor.lockState = CursorLockMode.Locked;
             if(tut == true)
             {
             if(!pause.activeInHierarchy)
             {
             if(gbx == false)
             {
             if(crd == false)
             {
             freeze = false;
             rbd.constraints = RigidbodyConstraints.FreezeRotation;
             }
             }
             }
             }
             Invoke("jkl", 0.1f);
          }
        if(lockx == false && ñ == false)
        {
          if ((Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.JoystickButton9) && playst == true) || (Input.GetKeyDown(KeyCode.JoystickButton7) && xbox == true)) && !menu.activeInHierarchy && ñ == false && home == false && !impos.activeInHierarchy && !credits.activeInHierarchy && !rnxxx.activeInHierarchy && ef.enabled == false)
          {
audioSource.PlayOneShot(btnsn);
             menu.SetActive(true);
Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
             freeze = true;
             rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
             ñ = true;
          }
        }

        if(lockx == true)
        {
          if ((Input.GetKeyDown(KeyCode.Escape) || (playst == true && Input.GetKeyDown(KeyCode.JoystickButton2)) || (xbox == true && Input.GetKeyDown(KeyCode.JoystickButton1))))
          {
llori.enabled = true;
llori2.enabled = true;
llori3.enabled = true;
al.enabled = true;
 zxn = true;
 camy = 0;
 if(ef.enabled == false)
 {
 freeze = false;
 }
 canv.SetActive(true);
 rbd.constraints = RigidbodyConstraints.FreezeRotation;
 spooky.SetActive(true);
 filter.SetActive(false);
 kitch.SetActive(false);
 living.SetActive(false);
 bath.SetActive(false);
 corr.SetActive(false);
 bath2.SetActive(false);
 off.SetActive(false);
 my.SetActive(false);
 guest.SetActive(false);
 basem.SetActive(false);
 camx.SetActive(true);
 lockx = false;
 Invoke("jkl2", 0.05f);
          }
          if (camy == 1)
          {
             camy = 10;
          }
          if (camy == 11)
          {
             camy = 2;
          }
          if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.JoystickButton5)))
          {
             camy += 1;
          }
          if ((Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.JoystickButton4)))
          {
             camy -= 1;
          }
          if (Input.GetKeyDown(KeyCode.LeftArrow))
          {
             camy -= 1;
          }
          if (Input.GetKeyDown(KeyCode.RightArrow))
          {
             camy += 1;
          }
if(kitchb == true)
{
kitch.SetActive(false);
}
if(livingb == true)
{
living.SetActive(false);
}
if(bathb == true)
{
bath.SetActive(false);
}
if(corrb == true)
{
corr.SetActive(false);
}
if(bath2b == true)
{
bath2.SetActive(false);
}
if(offb == true)
{
off.SetActive(false);
}
if(myb == true)
{
my.SetActive(false);
}
if(guestb == true)
{
guest.SetActive(false);
}
if(basemb == true)
{
basem.SetActive(false);
}

          if (camy == 2)
          {
             texto2.text = "Cam1";
         if(idioma == "ingles")
         {
         texto3.text = "Kitchen";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Cocina";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Cuisine";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Kuche";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Cucina";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Cozinha";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "台所";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "주방";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "厨房";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "кухня";
         }
             if(kitchb == false)
             {
             kitch.SetActive(true);
             living.SetActive(false);
             bath.SetActive(false);
             corr.SetActive(false);
             bath2.SetActive(false);
             off.SetActive(false);
             my.SetActive(false);
             guest.SetActive(false);
             basem.SetActive(false);
             }
          }
          if (camy == 3)
          {
             texto2.text = "Cam2";
         if(idioma == "ingles")
         {
         texto3.text = "Living Room";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Salon";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Salon";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Lounge";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Sala";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Saguao";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "ラウンジ";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "라운지";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "休息室";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "бездельничать";
         }
             if(livingb == false)
             {
             kitch.SetActive(false);
             living.SetActive(true);
             bath.SetActive(false);
             corr.SetActive(false);
             bath2.SetActive(false);
             off.SetActive(false);
             my.SetActive(false);
             guest.SetActive(false);
             basem.SetActive(false);
             }
          }
          if (camy == 4)
          {
             texto2.text = "Cam3";
         if(idioma == "ingles")
         {
         texto3.text = "Bathroom 1";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Aseo 1";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Salle de bain 1";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Badezimmer 1";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Bagno 1";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Banheiro 1";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "バスルーム 1";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "화장실 1";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "浴室 1";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "ванная комната 1";
         }
             if(bathb == false)
             {
             kitch.SetActive(false);
             living.SetActive(false);
             bath.SetActive(true);
             corr.SetActive(false);
             bath2.SetActive(false);
             off.SetActive(false);
             my.SetActive(false);
             guest.SetActive(false);
             basem.SetActive(false);
             }
          }
          if (camy == 5)
          {
             texto2.text = "Cam4";
         if(idioma == "ingles")
         {
         texto3.text = "Hall";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Pasillo";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Allee";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Gang";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Corridoio";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Corredor";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "通路";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "통로";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "走道";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "ряд";
         }
             if(corrb == false)
             {
             kitch.SetActive(false);
             living.SetActive(false);
             bath.SetActive(false);
             corr.SetActive(true);
             bath2.SetActive(false);
             off.SetActive(false);
             my.SetActive(false);
             guest.SetActive(false);
             basem.SetActive(false);
             }
          }
          if (camy == 6)
          {
             texto2.text = "Cam5";
         if(idioma == "ingles")
         {
         texto3.text = "Bathroom 2";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Aseo 2";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Salle de bain 2";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Badezimmer 2";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Bagno 2";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Banheiro 2";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "バスルーム 2";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "화장실 2";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "浴室 2";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "ванная комната 2";
         }
             if(bath2b == false)
             {
             kitch.SetActive(false);
             living.SetActive(false);
             bath.SetActive(false);
             corr.SetActive(false);
             bath2.SetActive(true);
             off.SetActive(false);
             my.SetActive(false);
             guest.SetActive(false);
             basem.SetActive(false);
             }
          }
          if (camy == 7)
          {
             texto2.text = "Cam6";
         if(idioma == "ingles")
         {
         texto3.text = "Office";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Oficina";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Bureau";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Buro";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Ufficio";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Escritorio";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "オフィス";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "사무실";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "办公室";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "офис";
         }
             if(offb == false)
             {
             kitch.SetActive(false);
             living.SetActive(false);
             bath.SetActive(false);
             corr.SetActive(false);
             bath2.SetActive(false);
             off.SetActive(true);
             my.SetActive(false);
             guest.SetActive(false);
             basem.SetActive(false);
             }
          }
          if (camy == 8)
          {
             texto2.text = "Cam7";
         if(idioma == "ingles")
         {
         texto3.text = "My Room";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Mi Cuarto";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Ma Chambre";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Mein Zimmer";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "La Mia Stanza";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Meu Quarto";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "マイルーム";
         textok3.text = "";
         textoc3.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "내 방";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "我的房间";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "моя комната";
         }
             if(myb == false)
             {
             kitch.SetActive(false);
             living.SetActive(false);
             bath.SetActive(false);
             corr.SetActive(false);
             bath2.SetActive(false);
             off.SetActive(false);
             my.SetActive(true);
             guest.SetActive(false);
             basem.SetActive(false);
             }
          }
          if (camy == 9)
          {
             texto2.text = "Cam8";
         if(idioma == "ingles")
         {
         texto3.text = "Guest Room";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Cuarto de Invitados";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Chambre d'Amis";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Gastezimmer";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Camera Degli Ospiti";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Quarto de Hospedes";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "ゲストルーム";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "객실";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "客房";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "гостевая комната";
         }
             if(guestb == false)
             {
             kitch.SetActive(false);
             living.SetActive(false);
             bath.SetActive(false);
             corr.SetActive(false);
             bath2.SetActive(false);
             off.SetActive(false);
             my.SetActive(false);
             guest.SetActive(true);
             basem.SetActive(false);
             }
          }
          if (camy == 10)
          {
             texto2.text = "Cam9";
         if(idioma == "ingles")
         {
         texto3.text = "Basement";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "español")
         {
         texto3.text = "Sotano";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "frances")
         {
         texto3.text = "Sous-sol";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "aleman")
         {
         texto3.text = "Keller";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "italiano")
         {
         texto3.text = "Seminterrato";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "portugues")
         {
         texto3.text = "Porao";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "japones")
         {
         texto3.text = "";
         textoj3.text = "地下";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "coreano")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "최하부";
         textoc3.text = "";
         textor3.text = "";
         }
         if(idioma == "chino")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "地下室";
         textor3.text = "";
         }
         if(idioma == "ruso")
         {
         texto3.text = "";
         textoj3.text = "";
         textok3.text = "";
         textoc3.text = "";
         textor3.text = "подвал";
         }
             if(basemb == false)
             {
             kitch.SetActive(false);
             living.SetActive(false);
             bath.SetActive(false);
             corr.SetActive(false);
             bath2.SetActive(false);
             off.SetActive(false);
             my.SetActive(false);
             guest.SetActive(false);
             basem.SetActive(true);
             }
          }
        }
        
    }
public void jkl()
{
al.enabled = true;
   ñ = false;
textox.color = colorNormal;
textox1.color = colorNormal;
textox2.color = colorNormal;
textox3.color = colorNormal;
textox4.color = colorNormal;
button.snd = snd;
   snd = false;
setx.SetActive(false);
norx.SetActive(true);
menu.SetActive(false);
}
 public void jkl2()
 {
 canv2.SetActive(false);
 }
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player"))
    {
        intering = true;
    }
}

void OnTriggerExit(Collider other)
{
    if (other.CompareTag("Player"))
    {
        intering = false;
         texto.text = "";
         textoj0.text = "";
         textok0.text = "";
         textoc0.text = "";
         textor0.text = "";
    }
}
void zx()
{
 canv2.SetActive(true);
 rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
 kitch.SetActive(true);
 camy = 2;
 spooky.SetActive(false);
 filter.SetActive(true);
            blocksystem();

 lockx = true;
 freeze = true;
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texton2.text = "Change Camera (A D)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "español")
         {
         texton2.text = "Cambiar Camara (A D)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "frances")
         {
         texton2.text = "Changer de Camera (A D)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "aleman")
         {
         texton2.text = "Kamera Wechseln (A D)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "italiano")
         {
         texton2.text = "Cambiare Telecamera (A D)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "portugues")
         {
         texton2.text = "Mudar de Camera (A D)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "japones")
         {
         texton2.text = "";
         textoj2.text = "カメラを変更する (A D)";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "coreano")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "카메라 변경 (A D)";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "chino")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "更换相机 (A D)";
         textor2.text = "";
         }
         if(idioma == "ruso")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "сменить камеру (A D)";
         }
         }
         if(playst == true)
         {
         if(idioma == "ingles")
         {
         texton2.text = "Change Camera (L1 R1)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "español")
         {
         texton2.text = "Cambiar Camara (L1 R1)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "frances")
         {
         texton2.text = "Changer de Camera (L1 R1)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "aleman")
         {
         texton2.text = "Kamera Wechseln (L1 R1)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "italiano")
         {
         texton2.text = "Cambiare Telecamera (L1 R1)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "portugues")
         {
         texton2.text = "Mudar de Camera (L1 R1)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "japones")
         {
         texton2.text = "";
         textoj2.text = "カメラを変更する (L1 R1)";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "coreano")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "카메라 변경 (L1 R1)";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "chino")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "更换相机 (L1 R1)";
         textor2.text = "";
         }
         if(idioma == "ruso")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "сменить камеру (L1 R1)";
         }
         }
         if(xbox == true)
         {
         if(idioma == "ingles")
         {
         texton2.text = "Change Camera (LB RB)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "español")
         {
         texton2.text = "Cambiar Camara (LB RB)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "frances")
         {
         texton2.text = "Changer de Camera (LB RB)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "aleman")
         {
         texton2.text = "Kamera Wechseln (LB RB)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "italiano")
         {
         texton2.text = "Cambiare Telecamera (LB RB)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "portugues")
         {
         texton2.text = "Mudar de Camera (LB RB)";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "japones")
         {
         texton2.text = "";
         textoj2.text = "カメラを変更する (LB RB)";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "coreano")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "카메라 변경 (LB RB)";
         textoc2.text = "";
         textor2.text = "";
         }
         if(idioma == "chino")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "更换相机 (LB RB)";
         textor2.text = "";
         }
         if(idioma == "ruso")
         {
         texton2.text = "";
         textoj2.text = "";
         textok2.text = "";
         textoc2.text = "";
         textor2.text = "сменить камеру (LB RB)";
         }
         }

         if(xbox == false && playst == true)
         {
         if(idioma == "ingles")
         {
         texton.text = "Exit (o)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texton.text = "Salir (o)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texton.text = "Sortir (o)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texton.text = "Hinausgehen (o)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texton.text = "Esci (o)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texton.text = "Sair (o)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texton.text = "";
         textoj.text = "外出 (o)";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "나가다 (o)";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "出去 (o)";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "выходить (o)";
         }
         }
         if(xbox == true && playst == false)
         {
         if(idioma == "ingles")
         {
         texton.text = "Exit (B)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texton.text = "Salir (B)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texton.text = "Sortir (B)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texton.text = "Hinausgehen (B)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texton.text = "Esci (B)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texton.text = "Sair (B)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texton.text = "";
         textoj.text = "外出 (B)";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "나가다 (B)";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "出去 (MENU)";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "выходить (MENU)";
         }
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texton.text = "Exit (Esc)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texton.text = "Salir (Esc)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texton.text = "Sortir (Esc)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texton.text = "Hinausgehen (Esc)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texton.text = "Esci (Esc)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texton.text = "Sair (Esc)";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texton.text = "";
         textoj.text = "外出 (Esc)";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "나가다 (Esc)";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "出去 (Esc)";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texton.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "выходить (Esc)";
         }
         }
}
void camfix()
{
 anim.SetTrigger("z2");
}
void blocksystem()
{
if(canv2.activeInHierarchy)
{
                float rngx = Random.value;
        if (rngx <= probabilidad2)
        {
        int rng = Random.Range(1, 10);
        if (rng == 1)
        {
         kitchb = true;
        }
        if (rng == 2)
        {
         livingb = true;
        }
        if (rng == 3)
        {
         basemb = true;
        }
        if (rng == 4)
        {
         corrb = true;
        }
        if (rng == 5)
        {
         guestb = true;
        }
        if (rng == 6)
        {
         bath2b = true;
        }
        if (rng == 7)
        {
         myb = true;
        }
        if (rng == 8)
        {
         bathb = true;
        }
        if (rng == 9)
        {
         offb = true;
        }
        }
        Invoke("blocksystem", 10f);
}
}
void st()
{
if (!audioSource.isPlaying)
{
 audioSource.Play();
}
     if(!gameo.activeInHierarchy)
     {
     audioSource.clip = tns;
     audioSource.loop = true;
     }
}
}
