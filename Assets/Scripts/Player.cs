using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System.Runtime.InteropServices;
using UnityEngine.Video;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
[Range(0f, 1f)] public float probabilidad = 0.02f;

public GameObject hng;
public GameObject end;
public GameObject ox1;
public GameObject ox2;
public AudioClip cardf;
public AudioClip cardd;
public AudioClip cardd2;
public TMP_Text textoa;
public TMP_Text textoja;
public TMP_Text textoka;
public TMP_Text textoca;
public TMP_Text textora;
public TMP_Text textol;
public TMP_Text textojl;
public TMP_Text textokl;
public TMP_Text textocl;
public TMP_Text textorl;
    public bool mexico;
    public Cameras cm;
    public GameObject invk;
    public Animator cer2;
    public AudioClip harp;
    public bool wtn;
    public AudioClip pers;
    public Light lumen;
    public GameObject imp2;
    public bool notp;
    public bool arming3;
    public float speedo;
    public float ques;
    public float voice;
    public AudioSource fdt;
    public AudioClip mxc;
    public AudioClip hit;
    public Flashlight flash;
    public bool on;
    public GameObject arm;
    public GameObject camaraxx;
    public Transform seller2;
    public GameObject camarax;
    public bool opi;
    public bool opi2;
    public GameObject redlight;
    public GameObject redscreen;
    public float hellock;
    public Animator animñ;
    public GameObject flss;
    public GameObject watch;
    public GameObject imp;
    public GameObject jmpscare;
    public GameObject spawnxx;
    public GameObject port;
    public GameObject portxxx;
    public GameObject kitsp;
    public GameObject spawnr;
    public GameObject trans3;
    public bool parm;
    private Vector3 posicionOriginal;
    private Vector3 posicionOriginal2;
    public bool porm;
    public float speed2 = 0.05f;
    public float velocidad = 5f;
    public float velocidad2 = 6f;
    public string textsp2;
    public GameObject par;
    public Animator parx;
    public GameObject por;
    public Animator porx;
    public Rigidbody rbd;
    public AudioClip eyesn;
    public AudioClip trapsn;
    public AudioClip ring;
    public AudioClip wlk;
    public AudioClip rn;
    public AudioClip wlk2;
    public AudioClip cr;
    public AudioClip dm;
    public AudioClip wh;
    public AudioClip jsc;
    public AudioClip sta;
    public AudioClip hit2;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSourcex;
    public AudioSource audioSource2x;
    public AudioSource audioSource3x;
    public AudioSource audioSource3;
    public AudioListener AudioListener;
    public GameObject phone;
    public float speed;
    public TMP_Text texto;
    private CharacterController controller;
    public float gravity = -9.81f;
    public float verticalVelocity;
    public Animator anim;
    public Animator anim2;
    public GameObject bar;
    public Slider bar2;
    public Slider bar3;
    public bool smaller;
    public float size;
    public bool rp;
    public bool rp1;
    public bool moving;
    public bool rp3;
    public Image xk1;
    public Image xk2;
    public bool drain;
    public bool freeze;
    public string plc;
    public bool safe;
    public GameObject sound;
    public Clock clock;
    public float night;
    public Vector3 escalaBase;
    public float x2;
    public float y;
    public float z;
    public Transform player;
    public GameObject penta;
    public bool purif;
    public Image pen;
    public float alphaStep;
    public bool bjp;
    public bool zx;
    public string ubi;
public TMP_Text textoj;
public TMP_Text textok;
public TMP_Text textoc;
public TMP_Text textor;
public TMP_Text textod;
public TMP_Text textojd;
public TMP_Text textokd;
public TMP_Text textocd;
public TMP_Text textord;
public string idioma;
public Data but;
    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;
    public GameObject blood4;
    public GameObject blood5;
    public GameObject blood6;
    public GameObject blood7;
    public GameObject blood8;
    public bool tut;
    public bool zñ;
    public bool rsp;
    public float textorder;
    public bool writing;
    public bool name;
    public bool texm;
    public bool freeze2;
    public GameObject menu;
    public bool nod;
    public AudioClip jsc2;
    public bool lñ;
    public GameObject cam;
    public GameObject stat;
    public AudioClip inf1;
    public AudioClip inf2;
    public GameObject filter;
    public GameObject mic;
    public bool home;
    public GameObject Ll;
    public GameObject Cl;
    public AudioClip tns;
    public bool zxm;
    public GameObject interx;
    public GameObject gameo;
    public GameObject camara;
    public GameObject wino;
    public GameObject runnx;
    public GameObject fls;
    public Transform fls2;
    public Animator plax;
    public GameObject hell;
    public GameObject hell2;
    public GameObject lant;
    public GameObject trans;
    public GameObject credits;
    public float pow;
    public bool zxh;
    public bool klo;
    public AudioClip fire;
    public bool ñal;
    public GameObject can;
    public VideoPlayer videoPlayer;
    public RawImage rawImage;
    public GameObject me;
    public Transform entryPortal;
    public Transform exitPortal;
    public Transform camp;
    public GameObject trap;
    public EffectFeature ef;
    public bool flip;
    public GameObject flipx;
    private bool isTeleporting = false;
    public System.Random rng = new System.Random();
    public GameObject interz;
    public bool hjñ;
    public GameObject wl1;
    public bool polt;
    public bool kml;
    public bool kml2;
    public bool kml3;
    public GameObject llor;
    public bool playst;
    public bool xbox;
    private List<string> mandosPrevios = new List<string>();
    public bool stick = false;
    public GameObject comp;
    public bool noc;
    public RectTransform larry;
    public float speedj = 600f;
    private Vector2 cursorPos;
    [DllImport("user32.dll")] static extern bool SetCursorPos(int X, int Y);
    [DllImport("user32.dll")]
    static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);
    private const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
    private const uint MOUSEEVENTF_LEFTUP   = 0x0004;
    public GameObject larryx;
    public GameObject homec;
    public GameObject gam;
    private bool isPressing = false;
    private Vector2 startPressPos;
    private Vector2 lastCursorPos;
    private bool isDragging = false;

    private PointerEventData pointerData;
    private GameObject dragTarget;
    private Slider activeSlider;
    public Sprite spriteA;
    public Sprite spriteB;
    public Sprite spder;
    public Sprite spizq;
    public Sprite sparr;
    public Sprite spaba;
    private Image larryImage;
    public GameObject pcwal;
    public GameObject mndwal;
    public GameObject block;
    public GameObject shrt;
    public bool g1;
    public bool g2;
    public bool g3;
    public bool g4;
    public bool g5;
    public GameObject thg;
    public TMP_Text tx1;
    public TMP_Text tx2;
    public TMP_Text tx3;
    public TMP_Text tx4;
    public TMP_Text tx5;
    public GameObject copy;
    public float hour;
    public GameObject scaryaf;
    public AudioClip meet;
    public bool skip;
    public GameObject secwall;
    public bool paso1;
    public bool paso2;
    public bool paso2x;
    public bool paso3;
    public bool paso3x;
    public bool paso4;
    public bool looking;
    public Camera playerCamera;
    public float detectDistance = 100f;
    public GameObject msg1;
    public GameObject msg2;
    public GameObject msg3;
    public GameObject msg4;
    public GameObject secr;
    public GameObject hellmode;
    public GameObject bloood;
    public GameObject rendclos;
    public GameObject rendopen;
    public GameObject shop1;
    public bool timestop;
    public bool zxcc;
    public GameObject pause;
    public Animator vanim;
    public bool arming;
    public bool arming2;
    public float taco;
    public float burr;
    public float nach;
    public float frij;
    public float tam;
    public Gambling gamb;
    public bool dis;
    public GameObject traga;
    public Camera camyx;
    public Camera cam2yx;
    public bool cls;
    public GameObject bck;
public AudioClip mxc2;
public float targetFOV;
public float speedd = 5;
public GameObject ml;
public GameObject ml2;
public GameObject nol;
public bool nolev;
public AudioClip wlk22;
public bool unlev;
public GameObject stalk;
public GameObject backtx;
public GameObject shop2;
public GameObject shop3;
public bool answer;
public string option;
public bool armingg;
public GameObject nolevi;
public GameObject answ;
public float mirai;
public float seller;
public bool armingg2;
    public TMP_Text textoq;
    public TMP_Text textojq;
    public TMP_Text textokq;
    public TMP_Text textocq;
    public TMP_Text textorq;
public float luck;
public Animator crd;
public Animator crd2;
public Cards cardi;
public float subend;
public float mirais;
public float sellers;
public GameObject mirob;
public GameObject selob;
public GameObject selob2;
public GameObject muf;
public GameObject vendmir;
public Animator vanimm;
public GameObject trapspec;
public GameObject trapspec2;
public Animator tranimx;
public GameObject wallsp;
public Animator mirend;
public bool ncx;
public Animator vendi;
public GameObject mircas;
public GameObject table;
public GameObject tv;
public Animator tv1;
public Animator tv2;
public GameObject tvv;
public Animator tvv1;
public Animator tvv2;
public GameObject tvsel;
public GameObject trait;
public GameObject icc;
public bool alone;
public GameObject crys;
public bool pop;
public GameObject muf2;


    void Start()
    {
            hellock = PlayerPrefs.GetFloat("Plus1");
        cursorPos = new Vector2(Screen.width / 2, Screen.height / 2);
        mandosPrevios = new List<string>(Input.GetJoystickNames());
        ActualizarEstados(mandosPrevios);
           Invoke("crs", 1f);
        posicionOriginal = par.transform.position;
        posicionOriginal2 = por.transform.position;
        controller = GetComponent<CharacterController>();
        filter.SetActive(true);
        home = true;
interx.SetActive(true);
Invoke("sp", 2f);
mirai = PlayerPrefs.GetInt("mir");
seller = PlayerPrefs.GetInt("sel");
    }


    void Update()
    {
if(night == 5 && mirai == 0)
{
ncx = true;
}
if(mirai >= -2.5f && mirai <= 2.5f)
{
mirais = 0;
}
if(mirai >= 3)
{
mirais = 1;
}
if(mirai <= -3)
{
mirais = -1;
}

if(seller >= -2.5f && seller <= 2.5f)
{
sellers = 0;
}
if(seller >= 3)
{
sellers = 1;
}
if(seller <= -3)
{
sellers = -1;
}

//SUBFIN
if(night == 6)
{
if(mirais == 0 && sellers == 0)
{
shop1.SetActive(false);
}
if(mirais == -1 && sellers == -1)
{
shop1.SetActive(false);
mirob.SetActive(false);
selob.SetActive(false);
selob2.SetActive(true);
muf.SetActive(true);
tvsel.SetActive(false);
alone = true;
}
if(mirais == 1 && sellers == 1)
{
    vanim.SetTrigger("feliz1");
    vanimm.SetTrigger("felizm");
vendmir.SetActive(true);
}
if(mirais == 0 && sellers == -1)
{
    vanim.SetTrigger("sd1");
    vendi.SetTrigger("sd1");
mirob.SetActive(false);
mircas.SetActive(true);
}
if(mirais == 1 && sellers == 0)
{
shop1.SetActive(false);
tv.SetActive(true);
tv1.SetTrigger("feliz1");
tv2.SetTrigger("mirai1");
tvsel.SetActive(false);
}
if(mirais == 0 && sellers == 1)
{
shop1.SetActive(false);
tvv.SetActive(true);
tvv1.SetTrigger("feliz1");
tvv2.SetTrigger("mirai1");
tvsel.SetActive(false);
}
if(mirais == 1 && sellers == -1)
{
shop1.SetActive(false);
mirob.SetActive(false);
selob.SetActive(false);
selob2.SetActive(true);
tvsel.SetActive(false);
trait.SetActive(true);
muf2.SetActive(true);
alone = true;
}
if(mirais == -1 && sellers == 0)
{
shop1.SetActive(false);
    vanim.SetTrigger("sd1");
    vendi.SetTrigger("sd1");
icc.SetActive(true);
crys.SetActive(true);
}
if(mirais == -1 && sellers == 1)
{
    alone = true;
shop1.SetActive(false);
if(pop == false)
{
    shop2.SetActive(true);
    pop = true;
}
selob.SetActive(false);
selob2.SetActive(true);
tvsel.SetActive(false);
}
}

if(night >= 5)
{
nol.SetActive(true);
}
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && wtn == true && !menu.activeInHierarchy)
              {
    textoa.text = "";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
           crd2.SetTrigger("x3");
    audioSource.PlayOneShot(cardd2);
        Invoke("O2", 0.5f);
              }
    if(texm == false)
    {
     backtx.SetActive(false);
    }
    if(texm == true)
    {
     backtx.SetActive(true);
    }
    if(night == 3)
    {
    stalk.SetActive(true);
    }
    if(night >= 4)
    {
    ml2.SetActive(true);
    }
    if(night <= 3)
    {
    ml.SetActive(true);
    }
    if(gameo.activeInHierarchy)
    {
     audioSource.clip = null;
     audioSource.Stop();
    }
    dis = gamb.dis;
    nach = but.nach;
    frij = but.frij;
    lumen.spotAngle = 45 + (nach * 5);
    lumen.shadowStrength = 1 - (frij / 2);
    speedo = speed - taco;
    taco = but.taco;
    burr = but.burr;
    tam = but.tam;
            if(night >= 4)
            {
             imp2.SetActive(true);
             traga.SetActive(true);
            }
    if(home == true)
    {
     bck.SetActive(false);
    }
    if(home == false)
    {
     bck.SetActive(true);
    }
    if(cls == true)
    {
        camyx.fieldOfView = Mathf.Lerp(camyx.fieldOfView, targetFOV, Time.deltaTime * speedd);
        cam2yx.fieldOfView = Mathf.Lerp(camyx.fieldOfView, targetFOV, Time.deltaTime * speedd);
    }
            if(arming == true)
            {
        float speedz = 5;
        Quaternion targetRotation = Quaternion.Euler(0, 0, 0);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
            }
            if(armingg == true)
            {
        float speedz = 10;
        Quaternion targetRotation = Quaternion.Euler(0, -50, 0);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
            }
            if(armingg2 == true)
            {
        float speedz = 2;
        Quaternion targetRotation = Quaternion.Euler(0, -30, 0);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
            }
            if(arming2 == true)
            {
        float speedz = 2;
        Quaternion targetRotation = Quaternion.Euler(0, -75, 0);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
            }
            if(arming3 == true)
            {
        float speedz = 5;
        Quaternion targetRotation = Quaternion.Euler(0, -20, 0);

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
            }
            if(night >= 2 && zxcc == false)
            {
            if(night != 6 && ncx == false)
            {
            shop1.SetActive(true);
            }
            zxcc = true;
            }
        if(night == 1)
        {
        if(timestop == false && tut == true)
        {
         pause.SetActive(false);
        }
        }
        if(timestop == false && night >= 2)
        {
         pause.SetActive(false);
        }
        if(timestop == true)
        {
         pause.SetActive(true);
        }
        if(tut == false && night == 1)
        {
         pause.SetActive(false);
        }

        if(night >= 2 && !runnx.activeInHierarchy)
        {
         rendopen.SetActive(true);
         rendclos.SetActive(false);
        }
        if(runnx.activeInHierarchy)
        {
         rendopen.SetActive(false);
         rendclos.SetActive(true);
        }
        if(night <= 1)
        {
         rendopen.SetActive(false);
         rendclos.SetActive(true);
        }
        if(home == true)
        {
        if(hellock == 1)
        {
        hellmode.SetActive(true);
        bloood.SetActive(true);
        }
        if(hellock == 0)
        {
        hellmode.SetActive(false);
        bloood.SetActive(false);
        }
        }
        if(home == false)
        {
        redlight.SetActive(true);
        redscreen.SetActive(false);
        bloood.SetActive(false);
        }
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
int layerMask = ~LayerMask.GetMask("Player");
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, detectDistance, layerMask))
        {
            if (hit.collider.CompareTag("secretx"))
            {
                looking = true;
                paso1 = true;
                if(paso2 == true)
                {
                paso2x = true;
                }
                if(paso3 == true)
                {
                paso3x = true;
                }
            }
            else
            {
             looking = false;
            }
        }
     if(looking == false && paso1 == true)
     {
      paso2 = true;
     }
     if(looking == false && paso2x == true)
     {
      paso3 = true;
     }
     if(looking == false && paso3x == true)
     {
      paso4 = true;
     }
     if(paso2 == true && paso3 == false && paso4 == false)
     {
       msg1.SetActive(false);
       msg2.SetActive(true);
       msg3.SetActive(false);
       msg4.SetActive(false);
     }
     if(paso2 == true && paso3 == true && paso4 == false)
     {
       msg1.SetActive(false);
       msg2.SetActive(false);
       msg3.SetActive(true);
       msg4.SetActive(false);
     }
     if(paso2 == true && paso3 == true && paso4 == true)
     {
       msg1.SetActive(false);
       msg2.SetActive(false);
       msg3.SetActive(false);
       msg4.SetActive(true);
     }


    hour = clock.hour;
        if(home == true)
        {
        if (Microphone.devices.Length == 0)
        {
            block.SetActive(true);
            shrt.SetActive(false);
        }
        if (Microphone.devices.Length > 0)
        {
            block.SetActive(false);
            shrt.SetActive(true);
        }
        }
//MANDOS

//Raton-Joystick
if(playst == false && xbox == false)
{
larryx.SetActive(false);
pcwal.SetActive(true);
mndwal.SetActive(false);
}
if(playst == true || xbox == true)
{
pcwal.SetActive(false);
mndwal.SetActive(true);
}
if(larryx.activeInHierarchy)
{
  Cursor.visible = false;
}
if(!larryx.activeInHierarchy && (wino.activeInHierarchy || (homec.activeInHierarchy && !trans.activeInHierarchy) || gam.activeInHierarchy || menu.activeInHierarchy || answ.activeInHierarchy))
{
  Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
}
if(!wino.activeInHierarchy && !homec.activeInHierarchy && !gam.activeInHierarchy && !menu.activeInHierarchy && !answ.activeInHierarchy)
{
larryx.SetActive(false);
}
if(playst == true || xbox == true)
{
if(wino.activeInHierarchy || homec.activeInHierarchy || gam.activeInHierarchy || menu.activeInHierarchy || answ.activeInHierarchy)
{
larryx.SetActive(true);
}

if(larryx.activeInHierarchy)
{
    
}



        if (Gamepad.current == null) return;

        Vector2 move = Gamepad.current.leftStick.ReadValue();
        cursorPos += move * speedj * Time.deltaTime;
        cursorPos.x = Mathf.Clamp(cursorPos.x, 0, Screen.width);
        cursorPos.y = Mathf.Clamp(cursorPos.y, 0, Screen.height);
        larry.position = cursorPos;

        int cursorX = (int)cursorPos.x;
        int cursorY = Screen.height - (int)cursorPos.y;
        SetCursorPos(cursorX, cursorY);

        bool actionPressed = Gamepad.current.buttonSouth.isPressed;

        if (!actionPressed && !isPressing)
        {
Vector2 sticksxx = Gamepad.current.leftStick.ReadValue();
if (sticksxx.magnitude == 0f)
{
larry.GetComponent<Image>().sprite = spriteA;
}
if (sticksxx.magnitude > 0.1f)
{
    if (Mathf.Abs(sticksxx.x) > Mathf.Abs(sticksxx.y))
    {
        if (sticksxx.x > 0) larry.GetComponent<Image>().sprite = spder;
        else larry.GetComponent<Image>().sprite = spizq;        
    }
    else
    {
        if (sticksxx.y > 0) larry.GetComponent<Image>().sprite = sparr;
        else larry.GetComponent<Image>().sprite = spaba;         
    }
}
        }

        if (actionPressed && !isPressing)
        {
larry.GetComponent<Image>().sprite = spriteB;
            isPressing = true;
            startPressPos = cursorPos;
            lastCursorPos = cursorPos;
            isDragging = false;

            pointerData = new PointerEventData(EventSystem.current) { position = cursorPos };
            var results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);
            dragTarget = results.Count > 0 ? results[0].gameObject : null;

            activeSlider = dragTarget != null ? dragTarget.GetComponentInParent<Slider>() : null;
        }

        if (actionPressed && isPressing)
        {
            Vector2 delta = cursorPos - lastCursorPos;

            if (dragTarget != null && delta.magnitude > 0.5f)
            {
                if (!isDragging)
                {
                    isDragging = true;
                    pointerData.position = lastCursorPos;
                    ExecuteEvents.Execute(dragTarget, pointerData, ExecuteEvents.pointerDownHandler);
                }

                pointerData.position = cursorPos;
                pointerData.delta = delta;
                ExecuteEvents.Execute(dragTarget, pointerData, ExecuteEvents.dragHandler);

                if (activeSlider != null)
                    UpdateSliderValue(activeSlider, cursorPos);
            }

            lastCursorPos = cursorPos;
        }

        if (!actionPressed && isPressing)
        {
            isPressing = false;

            if (isDragging && dragTarget != null)
            {
                pointerData.position = cursorPos;
                ExecuteEvents.Execute(dragTarget, pointerData, ExecuteEvents.pointerUpHandler);
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)cursorX, (uint)cursorY, 0, 0);
            }

            dragTarget = null;
            activeSlider = null;
            isDragging = false;
        }

}
        string[] mandosActuales = Input.GetJoystickNames();
        List<string> mandosActualesList = new List<string>(mandosActuales);

        if (!SonIguales(mandosPrevios, mandosActualesList))
        {
            ActualizarEstados(mandosActualesList);
            mandosPrevios = mandosActualesList;
        }



         if(ef.enabled == true)
         {
         lant.SetActive(false);
         }
         if(runnx.activeInHierarchy)
         {
          port.SetActive(false);
         }
         pow = clock.power;


//Flip
if(night >= 4)
{
if(flip == true && !menu.activeInHierarchy)
{
if(hjñ == false)
{
interz.SetActive(true);

if(wl1.activeInHierarchy)
{
flipx.SetActive(true);
}
    Invoke("th2", 30f);
    Invoke("intf", 0.5f);
hjñ = true;
}
}
if(flip == false)
{
flipx.SetActive(false);
hjñ = false;
}
}


//Gravedad 0
if(night >= 3)
{
if(polt == true && kml == false)
{
 rbd.useGravity = false;
        StartCoroutine(ApplyRandomImpulses());
        StartCoroutine(ApplyRandomRotation());
if(kml2 == false)
{
Invoke("th3", 20f);
kml3 = false;
kml2 = true;
}
kml = true;
}

if(polt == false && kml3 == false)
{
rbd.linearVelocity = Vector3.zero;
 kml2 = false;
 rbd.useGravity = true;
 kml3 = true;
}
}


         if(pow <= 0 && dis == false)
         {
         if(safe == false)
         {
       Ll.SetActive(false);
       freeze = true;
       rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
       flss.SetActive(true);
       flss.transform.SetParent(null);
        Invoke("cn1", 2f);
        Invoke("kill", 5f);
        Invoke("gameover", 6f);
        if(klo == false)
        {
        klo = true;
        audioSource.PlayOneShot(sta);
        }
         }
         if(safe == true)
         {
         Invoke("gameover", 0.01f);
         }
         }
         if(xbox == false && playst == false)
         {
         if(Input.GetKeyDown(KeyCode.Q) && penta.activeInHierarchy && fls.activeInHierarchy && !menu.activeInHierarchy)
         {
            hellock = 1f;
            PlayerPrefs.SetFloat("Plus1", hellock);
            PlayerPrefs.Save();
         penta.SetActive(false);
        if (rawImage != null)
            rawImage.enabled = false;
        if (videoPlayer != null)
        {
            videoPlayer.playOnAwake = false;
            videoPlayer.Prepare();
            videoPlayer.prepareCompleted += OnVideoPrepared;
        }
            rawImage.enabled = true;
            videoPlayer.Play();
    audioSource2.PlayOneShot(jsc2);
         Invoke("cnxxx", 0.5f);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         fls.SetActive(false);
         filter.SetActive(true);
         lant.SetActive(true);
         audioSourcex.clip = null;
         audioSource2x.clip = null;
         audioSource3x.clip = null;
         if(!wallsp.activeInHierarchy)
         {
         Invoke("cnx", 2f);
         }
         }
         }
         if(xbox == true || playst == true)
         {
         if(((Input.GetKeyDown(KeyCode.JoystickButton0) && playst == true) || (Input.GetKeyDown(KeyCode.JoystickButton2) && xbox == true)) && penta.activeInHierarchy && fls.activeInHierarchy && !menu.activeInHierarchy)
         {
         penta.SetActive(false);
        if (rawImage != null)
            rawImage.enabled = false;
        if (videoPlayer != null)
        {
            videoPlayer.playOnAwake = false;
            videoPlayer.Prepare();
            videoPlayer.prepareCompleted += OnVideoPrepared;
        }
            rawImage.enabled = true;
            videoPlayer.Play();
    audioSource2.PlayOneShot(jsc2);
         Invoke("cnxxx", 0.5f);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         fls.SetActive(false);
         filter.SetActive(true);
         lant.SetActive(true);
         audioSourcex.clip = null;
         audioSource2x.clip = null;
         audioSource3x.clip = null;
         if(!wallsp.activeInHierarchy)
         {
         Invoke("cnx", 2f);
         }
         }
         }
if(home == true)
{
 audioSource2.Stop();
 audioSource3.Stop();
 audioSourcex.Stop();
 audioSource2x.Stop();
 audioSource3x.Stop();
if (!audioSource.isPlaying && !gameo.activeInHierarchy)
{
 audioSource.Play();
}
  Ll.SetActive(false);
  Cl.SetActive(false);
  if(!gameo.activeInHierarchy && mexico == false)
  {
        Invoke("mus", 0.4f);
  }
}
if(home == false && zxm == false)
{
     audioSource.clip = null;
 zxm = true;
}

if((Input.GetKeyDown(KeyCode.Return) || ((Input.GetKeyDown(KeyCode.JoystickButton0)) || (Input.GetKeyDown(KeyCode.JoystickButton1)))) && credits.activeInHierarchy)
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
if((Input.GetKeyDown(KeyCode.Return) || ((Input.GetKeyDown(KeyCode.JoystickButton0)) || (Input.GetKeyDown(KeyCode.JoystickButton1)))) && skip == true)
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
//Gameplay
if(home == false)
{
  ñal = false;
  Ll.SetActive(true);
  Cl.SetActive(true);
if(porm == true)
{
        por.transform.position += Vector3.right * velocidad * Time.deltaTime;
}
if(parm == true)
{
        par.transform.position += Vector3.right * velocidad2 * Time.deltaTime;
}
if(parm == false && porm == false && bjp == false)
{
porx.enabled = true;
parx.enabled = true;
           porx.SetTrigger("mv2");
           parx.SetTrigger("ch2");
porx.enabled = false;
parx.enabled = false;
bjp = true;
}
if(wino.activeInHierarchy)
{
home = true;
        Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
}
if (!audioSource2.isPlaying)
{
 audioSource2.Play();
}
if (!audioSource3.isPlaying)
{
 audioSource3.Play();
}
if (!audioSourcex.isPlaying)
{
 audioSourcex.Play();
}
if (!audioSource2x.isPlaying)
{
 audioSource2x.Play();
}
if (!audioSource3x.isPlaying)
{
 audioSource3x.Play();
}
     if(cam.activeInHierarchy && !stat.activeInHierarchy)
     {
     audioSourcex.clip = inf1;
     audioSourcex.loop = true;
     }
     if(cam.activeInHierarchy && stat.activeInHierarchy)
     {
     audioSourcex.clip = inf2;
     audioSourcex.loop = true;
     }
if(!penta.activeInHierarchy)
{
     if(tut == true && !cam.activeInHierarchy)
     {
     audioSourcex.clip = null;
     }

     audioSource3.clip = null;
}
if(menu.activeInHierarchy)
{
moving = false;
           anim.SetTrigger("wlk2");
           anim.SetTrigger("cr2");
           anim.SetTrigger("rn2");
}
        freeze2 = freeze;
        if(rsp == true)
        {
         if(Input.GetKeyDown(KeyCode.Z) || (Input.GetKeyDown(KeyCode.JoystickButton1) && playst == true) || (Input.GetKeyDown(KeyCode.JoystickButton1) && xbox == true))
         {
           audioSourcex.clip = null;
           Invoke("p3", 2f);
           nod = true;
         textol.text = "";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
           rsp = false;
            texm = true;
         }
         if(Input.GetKeyDown(KeyCode.X) || (Input.GetKeyDown(KeyCode.JoystickButton2) && playst == true) || (Input.GetKeyDown(KeyCode.JoystickButton2) && xbox == true))
         {
           tut = true;
           anim2.SetTrigger("dw");
           Invoke("p2y", 0.2f);
           audioSourcex.clip = null;
         textol.text = "";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
           rsp = false;
         }
        }
        if(night > 1)
        {
         tut = true;
        }
        if(night == 1 && tut == false && zñ == false)
        {
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        Invoke("p1", 2f);
        zñ = true;      
        }
             if ((Input.GetKeyDown(KeyCode.Return) || ((Input.GetKeyDown(KeyCode.JoystickButton1) && playst == true) || (Input.GetKeyDown(KeyCode.JoystickButton1) && xbox == true))) && name == false && texm == true && nod == false && answer == false)
             {
              speed2 = 0.03f;
              textorder += 1;
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
             }
             if ((Input.GetKeyDown(KeyCode.Return) || ((Input.GetKeyDown(KeyCode.JoystickButton1) && playst == true) || (Input.GetKeyDown(KeyCode.JoystickButton1) && xbox == true))) && name == false && texm == true && nod == false && answer == true)
             {
             Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
             answ.SetActive(true);
             }
             if ((Input.GetKeyDown(KeyCode.Return) || ((Input.GetKeyDown(KeyCode.JoystickButton1) && playst == true) || (Input.GetKeyDown(KeyCode.JoystickButton1) && xbox == true))) && name == true && texm == true)
             {
              speed2 /= 6;
             }
             if(textorder == -133 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "Huh? Sorry, I was thinking about something...";
}
if(idioma == "español")
{
    textsp2 = "Eh? Perdon, estaba pensando en algo...";
}
if(idioma == "frances")
{
    textsp2 = "Hein ? Desolee, je pensais a quelque chose...";
}
if(idioma == "aleman")
{
    textsp2 = "Ha? Tut mir leid, ich war in Gedanken...";
}
if(idioma == "italiano")
{
    textsp2 = "Eh? Scusa, stavo pensando a qualcosa...";
}
if(idioma == "portugues")
{
    textsp2 = "Ha? Desculpa, eu estava pensando em algo...";
}
if(idioma == "japones")
{
    textsp2 = "え？ごめん、ちょっと考え事をしてて...";
}
if(idioma == "coreano")
{
    textsp2 = "어? 미안, 잠깐 딴생각을 했어...";
}
if(idioma == "chino")
{
    textsp2 = "嗯？抱歉，我刚刚在想事情...";
}
if(idioma == "ruso")
{
    textsp2 = "А? Прости, я задумалась...";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -132 && writing == true)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "Hey, can I tell you something?";
}
if(idioma == "español")
{
    textsp2 = "Oye, puedo decirte algo?";
}
if(idioma == "frances")
{
    textsp2 = "He, je peux te dire quelque chose ?";
}
if(idioma == "aleman")
{
    textsp2 = "Hey, kann ich dir etwas sagen?";
}
if(idioma == "italiano")
{
    textsp2 = "Ehi, posso dirti una cosa?";
}
if(idioma == "portugues")
{
    textsp2 = "Ei, posso te dizer uma coisa?";
}
if(idioma == "japones")
{
    textsp2 = "ねえ、ちょっと話してもいい？";
}
if(idioma == "coreano")
{
    textsp2 = "저기, 나 너한테 할 말이 있어";
}
if(idioma == "chino")
{
    textsp2 = "喂，我可以跟你说件事吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Эй, можно я тебе кое-что скажу?";
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -131 && writing == false)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "You know... they say people die twice...";
}
if(idioma == "español")
{
    textsp2 = "Sabes... dicen que las personas mueren dos veces...";
}
if(idioma == "frances")
{
    textsp2 = "Tu sais... on dit que les gens meurent deux fois...";
}
if(idioma == "aleman")
{
    textsp2 = "Weißt du... man sagt, dass Menschen zweimal sterben...";
}
if(idioma == "italiano")
{
    textsp2 = "Sai... dicono che le persone muoiono due volte...";
}
if(idioma == "portugues")
{
    textsp2 = "Sabe... dizem que as pessoas morrem duas vezes...";
}
if(idioma == "japones")
{
    textsp2 = "ねえ...人は二度死ぬって言うよね...";
}
if(idioma == "coreano")
{
    textsp2 = "있잖아... 사람은 두 번 죽는다고 하잖아...";
}
if(idioma == "chino")
{
    textsp2 = "你知道吗...人们常说，人会死两次...";
}
if(idioma == "ruso")
{
    textsp2 = "Знаешь... говорят, что человек умирает дважды...";
}

             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -130 && writing == true)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "Once when they die...";
}
if(idioma == "español")
{
    textsp2 = "Una cuando mueren...";
}
if(idioma == "frances")
{
    textsp2 = "Une fois quand ils meurent...";
}
if(idioma == "aleman")
{
    textsp2 = "Einmal, wenn sie sterben...";
}
if(idioma == "italiano")
{
    textsp2 = "Una volta quando muoiono...";
}
if(idioma == "portugues")
{
    textsp2 = "Uma vez quando morrem...";
}
if(idioma == "japones")
{
    textsp2 = "一度目は、死ぬとき...";
}
if(idioma == "coreano")
{
    textsp2 = "한 번은 죽을 때...";
}
if(idioma == "chino")
{
    textsp2 = "一次是在他们死去的时候...";
}
if(idioma == "ruso")
{
    textsp2 = "Один раз — когда они умирают...";
}

             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -129 && writing == false)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "And another when someone says your name for the last time...";
}
if(idioma == "español")
{
    textsp2 = "Y otra cuando alguien dice tu nombre por ultima vez...";
}
if(idioma == "frances")
{
    textsp2 = "Et une autre quand quelqu'un prononce ton nom pour la derniere fois...";
}
if(idioma == "aleman")
{
    textsp2 = "Und ein weiteres Mal, wenn jemand deinen Namen zum letzten Mal ausspricht...";
}
if(idioma == "italiano")
{
    textsp2 = "E un'altra quando qualcuno pronuncia il tuo nome per l'ultima volta...";
}
if(idioma == "portugues")
{
    textsp2 = "E outra quando alguem diz o seu nome pela ultima vez...";
}
if(idioma == "japones")
{
    textsp2 = "そしてもう一度は、誰かが君の名前を最後に口にするとき...";
}
if(idioma == "coreano")
{
    textsp2 = "그리고 또 한 번은, 누군가가 네 이름을 마지막으로 말할 때야...";
}
if(idioma == "chino")
{
    textsp2 = "还有一次，是当有人最后一次说出你的名字时...";
}
if(idioma == "ruso")
{
    textsp2 = "И ещё раз — когда кто-то произносит твоё имя в последний раз...";
}

             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -128 && writing == true)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "They actually die three times. Spirits die and reincarnate";
}
if(idioma == "español")
{
    textsp2 = "En realidad mueren tres veces. Los espiritus mueren y se reencarnan";
}
if(idioma == "frances")
{
    textsp2 = "En realite, ils meurent trois fois. Les esprits meurent et se reincarnent";
}
if(idioma == "aleman")
{
    textsp2 = "Eigentlich sterben sie drei Mal. Geister sterben und werden wiedergeboren";
}
if(idioma == "italiano")
{
    textsp2 = "In realta muoiono tre volte. Gli spiriti muoiono e si reincarnano";
}
if(idioma == "portugues")
{
    textsp2 = "Na verdade, eles morrem tres vezes. Os espiritos morrem e reencarnam";
}
if(idioma == "japones")
{
    textsp2 = "実は三度死ぬ。魂は死に、そして転生する";
}
if(idioma == "coreano")
{
    textsp2 = "사실 그들은 세 번 죽어. 영혼은 죽고, 다시 환생해";
}
if(idioma == "chino")
{
    textsp2 = "实际上，他们会死三次。灵魂会死亡，然后转生";
}
if(idioma == "ruso")
{
    textsp2 = "На самом деле они умирают трижды. Духи умирают и перерождаются";
}

             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -127 && writing == false)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "If I have to die two physical times...";
}
if(idioma == "español")
{
    textsp2 = "Si tengo que morir dos veces de forma fisica...";
}
if(idioma == "frances")
{
    textsp2 = "Si je dois mourir deux fois physiquement...";
}
if(idioma == "aleman")
{
    textsp2 = "Wenn ich zwei Mal korperlich sterben muss...";
}
if(idioma == "italiano")
{
    textsp2 = "Se devo morire due volte fisicamente...";
}
if(idioma == "portugues")
{
    textsp2 = "Se eu tiver que morrer duas vezes fisicamente...";
}
if(idioma == "japones")
{
    textsp2 = "もし肉体として二度死ななければならないのなら...";
}
if(idioma == "coreano")
{
    textsp2 = "만약 내가 육체적으로 두 번 죽어야 한다면...";
}
if(idioma == "chino")
{
    textsp2 = "如果我必须在肉体上死去两次...";
}
if(idioma == "ruso")
{
    textsp2 = "Если мне предстоит умереть физически дважды...";
}

             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -126 && writing == true)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "I don't want to die a third...";
}
if(idioma == "español")
{
    textsp2 = "No quiero morir una tercera vez...";
}
if(idioma == "frances")
{
    textsp2 = "Je ne veux pas mourir une troisieme fois...";
}
if(idioma == "aleman")
{
    textsp2 = "Ich will kein drittes Mal sterben...";
}
if(idioma == "italiano")
{
    textsp2 = "Non voglio morire una terza volta...";
}
if(idioma == "portugues")
{
    textsp2 = "Nao quero morrer uma terceira vez...";
}
if(idioma == "japones")
{
    textsp2 = "三度目の死は迎えたくない...";
}
if(idioma == "coreano")
{
    textsp2 = "세 번째 죽음은 맞이하고 싶지 않아...";
}
if(idioma == "chino")
{
    textsp2 = "我不想迎来第三次死亡...";
}
if(idioma == "ruso")
{
    textsp2 = "Я не хочу умирать в третий раз...";
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -125 && writing == false)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "...Will you remember my name when I'm no longer here to hear it?...";
}
if(idioma == "español")
{
    textsp2 = "...Recordaras mi nombre cuando ya no este aqui para escucharlo?...";
}
if(idioma == "frances")
{
    textsp2 = "...Te souviendras-tu de mon nom quand je ne serai plus la pour l'entendre ?...";
}
if(idioma == "aleman")
{
    textsp2 = "...Wirst du dich an meinen Namen erinnern, wenn ich nicht mehr hier bin, um ihn zu horen?...";
}
if(idioma == "italiano")
{
    textsp2 = "...Ti ricorderai del mio nome quando non saro piu qui per sentirlo?...";
}
if(idioma == "portugues")
{
    textsp2 = "...Voce se lembrara do meu nome quando eu nao estiver mais aqui para ouvi-lo?...";
}
if(idioma == "japones")
{
    textsp2 = "...私がもう聞くことのできない場所に行っても、私の名前を覚えていてくれる？...";
}
if(idioma == "coreano")
{
    textsp2 = "...내가 더 이상 들을 수 없게 되어도, 내 이름을 기억해 줄래?...";
}
if(idioma == "chino")
{
    textsp2 = "...当我不再能听见的时候，你还会记得我的名字吗？...";
}
if(idioma == "ruso")
{
    textsp2 = "...Ты будешь помнить мое имя, когда меня больше не будет рядом, чтобы его услышать?...";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -124 && writing == true)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "Sorry, I'm being stupid, aren't I?";
}
if(idioma == "español")
{
    textsp2 = "Lo siento, estoy siendo estupida, verdad?";
}
if(idioma == "frances")
{
    textsp2 = "Desolee, je suis stupide, n'est-ce pas ?";
}
if(idioma == "aleman")
{
    textsp2 = "Tut mir leid, ich benehme mich dumm, oder?";
}
if(idioma == "italiano")
{
    textsp2 = "Scusa, sto dicendo sciocchezze, vero?";
}
if(idioma == "portugues")
{
    textsp2 = "Desculpa, estou sendo boba, nao e?";
}
if(idioma == "japones")
{
    textsp2 = "...ごめん、私、バカなこと言ってるよね？";
}
if(idioma == "coreano")
{
    textsp2 = "미안... 내가 바보 같은 말 하고 있지?";
}
if(idioma == "chino")
{
    textsp2 = "...对不起，我是不是很蠢？";
}
if(idioma == "ruso")
{
    textsp2 = "Извини... я ведь говорю глупости, да?";
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -77 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "Um... You're broke, mate";
}
if(idioma == "español")
{
    textsp2 = "Esto... Estas sin blanca, colega";
}
if(idioma == "frances")
{
    textsp2 = "Euh... T'es fauche, mec";
}
if(idioma == "aleman")
{
    textsp2 = "Ahm... Du bist pleite, Kumpel";
}
if(idioma == "italiano")
{
    textsp2 = "Ehm... Sei al verde, amico";
}
if(idioma == "portugues")
{
    textsp2 = "Hum... Voce esta sem grana, colega";
}
if(idioma == "japones")
{
    textsp2 = "えっと... お金がないね、友よ";
}
if(idioma == "coreano")
{
    textsp2 = "음... 너 완전 무일푼이구나, 친구";
}
if(idioma == "chino")
{
    textsp2 = "这个... 你没钱啊，哥们";
}
if(idioma == "ruso")
{
    textsp2 = "Эээ... Ты на мели, дружище";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -76 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        texm = false;
             writing = false;
             freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
             texm = false;
             }

             if(textorder == -123 && writing == false)
             {
timestop = false;
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "Let's see...";
}
if(idioma == "español")
{
    textsp2 = "Veamos...";
}
if(idioma == "frances")
{
    textsp2 = "Voyons...";
}
if(idioma == "aleman")
{
    textsp2 = "Mal sehen...";
}
if(idioma == "italiano")
{
    textsp2 = "Vediamo...";
}
if(idioma == "portugues")
{
    textsp2 = "Vejamos...";
}
if(idioma == "japones")
{
    textsp2 = "さて...";
}
if(idioma == "coreano")
{
    textsp2 = "어디 보자...";
}
if(idioma == "chino")
{
    textsp2 = "让我看看...";
}
if(idioma == "ruso")
{
    textsp2 = "Посмотрим...";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -122 && writing == true)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(luck == 0)
{
if(idioma == "ingles")
{
    textsp2 = "A terrible fate awaits you";
}
if(idioma == "español")
{
    textsp2 = "Te acecha un terrible destino";
}
if(idioma == "frances")
{
    textsp2 = "Un terrible destin t'attend";
}
if(idioma == "aleman")
{
    textsp2 = "Ein schreckliches Schicksal erwartet dich";
}
if(idioma == "italiano")
{
    textsp2 = "Un terribile destino ti attende";
}
if(idioma == "portugues")
{
    textsp2 = "Um terrivel destino te aguarda";
}
if(idioma == "japones")
{
    textsp2 = "恐ろしい運命が君を待っている";
}
if(idioma == "coreano")
{
    textsp2 = "끔찍한 운명이 너를 기다리고 있어";
}
if(idioma == "chino")
{
    textsp2 = "可怕的命运正等待着你";
}
if(idioma == "ruso")
{
    textsp2 = "Тебя ждёт ужасная судьба";
}
}

if(luck == 1)
{
if(idioma == "ingles")
{
    textsp2 = "You will find a light in the darkness";
}
if(idioma == "español")
{
    textsp2 = "Encontraras una luz en la oscuridad";
}
if(idioma == "frances")
{
    textsp2 = "Tu trouveras une lumiere dans l'obscurite";
}
if(idioma == "aleman")
{
    textsp2 = "Du wirst ein Licht in der Dunkelheit finden";
}
if(idioma == "italiano")
{
    textsp2 = "Troverai una luce nell'oscurita";
}
if(idioma == "portugues")
{
    textsp2 = "Voce encontrara uma luz na escuridao";
}
if(idioma == "japones")
{
    textsp2 = "闇の中に光を見つけるだろう";
}
if(idioma == "coreano")
{
    textsp2 = "어둠 속에서 빛을 찾게 될 거야";
}
if(idioma == "chino")
{
    textsp2 = "你会在黑暗中找到一束光";
}
if(idioma == "ruso")
{
    textsp2 = "Ты найдёшь свет во тьме";
}
}

if(luck == 2 || luck == 3)
{
if(idioma == "ingles")
{
    textsp2 = "Your future is very interesting";
}
if(idioma == "español")
{
    textsp2 = "Tu futuro es muy interesante";
}
if(idioma == "frances")
{
    textsp2 = "Ton avenir est tres interessant";
}
if(idioma == "aleman")
{
    textsp2 = "Deine Zukunft ist sehr interessant";
}
if(idioma == "italiano")
{
    textsp2 = "Il tuo futuro e molto interessante";
}
if(idioma == "portugues")
{
    textsp2 = "Seu futuro e muito interessante";
}
if(idioma == "japones")
{
    textsp2 = "君の未来はとても興味深い";
}
if(idioma == "coreano")
{
    textsp2 = "너의 미래는 정말 흥미로워";
}
if(idioma == "chino")
{
    textsp2 = "你的未来非常有意思";
}
if(idioma == "ruso")
{
    textsp2 = "Твоё будущее очень интересное";
}
}

if(luck == 4)
{
if(idioma == "ingles")
{
    textsp2 = "There are shadows in your future, but everything will be fine if you don't give up";
}
if(idioma == "español")
{
    textsp2 = "Hay sombras en tu futuro, pero todo ira bien si no te rindes";
}
if(idioma == "frances")
{
    textsp2 = "Il y a des ombres dans ton avenir, mais tout ira bien si tu n'abandonnes pas";
}
if(idioma == "aleman")
{
    textsp2 = "Es gibt Schatten in deiner Zukunft, aber alles wird gut, wenn du nicht aufgibst";
}
if(idioma == "italiano")
{
    textsp2 = "Ci sono ombre nel tuo futuro, ma andra tutto bene se non ti arrendi";
}
if(idioma == "portugues")
{
    textsp2 = "Ha sombras no seu futuro, mas tudo vai ficar bem se voce nao desistir";
}
if(idioma == "japones")
{
    textsp2 = "君の未来には影があるが、諦めなければきっとうまくいく";
}
if(idioma == "coreano")
{
    textsp2 = "네 미래에는 그림자가 있지만, 포기하지 않으면 다 잘될 거야";
}
if(idioma == "chino")
{
    textsp2 = "你的未来有阴影，但只要你不放弃，一切都会好起来";
}
if(idioma == "ruso")
{
    textsp2 = "В твоём будущем есть тени, но всё будет хорошо, если ты не сдашься";
}
}

if(luck == 5)
{
if(idioma == "ingles")
{
    textsp2 = "A promising future awaits you";
}
if(idioma == "español")
{
    textsp2 = "Te aguarda un futuro prometedor";
}
if(idioma == "frances")
{
    textsp2 = "Un avenir prometteur t'attend";
}
if(idioma == "aleman")
{
    textsp2 = "Eine vielversprechende Zukunft erwartet dich";
}
if(idioma == "italiano")
{
    textsp2 = "Un futuro promettente ti attende";
}
if(idioma == "portugues")
{
    textsp2 = "Um futuro promissor te aguarda";
}
if(idioma == "japones")
{
    textsp2 = "希望に満ちた未来が君を待っている";
}
if(idioma == "coreano")
{
    textsp2 = "희망찬 미래가 너를 기다리고 있어";
}
if(idioma == "chino")
{
    textsp2 = "一个充满希望的未来在等着你";
}
if(idioma == "ruso")
{
    textsp2 = "Тебя ждёт многообещающее будущее";
}
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -121 && writing == false)
             {
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
if(idioma == "ingles")
{
    textsp2 = "See it for yourself";
}
if(idioma == "español")
{
    textsp2 = "Miralo tu mismo";
}
if(idioma == "frances")
{
    textsp2 = "Regarde par toi-meme";
}
if(idioma == "aleman")
{
    textsp2 = "Sieh es dir selbst an";
}
if(idioma == "italiano")
{
    textsp2 = "Guardalo tu stesso";
}
if(idioma == "portugues")
{
    textsp2 = "Veja por si mesmo";
}
if(idioma == "japones")
{
    textsp2 = "自分の目で確かめてみろ";
}
if(idioma == "coreano")
{
    textsp2 = "직접 확인해 봐";
}
if(idioma == "chino")
{
    textsp2 = "你自己看看吧";
}
if(idioma == "ruso")
{
    textsp2 = "Посмотри сам";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -120 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        texm = false;
             writing = false;
             texm = false;
           crd.SetTrigger("up");
        Invoke("O1", 1f);
        Invoke("O22", 4f);
    audioSource.PlayOneShot(cardf);
             }


             if(textorder == 1 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Gran";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Abu";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mamie";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Oma";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Nonna";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vo";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ばあば";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "할매";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "奶";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Бабуля";
}
         textod.text = "";
         textojd.text = "";
         textokd.text = "";
         textocd.text = "";
         textord.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "Hello? Hello hello?";
         }
         if(idioma == "español")
         {
         textsp2 = "Hola? Hola hola?";
         }
         if(idioma == "frances")
         {
         textsp2 = "Allo? Allo allo?";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Hallo? Hallo hallo?";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Ciao? Ciao ciao?";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Ola? Ola ola?";
         }
         if(idioma == "japones")
         {
         textsp2 = "こんにちは？こんにちは、こんにちは？";
         }
         if(idioma == "coreano")
         {
         textsp2 = "안녕하세요? 안녕하세요 안녕하세요?";
         }
         if(idioma == "chino")
         {
         textsp2 = "喂？喂喂？";
         }
         if(idioma == "ruso")
         {
         textsp2 = "Алло? Алло Алло?";
         }
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 2 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "You called me earlier because you said there was a ghost in the house, right?";
         }
         if(idioma == "español")
         {
         textsp2 = "Me habias llamado antes porque decias que habia un fantasma en casa no?";
         }
         if(idioma == "frances")
         {
         textsp2 = "Tu m as appele avant parce que tu as dit qu il y avait un fantôme dans la maison, n est-ce pas?";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Du hast mich vorhin angerufen, weil du gesagt hast, dass ein Geist im Haus sei, richtig?";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Mi hai chiamato prima perche hai detto che c era un fantasma in casa, giusto?";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Voce me ligou antes porque disse que tinha um fantasma na casa, certo?";
         }
         if(idioma == "japones")
         {
         textsp2 = "前に家に幽霊が出ると言って電話してきたよね？";
         }
         if(idioma == "coreano")
         {
         textsp2 = "전에 집에 유령이 있다고 전화하셨죠?";
         }
         if(idioma == "chino")
         {
         textsp2 = "你之前打电话给我是因为你说房子里有鬼，对吗？";
         }
         if(idioma == "ruso")
         {
         textsp2 = "Ты мне уже звонил, потому что сказал, что в доме есть привидение, да?";
         }
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 3 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "It's La Llorona, my mother used to tell me stories about her";
         }
         if(idioma == "español")
         {
         textsp2 = "Es la Llorona, mi madre solia contarme historias sobre ella";
         }
         if(idioma == "frances")
         {
         textsp2 = "C'est La Llorona, ma mere me racontait des histoires à son sujet.";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Es ist La Llorona, meine Mutter hat mir immer Geschichten uber sie erzahlt.";
         }
         if(idioma == "italiano")
         {
         textsp2 = "E La Llorona, mia madre mi raccontava sempre storie su di lei.";
         }
         if(idioma == "portugues")
         {
         textsp2 = "E La Llorona, minha mae costumava me contar historias sobre ela.";
         }
         if(idioma == "japones")
         {
         textsp2 = "それはラ・ヨローナです。私の母は彼女についての物語を私によく話してくれました。";
         }
         if(idioma == "coreano")
         {
         textsp2 = "이곳은 라 요로나입니다. 어머니께서 늘 그녀에 대한 이야기를 들려주시곤 했습니다.";
         }
         if(idioma == "chino")
         {
         textsp2 = "这是《哭泣的女人》，我的母亲曾经给我讲过关于她的故事。";
         }
         if(idioma == "ruso")
         {
         textsp2 = "Это Ла Йорона, моя мама рассказывала мне истории о ней.";
         }
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 4 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "A ghost who wanders the streets in search of his children";
         }
         if(idioma == "español")
         {
         textsp2 = "Un fantasma que vaga por las calles en busca de sus hijos";
         }
         if(idioma == "frances")
         {
         textsp2 = "Un fantome qui erre dans les rues a la recherche de ses enfants";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Ein Geist, der auf der Suche nach seinen Kindern durch die Straßen wandert";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Un fantasma che vaga per le strade in cerca dei suoi figli";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Um fantasma que vagueia pelas ruas em busca de seus filhos";
         }
         if(idioma == "japones")
         {
         textsp2 = "子供たちを探して街をさまよう幽霊";
         }
         if(idioma == "coreano")
         {
         textsp2 = "자식을 찾아 거리를 헤매는 유령";
         }
         if(idioma == "chino")
         {
         textsp2 = "一个在街上游荡寻找孩子的鬼魂";
         }
         if(idioma == "ruso")
         {
         textsp2 = "Призрак, который бродит по улицам в поисках своих детей.";
         }
             StartCoroutine(writex());
             writing = false;
             }


             if(textorder == -10 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "It's a shame, you know? I was starting to like you";
}
if(idioma == "español")
{
    textsp2 = "Es una lastima, sabes? Empezabas a caerme bien";
}
if(idioma == "frances")
{
    textsp2 = "C'est dommage, tu sais ? Je commencais a t'apprecier";
}
if(idioma == "aleman")
{
    textsp2 = "Es ist schade, weißt du? Du fingst an, mir sympathisch zu werden";
}
if(idioma == "italiano")
{
    textsp2 = "E un peccato, sai? Avevo iniziato a trovarti simpatico";
}
if(idioma == "portugues")
{
    textsp2 = "E uma pena, sabia? Eu estava comecando a gostar de voce";
}
if(idioma == "japones")
{
    textsp2 = "残念だよ、わかる？君のこと少し好きになり始めてたんだ";
}
if(idioma == "coreano")
{
    textsp2 = "안타깝네요, 알죠? 당신이 조금 좋아지기 시작했는데";
}
if(idioma == "chino")
{
    textsp2 = "真可惜，你知道吗？我开始有点喜欢你了";
}
if(idioma == "ruso")
{
    textsp2 = "Жаль, знаешь? Ты начинал мне нравиться";
}
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == -9 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "At least until you decided to drop your good-person facade and act like paying wasn’t necessary";
}
if(idioma == "español")
{
    textsp2 = "Al menos hasta que decidiste quitar tu fachada de buena persona y que pagar no era necesario";
}
if(idioma == "frances")
{
    textsp2 = "Au moins jusqu'a ce que tu decides d'abandonner ta facade de bonne personne et de faire comme si payer n'etait pas necessaire";
}
if(idioma == "aleman")
{
    textsp2 = "Zumindest bis du beschlossen hast, deine Gutmenschen-Fassade fallenzulassen und so zu tun, als ware es nicht notig zu bezahlen";
}
if(idioma == "italiano")
{
    textsp2 = "Almeno fino a quando hai deciso di togliere la tua facciata da brava persona e comportarti come se pagare non fosse necessario";
}
if(idioma == "portugues")
{
    textsp2 = "Pelo menos ate voce decidir tirar sua fachada de boa pessoa e agir como se pagar nao fosse necessario";
}
if(idioma == "japones")
{
    textsp2 = "少なくとも、君が“良い人”の仮面を外して、支払う必要なんてないと言わんばかりの態度を見せるまではね";
}
if(idioma == "coreano")
{
    textsp2 = "적어도 네가 착한 사람인 척하던 가면을 벗고, 돈을 낼 필요도 없다는 듯 행동하기 전까지는 말이야";
}
if(idioma == "chino")
{
    textsp2 = "至少在你决定摘下“好人”的伪装，并表现得好像不需要付钱之前是这样";
}
if(idioma == "ruso")
{
    textsp2 = "По крайней мере, пока ты не решил снять свою маску «хорошего человека» и вести себя так, будто платить вовсе не обязательно";
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -8 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I hate people like you";
}
if(idioma == "español")
{
    textsp2 = "Odio a las personas como tu";
}
if(idioma == "frances")
{
    textsp2 = "Je deteste les gens comme toi";
}
if(idioma == "aleman")
{
    textsp2 = "Ich hasse Menschen wie dich";
}
if(idioma == "italiano")
{
    textsp2 = "Odio le persone come te";
}
if(idioma == "portugues")
{
    textsp2 = "Eu odeio pessoas como voce";
}
if(idioma == "japones")
{
    textsp2 = "君みたいな人間が大嫌いだ";
}
if(idioma == "coreano")
{
    textsp2 = "너 같은 사람은 정말 싫어";
}
if(idioma == "chino")
{
    textsp2 = "我讨厌像你这样的人";
}
if(idioma == "ruso")
{
    textsp2 = "Я ненавижу таких людей, как ты";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -7 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I hate that my daughter has to live in the same world as scum like you";
}
if(idioma == "español")
{
    textsp2 = "Odio que mi hija tenga que vivir en el mismo mundo que escoria como tu";
}
if(idioma == "frances")
{
    textsp2 = "Je deteste que ma fille doive vivre dans le meme monde que de la vermine comme toi";
}
if(idioma == "aleman")
{
    textsp2 = "Ich hasse es, dass meine Tochter in derselben Welt leben muss wie Abschaum wie du";
}
if(idioma == "italiano")
{
    textsp2 = "Odio che mia figlia debba vivere nello stesso mondo della feccia come te";
}
if(idioma == "portugues")
{
    textsp2 = "Eu odeio que minha filha tenha que viver no mesmo mundo que escoria como voce";
}
if(idioma == "japones")
{
    textsp2 = "娘がお前みたいなクズと同じ世界で生きなきゃいけないなんて大嫌いだ";
}
if(idioma == "coreano")
{
    textsp2 = "내 딸이 너 같은 쓰레기와 같은 세상에서 살아야 한다는 게 정말 싫다";
}
if(idioma == "chino")
{
    textsp2 = "我讨厌我的女儿必须和像你这样的渣滓生活在同一个世界";
}
if(idioma == "ruso")
{
    textsp2 = "Ненавижу, что моей дочери приходится жить в одном мире с таким отребьем, как ты";
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -6 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "This world has already done more than enough to her without people like you coming to make things worse";
}
if(idioma == "español")
{
    textsp2 = "Este mundo ya le ha hecho mas que suficiente como para que gente como tu tenga que venir a empeorar las cosas";
}
if(idioma == "frances")
{
    textsp2 = "Ce monde lui en a deja fait bien assez sans que des gens comme toi viennent empirer les choses";
}
if(idioma == "aleman")
{
    textsp2 = "Diese Welt hat ihr schon mehr als genug angetan, ohne dass Leute wie du kommen müssen, um alles noch schlimmer zu machen";
}
if(idioma == "italiano")
{
    textsp2 = "Questo mondo le ha già fatto fin troppo, senza che gente come te venga a peggiorare le cose";
}
if(idioma == "portugues")
{
    textsp2 = "Este mundo ja fez mais do que o suficiente com ela, sem que gente como voce venha piorar ainda mais as coisas";
}
if(idioma == "japones")
{
    textsp2 = "この世界はすでに彼女に十分すぎるほどの苦しみを与えたのに、お前みたいな奴が来てさらに悪化させる必要はない";
}
if(idioma == "coreano")
{
    textsp2 = "이 세상은 이미 그녀에게 충분할 만큼 상처를 줬어. 너 같은 인간이 와서 더 악화시킬 필요는 없어";
}
if(idioma == "chino")
{
    textsp2 = "这个世界已经给了她足够多的痛苦了，不需要像你这样的人来让事情变得更糟";
}
if(idioma == "ruso")
{
    textsp2 = "Этот мир уже причинил ей более чем достаточно, и людям вроде тебя не обязательно приходить, чтобы сделать всё ещё хуже";
}
             StartCoroutine(writex());
             writing = true;
             }


             if(textorder == -5 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "You disgust me";
}
if(idioma == "español")
{
    textsp2 = "Me das asco";
}
if(idioma == "frances")
{
    textsp2 = "Tu me degoutes";
}
if(idioma == "aleman")
{
    textsp2 = "Du ekelst mich an";
}
if(idioma == "italiano")
{
    textsp2 = "Mi fai schifo";
}
if(idioma == "portugues")
{
    textsp2 = "Voce me da nojo";
}
if(idioma == "japones")
{
    textsp2 = "あなたには吐き気がする";
}
if(idioma == "coreano")
{
    textsp2 = "너 정말 역겨워";
}
if(idioma == "chino")
{
    textsp2 = "你让我恶心";
}
if(idioma == "ruso")
{
    textsp2 = "Ты вызываешь у меня отвращение";
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == -4 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "That's why I try to cleanse this world, so my daughter can one day go outside without fear";
}
if(idioma == "español")
{
    textsp2 = "Es por eso que intento limpiar este mundo, para que mi hija pueda algun dia salir sin miedo";
}
if(idioma == "frances")
{
    textsp2 = "C'est pour cela que j'essaie de purifier ce monde, pour que ma fille puisse un jour sortir sans peur";
}
if(idioma == "aleman")
{
    textsp2 = "Deshalb versuche ich, diese Welt zu reinigen, damit meine Tochter eines Tages ohne Angst hinausgehen kann";
}
if(idioma == "italiano")
{
    textsp2 = "Ecco perche cerco di ripulire questo mondo, affinche mia figlia possa un giorno uscire senza paura";
}
if(idioma == "portugues")
{
    textsp2 = "E por isso que tento limpar este mundo, para que minha filha possa um dia sair sem medo";
}
if(idioma == "japones")
{
    textsp2 = "だからこそ、この世界を浄化しようとしているんだ。いつか娘が恐れずに外に出られるように";
}
if(idioma == "coreano")
{
    textsp2 = "그래서 나는 이 세상을 깨끗이 하려고 하는 거야. 언젠가 내 딸이 두려움 없이 밖에 나갈 수 있도록";
}
if(idioma == "chino")
{
    textsp2 = "正因如此我才努力净化这个世界，好让我的女儿有一天能无所畏惧地走出去";
}
if(idioma == "ruso")
{
    textsp2 = "Вот почему я пытаюсь очистить этот мир, чтобы моя дочь однажды смогла выйти без страха";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == -3 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I would do anything to see my daughter smile again, and if catching people who lie and hurt others helps even a little, then that's what I'll do";
}
if(idioma == "español")
{
    textsp2 = "Haria lo que fuera por ver a mi hija sonreir de nuevo, y si atrapar a la gente que miente y lastima a otros ayuda aunque sea un poco, entonces eso hare";
}
if(idioma == "frances")
{
    textsp2 = "Je ferais n'importe quoi pour revoir ma fille sourire, et si attraper les gens qui mentent et blessent les autres aide ne serait-ce qu'un peu, alors c'est ce que je ferai";
}
if(idioma == "aleman")
{
    textsp2 = "Ich wurde alles tun, um meine Tochter wieder lächeln zu sehen, und wenn es auch nur ein wenig hilft, Menschen zu fangen, die lugen und anderen schaden, dann werde ich genau das tun";
}
if(idioma == "italiano")
{
    textsp2 = "Farei qualsiasi cosa per rivedere il sorriso di mia figlia, e se catturare chi mente e fa del male agli altri aiuta anche solo un po', allora e quello che faro";
}
if(idioma == "portugues")
{
    textsp2 = "Eu faria qualquer coisa para ver minha filha sorrir de novo, e se capturar pessoas que mentem e machucam os outros ajudar nem que seja um pouco, entao e isso que farei";
}
if(idioma == "japones")
{
    textsp2 = "娘がもう一度笑えるなら、僕は何だってする。嘘をつき、人を傷つける連中を捕まえることが少しでも役に立つのなら、僕はそうするだけだ";
}
if(idioma == "coreano")
{
    textsp2 = "딸이 다시 웃는 모습을 볼 수 있다면 무엇이든 할 거야. 거짓말하고 남에게 해를 끼치는 사람들을 잡는 게 조금이라도 도움이 된다면, 나는 그렇게 할 거야";
}
if(idioma == "chino")
{
    textsp2 = "为了再次看到我的女儿微笑，我愿意做任何事。如果抓住那些撒谎并伤害他人的人哪怕能有一点帮助，那么我就会去做";
}
if(idioma == "ruso")
{
    textsp2 = "Я бы сделал всё, чтобы увидеть улыбку моей дочери снова. И если поимка людей, которые лгут и причиняют вред другим, поможет хотя бы немного, то именно этим я и займусь";
}
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == -2 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Now you will stay here and cook for my business with the others. Maybe that way you will pay the debt you owe to the world. Enjoy eternity with those of your kind";
}
if(idioma == "español")
{
    textsp2 = "Ahora te quedaras aqui y cocinaras para mi negocio con el resto, asi tal vez pagues la deuda que tienes con el mundo. Diviertete toda la eternidad con los de tu tipo";
}
if(idioma == "frances")
{
    textsp2 = "Maintenant tu resteras ici et tu cuisineras pour mon entreprise avec les autres. Peut‑etre qu’ainsi tu paieras la dette que tu dois au monde. Amuse‑toi pour l’eternite avec ceux de ton espece";
}
if(idioma == "aleman")
{
    textsp2 = "Jetzt wirst du hierbleiben und für mein Geschaft mit den anderen kochen. Vielleicht begleichst du so die Schuld, die du der Welt hast. Viel Spaß in der Ewigkeit mit deinesgleichen";
}
if(idioma == "italiano")
{
    textsp2 = "Ora resterai qui e cucinerai per la mia attivita insieme agli altri. Forse cosi pagherai il debito che hai con il mondo. Divertiti per l’eternita con quelli della tua specie";
}
if(idioma == "portugues")
{
    textsp2 = "Agora voce vai ficar aqui e cozinhar para o meu negocio com os outros. Talvez assim pague a divida que tem com o mundo. Divirta‑se pela eternidade com os da sua laia";
}
if(idioma == "japones")
{
    textsp2 = "これからはここに残り、他の連中と一緒に俺の商売のために料理してもらう。そうすれば世界に負った借りを少しは返せるだろう。お前と同類の奴らと永遠に楽しむんだな";
}
if(idioma == "coreano")
{
    textsp2 = "이제 너는 여기 남아서 다른 녀석들과 함께 내 가게를 위해 요리하게 될 거야. 그래야 세상에 진 빚을 조금이라도 갚을 수 있겠지. 너 같은 부류들과 영원을 즐겨라";
}
if(idioma == "chino")
{
    textsp2 = "从现在起你会留在这里，和其他人一起为我的生意做饭。也许这样你能偿还你欠世界的债。和与你同类的人一起享受永恒吧";
}
if(idioma == "ruso")
{
    textsp2 = "Теперь ты останешься здесь и будешь готовить для моего дела вместе с остальными. Возможно, так ты хоть немного расплатишься с долгом, который должен миру. Наслаждайся вечностью среди себе подобных";
}
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == -1 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        texm = false;
             writing = false;
             texm = false;
        Invoke("pay2", 1f);
             }

             if(textorder == 5 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "You said you were in the camera room, right? Perfect";
         }
         if(idioma == "español")
         {
         textsp2 = "Dijiste que estabas en la sala de camaras, no? Perfecto";
         }
         if(idioma == "frances")
         {
         textsp2 = "Tu as dit que tu etais dans la salle des cameras, n'est-ce pas ? Parfait";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Sie sagten, Sie waren im Kameraraum, richtig? Perfekt";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Hai detto che eri nella sala delle riprese, giusto? Perfetto";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Voce disse que estava na sala de filmagem, certo? Perfeito";
         }
         if(idioma == "japones")
         {
         textsp2 = "カメラ室にいたって言ってたよね？完璧だ";
         }
         if(idioma == "coreano")
         {
         textsp2 = "카메라 룸에 있었다고 했죠? 완벽해요";
         }
         if(idioma == "chino")
         {
         textsp2 = "你说你在摄像室，对吧？太好了";
         }
         if(idioma == "ruso")
         {
         textsp2 = "Ты же сказал, что был в комнате с камерами, да? Отлично";
         }
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 6 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "The candles in that room keep away the dark energy, in that room you are safe";
         }
         if(idioma == "español")
         {
         textsp2 = "Las velas de ese cuarto alejan la energia oscura, en esa sala estas a salvo";
         }
         if(idioma == "frances")
         {
         textsp2 = "Les bougies dans cette piece eloignent l'energie sombre, dans cette piece vous etes en securite";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Die Kerzen in diesem Raum halten die dunkle Energie fern, in diesem Raum bist du sicher";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Le candele in quella stanza tengono lontana l'energia oscura, in quella stanza sei al sicuro";
         }
         if(idioma == "portugues")
         {
         textsp2 = "As velas naquele quarto afastam a energia escura, naquele quarto voce esta seguro";
         }
         if(idioma == "japones")
         {
         textsp2 = "その部屋のろうそくは闇のエネルギーを遠ざけ、その部屋ではあなたは安全です";
         }
         if(idioma == "coreano")
         {
         textsp2 = "그 방의 촛불은 어둠의 에너지를 막아내고, 그 방 안에서는 당신은 안전합니다";
         }
         if(idioma == "chino")
         {
         textsp2 = "房间里的蜡烛可以驱散黑暗能量，在那个房间里你是安全的";
         }
         if(idioma == "ruso")
         {
         textsp2 = "Свечи в этой комнате отгоняют темную энергию, в этой комнате вы в безопасности.";
         }
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 7 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "La Llorona knows this and will curse rooms to gain power. The more cursed rooms there are, the faster the candles will go out.";
         }
         if(idioma == "español")
         {
         textsp2 = "La llorona sabe esto y maldecira habitaciones para ganar poder, cuantas mas habitaciones malditas haya mas rapido se apagaran las velas";
         }
         if(idioma == "frances")
         {
         textsp2 = "La Llorona le sait et maudit les pieces pour gagner en puissance. Plus il y a de pieces maudites, plus vite les bougies s'eteindront";
         }
         if(idioma == "aleman")
         {
         textsp2 = "La Llorona weiß das und verflucht Raume, um Macht zu erlangen. Je mehr verfluchte Raume es gibt, desto schneller gehen die Kerzen aus";
         }
         if(idioma == "italiano")
         {
         textsp2 = "La Llorona lo sa e maledira le stanze per ottenere potere. Piu stanze maledette ci sono, piu velocemente le candele si spegneranno";
         }
         if(idioma == "portugues")
         {
         textsp2 = "La Llorona sabe disso e amaldicoa comodos para ganhar poder. Quanto mais comodos amaldicoados houver, mais rapido as velas se apagarao";
         }
         if(idioma == "japones")
         {
         textsp2 = "ラ・ヨローナはそれを知っており、力を得るために部屋に呪いをかけます。呪われた部屋の数が増えるほど、ろうそくの火は早く消えます";
         }
         if(idioma == "coreano")
         {
         textsp2 = "라 요로나는 이 사실을 알고 있으며, 힘을 얻기 위해 방에 저주를 걸 것입니다. 저주받은 방이 많을수록 촛불이 더 빨리 꺼질 것입니다";
         }
         if(idioma == "chino")
         {
         textsp2 = "哭泣女人深谙此道，她会诅咒房间来获取力量。被诅咒的房间越多，蜡烛熄灭的速度就越快";
         }
         if(idioma == "ruso")
         {
         textsp2 = "Ла Йорона знает это и проклинает комнаты, чтобы получить силу. Чем больше проклятых комнат, тем быстрее погаснут свечи";
         }
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 8 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "From the cameras you can see her position and the cursed rooms, go to them without being caught and purify them";
         }
         if(idioma == "español")
         {
         textsp2 = "Desde las camaras puedes ver su posicion y las habitaciones malditas, ve hasta ellas sin que te pille y purificalas";
         }
         if(idioma == "frances")
         {
         textsp2 = "Depuis les cameras, vous pouvez voir leur position et les pieces maudites, allez vers elles sans vous faire prendre et purifiez-les.";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Uber die Kameras konnen Sie ihre Position und die verfluchten Raume sehen, sich dorthin begeben, ohne erwischt zu werden, und sie reinigen";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Dalle telecamere puoi vedere la loro posizione e le stanze maledette, raggiungile senza farti catturare e purificale";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Pelas cameras voce pode ver a posicao deles e as salas amaldicoadas, va ate elas sem ser pego e purifique-as";
         }
         if(idioma == "japones")
         {
         textsp2 = "カメラから彼らの位置と呪われた部屋を見ることができるので、捕まることなくそこへ行き、浄化してください";
         }
         if(idioma == "coreano")
         {
         textsp2 = "카메라를 통해 그들의 위치와 저주받은 방을 볼 수 있으므로, 잡히지 않고 그곳으로 가서 정화하면 됩니다";
         }
         if(idioma == "chino")
         {
         textsp2 = "通过摄像机你可以看到他们的位置和被诅咒的房间，在不被抓住的情况下前往并净化它们";
         }
         if(idioma == "ruso")
         {
         textsp2 = "С помощью камер вы можете увидеть их местоположение и проклятые комнаты, проникнуть туда и очистить их, не будучи пойманными";
         }
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 9 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         textsp2 = "You have an advantage, you have a flashlight <sprite name=\"raton\"> and she has 500-year-old eyes. However, she has excellent hearing, so be as quiet as possible.";
         }
         if(idioma == "español")
         {
         textsp2 = "Tienes una ventaja, tu tienes linterna <sprite name=\"raton\"> y ella ojos de 500 años de antiguedad. Sin embargo tiene un gran oido, haz el menor ruido posible";
         }
         if(idioma == "frances")
         {
         textsp2 = "Vous avez un avantage, vous avez une lampe de poche <sprite name=\"raton\"> et elle a des yeux vieux de 500 ans. Cependant, elle a une excellente ouie, alors restez aussi silencieux que possible";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Du hast einen Vorteil, Du hast eine Taschenlampe <sprite name=\"raton\"> und sie hat 500 Jahre alte Augen. Allerdings hat sie ein ausgezeichnetes Gehor, also sei so leise wie moglich";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Hai un vantaggio, hai una torcia <sprite name=\"raton\"> e lei ha occhi di 500 anni. Tuttavia, ha un udito eccellente, quindi fai il piu silenzio possibile";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Voce tem uma vantagem, voce tem uma lanterna <sprite name=\"raton\"> e ela tem olhos de 500 anos. No entanto, ela tem uma audicao excelente, entao seja o mais silencioso possivel";
         }
         if(idioma == "japones")
         {
         textsp2 = "あなたには有利な点があります,懐中電灯 <sprite name=\"raton\"> があり、彼女は500歳の目を持っています。しかし、彼女は優れた聴覚を持っているので、できるだけ静かにしてください";
         }
         if(idioma == "coreano")
         {
         textsp2 = "당신에게는 유리한 점이 있습니다, 손전등 <sprite name=\"raton\"> 을 사용할 수 있고, 그녀는 500년 된 눈을 가지고 있습니다. 하지만 그녀의 청력은 매우 뛰어나니 최대한 조용히 하세요";
         }
         if(idioma == "chino")
         {
         textsp2 = "你有一个优势, 你有一个手电筒 <sprite name=\"raton\"> 而她有一双500岁的眼睛。不过，她的听力很好，所以尽量保持安静";
         }
         if(idioma == "ruso")
         {
         textsp2 = "У вас есть преимущество, у вас есть фонарик <sprite name=\"raton\">, а у неё 500-летние глаза. Однако у неё отличный слух, так что действуйте как можно тише";
         }
         }
         if(xbox == false && playst == true)
         {
         if(idioma == "ingles")
         {
         textsp2 = "You have an advantage, you have a flashlight <sprite name=\"L1\"> and she has 500-year-old eyes. However, she has excellent hearing, so be as quiet as possible.";
         }
         if(idioma == "español")
         {
         textsp2 = "Tienes una ventaja, tu tienes linterna <sprite name=\"L1\"> y ella ojos de 500 años de antiguedad. Sin embargo tiene un gran oido, haz el menor ruido posible";
         }
         if(idioma == "frances")
         {
         textsp2 = "Vous avez un avantage, vous avez une lampe de poche <sprite name=\"L1\"> et elle a des yeux vieux de 500 ans. Cependant, elle a une excellente ouie, alors restez aussi silencieux que possible";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Du hast einen Vorteil, Du hast eine Taschenlampe <sprite name=\"L1\"> und sie hat 500 Jahre alte Augen. Allerdings hat sie ein ausgezeichnetes Gehor, also sei so leise wie moglich";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Hai un vantaggio, hai una torcia <sprite name=\"L1\"> e lei ha occhi di 500 anni. Tuttavia, ha un udito eccellente, quindi fai il piu silenzio possibile";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Voce tem uma vantagem, voce tem uma lanterna <sprite name=\"L1\"> e ela tem olhos de 500 anos. No entanto, ela tem uma audicao excelente, entao seja o mais silencioso possivel";
         }
         if(idioma == "japones")
         {
         textsp2 = "あなたには有利な点があります,懐中電灯 <sprite name=\"L1\"> があり、彼女は500歳の目を持っています。しかし、彼女は優れた聴覚を持っているので、できるだけ静かにしてください";
         }
         if(idioma == "coreano")
         {
         textsp2 = "당신에게는 유리한 점이 있습니다, 손전등 <sprite name=\"L1\"> 을 사용할 수 있고, 그녀는 500년 된 눈을 가지고 있습니다. 하지만 그녀의 청력은 매우 뛰어나니 최대한 조용히 하세요";
         }
         if(idioma == "chino")
         {
         textsp2 = "你有一个优势, 你有一个手电筒 <sprite name=\"L1\"> ，而她有一双500岁的眼睛。不过，她的听力很好，所以尽量保持安静";
         }
         if(idioma == "ruso")
         {
         textsp2 = "У вас есть преимущество, у вас есть фонарик <sprite name=\"L1\">, а у неё 500-летние глаза. Однако у неё отличный слух, так что действуйте как можно тише";
         }
         }
         if(xbox == true && playst == false)
         {
         if(idioma == "ingles")
         {
         textsp2 = "You have an advantage, you have a flashlight <sprite name=\"LB\"> and she has 500-year-old eyes. However, she has excellent hearing, so be as quiet as possible.";
         }
         if(idioma == "español")
         {
         textsp2 = "Tienes una ventaja, tu tienes linterna <sprite name=\"LB\"> y ella ojos de 500 años de antiguedad. Sin embargo tiene un gran oido, haz el menor ruido posible";
         }
         if(idioma == "frances")
         {
         textsp2 = "Vous avez un avantage, vous avez une lampe de poche <sprite name=\"LB\"> et elle a des yeux vieux de 500 ans. Cependant, elle a une excellente ouie, alors restez aussi silencieux que possible";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Du hast einen Vorteil, Du hast eine Taschenlampe <sprite name=\"LB\"> und sie hat 500 Jahre alte Augen. Allerdings hat sie ein ausgezeichnetes Gehor, also sei so leise wie moglich";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Hai un vantaggio, hai una torcia <sprite name=\"LB\"> e lei ha occhi di 500 anni. Tuttavia, ha un udito eccellente, quindi fai il piu silenzio possibile";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Voce tem uma vantagem, voce tem uma lanterna <sprite name=\"LB\"> e ela tem olhos de 500 anos. No entanto, ela tem uma audicao excelente, entao seja o mais silencioso possivel";
         }
         if(idioma == "japones")
         {
         textsp2 = "あなたには有利な点があります,懐中電灯 <sprite name=\"LB\"> があり、彼女は500歳の目を持っています。しかし、彼女は優れた聴覚を持っているので、できるだけ静かにしてください";
         }
         if(idioma == "coreano")
         {
         textsp2 = "당신에게는 유리한 점이 있습니다, 손전등 <sprite name=\"LB\"> 을 사용할 수 있고, 그녀는 500년 된 눈을 가지고 있습니다. 하지만 그녀의 청력은 매우 뛰어나니 최대한 조용히 하세요";
         }
         if(idioma == "chino")
         {
         textsp2 = "你有一个优势, 你有一个手电筒 <sprite name=\"LB\"> ，而她有一双500岁的眼睛。不过，她的听力很好，所以尽量保持安静";
         }
         if(idioma == "ruso")
         {
         textsp2 = "У вас есть преимущество, у вас есть фонарик <sprite name=\"LB\">, а у неё 500-летние глаза. Однако у неё отличный слух, так что действуйте как можно тише";
         }
         }
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 10 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "If all the candles go out, there will be nothing to protect you from her and you will die instantly.";
         }
         if(idioma == "español")
         {
         textsp2 = "Si todas las velas se apagan, no habra nada que te proteja de ella y moriras al instante";
         }
         if(idioma == "frances")
         {
         textsp2 = "Si toutes les bougies s'eteignent, il n'y aura plus rien pour vous proteger et vous mourrez instantanement.";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Wenn alle Kerzen ausgehen, gibt es nichts, was Sie davor schutzen konnte, und Sie werden sofort sterben";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Se tutte le candele si spengono, non ci sara nulla a proteggerti e morirai all'istante";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Se todas as velas se apagarem, nao havera nada para protege-lo e voce morrera instantaneamente.";
         }
         if(idioma == "japones")
         {
         textsp2 = "ろうそくがすべて消えてしまったら、あなたを守るものは何もなく、あなたは即死してしまいます";
         }
         if(idioma == "coreano")
         {
         textsp2 = "만약 모든 촛불이 꺼진다면, 당신을 보호할 수 있는 것은 아무것도 없을 것이고, 당신은 즉시 죽을 것입니다";
         }
         if(idioma == "chino")
         {
         textsp2 = "如果所有蜡烛都熄灭了，就没有什么可以保护你，你会立即死亡";
         }
         if(idioma == "ruso")
         {
         textsp2 = "сли все свечи погаснут, вас ничто не защитит, и вы умрете мгновенно";
         }
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 11 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "Survive until 6 in the morning, by then his power will have weakened and he will leave for the night.";
         }
         if(idioma == "español")
         {
         textsp2 = "Sobrevive hasta las 6 de la mañana, para entonces su poder se habra debilitado y se ira por esta noche";
         }
         if(idioma == "frances")
         {
         textsp2 = "Survivez jusqu'à 6 heures du matin, à ce moment-là, son pouvoir sera affaibli et il partira pour la nuit";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Uberlebe bis 6 Uhr morgens, bis dahin wird seine Kraft nachgelassen haben und er wird fur die Nacht verschwinden";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Sopravvivi fino alle 6 del mattino, a quel punto il suo potere si sara indebolito e se ne andra per la notte";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Sobreviva ate as 6 da manha, quando seu poder estara enfraquecido e ele saira para dormir";
         }
         if(idioma == "japones")
         {
         textsp2 = "午前 6 時まで生き延びてください。その時までには彼の力は弱まり、夜に去るでしょう";
         }
         if(idioma == "coreano")
         {
         textsp2 = "오전 6시까지 살아남아라. 그때쯤이면 그의 힘은 약해지고 그는 밤에 떠날 것이다";
         }
         if(idioma == "chino")
         {
         textsp2 = "活到早上 6 点，那时他的力量就会减弱，他就会离开去过夜";
         }
         if(idioma == "ruso")
         {
         textsp2 = "ыживите до 6 утра, к тому времени его силы ослабнут, и он уйдет на ночь";
         }
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 12 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         if(idioma == "ingles")
         {
         textsp2 = "Now I have to go, it's bingo time!";
         }
         if(idioma == "español")
         {
         textsp2 = "Ahora tengo que irme, Es la hora del bingo!";
         }
         if(idioma == "frances")
         {
         textsp2 = "Maintenant je dois y aller, c'est l'heure du bingo !";
         }
         if(idioma == "aleman")
         {
         textsp2 = "Jetzt muss ich gehen, es ist Bingo-Zeit!";
         }
         if(idioma == "italiano")
         {
         textsp2 = "Adesso devo andare, e l'ora del bingo!";
         }
         if(idioma == "portugues")
         {
         textsp2 = "Agora tenho que ir, e hora do bingo!";
         }
         if(idioma == "japones")
         {
         textsp2 = "もう行かなきゃ、ビンゴの時間だよ！";
         }
         if(idioma == "coreano")
         {
         textsp2 = "이제 가야 해요. 빙고 타임이에요!";
         }
         if(idioma == "chino")
         {
         textsp2 = "现在我得走了，宾果游戏时间到了！";
         }
         if(idioma == "ruso")
         {
         textsp2 = "теперь мне пора идти, пора играть в бинго!";
         }
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 13 && writing == false)
             {
           tut = true;

           freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
           anim2.SetTrigger("dw");
           Invoke("p2y", 0.2f);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
           texm = false;
           rsp = false;
            writing = true;
             }



             if(textorder == 14 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "A customer?... A customer! Finally!";
}
if(idioma == "español")
{
    textsp2 = "Un cliente?... Un cliente! Al fin!";
}
if(idioma == "frances")
{
    textsp2 = "Un client?... Un client! Enfin!";
}
if(idioma == "aleman")
{
    textsp2 = "Ein Kunde?... Ein Kunde! Endlich!";
}
if(idioma == "italiano")
{
    textsp2 = "Un cliente?... Un cliente! Finalmente!";
}
if(idioma == "portugues")
{
    textsp2 = "Um cliente?... Um cliente! Finalmente!";
}
if(idioma == "japones")
{
    textsp2 = "お客さん？... お客さんだ！やっと来た！";
}
if(idioma == "coreano")
{
    textsp2 = "손님?... 손님이다! 드디어!";
}
if(idioma == "chino")
{
    textsp2 = "顾客？... 顾客！终于来了！";
}
if(idioma == "ruso")
{
    textsp2 = "Клиент?... Клиент! Наконец-то!";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 15 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Welcome to the Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "español")
{
    textsp2 = "Bienvenido al Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "frances")
{
    textsp2 = "Bienvenue au piment roulant! El chile mas picante de todo el infierno!";
}
if(idioma == "aleman")
{
    textsp2 = "Willkommen beim Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "italiano")
{
    textsp2 = "Benvenuto al Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "portugues")
{
    textsp2 = "Bem-vindo ao Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "japones")
{
    textsp2 = "ようこそ、Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "coreano")
{
    textsp2 = "굴러가는 매운맛에 오신 것을 환영합니다! El chile mas picante de todo el infierno!";
}
if(idioma == "chino")
{
    textsp2 = "欢迎来到滚动的辣味！El chile mas picante de todo el infierno!";
}
if(idioma == "ruso")
{
    textsp2 = "Добро пожаловать в Picante Rodante! El chile mas picante de todo el infierno!";
}
             StartCoroutine(writex());
             writing = false;
opi = false;
arming2 = false;
             }
             if(textorder == 16 && writing == false)
             {
    if(opi == false)
    {
    shop1.SetActive(false);
    vanim.SetTrigger("feliz2");
if(idioma == "ingles")
{
    textoq.text = "Danger?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Peligro?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Danger?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Gefahr?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Pericolo?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Perigo?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "危険？";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "위험?";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "危险？";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Опасно?";
}
    opi = true;
         fdt.clip = null;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Hey... You don't look like a demon. I guess I'll have to kill you.";
}
if(idioma == "español")
{
    textsp2 = "Oye... No pareces un demonio. Creo que tendre que matarte.";
}
if(idioma == "frances")
{
    textsp2 = "He... Tu ne ressembles pas a un demon. Je crois que je vais devoir te tuer.";
}
if(idioma == "aleman")
{
    textsp2 = "Hey... Du siehst nicht wie ein Damon aus. Ich glaube, ich werde dich toten mussen.";
}
if(idioma == "italiano")
{
    textsp2 = "Ehi... Non sembri un demone. Credo che dovro ucciderti.";
}
if(idioma == "portugues")
{
    textsp2 = "Ei... Voce nao parece um demonio. Acho que vou ter que te matar.";
}
if(idioma == "japones")
{
    textsp2 = "おい... お前、悪魔には見えないな。殺すしかないようだ。";
}
if(idioma == "coreano")
{
    textsp2 = "이봐... 너는 악마처럼 보이지 않는군. 어쩔 수 없이 널 죽여야겠어.";
}
if(idioma == "chino")
{
    textsp2 = "喂... 你看起来不像恶魔。看来我只能杀了你。";
}
if(idioma == "ruso")
{
    textsp2 = "Эй... Ты не похож на демона. Похоже, мне придётся тебя убить.";
}
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 17 && writing == true)
             {
    vanim.SetTrigger("feliz1");
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         fdt.clip = mxc;
fdt.Play();
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Haha! Relax, it was a joke! You fell for it!";
}
if(idioma == "español")
{
    textsp2 = "Jaja! Tranqui, era broma! Picaste!";
}
if(idioma == "frances")
{
    textsp2 = "Haha! Tranquille, c etait une blague ! Tu t es fait avoir !";
}
if(idioma == "aleman")
{
    textsp2 = "Haha! Entspann dich, war nur ein Witz! Du bist darauf reingefallen!";
}
if(idioma == "italiano")
{
    textsp2 = "Ahah! Tranquillo, era uno scherzo! Ci sei cascato!";
}
if(idioma == "portugues")
{
    textsp2 = "Haha! Calma, era brincadeira! Voce caiu direitinho!";
}
if(idioma == "japones")
{
    textsp2 = "はは！落ち着けよ、冗談だって！ひっかかったな！";
}
if(idioma == "coreano")
{
    textsp2 = "하하! 진정해, 장난이었어! 속았지!";
}
if(idioma == "chino")
{
    textsp2 = "哈哈！放轻松，是开玩笑的！你上当了！";
}
if(idioma == "ruso")
{
    textsp2 = "Хаха! Спокойно, это была шутка! Ты повёлся!";
}
    vanim.SetTrigger("feliz1");
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 18 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "You're the first customer in 100 years who hasn't tried to kill us! Congratulations!";
}
if(idioma == "español")
{
    textsp2 = "Eres el primer cliente en un siglo que no intenta matarnos! Felicidades!";
}
if(idioma == "frances")
{
    textsp2 = "Tu es le premier client en 100 ans qui n essaie pas de nous tuer! Felicitations!";
}
if(idioma == "aleman")
{
    textsp2 = "Du bist der erste Kunde seit 100 Jahren, der nicht versucht, uns zu toten! Gluckwunsch!";
}
if(idioma == "italiano")
{
    textsp2 = "Sei il primo cliente in 100 anni che non prova a ucciderci! Complimenti!";
}
if(idioma == "portugues")
{
    textsp2 = "Voce e o primeiro cliente em 100 anos que nao tentou nos matar! Parabens!";
}
if(idioma == "japones")
{
    textsp2 = "君は100年ぶりに俺たちを殺そうとしなかった初めての客だ！おめでとう！";
}
if(idioma == "coreano")
{
    textsp2 = "100년 동안 우리를 죽이려고 하지 않은 첫 번째 손님이네요! 축하합니다!";
}
if(idioma == "chino")
{
    textsp2 = "你是这100年来第一个没试图杀我们的客人！恭喜！";
}
if(idioma == "ruso")
{
    textsp2 = "Ты первый клиент за 100 лет, который не пытается нас убить! Поздравляю!";
}
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 19 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Centuries ago I went on a journey with my wife and daughter through the mortal plane to sell food straight from Hell!";
}
if(idioma == "español")
{
    textsp2 = "Hace siglos sali de viaje con mi esposa e hija por el plano mortal para vender comida directa del infierno!";
}
if(idioma == "frances")
{
    textsp2 = "Il y a des siecles, je suis parti en voyage avec ma femme et ma fille a travers le plan mortel pour vendre de la nourriture directement de l enfer !";
}
if(idioma == "aleman")
{
    textsp2 = "Vor Jahrhunderten reiste ich mit meiner Frau und meiner Tochter durch die sterbliche Ebene, um Essen direkt aus der Holle zu verkaufen!";
}
if(idioma == "italiano")
{
    textsp2 = "Secoli fa partii in viaggio con mia moglie e mia figlia attraverso il piano mortale per vendere cibo direttamente dall’inferno!";
}
if(idioma == "portugues")
{
    textsp2 = "Ha seculos, viajei com minha esposa e filha pelo plano mortal para vender comida diretamente do inferno!";
}
if(idioma == "japones")
{
    textsp2 = "何世紀も前、妻と娘と一緒に人間界を旅し、地獄産の食べ物を売り歩いていたんだ！";
}
if(idioma == "coreano")
{
    textsp2 = "수세기 전, 아내와 딸과 함께 죽을 자의 세계를 여행하며 지옥산 음식을 팔았지!";
}
if(idioma == "chino")
{
    textsp2 = "几个世纪前，我和妻子、女儿一起在凡人界旅行，出售直接来自地狱的食物！";
}
if(idioma == "ruso")
{
    textsp2 = "Много веков назад я отправился в путешествие со своей женой и дочерью по смертному плану, чтобы продавать еду прямо из ада!";
}
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 20 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "My daughter is back in her room! You'd be surprised how big this thing is inside! She's a bit shy and usually doesn't come out to greet customers.";
}
if(idioma == "español")
{
    textsp2 = "Mi hija esta atras en su cuarto! Te sorprenderia lo grande que es esta cosa por dentro! Es un poco timida y no suele salir a recibir a los clientes.";
}
if(idioma == "frances")
{
    textsp2 = "Ma fille est dans sa chambre ! Tu serais surpris de voir a quel point cette chose est grande a l interieur ! Elle est un peu timide et ne vient generalement pas accueillir les clients.";
}
if(idioma == "aleman")
{
    textsp2 = "Meine Tochter ist hinten in ihrem Zimmer! Du würdest uberrascht sein, wie groß dieses Ding innen ist! Sie ist etwas schüchtern und kommt normalerweise nicht heraus, um Kunden zu begrußen.";
}
if(idioma == "italiano")
{
    textsp2 = "Mia figlia e nella sua stanza! Ti sorprenderebbe quanto sia grande questa cosa dentro! E un po timida e di solito non esce ad accogliere i clienti.";
}
if(idioma == "portugues")
{
    textsp2 = "Minha filha esta no quarto dela! Voce ficaria surpreso com o tamanho desta coisa por dentro! Ela e um pouco timida e geralmente nao sai para receber os clientes.";
}
if(idioma == "japones")
{
    textsp2 = "娘は奥の部屋にいるよ！中がどれだけ大きいか驚くだろう！少し恥ずかしがり屋で、普段はお客さんを迎えに出てこないんだ。";
}
if(idioma == "coreano")
{
    textsp2 = "내 딸은 방 안에 있어! 안이 얼마나 큰지 보면 놀랄 거야! 조금 수줍어해서 보통 손님을 맞으러 나오지 않아.";
}
if(idioma == "chino")
{
    textsp2 = "我女儿在她的房间里！你会惊讶这里面有多大！她有点害羞，通常不会出来迎接客人。";
}
if(idioma == "ruso")
{
    textsp2 = "Моя дочь в своей комнате! Ты бы удивился, насколько большое это место внутри! Она немного стеснительная и обычно не выходит встречать клиентов.";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 21 && writing == true)
             {
    if(opi2 == false)
    {
    vanim.SetTrigger("feliz2");
    opi2 = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "And my wife-!";
}
if(idioma == "español")
{
    textsp2 = "Y mi esposa-!";
}
if(idioma == "frances")
{
    textsp2 = "Et ma femme- !";
}
if(idioma == "aleman")
{
    textsp2 = "Und meine Frau-!";
}
if(idioma == "italiano")
{
    textsp2 = "E mia moglie-!";
}
if(idioma == "portugues")
{
    textsp2 = "E minha esposa-!";
}
if(idioma == "japones")
{
    textsp2 = "そして妻は-！";
}
if(idioma == "coreano")
{
    textsp2 = "그리고 내 아내는-!";
}
if(idioma == "chino")
{
    textsp2 = "还有我妻子-！";
}
if(idioma == "ruso")
{
    textsp2 = "А моя жена-!";
}
opi = false;
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 22 && writing == false)
             {
    if(opi == false)
    {
    vanim.SetTrigger("sd1");
         fdt.clip = null;
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "My wife...";
}
if(idioma == "español")
{
    textsp2 = "Mi esposa...";
}
if(idioma == "frances")
{
    textsp2 = "Ma femme...";
}
if(idioma == "aleman")
{
    textsp2 = "Meine Frau...";
}
if(idioma == "italiano")
{
    textsp2 = "Mia moglie...";
}
if(idioma == "portugues")
{
    textsp2 = "Minha esposa...";
}
if(idioma == "japones")
{
    textsp2 = "妻は...";
}
if(idioma == "coreano")
{
    textsp2 = "내 아내는...";
}
if(idioma == "chino")
{
    textsp2 = "我妻子...";
}
if(idioma == "ruso")
{
    textsp2 = "Моя жена...";
}
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 23 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "...";
}
if(idioma == "español")
{
    textsp2 = "...";
}
if(idioma == "frances")
{
    textsp2 = "...";
}
if(idioma == "aleman")
{
    textsp2 = "...";
}
if(idioma == "italiano")
{
    textsp2 = "...";
}
if(idioma == "portugues")
{
    textsp2 = "...";
}
if(idioma == "japones")
{
    textsp2 = "...";
}
if(idioma == "coreano")
{
    textsp2 = "...";
}
if(idioma == "chino")
{
    textsp2 = "...";
}
if(idioma == "ruso")
{
    textsp2 = "...";
}
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 24 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "My wife... she died in a witch hunt centuries ago...";
}
if(idioma == "español")
{
    textsp2 = "Mi esposa... murio en una caza de brujas hace siglos...";
}
if(idioma == "frances")
{
    textsp2 = "Ma femme... elle est morte lors d une chasse aux sorcieres il y a des siecles...";
}
if(idioma == "aleman")
{
    textsp2 = "Meine Frau... sie starb vor Jahrhunderten bei einer Hexenjagd...";
}
if(idioma == "italiano")
{
    textsp2 = "Mia moglie... e morta in una caccia alle streghe secoli fa...";
}
if(idioma == "portugues")
{
    textsp2 = "Minha esposa... morreu em uma caca as bruxas ha seculos...";
}
if(idioma == "japones")
{
    textsp2 = "妻は... 何世紀も前の魔女狩りで命を落としたんだ...";
}
if(idioma == "coreano")
{
    textsp2 = "내 아내는... 수세기 전 마녀사냥에서 죽었어...";
}
if(idioma == "chino")
{
    textsp2 = "我妻子...在几个世纪前的猎巫行动中死去了...";
}
if(idioma == "ruso")
{
    textsp2 = "Моя жена... она погибла много веков назад во время охоты на ведьм...";
}
             StartCoroutine(writex());
             writing = true;
opi = false;
             }
             if(textorder == 25 && writing == true)
             {
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz1");
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "My daughter is handling it well!";
}
if(idioma == "español")
{
    textsp2 = "Mi hija lo lleva bien!";
}
if(idioma == "frances")
{
    textsp2 = "Ma fille le gere bien !";
}
if(idioma == "aleman")
{
    textsp2 = "Meine Tochter kommt gut damit zurecht!";
}
if(idioma == "italiano")
{
    textsp2 = "Mia figlia la sta affrontando bene!";
}
if(idioma == "portugues")
{
    textsp2 = "Minha filha esta lidando bem com isso!";
}
if(idioma == "japones")
{
    textsp2 = "娘はちゃんと受け止めているよ！";
}
if(idioma == "coreano")
{
    textsp2 = "내 딸은 잘 이겨내고 있어!";
}
if(idioma == "chino")
{
    textsp2 = "我女儿应对得很好！";
}
if(idioma == "ruso")
{
    textsp2 = "Моя дочь хорошо с этим справляется!";
}
             StartCoroutine(writex());
             writing = false;
opi2 = false;
             }
             if(textorder == 26 && writing == false)
             {
    if(opi2 == false)
    {
    vanim.SetTrigger("feliz2");
    vanim.SetTrigger("sd1");
    opi2 = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "So well that... ever since then she doesn't want to talk to me and stays in her room all day...";
}
if(idioma == "español")
{
    textsp2 = "Tan bien que... desde entonces no quiere hablar conmigo y se queda todo el dia en su cuarto...";
}
if(idioma == "frances")
{
    textsp2 = "Si bien que... depuis ce jour, elle ne veut plus me parler et reste toute la journee dans sa chambre...";
}
if(idioma == "aleman")
{
    textsp2 = "So gut, dass... seitdem sie nicht mehr mit mir reden will und den ganzen Tag in ihrem Zimmer bleibt...";
}
if(idioma == "italiano")
{
    textsp2 = "Cosi bene che... da allora non vuole piu parlarmi e rimane tutto il giorno nella sua stanza...";
}
if(idioma == "portugues")
{
    textsp2 = "Tao bem que... desde entao ela nao quer mais falar comigo e fica o dia todo no quarto...";
}
if(idioma == "japones")
{
    textsp2 = "あまりにも平気そうで... それ以来、僕と話したがらず、一日中自分の部屋にこもっているんだ...";
}
if(idioma == "coreano")
{
    textsp2 = "너무 잘 지내는 것 같아서... 그때부터 나와 말도 하지 않고 하루 종일 방에만 있어...";
}
if(idioma == "chino")
{
    textsp2 = "好得甚至... 从那以后她就不愿再跟我说话，一整天都待在她的房间里...";
}
if(idioma == "ruso")
{
    textsp2 = "Настолько хорошо, что... с тех пор она не хочет со мной разговаривать и весь день сидит у себя в комнате...";
}
             StartCoroutine(writex());
             writing = true;
opi = false;
             }
             if(textorder == 27 && writing == true)
             {
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("md1");
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "If I ever found the man who did this to my family, I... I...";
}
if(idioma == "español")
{
    textsp2 = "Si me encontrara al hombre que le hizo esto a mi familia yo... yo...";
}
if(idioma == "frances")
{
    textsp2 = "Si je trouvais l homme qui a fait ca a ma famille, je... je...";
}
if(idioma == "aleman")
{
    textsp2 = "Wenn ich den Mann finden wurde, der meiner Familie das angetan hat, ich... ich...";
}
if(idioma == "italiano")
{
    textsp2 = "Se trovassi l uomo che ha fatto questo alla mia famiglia io... io...";
}
if(idioma == "portugues")
{
    textsp2 = "Se eu encontrasse o homem que fez isso a minha familia, eu... eu...";
}
if(idioma == "japones")
{
    textsp2 = "もし家族にこんなことをした男を見つけられたら、俺は...俺は...";
}
if(idioma == "coreano")
{
    textsp2 = "내 가족에게 이런 짓을 한 남자를 찾기만 한다면... 난... 난...";
}
if(idioma == "chino")
{
    textsp2 = "要是我找到对我家人做出这一切的那个人，我...我...";
}
if(idioma == "ruso")
{
    textsp2 = "Если бы я нашёл человека, который сделал это моей семье, я... я...";
}
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 28 && writing == false)
             {
arm.SetActive(true);
arming = true;
texm = false;
opi = false;
opi2 = false;
        Invoke("sellx", 0.25f);
        Invoke("sell2", 1.5f);
        Invoke("sell4", 3f);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
             writing = true;
             }
             if(textorder == 29 && writing == true)
             {
    if(opi == false)
    {
    vanim.SetTrigger("md2");
    vanim.SetTrigger("feliz1");
         fdt.clip = mxc;
fdt.Play();
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Ah! Sorry! Looks like I got carried away!";
}
if(idioma == "español")
{
    textsp2 = "Ah! Perdon! Parece que me deje llevar!";
}
if(idioma == "frances")
{
    textsp2 = "Ah ! Desole ! On dirait que je me suis un peu emporte !";
}
if(idioma == "aleman")
{
    textsp2 = "Ah! Entschuldigung! Sieht so aus, als hatte ich mich hinreißen lassen!";
}
if(idioma == "italiano")
{
    textsp2 = "Ah! Scusa! Sembra che mi sia fatto prendere la mano!";
}
if(idioma == "portugues")
{
    textsp2 = "Ah! Desculpa! Parece que me empolguei demais!";
}
if(idioma == "japones")
{
    textsp2 = "あっ！すまない！少し熱くなってしまったようだ！";
}
if(idioma == "coreano")
{
    textsp2 = "아! 미안! 내가 좀 흥분했던 것 같아!";
}
if(idioma == "chino")
{
    textsp2 = "啊！抱歉！我好像有点激动了！";
}
if(idioma == "ruso")
{
    textsp2 = "Ах! Прости! Кажется, я немного увлёкся!";
}
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 30 && writing == false)
             {
    if(opi2 == false)
    {
    vanim.SetTrigger("feliz2");
    opi2 = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Anyway, I stopped here because I sensed a strong spiritual energy coming from this house. Although you have quite a bit yourself, you don't seem to be the source. Are you dealing with some kind of spirit here?";
}
if(idioma == "español")
{
    textsp2 = "En fin, me pare aqui porque senti una fuerte energia espiritual de esta casa, aunque tienes bastante tu no pareces la fuente, estas lidiando con algun espiritu aqui?";
}
if(idioma == "frances")
{
    textsp2 = "Enfin, je me suis arrete ici parce que j’ai senti une forte energie spirituelle provenant de cette maison. Meme si tu en as pas mal toi-meme, tu ne sembles pas en etre la source. Tu fais face a un esprit ici ?";
}
if(idioma == "aleman")
{
    textsp2 = "Jedenfalls hielt ich hier an, weil ich eine starke spirituelle Energie von diesem Haus gespürt habe. Auch wenn du selbst einiges davon hast, scheinst du nicht die Quelle zu sein. Hast du es hier mit einem Geist zu tun?";
}
if(idioma == "italiano")
{
    textsp2 = "Comunque, mi sono fermato qui perche ho sentito una forte energia spirituale provenire da questa casa. Anche se ne hai parecchia tu stesso, non sembri essere la fonte. Stai avendo a che fare con qualche spirito qui?";
}
if(idioma == "portugues")
{
    textsp2 = "Enfim, parei aqui porque senti uma forte energia espiritual vindo desta casa. Embora voce tenha bastante, nao parece ser a fonte. Esta lidando com algum espirito aqui?";
}
if(idioma == "japones")
{
    textsp2 = "とにかく、この家から強い霊的エネルギーを感じたからここに立ち寄ったんだ。君自身もかなり持っているようだが、どうも源ではなさそうだ。ここで何か霊と関わっているのかい？";
}
if(idioma == "coreano")
{
    textsp2 = "아무튼, 이 집에서 강한 영적 기운이 느껴져서 여기 멈춘 거야. 너도 꽤 가진 것 같지만, 근원은 아닌 것 같아. 여기서 어떤 영혼과 얽혀 있는 거야?";
}
if(idioma == "chino")
{
    textsp2 = "总之，我停在这里是因为从这房子里感受到强烈的灵力。虽然你自己也有不少，但你似乎不是源头。你在这里和什么灵体打交道吗？";
}
if(idioma == "ruso")
{
    textsp2 = "В общем, я остановился здесь, потому что почувствовал сильную духовную энергию, исходящую от этого дома. Хотя у тебя самого её немало, похоже, что ты не источник. Ты здесь имеешь дело с каким-то духом?";
}
             StartCoroutine(writex());
             writing = true;
opi = false;
             }
             if(textorder == 31 && writing == true)
             {
    if(opi == false)
    {
    vanim.SetTrigger("feliz1");
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Then today is your lucky day! My food from Hell, besides being delicious, grants boosts to different stats and abilities!";
}
if(idioma == "español")
{
    textsp2 = "Entonces hoy es tu dia de suerte! Mi comida del infierno, aparte de ser deliciosa, ofrece aumentos en distintas caracteristicas o habilidades!";
}
if(idioma == "frances")
{
    textsp2 = "Alors aujourd hui est ton jour de chance ! Ma nourriture de l enfer, en plus d etre delicieuse, offre des ameliorations a diverses caracteristiques ou competences !";
}
if(idioma == "aleman")
{
    textsp2 = "Dann ist heute dein Gluckstag! Mein Essen aus der Holle ist nicht nur kostlich, sondern verleiht auch Verbesserungen fur verschiedene Eigenschaften und Fahigkeiten!";
}
if(idioma == "italiano")
{
    textsp2 = "Allora oggi e il tuo giorno fortunato! Il mio cibo infernale, oltre a essere delizioso, offre potenziamenti a varie caratteristiche o abilita!";
}
if(idioma == "portugues")
{
    textsp2 = "Entao hoje e seu dia de sorte! A minha comida do inferno, alem de ser deliciosa, oferece aumentos em varias caracteristicas ou habilidades!";
}
if(idioma == "japones")
{
    textsp2 = "なら今日は運がいいぞ！俺の地獄の料理は美味しいだけじゃなく、さまざまな能力やステータスを強化してくれるんだ！";
}
if(idioma == "coreano")
{
    textsp2 = "그렇다면 오늘은 네 행운의 날이야! 내 지옥의 음식은 맛있을 뿐만 아니라 여러 능력이나 스탯을 강화해 준다고!";
}
if(idioma == "chino")
{
    textsp2 = "那么今天就是你的幸运日！我的地狱料理不仅美味，还能提升各种属性和技能！";
}
if(idioma == "ruso")
{
    textsp2 = "Тогда сегодня твой счастливый день! Моя адская еда не только вкусная, но и даёт усиления разных характеристик и способностей!";
}
             StartCoroutine(writex());
             writing = false;
opi2 = false;
             }
             if(textorder == 32 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "You don't have money? Don't worry, we spirits don't use that! Just give me some of the energy from those delicious candles and that's more than enough for me!";
}
if(idioma == "español")
{
    textsp2 = "No tienes dinero? No te preocupes, los espiritus no usamos de eso! Con que me des de la energia de esas velas tan deliciosas me sirvo y me basto!";
}
if(idioma == "frances")
{
    textsp2 = "Tu n’as pas d’argent ? Ne t’inquiete pas, les esprits n’utilisons pas ca ! Donne-moi simplement un peu de l’energie de ces bougies si delicieuses et ca me suffit largement !";
}
if(idioma == "aleman")
{
    textsp2 = "Du hast kein Geld? Keine Sorge, wir Geister benutzen so etwas nicht! Gib mir einfach etwas Energie von diesen köstlichen Kerzen, das reicht mir vollig!";
}
if(idioma == "italiano")
{
    textsp2 = "Non hai soldi? Non preoccuparti, noi spiriti non usiamo quelle cose! Basta che mi dai un po' dell’energia di quelle candele così deliziose e per me e piu che sufficiente!";
}
if(idioma == "portugues")
{
    textsp2 = "Nao tem dinheiro? Nao se preocupe, nos espiritos nao usamos isso! So me de um pouco da energia dessas velas tao deliciosas e ja fico mais do que satisfeito!";
}
if(idioma == "japones")
{
    textsp2 = "お金がない？心配するな、霊たちはそんなもの使わない！あの美味しそうなろうそくのエネルギーを少し分けてくれれば、それで十分だ！";
}
if(idioma == "coreano")
{
    textsp2 = "돈이 없어? 걱정 마, 영혼인 우리는 그런 걸 쓰지 않아! 저 맛있어 보이는 양초들에서 나는 에너지를 조금만 줘도 난 충분해!";
}
if(idioma == "chino")
{
    textsp2 = "没钱？别担心，我们灵体可不需要那些东西！只要给我一点那些美味蜡烛的能量，我就完全够用了！";
}
if(idioma == "ruso")
{
    textsp2 = "У тебя нет денег? Не волнуйся, мы духи этим не пользуемся! Просто дай мне немного энергии от тех вкусных свечей — и мне этого более чем достаточно!";
}
             StartCoroutine(writex());
             writing = true;
opi = false;
             }
             if(textorder == 33 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Come on! Come here and try some!";
}
if(idioma == "español")
{
    textsp2 = "Venga! Ven aqui y prueba un poco!";
}
if(idioma == "frances")
{
    textsp2 = "Allez ! Viens ici et goute un peu !";
}
if(idioma == "aleman")
{
    textsp2 = "Komm schon! Komm her und probier ein bisschen!";
}
if(idioma == "italiano")
{
    textsp2 = "Dai! Vieni qui e assaggia un po'!";
}
if(idioma == "portugues")
{
    textsp2 = "Vamos la! Venha aqui e experimente um pouco!";
}
if(idioma == "japones")
{
    textsp2 = "さあ！ここに来て少し味見してみなよ！";
}
if(idioma == "coreano")
{
    textsp2 = "자! 이리 와서 조금 맛봐봐!";
}
if(idioma == "chino")
{
    textsp2 = "来吧！过来尝一点！";
}
if(idioma == "ruso")
{
    textsp2 = "Давай! Иди сюда и попробуй немного!";
}
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 34 && writing == false)
             {
    if(opi == false)
    {
    vanim.SetTrigger("feliz2");
    opi = true;
    }
            freeze = false;
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = true;
         timestop = false;
             }






             if(textorder == 35 && writing == false)
             {
    if(opi == false)
    {
    vanim.SetTrigger("feliz1");
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "The customer of the century has returned! He's a regular!";
}
if(idioma == "español")
{
    textsp2 = "El cliente del siglo ha vuelto! Es uno recurrente!";
}
if(idioma == "frances")
{
    textsp2 = "Le client du siecle est revenu ! C'est un habitue !";
}
if(idioma == "aleman")
{
    textsp2 = "Der Kunde des Jahrhunderts ist zuruck! Er ist ein Stammkunde!";
}
if(idioma == "italiano")
{
    textsp2 = "Il cliente del secolo e tornato! E un cliente abituale!";
}
if(idioma == "portugues")
{
    textsp2 = "O cliente do seculo voltou! Ele e um cliente recorrente!";
}
if(idioma == "japones")
{
    textsp2 = "世紀のお得意様が戻ってきた！常連さんだ！";
}
if(idioma == "coreano")
{
    textsp2 = "세기의 단골손님이 돌아왔다! 그는 단골이야!";
}
if(idioma == "chino")
{
    textsp2 = "本世纪的老主顾回来了！他是常客！";
}
if(idioma == "ruso")
{
    textsp2 = "Клиент века вернулся! Он постоянный посетитель!";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 36 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "To celebrate, I took from the storage room an object of unlimited happiness!";
}
if(idioma == "español")
{
    textsp2 = "Para celebrarlo, he sacado del trastero un objeto de felicidad ilimitada!";
}
if(idioma == "frances")
{
    textsp2 = "Pour celebrer, j'ai sorti du debarras un objet de bonheur illimite!";
}
if(idioma == "aleman")
{
    textsp2 = "Um das zu feiern, habe ich aus dem Abstellraum einen Gegenstand unendlichen Glucks herausgeholt!";
}
if(idioma == "italiano")
{
    textsp2 = "Per festeggiare, ho tirato fuori dal ripostiglio un oggetto di felicita illimitata!";
}
if(idioma == "portugues")
{
    textsp2 = "Para comemorar, tirei do sotao um objeto de felicidade ilimitada!";
}
if(idioma == "japones")
{
    textsp2 = "お祝いに、物置から無限の幸福をもたらす物を取り出したよ！";
}
if(idioma == "coreano")
{
    textsp2 = "축하하기 위해, 창고에서 무한한 행복의 물건을 꺼내왔어!";
}
if(idioma == "chino")
{
    textsp2 = "为了庆祝，我从杂物间拿出了一个带来无限幸福的物品！";
}
if(idioma == "ruso")
{
    textsp2 = "Чтобы отпраздновать, я достал из кладовки предмет безграничного счастья!";
}
opi = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 37 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "The old slot machine!";
}
if(idioma == "español")
{
    textsp2 = "La vieja tragaperras!";
}
if(idioma == "frances")
{
    textsp2 = "La vieille machine a sous !";
}
if(idioma == "aleman")
{
    textsp2 = "Der alte Spielautomat!";
}
if(idioma == "italiano")
{
    textsp2 = "La vecchia slot machine!";
}
if(idioma == "portugues")
{
    textsp2 = "A velha maquina de caca-niqueis!";
}
if(idioma == "japones")
{
    textsp2 = "古いスロットマシンだ！";
}
if(idioma == "coreano")
{
    textsp2 = "오래된 슬롯머신이다!";
}
if(idioma == "chino")
{
    textsp2 = "老老虎机！";
}
if(idioma == "ruso")
{
    textsp2 = "Старый игровой автомат!";
}
opi = false;
shop1.SetActive(false);
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 38 && writing == true)
             {
         arming3 = true;
         texm = false;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
             writing = false;
             invk.SetActive(true);
          cls = true;
          targetFOV = 30;
        Invoke("in1", 5f);
        Invoke("in11", 3.3f);
         fdt.clip = harp;
fdt.Play();
             }

             if(textorder == 39 && writing == false)
             {
    if(opi == false)
    {
    vanim.SetTrigger("feliz2");
    opi = true;
         fdt.clip = mxc;
fdt.Play();
    }
   arming2 = false;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "What?";
}
if(idioma == "español")
{
    textsp2 = "Que?";
}
if(idioma == "frances")
{
    textsp2 = "Quoi ?";
}
if(idioma == "aleman")
{
    textsp2 = "Was?";
}
if(idioma == "italiano")
{
    textsp2 = "Cosa?";
}
if(idioma == "portugues")
{
    textsp2 = "O que?";
}
if(idioma == "japones")
{
    textsp2 = "え？";
}
if(idioma == "coreano")
{
    textsp2 = "뭐?";
}
if(idioma == "chino")
{
    textsp2 = "什么？";
}
if(idioma == "ruso")
{
    textsp2 = "Что?";
}
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 40 && writing == true)
             {
         arming3 = true;
         texm = false;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
             writing = false;
        Invoke("in3", 3f);
             }

             if(textorder == 41 && writing == false)
             {
    if(opi2 == false)
    {
    vanim.SetTrigger("feliz1");
    opi2 = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Anyway, enjoy it";
}
if(idioma == "español")
{
    textsp2 = "En fin, disfruta de ella";
}
if(idioma == "frances")
{
    textsp2 = "Enfin, profite-en";
}
if(idioma == "aleman")
{
    textsp2 = "Also gut, genieße es";
}
if(idioma == "italiano")
{
    textsp2 = "Insomma, goditela";
}
if(idioma == "portugues")
{
    textsp2 = "Enfim, aproveite ela";
}
if(idioma == "japones")
{
    textsp2 = "まあ、楽しんでくれ";
}
if(idioma == "coreano")
{
    textsp2 = "아무튼, 잘 즐겨";
}
if(idioma == "chino")
{
    textsp2 = "总之，好好享受吧";
}
if(idioma == "ruso")
{
    textsp2 = "В общем, наслаждайся";
}
opi = false;
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 42 && writing == true)
             {
    if(opi == false)
    {
    vanim.SetTrigger("feliz2");
    vanim.SetTrigger("sd1");
         fdt.clip = null;
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Normally... there would be a song about gambling addiction now, but... she used to sing it by my side... and now I don't have the courage to do it alone...";
}
if(idioma == "español")
{
    textsp2 = "Normalmente... ahora habria una cancion sobre la ludopatia pero... ella la cantaba a mi lado... y ahora no reuno el valor para hacerlo solo...";
}
if(idioma == "frances")
{
    textsp2 = "Normalement... il y aurait maintenant une chanson sur la dependance au jeu mais... elle la chantait a mes cotes... et maintenant je n’ai plus le courage de le faire seul...";
}
if(idioma == "aleman")
{
    textsp2 = "Normalerweise... wurde jetzt ein Lied uber Spielsucht kommen, aber... sie sang es an meiner Seite... und jetzt habe ich nicht mehr den Mut, es allein zu machen...";
}
if(idioma == "italiano")
{
    textsp2 = "Normalmente... ora ci sarebbe una canzone sulla ludopatia ma... lei la cantava al mio fianco... e ora non ho il coraggio di farlo da solo...";
}
if(idioma == "portugues")
{
    textsp2 = "Normalmente... agora haveria uma musica sobre vicio em jogos mas... ela a cantava ao meu lado... e agora nao tenho coragem de faze-lo sozinho...";
}
if(idioma == "japones")
{
    textsp2 = "普通なら...今ごろギャンブル依存についての曲が始まるところだけど...彼女はいつも俺の隣で歌ってくれたんだ...今は一人で歌う勇気が出ない...";
}
if(idioma == "coreano")
{
    textsp2 = "보통이라면... 지금쯤 도박 중독에 대한 노래가 나올 텐데... 그녀가 내 옆에서 함께 불러줬거든... 이제는 혼자 부를 용기가 나지 않아...";
}
if(idioma == "chino")
{
    textsp2 = "通常来说...现在应该会有一首关于赌瘾的歌...但...她以前都会在我身旁唱...而现在我没有勇气独自唱下去...";
}
if(idioma == "ruso")
{
    textsp2 = "Обычно... сейчас прозвучала бы песня о лудомании, но... она пела её рядом со мной... и теперь у меня нет сил исполнять её одному...";
}
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 43 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "It’s 2 energy per spin... good luck...";
}
if(idioma == "español")
{
    textsp2 = "Son 2 de energia por tirada... suerte...";
}
if(idioma == "frances")
{
    textsp2 = "C’est 2 d’energie par tirage... bonne chance...";
}
if(idioma == "aleman")
{
    textsp2 = "Es sind 2 Energie pro Dreh... viel Gluck...";
}
if(idioma == "italiano")
{
    textsp2 = "Sono 2 di energia per ogni giro... buona fortuna...";
}
if(idioma == "portugues")
{
    textsp2 = "Sao 2 de energia por giro... boa sorte...";
}
if(idioma == "japones")
{
    textsp2 = "1回につきエネルギーは2だよ...幸運を...";
}
if(idioma == "coreano")
{
    textsp2 = "한 번 돌릴 때마다 에너지가 2야... 행운을...";
}
if(idioma == "chino")
{
    textsp2 = "每转一次要消耗2点能量...祝你好运...";
}
if(idioma == "ruso")
{
    textsp2 = "По 2 энергии за один спин... удачи...";
}
opi = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 44 && writing == true)
             {
         texm = false;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
             writing = false;
    if(opi2 == false)
    {
    vanim.SetTrigger("sd2");
    opi2 = true;
         fdt.clip = mxc;
fdt.Play();
    }
    freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
    timestop = false;
             }


             if(textorder == 45 && writing == false)
             {
    if(opi == false)
    {
    vanim.SetTrigger("feliz1");
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Hey, it's my favorite customer!";
}
if(idioma == "español")
{
    textsp2 = "Hey, si es mi cliente favorito!";
}
if(idioma == "frances")
{
    textsp2 = "He, c’est mon client prrfere!";
}
if(idioma == "aleman")
{
    textsp2 = "Hey, das ist mein Lieblingskunde!";
}
if(idioma == "italiano")
{
    textsp2 = "Ehi, e il mio cliente preferito!";
}
if(idioma == "portugues")
{
    textsp2 = "Ei, e o meu cliente favorito!";
}
if(idioma == "japones")
{
    textsp2 = "おや、俺のお気に入りのお客さんじゃないか！";
}
if(idioma == "coreano")
{
    textsp2 = "어이, 내가 제일 좋아하는 손님이잖아!";
}
if(idioma == "chino")
{
    textsp2 = "嘿，这是我最喜欢的客人！";
}
if(idioma == "ruso")
{
    textsp2 = "Эй, это мой любимый клиент!";
}
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 46 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Hey, we're friends, right? We've known each other for... how long? Two nights already?";
}
if(idioma == "español")
{
    textsp2 = "Oye, somos amigos, no? Nos conocemos desde hace... cuanto? Dos noches ya?";
}
if(idioma == "frances")
{
    textsp2 = "He, on est amis, non ? On se connait depuis... combien de temps? Deux nuits deja ?";
}
if(idioma == "aleman")
{
    textsp2 = "Hey, wir sind doch Freunde, oder? Wir kennen uns seit... wie lange? Schon zwei Nachte?";
}
if(idioma == "italiano")
{
    textsp2 = "Ehi, siamo amici, no? Ci conosciamo da... quanto? Gia due notti?";
}
if(idioma == "portugues")
{
    textsp2 = "Ei, somos amigos, ne? A gente se conhece ha... quanto tempo? Duas noites ja?";
}
if(idioma == "japones")
{
    textsp2 = "なあ、俺たち友達だよな？知り合ってから...どれくらいだ？もう2晩だっけ？";
}
if(idioma == "coreano")
{
    textsp2 = "야, 우리 친구 맞지? 알게 된 지... 얼마나 됐지? 벌써 이틀 밤이야?";
}
if(idioma == "chino")
{
    textsp2 = "喂，我们算是朋友了吧？认识多久了来着？已经两晚了吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Эй, мы же друзья, да? Мы знакомы уже... сколько? Уже две ночи?";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 47 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "In that case, would you mind if I asked you for a tiny little favor?";
}
if(idioma == "español")
{
    textsp2 = "En ese caso, te importa si te pido un minusculo favorcito?";
}
if(idioma == "frances")
{
    textsp2 = "Dans ce cas, ca te derange si je te demande un tout petit service ?";
}
if(idioma == "aleman")
{
    textsp2 = "In dem Fall, wurde es dir etwas ausmachen, wenn ich dich um einen klitzekleinen Gefallen bitte?";
}
if(idioma == "italiano")
{
    textsp2 = "In tal caso, ti dispiacerebbe se ti chiedessi un piccolissimo favore?";
}
if(idioma == "portugues")
{
    textsp2 = "Nesse caso, voce se importaria se eu te pedisse um favorzinho bem pequeno?";
}
if(idioma == "japones")
{
    textsp2 = "じゃあさ、ちょっとしたお願いをしてもいいかな？";
}
if(idioma == "coreano")
{
    textsp2 = "그럼 말인데, 아주 작은 부탁 하나 해도 될까?";
}
if(idioma == "chino")
{
    textsp2 = "既然这样，我能不能请你帮我一个小小的忙？";
}
if(idioma == "ruso")
{
    textsp2 = "В таком случае, ты не против, если я попрошу тебя об одном крошечном одолжении?";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 48 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Earlier I tried talking to my daughter... I thought bringing up her mother might lift some weight off her shoulders... and everything was going well...";
}
if(idioma == "español")
{
    textsp2 = "Antes intente hablar con mi hija... crei que hablar del tema de su madre le quitaria algo de peso de encima... y todo iba bien...";
}
if(idioma == "frances")
{
    textsp2 = "Plus tot, j’ai essaye de parler avec ma fille... je pensais qu’aborder le sujet de sa mere lui enleverait un peu de poids des epaules... et tout se passait bien...";
}
if(idioma == "aleman")
{
    textsp2 = "Vorhin habe ich versucht, mit meiner Tochter zu reden... ich dachte, das Thema ihrer Mutter wurde ihr etwas Last von den Schultern nehmen... und alles lief gut...";
}
if(idioma == "italiano")
{
    textsp2 = "Prima ho provato a parlare con mia figlia... pensavo che parlare di sua madre le avrebbe tolto un po’ di peso dalle spalle... e stava andando tutto bene...";
}
if(idioma == "portugues")
{
    textsp2 = "Antes tentei falar com minha filha... achei que tocar no assunto da mae dela tiraria um pouco do peso de cima... e estava tudo indo bem...";
}
if(idioma == "japones")
{
    textsp2 = "さっき娘と話そうとしたんだ...母親の話題に触れれば、少しは気が楽になると思って...最初はうまくいってた...";
}
if(idioma == "coreano")
{
    textsp2 = "아까 딸과 이야기를 해보려고 했어... 어머니 이야기를 꺼내면 조금은 마음의 짐이 덜어질 거라 생각했거든... 처음엔 잘 되고 있었어...";
}
if(idioma == "chino")
{
    textsp2 = "之前我试着和我女儿谈谈...我以为提起她母亲的话题能让她轻松一点...一开始一切都很顺利...";
}
if(idioma == "ruso")
{
    textsp2 = "Ранее я попытался поговорить с дочерью... я думал, что разговор о её матери немного облегчит её ношу... и всё шло хорошо...";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 49 && writing == false)
             {
    if(opi == false)
    {
    vanim.SetTrigger("feliz2");
    vanim.SetTrigger("sd1");
         fdt.clip = null;
    opi = true;
    }
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "At least until she told me she never wanted to see me again.";
}
if(idioma == "español")
{
    textsp2 = "Al menos hasta que me dijo que no queria verme nunca mas.";
}
if(idioma == "frances")
{
    textsp2 = "Du moins jusqu’a ce qu’elle me dise qu’elle ne voulait plus jamais me voir.";
}
if(idioma == "aleman")
{
    textsp2 = "Zumindest bis sie mir sagte, dass sie mich nie wieder sehen wollte.";
}
if(idioma == "italiano")
{
    textsp2 = "Almeno fino a quando mi ha detto che non voleva piu vedermi.";
}
if(idioma == "portugues")
{
    textsp2 = "Pelo menos ate que ela me disse que nunca mais queria me ver.";
}
if(idioma == "japones")
{
    textsp2 = "少なくとも...二度と会いたくないって言われるまではな。";
}
if(idioma == "coreano")
{
    textsp2 = "적어도... 다시는 보고 싶지 않다고 말하기 전까지는 말이야.";
}
if(idioma == "chino")
{
    textsp2 = "至少...直到她对我说她再也不想见到我为止。";
}
if(idioma == "ruso")
{
    textsp2 = "По крайней мере до тех пор, пока она не сказала, что больше никогда не хочет меня видеть.";
}
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 50 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I know how stupid it is to ask this of a customer, but... honestly, I don't know what else to do anymore...";
}
if(idioma == "español")
{
    textsp2 = "Se lo estupido que es pedirle esto a un cliente, pero... honestamente ya no se que hacer...";
}
if(idioma == "frances")
{
    textsp2 = "Je sais a quel point c’est stupide de demander ca a un client, mais... honnetement, je ne sais plus quoi faire...";
}
if(idioma == "aleman")
{
    textsp2 = "Ich weiß, wie dumm es ist, das von einem Kunden zu verlangen, aber... ehrlich gesagt weiß ich nicht mehr, was ich tun soll...";
}
if(idioma == "italiano")
{
    textsp2 = "So quanto sia stupido chiedere una cosa del genere a un cliente, ma... sinceramente non so piu cosa fare...";
}
if(idioma == "portugues")
{
    textsp2 = "Eu sei o quao estupido e pedir isso a um cliente, mas... sinceramente ja nao sei o que fazer...";
}
if(idioma == "japones")
{
    textsp2 = "客にこんなことを頼むなんて馬鹿げてるのは分かってる...でも正直、もうどうすればいいのか分からないんだ...";
}
if(idioma == "coreano")
{
    textsp2 = "손님에게 이런 부탁을 하는 게 얼마나 어리석은지 알지만... 솔직히 이제 뭘 해야 할지 모르겠어...";
}
if(idioma == "chino")
{
    textsp2 = "我知道向客人提出这种请求很愚蠢...但说实话，我已经不知道该怎么办了...";
}
if(idioma == "ruso")
{
    textsp2 = "Я понимаю, насколько глупо просить об этом клиента, но... честно говоря, я уже не знаю, что делать...";
}
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 51 && writing == false)
             {
armingg = false;
shop2.SetActive(true);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I'm begging you... please... could you talk to her?";
}
if(idioma == "español")
{
    textsp2 = "Te lo suplico... por favor... podrias hablar con ella?";
}
if(idioma == "frances")
{
    textsp2 = "Je t’en supplie... s’il te plaît... pourrais-tu lui parler ?";
}
if(idioma == "aleman")
{
    textsp2 = "Ich flehe dich an... bitte... konntest du mit ihr reden?";
}
if(idioma == "italiano")
{
    textsp2 = "Ti supplico... per favore... potresti parlare con lei?";
}
if(idioma == "portugues")
{
    textsp2 = "Eu te imploro... por favor... voce poderia falar com ela?";
}
if(idioma == "japones")
{
    textsp2 = "頼む...お願いだ...彼女と話してくれないか？";
}
if(idioma == "coreano")
{
    textsp2 = "제발... 부탁이야... 그녀와 이야기해 줄 수 있을까?";
}
if(idioma == "chino")
{
    textsp2 = "我求你了...拜托...你能和她谈谈吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Я умоляю тебя... пожалуйста... ты мог бы поговорить с ней?";
}
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }
             if(textorder == 52 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "She's at the end of the ventilation duct to your left...";
}
if(idioma == "español")
{
    textsp2 = "Esta al fondo del conducto de ventilacion a tu izquierda...";
}
if(idioma == "frances")
{
    textsp2 = "Elle est au fond du conduit de ventilation a ta gauche...";
}
if(idioma == "aleman")
{
    textsp2 = "Sie ist am Ende des Luftungsschachts zu deiner Linken...";
}
if(idioma == "italiano")
{
    textsp2 = "E in fondo al condotto di ventilazione alla tua sinistra...";
}
if(idioma == "portugues")
{
    textsp2 = "Ela esta no fundo do duto de ventilacao a sua esquerda...";
}
if(idioma == "japones")
{
    textsp2 = "彼女は左側の換気ダクトの奥にいる...";
}
if(idioma == "coreano")
{
    textsp2 = "그녀는 왼쪽 환기 덕트의 끝에 있어...";
}
if(idioma == "chino")
{
    textsp2 = "她在你左边通风管道的尽头...";
}
if(idioma == "ruso")
{
    textsp2 = "Она в конце вентиляционного канала слева от тебя...";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 53 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I hope it goes well...";
}
if(idioma == "español")
{
    textsp2 = "espero que vaya bien...";
}
if(idioma == "frances")
{
    textsp2 = "j’espere que ca se passera bien...";
}
if(idioma == "aleman")
{
    textsp2 = "ich hoffe, es lauft gut...";
}
if(idioma == "italiano")
{
    textsp2 = "spero che vada bene...";
}
if(idioma == "portugues")
{
    textsp2 = "espero que de tudo certo...";
}
if(idioma == "japones")
{
    textsp2 = "うまくいくことを願ってる...";
}
if(idioma == "coreano")
{
    textsp2 = "잘 되길 바랄게...";
}
if(idioma == "chino")
{
    textsp2 = "希望一切顺利...";
}
if(idioma == "ruso")
{
    textsp2 = "надеюсь, всё пройдёт хорошо...";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 54 && writing == true)
             {
    shop1.SetActive(false);
         texm = false;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
    freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
    timestop = false;
    writing = false;
             }

             if(textorder == 55 && writing == false)
             {
shop3.SetActive(true);
nolev = false;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Lights off, you creep.";
}
if(idioma == "español")
{
    textsp2 = "Apaga la luz, idiota.";
}
if(idioma == "frances")
{
    textsp2 = "Eteins la lumiere, espece de pervers.";
}
if(idioma == "aleman")
{
    textsp2 = "Licht aus, du Widerling.";
}
if(idioma == "italiano")
{
    textsp2 = "Spegni la luce, idiota.";
}
if(idioma == "portugues")
{
    textsp2 = "Apaga a luz, seu esquisito.";
}
if(idioma == "japones")
{
    textsp2 = "電気消してよ、キモい。";
}
if(idioma == "coreano")
{
    textsp2 = "불 꺼, 변태야.";
}
if(idioma == "chino")
{
    textsp2 = "把灯关了，变态。";
}
if(idioma == "ruso")
{
    textsp2 = "Выключи свет, придурок.";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 56 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Daughter?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Hija?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Fille?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Tochter?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Figlia?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Filha?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "娘?";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "딸?";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "女儿?";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Дочь?";
}
lant.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Let me guess, dad asked his customer to solve his family problems. I don't even need to use the cards to see that.";
}
if(idioma == "español")
{
    textsp2 = "Dejame adivinar, papa le ha pedido a su cliente que resuelva sus problemas intrafamiliares. Ni siquiera necesito usar las cartas para verlo.";
}
if(idioma == "frances")
{
    textsp2 = "Laisse-moi deviner, papa a demande a son client de regler ses problemes familiaux. Je n’ai meme pas besoin d’utiliser les cartes pour le voir.";
}
if(idioma == "aleman")
{
    textsp2 = "Lass mich raten, Papa hat seinen Kunden gebeten, seine familiären Probleme zu lösen. Dafür brauche ich nicht einmal die Karten.";
}
if(idioma == "italiano")
{
    textsp2 = "Fammi indovinare, papa ha chiesto al suo cliente di risolvere i suoi problemi familiari. Non ho nemmeno bisogno di usare le carte per capirlo.";
}
if(idioma == "portugues")
{
    textsp2 = "Deixa eu adivinhar, o papai pediu ao cliente dele para resolver os problemas familiares. Nem preciso usar as cartas para ver isso.";
}
if(idioma == "japones")
{
    textsp2 = "当ててみようか。パパが客に家庭の問題を解決させようとしてるんでしょ。カードを使わなくても分かるよ。";
}
if(idioma == "coreano")
{
    textsp2 = "맞혀볼까? 아빠가 손님한테 가족 문제를 해결해 달라고 한 거지. 카드 안 써도 다 보여.";
}
if(idioma == "chino")
{
    textsp2 = "让我猜猜，爸爸让他的客人来解决家庭问题了吧。我连牌都不用看就知道了。";
}
if(idioma == "ruso")
{
    textsp2 = "Дай угадаю, папа попросил своего клиента разобраться с его семейными проблемами. Мне даже карты не нужны, чтобы это увидеть.";
}
opi = false;
opi2 = false;
nol.SetActive(true);
shop2.SetActive(false);
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 57 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Gamer?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Gamer?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Gamer?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Gamer?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Gamer?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Gamer?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ゲーマー?";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "게이머?";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "玩家?";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Геймер?";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Something tells me you’re not leaving even if I ask, like this is some side quest in a video game or something.";
}
if(idioma == "español")
{
    textsp2 = "Algo me dice que no te vas a ir aunque te lo pida, como si esto fuera la mision secundaria de un videojuego o algo.";
}
if(idioma == "frances")
{
    textsp2 = "Quelque chose me dit que tu ne vas pas partir meme si je le demande, comme si c’etait une quete secondaire dans un jeu video ou quelque chose comme ca.";
}
if(idioma == "aleman")
{
    textsp2 = "Irgendetwas sagt mir, dass du nicht gehst, auch wenn ich es bitte, als wäre das eine Nebenquest in einem Videospiel oder so.";
}
if(idioma == "italiano")
{
    textsp2 = "Qualcosa mi dice che non te ne andrai nemmeno se te lo chiedo, come se fosse una missione secondaria di un videogioco o qualcosa del genere.";
}
if(idioma == "portugues")
{
    textsp2 = "Algo me diz que voce nao vai embora mesmo se eu pedir, como se isso fosse uma missao secundaria de videogame ou algo assim.";
}
if(idioma == "japones")
{
    textsp2 = "頼んでも絶対に去らない気がするな、まるでゲームのサイドクエストみたいに。";
}
if(idioma == "coreano")
{
    textsp2 = "내가 부탁해도 절대 가지 않을 것 같아, 마치 비디오 게임의 사이드 퀘스트처럼.";
}
if(idioma == "chino")
{
    textsp2 = "总觉得即使我让你走，你也不会离开，就像这是游戏里的支线任务一样。";
}
if(idioma == "ruso")
{
    textsp2 = "Что-то подсказывает мне, что ты не уйдешь, даже если я попрошу, как будто это побочное задание в видеоигре или что-то такое.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 58 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "And you look like the kind of nerd who finishes the game 100%, so let's get this over with, shall we?";
}
if(idioma == "español")
{
    textsp2 = "Y tu tienes toda la pinta de friki que termina el juego al 100%, asi que vamos a acabar con esto rapido, vale?";
}
if(idioma == "frances")
{
    textsp2 = "Et toi, t’as l’air du genre de geek qui finit le jeu a 100%, alors finissons-en vite, d’accord ?";
}
if(idioma == "aleman")
{
    textsp2 = "Und du siehst aus wie der Typ Nerd, der das Spiel zu 100% abschließt, also lass uns das schnell erledigen, ja?";
}
if(idioma == "italiano")
{
    textsp2 = "E tu sembri proprio il tipo di nerd che finisce il gioco al 100%, quindi finiamo in fretta, ok?";
}
if(idioma == "portugues")
{
    textsp2 = "E voce tem cara de nerd que termina o jogo 100%, entao vamos acabar com isso rapido, ta?";
}
if(idioma == "japones")
{
    textsp2 = "そして君はゲームを100％クリアするオタクっぽいから、さっさと終わらせようか。";
}
if(idioma == "coreano")
{
    textsp2 = "그리고 너, 게임을 100% 클리어하는 덕후 같은데, 그러니까 빨리 끝내자.";
}
if(idioma == "chino")
{
    textsp2 = "你看起来就像那种把游戏玩到100%的宅，所以我们快点结束吧。";
}
if(idioma == "ruso")
{
    textsp2 = "И ты выглядишь как тот самый задрот, что проходит игру на 100%, так что давай покончим с этим быстро.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 59 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Daughter";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Hija";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Fille";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Tochter";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Figlia";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Filha";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "娘";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "딸";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "女儿";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Дочь";
}
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "He always does this, you know? He does whatever he thinks is best for me, even if I totally disagree!";
}
if(idioma == "español")
{
    textsp2 = "Siempre hace esto, sabes? Hace lo que le parece mejor para mi, aunque yo no este de acuerdo en absoluto!";
}
if(idioma == "frances")
{
    textsp2 = "Il fait toujours ca, tu sais ? Il fait ce qu'il pense etre le mieux pour moi, meme si je ne suis pas du tout d'accord !";
}
if(idioma == "aleman")
{
    textsp2 = "Er macht das immer, weißt du? Er tut, was er fur das Beste fur mich halt, auch wenn ich uberhaupt nicht einverstanden bin!";
}
if(idioma == "italiano")
{
    textsp2 = "Fa sempre cosi, sai? Fa quello che pensa sia meglio per me, anche se non sono affatto d'accordo!";
}
if(idioma == "portugues")
{
    textsp2 = "Ele sempre faz isso, sabe? Ele faz o que acha melhor para mim, mesmo que eu nao concorde nem um pouco!";
}
if(idioma == "japones")
{
    textsp2 = "いつもこうするんだよね、わかる？彼は自分が私のために最善だと思うことをする、たとえ私が全然同意してなくても！";
}
if(idioma == "coreano")
{
    textsp2 = "항상 이렇게 해, 알지? 그는 내가 동의하지 않아도 내가 위해 최고라고 생각하는 건 뭐든 해!";
}
if(idioma == "chino")
{
    textsp2 = "他总是这样做，你知道吗？他做他认为对我最好的事，即使我完全不同意！";
}
if(idioma == "ruso")
{
    textsp2 = "Он всегда так делает, знаешь? Делает то, что считает лучшим для меня, даже если я совсем не согласна!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 60 && writing == true)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
mirai += 1;
if(idioma == "ingles")
{
    textsp2 = "Yeah, I get that, genius! The problem is that he worries too much! I wish... he trusted me more and let me handle my own problems.";
}
if(idioma == "español")
{
    textsp2 = "Si, hasta ahi llego, genio! El problema es que se preocupa demasiado. Ojala... confiara mas en mi y me dejara resolver mis propios problemas.";
}
if(idioma == "frances")
{
    textsp2 = "Oui, jusque-la j'ai compris, genie ! Le probleme, c'est qu'il s'inquiete trop. J'aimerais... qu'il me fasse plus confiance et me laisse regler mes propres problemes.";
}
if(idioma == "aleman")
{
    textsp2 = "Ja, bis dahin habe ich es verstanden, Genie! Das Problem ist, dass er sich zu viele Sorgen macht. Ich wunschte... er wurde mir mehr vertrauen und mich meine eigenen Probleme losen lassen.";
}
if(idioma == "italiano")
{
    textsp2 = "Si, fin li ci arrivo, genio! Il problema e che si preoccupa troppo. Vorrei... che si fidasse di piu di me e mi lasciasse risolvere i miei problemi.";
}
if(idioma == "portugues")
{
    textsp2 = "Sim, ate ai eu entendo, genio! O problema e que ele se preocupa demais. Queria... que confiasse mais em mim e me deixasse resolver meus proprios problemas.";
}
if(idioma == "japones")
{
    textsp2 = "うん、そこまでは分かってるよ、天才！問題は、彼が心配しすぎるってこと。できれば...もっと私を信じて、自分の問題は自分で解決させてほしい。";
}
if(idioma == "coreano")
{
    textsp2 = "그래, 그 정도는 알아, 천재님! 문제는 그가 너무 걱정한다는 거야. 제발... 나를 좀 더 믿고 내 문제는 내가 해결하게 해줬으면 좋겠어.";
}
if(idioma == "chino")
{
    textsp2 = "是的，那点我当然知道，天才！问题是他太过担心了。真希望...他能多信任我一点，让我自己解决我的问题。";
}
if(idioma == "ruso")
{
    textsp2 = "Да, до этого я дошла, гений! Проблема в том, что он слишком переживает. Хотелось бы... чтобы он больше мне доверял и позволял самой решать свои проблемы.";
}
}

if(option == "B")
{
mirai -= 1;
if(idioma == "ingles")
{
    textsp2 = "Finally, someone who understands what I'm saying! He should let me deal with my own matters!";
}
if(idioma == "español")
{
    textsp2 = "Al fin alguien que entiende lo que digo! El deberia dejarme lidiar con mis asuntos!";
}
if(idioma == "frances")
{
    textsp2 = "Enfin quelqu'un qui comprend ce que je dis ! Il devrait me laisser gerer mes affaires !";
}
if(idioma == "aleman")
{
    textsp2 = "Endlich jemand, der versteht, was ich sage! Er sollte mich meine eigenen Angelegenheiten regeln lassen!";
}
if(idioma == "italiano")
{
    textsp2 = "Finalmente qualcuno che capisce quello che dico! Dovrebbe lasciarmi occuparmi dei miei affari!";
}
if(idioma == "portugues")
{
    textsp2 = "Finalmente alguem que entende o que eu digo! Ele deveria me deixar lidar com os meus assuntos!";
}
if(idioma == "japones")
{
    textsp2 = "やっと私の言ってることを理解してくれる人がいた！彼は私に自分のことを自分で対処させるべきだ！";
}
if(idioma == "coreano")
{
    textsp2 = "마침내 내가 하는 말을 이해해 주는 사람이 있네! 그는 내 일은 내가 처리하게 둬야 해!";
}
if(idioma == "chino")
{
    textsp2 = "终于有人理解我在说什么了！他应该让我自己处理我的事情！";
}
if(idioma == "ruso")
{
    textsp2 = "Наконец-то кто-то понимает, что я говорю! Он должен позволить мне самой разбираться со своими делами!";
}
}

if(option == "C")
{
mirai -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "My mother? He also put that idea in your head? He thinks this is just a phase because of my mother's death or something... But he's the one who hasn't moved on!";
}
if(idioma == "español")
{
    textsp2 = "Mi madre? El tambien te ha metido esa idea en la cabeza? El cree que esto es una fase por culpa de la muerte de mi madre o algo asi... Pero es el el que no ha pasado pagina!";
}
if(idioma == "frances")
{
    textsp2 = "Ma mere ? Il t'a aussi mis cette idee en tete ? Il pense que c'est juste une phase a cause de la mort de ma mere ou quelque chose comme ca... Mais c'est lui qui n'a pas tourne la page !";
}
if(idioma == "aleman")
{
    textsp2 = "Meine Mutter? Hat er dir diese Idee auch ins Kopf gesetzt? Er denkt, das ist nur eine Phase wegen des Todes meiner Mutter oder so... Aber er ist derjenige, der nicht weitergekommen ist!";
}
if(idioma == "italiano")
{
    textsp2 = "Mia madre? Anche lui ti ha messo quest'idea in testa? Pensa che sia solo una fase a causa della morte di mia madre o qualcosa del genere... Ma e lui quello che non ha superato la cosa!";
}
if(idioma == "portugues")
{
    textsp2 = "Minha mae? Ele tambem te colocou essa ideia na cabeca? Ele acha que isso e apenas uma fase por causa da morte da minha mae ou algo assim... Mas ele e quem nao superou!";
}
if(idioma == "japones")
{
    textsp2 = "母のこと？彼もその考えを君の頭に植え付けたの？彼はこれが母の死のせいの一時的なことだと思っている...でも、本当に前に進んでいないのは彼の方だ！";
}
if(idioma == "coreano")
{
    textsp2 = "내 엄마? 그 사람도 네 머릿속에 그런 생각 심었어? 그는 이것이 엄마의 죽음 때문인 한 시기적 현상이라고 생각하지만... 사실 문제를 해결하지 못한 건 그 자신이야!";
}
if(idioma == "chino")
{
    textsp2 = "我妈妈？他也把这个想法灌输给你了？他认为这只是因为我母亲去世的一个阶段或者什么的...但真正没有走出的人是他！";
}
if(idioma == "ruso")
{
    textsp2 = "Моя мать? Он тоже внушил тебе эту мысль? Он думает, что это всего лишь фаза из-за смерти моей матери или что-то вроде того... Но на самом деле не пережил это он!";
}
}

if(option == "D")
{
mirai += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Eh? What are you talking about? Although... I guess... there must be people somewhere who are dealing with it worse.";
}
if(idioma == "español")
{
    textsp2 = "Eh? De que hablas? Aunque... supongo que... debe haber gente que lo lleve peor en algun lugar.";
}
if(idioma == "frances")
{
    textsp2 = "Hein ? De quoi parles-tu ? Bien que... je suppose que... il doit y avoir des gens quelque part qui vivent ca pire.";
}
if(idioma == "aleman")
{
    textsp2 = "Eh? Wovon redest du? Obwohl... ich schatze... muss es irgendwo Leute geben, die es schlimmer haben.";
}
if(idioma == "italiano")
{
    textsp2 = "Eh? Di cosa parli? Anche se... suppongo che... ci debbano essere persone da qualche parte a cui va peggio.";
}
if(idioma == "portugues")
{
    textsp2 = "Eh? Do que voce esta falando? Embora... eu suponha que... deve haver pessoas em algum lugar que estejam passando pior.";
}
if(idioma == "japones")
{
    textsp2 = "え？何の話？でも...たぶん...どこかにはもっと大変な思いをしている人もいるんだろうね。";
}
if(idioma == "coreano")
{
    textsp2 = "어? 무슨 말이야? 그래도... 아마... 어딘가에는 더 힘든 사람들도 있을 거야.";
}
if(idioma == "chino")
{
    textsp2 = "诶？你在说什么？不过...我想...应该还有人在某些地方过得更糟。";
}
if(idioma == "ruso")
{
    textsp2 = "Э? О чём ты говоришь? Хотя... думаю... где-то есть люди, которым приходится хуже.";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 61 && writing == false)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
mirai -= 1;
if(idioma == "ingles")
{
    textsp2 = "Talk to him? You think I haven't tried? If mom were here, she would surely understand me... But he won't.";
}
if(idioma == "español")
{
    textsp2 = "Hablar con el? Te crees que no lo he intentado? Si mama estuviera aqui, seguro que me entenderia... Pero el no lo hara.";
}
if(idioma == "frances")
{
    textsp2 = "Parler avec lui ? Tu crois que je n'ai pas essaye ? Si maman etait ici, elle me comprendrait surement... Mais lui ne le fera pas.";
}
if(idioma == "aleman")
{
    textsp2 = "Mit ihm reden? Denkst du, ich hatte es nicht versucht? Wenn Mama hier ware, wurde sie mich sicher verstehen... Aber er wird es nicht tun.";
}
if(idioma == "italiano")
{
    textsp2 = "Parlare con lui? Credi che non ci abbia provato? Se mamma fosse qui, sicuramente mi capirebbe... Ma lui non lo fara.";
}
if(idioma == "portugues")
{
    textsp2 = "Falar com ele? Voce acha que eu nao tentei? Se a mamae estivesse aqui, com certeza ela me entenderia... Mas ele nao vai.";
}
if(idioma == "japones")
{
    textsp2 = "彼と話す？試してないと思ってるの？もしママがここにいたら、きっと私のことを理解してくれる...でも彼はそうしない。";
}
if(idioma == "coreano")
{
    textsp2 = "그와 이야기하라고? 내가 안 해봤다고 생각해? 엄마가 여기 있었다면 분명 날 이해해줬을 텐데... 하지만 그는 그럴 리가 없어.";
}
if(idioma == "chino")
{
    textsp2 = "跟他谈？你以为我没试过吗？如果妈妈在这里，她肯定会理解我...但他不会的。";
}
if(idioma == "ruso")
{
    textsp2 = "Поговорить с ним? Думаешь, я не пыталась? Если бы мама была здесь, она бы меня точно поняла... Но он этого не сделает.";
}
}

if(option == "B")
{
mirai -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Hey... That was a bit cruel, wasn't it?... Although... maybe you're kind of right... Mom used to fix these problems... He did listen to her...";
}
if(idioma == "español")
{
    textsp2 = "Oye... Eso ha sido un poco cruel, no?... Aunque... tal vez tienes algo de razon... Mama solia arreglar estos problemas... El si la escuchaba...";
}
if(idioma == "frances")
{
    textsp2 = "He... C'etait un peu cruel, non ?... Bien que... tu as peut-etre un peu raison... Maman reglait ces problemes... Lui, il l'ecoutait...";
}
if(idioma == "aleman")
{
    textsp2 = "Hey... Das war ein bisschen gemein, oder?... Obwohl... vielleicht hast du ein Stuck weit recht... Mama hat diese Probleme immer gelost... Er hat ihr zugehort...";
}
if(idioma == "italiano")
{
    textsp2 = "Ehi... E stato un po' crudele, no?... Anche se... forse hai un po' di ragione... La mamma risolveva sempre questi problemi... Lui l'ascoltava...";
}
if(idioma == "portugues")
{
    textsp2 = "Ei... Isso foi um pouco cruel, nao?... Embora... talvez voce esteja um pouco certo... Mamae costumava resolver esses problemas... Ele a escutava...";
}
if(idioma == "japones")
{
    textsp2 = "ねえ... それはちょっと意地悪だったよね？...でも...もしかしたらあなたの言うことも一理ある...ママはこういう問題を解決してくれた...彼はママの話を聞いてくれた...";
}
if(idioma == "coreano")
{
    textsp2 = "있지... 그거 좀 잔인했지, 안 그래?... 그래도... 아마 네 말이 맞는 부분도 있겠지... 엄마는 이런 문제들을 해결하곤 했어... 그는 엄마 말을 들었어...";
}
if(idioma == "chino")
{
    textsp2 = "嘿... 那有点残酷，不是吗？...不过...也许你有点道理...妈妈以前会解决这些问题...他会听她的...";
}
if(idioma == "ruso")
{
    textsp2 = "Эй... Это было немного жестоко, не так ли?... Хотя... может, ты отчасти прав... Мама всегда решала такие проблемы... А он её слушал...";
}
}

if(option == "C")
{
mirai += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Shut up! Even though he's the oldest, ever since she left he carries a heavy burden... That's why I have to be strong for both of us.";
}
if(idioma == "español")
{
    textsp2 = "Callate! Aunque sea el mayor, desde que ella se fue el carga un gran peso... Por eso debo ser fuerte por los dos.";
}
if(idioma == "frances")
{
    textsp2 = "Tais-toi ! Meme s'il est l'aine, depuis qu'elle est partie, il porte un lourd fardeau... C'est pour ca que je dois etre forte pour nous deux.";
}
if(idioma == "aleman")
{
    textsp2 = "Halt den Mund! Auch wenn er der Alteste ist, seit sie gegangen ist, tragt er eine große Last... Deshalb muss ich fur uns beide stark sein.";
}
if(idioma == "italiano")
{
    textsp2 = "Stai zitta! Anche se e il maggiore, da quando se n'e andata porta un grande peso... Ecco perche devo essere forte per entrambi.";
}
if(idioma == "portugues")
{
    textsp2 = "Cala a boca! Mesmo sendo o mais velho, desde que ela se foi ele carrega um grande peso... Por isso devo ser forte pelos dois.";
}
if(idioma == "japones")
{
    textsp2 = "黙れ！長男だけど、彼女がいなくなってから彼は大きな重荷を背負っている...だから私は二人のために強くならなきゃ。";
}
if(idioma == "coreano")
{
    textsp2 = "닥쳐! 비록 그가 맏이지만, 그녀가 떠난 이후로 그는 큰 짐을 지고 있어... 그래서 나는 우리 둘을 위해 강해야 해.";
}
if(idioma == "chino")
{
    textsp2 = "闭嘴！虽然他是大哥，但自从她离开后，他背负了很大的压力...所以我必须为我们俩坚强。";
}
if(idioma == "ruso")
{
    textsp2 = "Заткнись! Хотя он старший, с тех пор как она ушла, он несет большую ношу... Поэтому я должна быть сильной за нас обоих.";
}
}

if(option == "D")
{
mirai += 1f;
if(idioma == "ingles")
{
    textsp2 = "What kind of question is that? Who doesn't care about their family?";
}
if(idioma == "español")
{
    textsp2 = "Que pregunta es esa? Quien no se preocupa por su familia?";
}
if(idioma == "frances")
{
    textsp2 = "Quelle question est-ce ? Qui ne se soucie pas de sa famille ?";
}
if(idioma == "aleman")
{
    textsp2 = "Was fur eine Frage ist das? Wer sorgt sich nicht um seine Familie?";
}
if(idioma == "italiano")
{
    textsp2 = "Che domanda e questa? Chi non si preoccupa per la propria famiglia?";
}
if(idioma == "portugues")
{
    textsp2 = "Que pergunta e essa? Quem nao se preocupa com sua familia?";
}
if(idioma == "japones")
{
    textsp2 = "何て質問なの？誰が家族のことを心配しないの？";
}
if(idioma == "coreano")
{
    textsp2 = "그게 무슨 질문이야? 누가 가족을 걱정하지 않겠어?";
}
if(idioma == "chino")
{
    textsp2 = "这是什么问题？谁不会关心自己的家人？";
}
if(idioma == "ruso")
{
    textsp2 = "Что за вопрос? Кто не заботится о своей семье?";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }


             if(textorder == 62 && writing == true)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
mirai -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Wow! Children resemble their parents? No way! Wait, you also look like yours? Impossible! You've just discovered America";
}
if(idioma == "español")
{
    textsp2 = "Wow! Los hijos se parecen a sus padres? No puede ser! Espera, tu tambien te pareces a los tuyos? Imposible! Acabas de descubrir America";
}
if(idioma == "frances")
{
    textsp2 = "Wow ! Les enfants ressemblent a leurs parents ? Impossible ! Attends, toi aussi tu ressembles aux tiens ? Incroyable ! Tu viens de decouvrir l'Amerique";
}
if(idioma == "aleman")
{
    textsp2 = "Wow! Kinder ahneln ihren Eltern? Das kann nicht sein! Warte, du siehst auch wie deine aus? Unmoglich! Du hast gerade Amerika entdeckt";
}
if(idioma == "italiano")
{
    textsp2 = "Wow! I figli assomigliano ai loro genitori? Non puo essere! Aspetta, anche tu assomigli ai tuoi? Impossibile! Hai appena scoperto l'America";
}
if(idioma == "portugues")
{
    textsp2 = "Uau! Os filhos se parecem com os pais? Nao pode ser! Espera, voce tambem se parece com os seus? Impossivel! Acabou de descobrir a America";
}
if(idioma == "japones")
{
    textsp2 = "わあ！子供は親に似るの？そんなはずはない！待って、あなたも自分の家族に似てるの？信じられない！まさに新大陸を発見した気分だ";
}
if(idioma == "coreano")
{
    textsp2 = "와! 아이들은 부모를 닮았다고? 말도 안 돼! 잠깐, 너도 네 가족을 닮았다고? 불가능해! 너 방금 아메리카를 발견했어";
}
if(idioma == "chino")
{
    textsp2 = "哇！孩子会像他们的父母？不可能！等等，你也像你家人？不可能！你刚刚发现了美洲";
}
if(idioma == "ruso")
{
    textsp2 = "Вау! Дети похожи на своих родителей? Не может быть! Подожди, ты тоже похож на своих? Невозможно! Ты только что открыл Америку";
}
}

if(option == "B")
{
mirai += 1f;
if(idioma == "ingles")
{
    textsp2 = "... Just a little. I'm sure you would miss yours too.";
}
if(idioma == "español")
{
    textsp2 = "... Solo un poco. Estoy segura de que tu tambien echarias de menos a los tuyos.";
}
if(idioma == "frances")
{
    textsp2 = "... Juste un peu. Je suis sure que toi aussi, tu manquerais aux tiens.";
}
if(idioma == "aleman")
{
    textsp2 = "... Nur ein wenig. Ich bin sicher, dass du deine auch vermissen wurdest.";
}
if(idioma == "italiano")
{
    textsp2 = "... Solo un po'. Sono sicura che anche tu sentiresti la mancanza dei tuoi.";
}
if(idioma == "portugues")
{
    textsp2 = "... So um pouco. Tenho certeza de que voce tambem sentiria falta dos seus.";
}
if(idioma == "japones")
{
    textsp2 = "... ちょっとだけ。あなたも大切な人が恋しくなると思うわ。";
}
if(idioma == "coreano")
{
    textsp2 = "... 조금만. 너도 너의 사람들을 그리워할 거라고 확신해.";
}
if(idioma == "chino")
{
    textsp2 = "... 只有一点点。我相信你也会想念你的人。";
}
if(idioma == "ruso")
{
    textsp2 = "... Только немного. Я уверена, что ты тоже скучал бы по своим.";
}
}

if(option == "C")
{
mirai += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "I mean, I'm handling it better than him! But really... could you just forget that your parents died?";
}
if(idioma == "español")
{
    textsp2 = "Me refiero a que lo llevo mejor que el! Pero en verdad... tu podrias simplemente olvidar que tus padres murieron?";
}
if(idioma == "frances")
{
    textsp2 = "Je veux dire, je gere mieux que lui ! Mais vraiment... pourrais-tu simplement oublier que tes parents sont morts ?";
}
if(idioma == "aleman")
{
    textsp2 = "Ich meine, ich komme besser damit klar als er! Aber im Ernst... konntest du einfach vergessen, dass deine Eltern gestorben sind?";
}
if(idioma == "italiano")
{
    textsp2 = "Intendo dire che lo sto gestendo meglio di lui! Ma davvero... potresti semplicemente dimenticare che i tuoi genitori sono morti?";
}
if(idioma == "portugues")
{
    textsp2 = "Quero dizer, eu estou lidando melhor que ele! Mas na verdade... voce poderia simplesmente esquecer que seus pais morreram?";
}
if(idioma == "japones")
{
    textsp2 = "つまり、私は彼よりうまくやってるってこと！でも本当に...両親が亡くなったことを簡単に忘れられると思う？";
}
if(idioma == "coreano")
{
    textsp2 = "내 말은, 내가 그보다 잘 견디고 있다는 거야! 하지만 정말로... 네 부모가 돌아가셨다는 걸 그냥 잊을 수 있겠어?";
}
if(idioma == "chino")
{
    textsp2 = "我的意思是，我比他处理得好！但真的...你能就这样忘记你的父母去世了吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Я имею в виду, я справляюсь с этим лучше, чем он! Но правда... ты бы смог просто забыть, что твои родители умерли?";
}
}

if(option == "D")
{
mirai -= 1f;
if(idioma == "ingles")
{
    textsp2 = "Of course! Someone has to be the mature one in the family, and my father isn't up to it. You would do the same for yours!";
}
if(idioma == "español")
{
    textsp2 = "Pues claro! Alguien tiene que ser la madura de la familia, y mi padre no esta en condiciones. Tu harias lo mismo por los tuyos!";
}
if(idioma == "frances")
{
    textsp2 = "Bien sur ! Quelqu'un doit etre le mature de la famille, et mon pere n'est pas en etat. Tu ferais la meme chose pour les tiens !";
}
if(idioma == "aleman")
{
    textsp2 = "Naturlich! Jemand muss der Reife in der Familie sein, und mein Vater ist dazu nicht in der Lage. Du wurdest dasselbe fur deine tun!";
}
if(idioma == "italiano")
{
    textsp2 = "Certo! Qualcuno deve essere la matura della famiglia, e mio padre non e in condizioni. Faresti lo stesso per i tuoi!";
}
if(idioma == "portugues")
{
    textsp2 = "Claro! Alguem tem que ser o maduro da familia, e meu pai nao esta em condicoes. Voce faria o mesmo pelos seus!";
}
if(idioma == "japones")
{
    textsp2 = "もちろん！家族の中で大人ぶらなきゃいけない人がいるし、父はその状態じゃない。あなたも自分の家族のために同じことをするでしょう！";
}
if(idioma == "coreano")
{
    textsp2 = "물론이지! 가족 중에 성숙한 사람이 있어야 하고, 우리 아버지는 그럴 상태가 아니야. 너도 너희 가족을 위해 똑같이 할 거야!";
}
if(idioma == "chino")
{
    textsp2 = "当然啦！家里总得有人成熟点，而我父亲现在不行。你也会为你家人做同样的事！";
}
if(idioma == "ruso")
{
    textsp2 = "Конечно! Кто-то должен быть взрослым в семье, а мой отец не в состоянии. Ты бы сделал то же самое для своих!";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }


             if(textorder == 63 && writing == false)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
mirai += 1;
if(idioma == "ingles")
{
    textsp2 = "You... too?... You must miss her like I do... In the end, I'm not the only one struggling...";
}
if(idioma == "español")
{
    textsp2 = "Tu... tambien?... Debes echarla de menos como yo... Al final no soy la unica que lo pasa mal...";
}
if(idioma == "frances")
{
    textsp2 = "Toi... aussi ?... Tu dois la regretter comme moi... Au final, je ne suis pas la seule a en souffrir...";
}
if(idioma == "aleman")
{
    textsp2 = "Du... auch?... Du musst sie vermissen wie ich... Am Ende bin ich nicht die Einzige, die leidet...";
}
if(idioma == "italiano")
{
    textsp2 = "Tu... anche tu?... Devi sentirne la mancanza come me... Alla fine non sono l'unica a soffrire...";
}
if(idioma == "portugues")
{
    textsp2 = "Voce... tambem?... Deve sentir falta dela como eu... No final, nao sou a unica que sofre...";
}
if(idioma == "japones")
{
    textsp2 = "あなたも...？私みたいに彼女が恋しいのでしょう...結局、苦しんでいるのは私だけじゃない...";
}
if(idioma == "coreano")
{
    textsp2 = "너도...? 나처럼 그녀가 그리울 거야... 결국, 힘든 건 나만이 아니야...";
}
if(idioma == "chino")
{
    textsp2 = "你...也...？一定像我一样想念她...毕竟，不只是我一个人在难过...";
}
if(idioma == "ruso")
{
    textsp2 = "Ты... тоже?... Должно быть, скучаешь по ней, как и я... В конце концов, я не единственная, кому тяжело...";
}
}

if(option == "B")
{
mirai -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Oh... God... I didn’t... I didn’t mean to... I'm so sorry.";
}
if(idioma == "español")
{
    textsp2 = "Oh... Dios... Yo no... No pretendia... Lo siento mucho.";
}
if(idioma == "frances")
{
    textsp2 = "Oh... Dieu... Je ne... Je ne voulais pas... Je suis vraiment desole.";
}
if(idioma == "aleman")
{
    textsp2 = "Oh... Gott... Ich... Ich wollte das nicht... Es tut mir so leid.";
}
if(idioma == "italiano")
{
    textsp2 = "Oh... Dio... Io non... Non volevo... Mi dispiace tanto.";
}
if(idioma == "portugues")
{
    textsp2 = "Oh... Deus... Eu nao... Nao pretendia... Sinto muito.";
}
if(idioma == "japones")
{
    textsp2 = "ああ...神様...私...そんなつもりじゃなかった...本当にごめんなさい。";
}
if(idioma == "coreano")
{
    textsp2 = "오... 하느님... 나... 그럴 의도가 아니었어... 정말 미안해.";
}
if(idioma == "chino")
{
    textsp2 = "哦...天啊...我...我不是故意的...真的很抱歉。";
}
if(idioma == "ruso")
{
    textsp2 = "О... Боже... Я не... Я не хотел... Мне так жаль.";
}
}

if(option == "C")
{
mirai += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "...Did something happen to them? Sorry if so. I guess everyone has their own problems.";
}
if(idioma == "español")
{
    textsp2 = "...Les paso algo? Perdon si es asi. Supongo que cada uno tiene sus problemas.";
}
if(idioma == "frances")
{
    textsp2 = "...Il leur est arrive quelque chose ? Desole si c'est le cas. Je suppose que chacun a ses propres problemes.";
}
if(idioma == "aleman")
{
    textsp2 = "...Ist ihnen etwas passiert? Entschuldigung, falls ja. Ich schatze, jeder hat seine eigenen Probleme.";
}
if(idioma == "italiano")
{
    textsp2 = "...E successo qualcosa a loro? Scusa se e cosi. Suppongo che ognuno abbia i suoi problemi.";
}
if(idioma == "portugues")
{
    textsp2 = "...Aconteceu algo com eles? Desculpa se sim. Suponho que cada um tenha seus proprios problemas.";
}
if(idioma == "japones")
{
    textsp2 = "...彼らに何かあったの？そうならごめん。みんなそれぞれ問題を抱えているんだろうね。";
}
if(idioma == "coreano")
{
    textsp2 = "...그들에게 무슨 일이 있었어? 그렇다면 미안해. 사람마다 각자의 문제가 있는 것 같아.";
}
if(idioma == "chino")
{
    textsp2 = "...他们发生什么事了吗？如果是的话，抱歉。我想每个人都有自己的问题。";
}
if(idioma == "ruso")
{
    textsp2 = "...С ними что-то случилось? Извини, если да. Думаю, у каждого свои проблемы.";
}
}

if(option == "D")
{
mirai -= 1f;
if(idioma == "ingles")
{
    textsp2 = "Your father doesn't understand you either... so... you're just like me.";
}
if(idioma == "español")
{
    textsp2 = "Tu padre tampoco te entiende... entonces... Estas igual que yo.";
}
if(idioma == "frances")
{
    textsp2 = "Ton pere ne te comprend pas non plus... donc... tu es comme moi.";
}
if(idioma == "aleman")
{
    textsp2 = "Dein Vater versteht dich auch nicht... also... bist du genauso wie ich.";
}
if(idioma == "italiano")
{
    textsp2 = "Tuo padre non ti capisce nemmeno... quindi... sei come me.";
}
if(idioma == "portugues")
{
    textsp2 = "Seu pai tambem nao te entende... entao... voce e igual a mim.";
}
if(idioma == "japones")
{
    textsp2 = "あなたの父もあなたを理解してくれない...だから...あなたは私と同じだ。";
}
if(idioma == "coreano")
{
    textsp2 = "네 아버지도 널 이해하지 못해... 그러니까... 너는 나랑 같아.";
}
if(idioma == "chino")
{
    textsp2 = "你父亲也不理解你...所以...你和我一样。";
}
if(idioma == "ruso")
{
    textsp2 = "Твой отец тоже тебя не понимает... так что... ты такая же, как я.";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }


             if(textorder == 64 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
mirai += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Huh... now you ask my name? Seriously? ...Whatever. It’s Mirai... and you?";
}
if(idioma == "español")
{
    textsp2 = "Eh... ahora me preguntas mi nombre? En serio...? Da igual. Soy Mirai... y tu?";
}
if(idioma == "frances")
{
    textsp2 = "Heh... tu me demandes mon nom maintenant ? Serieusement... ? Bref. C’est Mirai... et toi ?";
}
if(idioma == "aleman")
{
    textsp2 = "Hm... jetzt fragst du nach meinem Namen? Echt jetzt...? Egal. Ich bin Mirai... und du?";
}
if(idioma == "italiano")
{
    textsp2 = "Eh... mi chiedi il nome solo adesso? Sul serio...? Vabbe. Sono Mirai... e tu?";
}
if(idioma == "portugues")
{
    textsp2 = "Hm... agora voce pergunta meu nome? Serio...? Tanto faz. Sou Mirai... e voce?";
}
if(idioma == "japones")
{
    textsp2 = "はぁ...今さら名前聞くの？本当に...？まあいいけど。未来だよ...君は？";
}
if(idioma == "coreano")
{
    textsp2 = "하아... 이제 와서 이름을 묻는 거야? 진짜로...? 뭐, 됐어. 미라이야... 너는?";
}
if(idioma == "chino")
{
    textsp2 = "哈啊...现在才问我的名字吗？真是的...算了。我叫未来...你呢？";
}
if(idioma == "ruso")
{
    textsp2 = "Хм... ты только сейчас спрашиваешь моё имя? Серьёзно...? Ладно. Я Мирай... а ты?";
}
}

if(option == "B")
{
mirai += 1f;
if(idioma == "ingles")
{
    textsp2 = "If you say so... Huh?... Now that I think about it, we haven't introduced ourselves. I'm Mirai. Just Mirai. And you are?";
}
if(idioma == "español")
{
    textsp2 = "Si tu lo dices... Eh?... Ahora que lo pienso, no nos hemos presentado. Soy Mirai. Mirai a secas. Y tu eres?";
}
if(idioma == "frances")
{
    textsp2 = "Si tu le dis... Hein ?... Maintenant que j’y pense, on ne s’est pas presentes. Je suis Mirai. Juste Mirai. Et toi ?";
}
if(idioma == "aleman")
{
    textsp2 = "Wenn du das sagst... Hm?... Jetzt wo ich daruber nachdenke, haben wir uns gar nicht vorgestellt. Ich bin Mirai. Einfach Mirai. Und du?";
}
if(idioma == "italiano")
{
    textsp2 = "Se lo dici tu... Eh?... Ora che ci penso, non ci siamo presentati. Sono Mirai. Solo Mirai. E tu?";
}
if(idioma == "portugues")
{
    textsp2 = "Se voce diz... Eh?... Agora que penso nisso, a gente nem se apresentou. Sou Mirai. So Mirai. E voce?";
}
if(idioma == "japones")
{
    textsp2 = "そう言うなら...あれ？...今さらだけど、自己紹介してなかったね。未来だよ。名字とかないから。君は？";
}
if(idioma == "coreano")
{
    textsp2 = "네가 그렇다니까... 어?... 그러고 보니 우리 아직 자기소개도 안 했네. 미라이라고 해. 그냥 미라이. 너는?";
}
if(idioma == "chino")
{
    textsp2 = "既然你这么说的话...咦？...现在想想，我们好像还没自我介绍。我叫未来。就叫未来。你呢？";
}
if(idioma == "ruso")
{
    textsp2 = "Ну, раз ты так говоришь... Хм?... Если подумать, мы ведь так и не представились. Я Мирай. Просто Мирай. А ты?";
}
}

if(option == "C")
{
mirai -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Huh? Eh?! A weird guy comes out of the ventilation system, gives me a therapy session, and on top of that I have to tell him my name?! ... ... ... It’s Mirai. And you?";
}
if(idioma == "español")
{
    textsp2 = "Eh? Eh?! Un tipo raro sale del sistema de ventilacion, me hace una sesion de terapia y encima le tengo que decir mi nombre?! ... ... ... Es Mirai. Y el tuyo?";
}
if(idioma == "frances")
{
    textsp2 = "Hein ?! Quoi ?! Un type bizarre sort du systeme de ventilation, me fait une seance de therapie, et en plus je dois lui dire mon nom ?! ... ... ... C’est Mirai. Et toi ?";
}
if(idioma == "aleman")
{
    textsp2 = "Ha? Was?! Ein komischer Typ kommt aus dem Luftungsschacht, halt mir eine Therapiesitzung ab und dann soll ich ihm auch noch meinen Namen sagen?! ... ... ... Ich heiße Mirai. Und du?";
}
if(idioma == "italiano")
{
    textsp2 = "Eh? Cosa?! Un tipo strano esce dal sistema di ventilazione, mi fa una seduta di terapia e in piu dovrei dirgli il mio nome?! ... ... ... Sono Mirai. E tu?";
}
if(idioma == "portugues")
{
    textsp2 = "Ha? O que?! Um cara estranho sai do sistema de ventilacao, faz uma sessao de terapia comigo e ainda tenho que dizer meu nome?! ... ... ... Sou Mirai. E voce?";
}
if(idioma == "japones")
{
    textsp2 = "え？えっ？！変な男が換気口から出てきて、勝手に人生相談してきて、その上で名前まで聞くの？！... ... ... 未来だよ。で、君は？";
}
if(idioma == "coreano")
{
    textsp2 = "어? 어어?! 이상한 남자가 환풍구에서 튀어나와서 상담까지 해 주더니, 이제 와서 이름까지 말하라고?! ... ... ... 미라이라고 해. 너는?";
}
if(idioma == "chino")
{
    textsp2 = "诶？诶？！一个怪人从通风管里爬出来，给我做心理咨询，结果还要我报上名字？！... ... ... 我叫未来。你呢？";
}
if(idioma == "ruso")
{
    textsp2 = "Что? А?! Какой-то странный тип вылезает из вентиляции, устраивает мне сеанс терапии, и вдобавок я ещё должна назвать своё имя?! ... ... ... Я Мирай. А ты?";
}
}

if(option == "D")
{
mirai -= 1f;
if(idioma == "ingles")
{
    textsp2 = "... ... Mirai. That’s my name. M-i-r-a-i. You’d better remember it, or my next prediction is a punch to the face—and I’m always right. ... Now this is usually the part where humans say their name, weirdo.";
}
if(idioma == "español")
{
    textsp2 = "... ... Mirai. Es mi nombre. M-i-r-a-i. Mas te vale recordarlo o mi siguiente prediccion es un golpe en la cara, y siempre aciertan. ... Ahora es cuando los seres humanos suelen decir su nombre, rarito.";
}
if(idioma == "frances")
{
    textsp2 = "... ... Mirai. C’est mon nom. M-i-r-a-i. Tu ferais mieux de t’en souvenir, ou ma prochaine prediction sera un coup de poing dans la figure ... Normalement, c’est le moment ou les humains disent leur nom, l’etrange.";
}
if(idioma == "aleman")
{
    textsp2 = "... ... Mirai. Das ist mein Name. M-i-r-a-i. Merk ihn dir besser, sonst ist meine nachste Vorhersage ein Schlag ins Gesicht. ... Jetzt ware normalerweise der Moment, in dem Menschen ihren Namen sagen, du Freak.";
}
if(idioma == "italiano")
{
    textsp2 = "... ... Mirai. E il mio nome. M-i-r-a-i. Faresti meglio a ricordarlo, o la mia prossima previsione sarà un pugno in faccia. ... Di solito e questo il momento in cui gli esseri umani dicono il loro nome, strano.";
}
if(idioma == "portugues")
{
    textsp2 = "... ... Mirai. E o meu nome. M-i-r-a-i. E melhor lembrar, ou minha proxima previsao e um soco na cara — e eu sempre acerto. ... Agora normalmente e a parte em que os humanos dizem o proprio nome, esquisito.";
}
if(idioma == "japones")
{
    textsp2 = "...未来。それが私の名前。M・I・R・A・I。ちゃんと覚えなさい。じゃないと次の予知は顔面への一撃よ。外れたことないから。...で、普通はこの辺で人間が自分の名前を言うんだけど。変な人。";
}
if(idioma == "coreano")
{
    textsp2 = "... 미라이. 그게 내 이름이야. M-i-r-a-i. 잘 기억해 둬. 아니면 다음 예언은 네 얼굴에 한 방이니까 — 난 항상 맞거든. ... 자, 보통은 이쯤에서 인간이 자기 이름을 말하지, 이상한 사람.";
}
if(idioma == "chino")
{
    textsp2 = "...未来。这是我的名字。M-i-r-a-i。最好给我记清楚，不然我下一个预言就是一拳打在你脸上，而且我从不失手。...好了，按理说现在该人类报上自己的名字了，怪人。";
}
if(idioma == "ruso")
{
    textsp2 = "... Мирай. Это моё имя. М-и-р-а-й. Лучше запомни его, иначе моё следующее предсказание — удар по лицу. И я никогда не ошибаюсь. ... Обычно в этот момент люди называют своё имя, странный ты тип.";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 65 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Seriously? Your name is Yace? What kind of name is that? Did your parents hate you that mu... sorry.";
}
if(idioma == "español")
{
    textsp2 = "En serio? Te llamas Yace? Que clase de nombre es ese? Tanto te odiaban tus... perdon.";
}
if(idioma == "frances")
{
    textsp2 = "Serieusement ? Tu t’appelles Yace ? C’est quoi ce nom ? Tes parents te detestaient a ce poi... desolee.";
}
if(idioma == "aleman")
{
    textsp2 = "Im Ernst? Du heißt Yace? Was ist das denn fur ein Name? Haben deine Eltern dich so sehr gehas... sorry.";
}
if(idioma == "italiano")
{
    textsp2 = "Sul serio? Ti chiami Yace? Che razza di nome e? I tuoi genitori ti odiavano così ta... scusa.";
}
if(idioma == "portugues")
{
    textsp2 = "Serio? Voce se chama Yace? Que tipo de nome e esse? Seus pais te odiavam tan... desculpa.";
}
if(idioma == "japones")
{
    textsp2 = "え、本気？ヤス？...じゃなくて、ヤスじゃなくてヤース？変な名前。親にどれだけ嫌われてたの...ごめん。";
}
if(idioma == "coreano")
{
    textsp2 = "진짜로? 이름이 야세 야? 무슨 이름이 그래? 부모님이 그렇게 싫어했... 미안.";
}
if(idioma == "chino")
{
    textsp2 = "真的假的？你叫雅瑟？这算什么名字啊？你父母是有多讨厌你... 对不起。";
}
if(idioma == "ruso")
{
    textsp2 = "Серьёзно? Тебя зовут Йейс? Что это вообще за имя? Тебя родители так сильно ненави... прости.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }


             if(textorder == 66 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Let me tell you something. I can predict your future... for the very low price of 10 energy. And who knows? Maybe it’ll give you advantages... or disadvantages... The future is a mystery!";
}
if(idioma == "español")
{
    textsp2 = "Te dire algo. Puedo adivinar tu futuro... por el modico precio de 10 de energia. Y quien sabe? Tal vez te de ventajas... o desventajas... El futuro es un misterio!";
}
if(idioma == "frances")
{
    textsp2 = "Je vais te dire un truc. Je peux predire ton avenir... pour le modique prix de 10 points d’energie. Et qui sait ? ca pourrait te donner des avantages... ou des inconvenients... L’avenir est un mystere !";
}
if(idioma == "aleman")
{
    textsp2 = "Ich sag dir was. Ich kann deine Zukunft vorhersagen... fur den gunstigen Preis von 10 Energie. Und wer weiß? Vielleicht bringt es dir Vorteile... oder Nachteile... Die Zukunft ist ein Mysterium!";
}
if(idioma == "italiano")
{
    textsp2 = "Ti diro una cosa. Posso prevedere il tuo futuro... per il modico prezzo di 10 energia. E chissa? Potrebbe darti dei vantaggi... o degli svantaggi... Il futuro e un mistero!";
}
if(idioma == "portugues")
{
    textsp2 = "Vou te dizer uma coisa. Posso prever o seu futuro... pelo modico preco de 10 de energia. E quem sabe? Talvez isso te de vantagens... ou desvantagens... O futuro e um misterio!";
}
if(idioma == "japones")
{
    textsp2 = "一つ言っておくけど。10エネルギーで、あなたの未来を占ってあげる。安いでしょ？...有利になるかもしれないし、不利になるかもしれない。...未来は謎ってわけ！";
}
if(idioma == "coreano")
{
    textsp2 = "한 가지 말해줄게. 에너지 10만 있으면 네 미래를 예언해 줄 수 있어. 싸지? 어쩌면 이득일 수도 있고... 손해일 수도 있어... 미래는 미스터리니까!";
}
if(idioma == "chino")
{
    textsp2 = "我跟你说哦。我可以预测你的未来...只要10点能量。谁知道呢？也许会给你带来优势...或者劣势...未来可是个谜！";
}
if(idioma == "ruso")
{
    textsp2 = "Скажу тебе вот что. Я могу предсказать твоё будущее... всего за 10 единиц энергии. И кто знает? Может, это даст тебе преимущества... или недостатки... Будущее — загадка!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }


             if(textorder == 67 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "A-and... Yace? If it’s not too much trouble...";
}
if(idioma == "español")
{
    textsp2 = "Y... Yace? Si no es mucha molestia...";
}
if(idioma == "frances")
{
    textsp2 = "E-et... Yace ? Si ce n’est pas trop te demander...";
}
if(idioma == "aleman")
{
    textsp2 = "U-und... Yace? Wenn es keine Umstande macht...";
}
if(idioma == "italiano")
{
    textsp2 = "E-e... Yace? Se non e troppo disturbo...";
}
if(idioma == "portugues")
{
    textsp2 = "E-e... Yace? Se nao for muito incomodo...";
}
if(idioma == "japones")
{
    textsp2 = "ね、ねえ...ヤース？もし迷惑じゃなかったら...";
}
if(idioma == "coreano")
{
    textsp2 = "저... 저기... 야세? 혹시 괜찮다면...";
}
if(idioma == "chino")
{
    textsp2 = "那、那个...雅瑟？如果不太麻烦的话...";
}
if(idioma == "ruso")
{
    textsp2 = "Э-эм... Йейс? Если это не слишком сложно...";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 68 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Could you... come back tomorrow?... I mean, this... wasn’t totally awful... But don’t get any weird ideas! It’s not like I enjoy talking about my feelings! Get out of here!";
}
if(idioma == "español")
{
    textsp2 = "Podrias... volver la siguiente noche?... Quiero decir, esto... no estuvo tan mal... Pero no te hagas ideas raras! No es como si me gustara hablar de mis sentimientos! Largo de aqui!";
}
if(idioma == "frances")
{
    textsp2 = "Tu pourrais... revenir demain ?... Enfin, je veux dire, ca... c’etait pas si horrible... Mais ne te fais pas d’idees bizarres ! C’est pas comme si j’aimais parler de mes sentiments ! Degage !";
}
if(idioma == "aleman")
{
    textsp2 = "Konntest du... morgen wiederkommen?... Also, ich meine, das hier... war nicht ganz so schlimm... Aber mach dir keine komischen Hoffnungen! Es ist nicht so, dass ich gern uber meine Gefuhle rede! Raus hier!";
}
if(idioma == "italiano")
{
    textsp2 = "Potresti... tornare domani?... Voglio dire, questo... non e stato cosi terribile... Ma non farti strane idee! Non e che mi piaccia parlare dei miei sentimenti! Fuori di qui!";
}
if(idioma == "portugues")
{
    textsp2 = "Voce poderia... voltar amanha?... Quer dizer, isso... nao foi tao ruim assim... Mas nao tire conclusoes estranhas! Nao e como se eu gostasse de falar dos meus sentimentos! Vai embora!";
}
if(idioma == "japones")
{
    textsp2 = "あ、明日...また来てもいい？...べ、別にこれが嫌だったわけじゃないし...！でも変な勘違いしないでよ！感情の話が好きなわけじゃないんだから！さっさと出てって！";
}
if(idioma == "coreano")
{
    textsp2 = "그... 내일 다시 와줄 수 있어?... 이게 뭐랄까... 그렇게 나쁘진 않았어... 하지만 이상한 생각은 하지 마! 내가 감정 얘기 좋아하는 건 아니거든! 이제 나가!";
}
if(idioma == "chino")
{
    textsp2 = "你、你明天能再来吗？...我是说，这个...也没那么讨厌...但你可别乱想！我才不喜欢聊自己的感情呢！快走啦！";
}
if(idioma == "ruso")
{
    textsp2 = "Ты... можешь прийти завтра?... Я имею в виду, это... было не так уж плохо... Но не вздумай делать странные выводы! Мне вовсе не нравится говорить о своих чувствах! Убирайся!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 69 && writing == false)
             {
             nolevi.SetActive(true);
            freeze = false;
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = true;
         timestop = false;
             }

             if(textorder == 70 && writing == false)
             {
answer = true;
shop3.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "...So?... How did it go?...";
}
if(idioma == "español")
{
    textsp2 = "...Entonces?... Como ha ido?...";
}
if(idioma == "frances")
{
    textsp2 = "...Alors?... Comment ca s’est passe?...";
}
if(idioma == "aleman")
{
    textsp2 = "...Und?... Wie ist es gelaufen?...";
}
if(idioma == "italiano")
{
    textsp2 = "...Allora?... Com’e andata?...";
}
if(idioma == "portugues")
{
    textsp2 = "...Entao?... Como foi?...";
}
if(idioma == "japones")
{
    textsp2 = "...で？...どうだったの...？";
}
if(idioma == "coreano")
{
    textsp2 = "...그래서?... 어떻게 됐어?...";
}
if(idioma == "chino")
{
    textsp2 = "...所以呢？...怎么样了...？";
}
if(idioma == "ruso")
{
    textsp2 = "...Ну?... Как всё прошло?...";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 71 && writing == true)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz1");
    opi = true;
    }
seller += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Thank God, I was worried. Did she say something important?";
}
if(idioma == "español")
{
    textsp2 = "Gracias a Dios, me tenia preocupada. Ella dijo algo importante?";
}
if(idioma == "frances")
{
    textsp2 = "Merci a Dieu, j'etais inquiete. Elle a dit quelque chose d'important ?";
}
if(idioma == "aleman")
{
    textsp2 = "Gott sei Dank, ich war besorgt. Hat sie etwas Wichtiges gesagt?";
}
if(idioma == "italiano")
{
    textsp2 = "Grazie a Dio, ero preoccupata. Ha detto qualcosa di importante?";
}
if(idioma == "portugues")
{
    textsp2 = "Gracas a Deus, eu estava preocupada. Ela disse algo importante?";
}
if(idioma == "japones")
{
    textsp2 = "神様、心配してたよ。彼女は何か重要なことを言った？";
}
if(idioma == "coreano")
{
    textsp2 = "하나님 감사합니다, 걱정했어요. 그녀가 중요한 말을 했나요?";
}
if(idioma == "chino")
{
    textsp2 = "谢天谢地，我一直很担心。她说了什么重要的事吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Слава Богу, я была обеспокоена. Она сказала что-то важное?";
}
}

if(option == "B")
{
seller -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "I know... Sometimes she's a bit rude... And somewhat stubborn. But deep down she's good! I just wish she could see my point... She didn't say anything bad to you, right?";
}
if(idioma == "español")
{
    textsp2 = "Lo se... A veces es un poco maleducada... Y algo testaruda. Pero en el fondo es buena! Aunque me gustaria que viera mi punto... No te dijo nada malo, no?";
}
if(idioma == "frances")
{
    textsp2 = "Je sais... Parfois elle est un peu impolie... Et un peu tetue. Mais au fond, elle est bonne ! J'aimerais juste qu'elle voie mon point de vue... Elle ne t'a rien dit de mal, n'est-ce pas ?";
}
if(idioma == "aleman")
{
    textsp2 = "Ich weiß... Manchmal ist sie ein bisschen unhoflich... Und etwas stur. Aber im Grunde ist sie gut! Ich wunschte nur, sie konnte meinen Standpunkt sehen... Sie hat dir nichts Schlimmes gesagt, oder?";
}
if(idioma == "italiano")
{
    textsp2 = "Lo so... A volte e un po' maleducata... E un po' testarda. Ma in fondo e buona! Vorrei solo che vedesse il mio punto... Non ti ha detto niente di male, vero?";
}
if(idioma == "portugues")
{
    textsp2 = "Eu sei... As vezes ela e um pouco mal-educada... E um pouco teimosa. Mas no fundo ela e boa! Eu so gostaria que ela visse o meu ponto... Ela nao te disse nada de ruim, ne?";
}
if(idioma == "japones")
{
    textsp2 = "わかってる...時々ちょっと無礼で...少し頑固なところもある。でも本当はいい子だよ！私の言いたいことをわかってくれたらな...君に悪いことは言わなかったよね？";
}
if(idioma == "coreano")
{
    textsp2 = "알아... 가끔 조금 무례하고... 좀 고집스러울 때도 있어. 하지만 속으로는 착해! 내 입장을 이해해줬으면 좋겠어... 너한테 나쁜 말은 안 했지?";
}
if(idioma == "chino")
{
    textsp2 = "我知道... 有时候她有点无礼... 还有点固执。但她内心是善良的！我只是希望她能理解我的观点... 她没对你说什么坏话吧？";
}
if(idioma == "ruso")
{
    textsp2 = "Я знаю... Иногда она немного грубая... И немного упрямая. Но в глубине души она хорошая! Хотелось бы, чтобы она поняла мою точку зрения... Она тебе ничего плохого не сказала, да?";
}
}

if(option == "C")
{
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    opi = true;
    }
seller += 1f;
if(idioma == "ingles")
{
    textsp2 = "I think you're right... Maybe I should stop treating her like a tadpole, and she should be more open and tell me how she feels. I think that's what my wife would do. Did she say anything else?";
}
if(idioma == "español")
{
    textsp2 = "Creo que tienes razon... Tal vez yo deberia dejar de tratarla como una renacuaja, y ella deberia ser mas abierta y contarme como se siente. Creo que eso es lo que haria mi mujer. Dijo algo mas?";
}
if(idioma == "frances")
{
    textsp2 = "Je crois que tu as raison... Peut-etre que je devrais arreter de la traiter comme une gamine, et qu’elle devrait etre plus ouverte et me dire ce qu’elle ressent. A-t-elle dit autre chose ?";
}
if(idioma == "aleman")
{
    textsp2 = "Ich glaube, du hast recht... Vielleicht sollte ich aufhoren, sie wie ein kleines Kind zu behandeln, und sie sollte offener sein und mir sagen, wie sie sich fuhlt. Hat sie noch etwas gesagt?";
}
if(idioma == "italiano")
{
    textsp2 = "Credo che tu abbia ragione... Forse dovrei smettere di trattarla come una ragazzina, e lei dovrebbe essere piu aperta e dirmi come si sente. Penso che sia quello che farebbe mia moglie. Ha detto qualcos’altro?";
}
if(idioma == "portugues")
{
    textsp2 = "Acho que voce tem razão... Talvez eu devesse parar de trata-la como uma crianca, e ela deveria ser mais aberta e me contar como se sente. Acho que e isso que minha esposa faria. Ela disse mais alguma coisa?";
}
if(idioma == "japones")
{
    textsp2 = "君の言う通りかもしれない... 彼女を子供扱いするのはやめて、もっと正直に気持ちを話してもらうべきなのかもな。きっとそれが、妻ならすることだ。ほかにも何か言っていたか？";
}
if(idioma == "coreano")
{
    textsp2 = "네 말이 맞는 것 같아... 내가 그녀를 애처럼 대하는 걸 그만두고, 그녀도 좀 더 솔직하게 자신의 마음을 말해야 할지도 몰라. 그게 아내라면 했을 행동이겠지. 다른 말은 없었어?";
}
if(idioma == "chino")
{
    textsp2 = "我觉得你说得对...也许我应该停止把她当成小孩子，而她也应该更坦率地告诉我她的感受。我想这正是我妻子会做的事。她还说了什么吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Думаю, ты прав... Возможно, мне стоит перестать относиться к ней как к ребёнку, а ей — быть более открытой и рассказать мне о своих чувствах. Думаю, именно так поступила бы моя жена. Она сказала что-нибудь ещё?";
}
}

if(option == "D")
{
seller -= 1f;
if(idioma == "ingles")
{
    textsp2 = "Are you sure? Well... maybe you're right... Maybe it's already too late... Did she say something bad?";
}
if(idioma == "español")
{
    textsp2 = "Estas seguro? Bueno... tal vez tengas razon... Tal vez ya es demasiado tarde... Dijo algo malo?";
}
if(idioma == "frances")
{
    textsp2 = "Tu es sur ? Bon... peut-etre que tu as raison... Peut-etre qu'il est deja trop tard... Elle a dit quelque chose de mal ?";
}
if(idioma == "aleman")
{
    textsp2 = "Bist du sicher? Nun... vielleicht hast du recht... Vielleicht ist es schon zu spat... Hat sie etwas Schlimmes gesagt?";
}
if(idioma == "italiano")
{
    textsp2 = "Sei sicuro? Beh... forse hai ragione... Forse e gia troppo tardi... Ha detto qualcosa di brutto?";
}
if(idioma == "portugues")
{
    textsp2 = "Tem certeza? Bem... talvez voce tenha razao... Talvez ja seja tarde demais... Ela disse algo ruim?";
}
if(idioma == "japones")
{
    textsp2 = "本当に？うーん...君の言う通りかもしれない...もう手遅れなのかも...何か悪いことを言ってた？";
}
if(idioma == "coreano")
{
    textsp2 = "정말이야? 음... 네 말이 맞을지도 몰라... 이미 늦은 걸지도... 나쁜 말은 했어?";
}
if(idioma == "chino")
{
    textsp2 = "你确定吗？嗯...也许你是对的...也许已经太晚了...她说了什么不好的话吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Ты уверен? Ну... может, ты прав... Может, уже слишком поздно... Она сказала что-нибудь плохое?";
}
}

             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 72 && writing == false)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
    if(opi2 == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz1");
    opi2 = true;
    }
seller -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Yes, she usually talks like that. Can you believe that just a few centuries ago she was only a tiny black spot? She always says I treat her like a newborn.";
}
if(idioma == "español")
{
    textsp2 = "Si, normalmente habla asi. Te puedes creer que hace apenas unos siglos tan solo era una diminuta mancha negra? Siempre dice que la trato como un recien nacido.";
}
if(idioma == "frances")
{
    textsp2 = "Oui, elle parle normalement comme ca. Peux-tu croire qu'il y a seulement quelques siecles, elle n'etait qu'une petite tache noire ? Elle dit toujours que je la traite comme un nouveau-ne.";
}
if(idioma == "aleman")
{
    textsp2 = "Ja, sie spricht normalerweise so. Kannst du glauben, dass sie vor nur ein paar Jahrhunderten nur ein kleiner schwarzer Fleck war? Sie sagt immer, dass ich sie wie ein Neugeborenes behandle.";
}
if(idioma == "italiano")
{
    textsp2 = "Si, normalmente parla cosi. Puoi credere che solo pochi secoli fa era solo una piccola macchia nera? Dice sempre che la tratto come un neonato.";
}
if(idioma == "portugues")
{
    textsp2 = "Sim, normalmente ela fala assim. Voce consegue acreditar que ha apenas alguns seculos ela era apenas uma pequena mancha preta? Ela sempre diz que eu a trato como um recem-nascido.";
}
if(idioma == "japones")
{
    textsp2 = "うん、普段はあんな風に話すよ。ほんの数世紀前まで、彼女はただの小さな黒い点だったって信じられる？いつも、赤ん坊のように扱うって言ってる。";
}
if(idioma == "coreano")
{
    textsp2 = "응, 평소에도 그렇게 말해. 불과 몇 세기 전만 해도 그녀는 작은 검은 점에 불과했다는 거 믿을 수 있어? 항상 내가 그녀를 갓난아기처럼 대한다고 말해.";
}
if(idioma == "chino")
{
    textsp2 = "是的，她平时就是这样说话的。你能相信几百年前她只是一个小小的黑点吗？她总是说我对她像对待新生儿一样。";
}
if(idioma == "ruso")
{
    textsp2 = "Да, обычно она так говорит. Можешь поверить, что всего несколько веков назад она была всего лишь маленьким черным пятном? Она всегда говорит, что я обращаюсь с ней как с новорожденной.";
}
}

if(option == "B")
{
    if(opi2 == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz2");
    opi2 = true;
    }
seller += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "That's ridiculous! I always listen to her! Like that time she asked me to let her help with the business!... Well, maybe I imagined that.";
}
if(idioma == "español")
{
    textsp2 = "Eso es absurdo! Yo siempre la escucho! Como aquella vez que me pidio que la dejase ayudar con el negocio!... Bueno, tal vez me imagine eso.";
}
if(idioma == "frances")
{
    textsp2 = "C'est absurde ! Je l'ecoute toujours ! Comme cette fois ou elle m'a demande de la laisser aider avec le commerce !... Bon, peut-etre que je l'ai imagine.";
}
if(idioma == "aleman")
{
    textsp2 = "Das ist absurd! Ich hore ihr doch immer zu! Wie damals, als sie mich bat, sie beim Geschaft helfen zu lassen!... Nun ja, vielleicht habe ich mir das nur eingebildet.";
}
if(idioma == "italiano")
{
    textsp2 = "E assurdo! La ascolto sempre! Come quella volta che mi chiese di lasciarla aiutare con l'attivita!... Beh, forse me lo sono immaginato.";
}
if(idioma == "portugues")
{
    textsp2 = "Isso e absurdo! Eu sempre a escuto! Como aquela vez que ela me pediu para deixa-la ajudar no negocio!... Bem, talvez eu tenha imaginado isso.";
}
if(idioma == "japones")
{
    textsp2 = "それは馬鹿げてる！私はいつも彼女の話を聞いてるよ！あの時みたいに、商売を手伝わせてほしいって頼まれたことも...まあ、もしかしたら想像しただけかもね。";
}
if(idioma == "coreano")
{
    textsp2 = "말도 안 돼! 나는 항상 그녀의 말을 듣는데! 그때처럼 사업을 돕게 해달라고 했던 적도 있고... 음, 아마 내가 상상했을지도 몰라.";
}
if(idioma == "chino")
{
    textsp2 = "太荒谬了！我总是听她说话！就像那次她让我帮她处理生意一样！...嗯，也许我只是想象的。";
}
if(idioma == "ruso")
{
    textsp2 = "Это абсурд! Я всегда её слушаю! Как тогда, когда она просила позволить ей помочь с делом!... Ну, может быть, я это себе только представила.";
}
}

if(option == "C")
{
seller -= 1f;
if(idioma == "ingles")
{
    textsp2 = "I figured as much. I think she's watched too much anime.";
}
if(idioma == "español")
{
    textsp2 = "Eso suponia. Creo que ha visto demasiado anime.";
}
if(idioma == "frances")
{
    textsp2 = "Je m'en doutais. Je pense qu'elle a trop regarde d'anime.";
}
if(idioma == "aleman")
{
    textsp2 = "Das habe ich mir gedacht. Ich glaube, sie hat zu viel Anime geschaut.";
}
if(idioma == "italiano")
{
    textsp2 = "Lo immaginavo. Penso che abbia visto troppo anime.";
}
if(idioma == "portugues")
{
    textsp2 = "Isso eu ja imaginava. Acho que ela assistiu anime demais.";
}
if(idioma == "japones")
{
    textsp2 = "そう思った。彼女はアニメを見すぎたと思う。";
}
if(idioma == "coreano")
{
    textsp2 = "그럴 줄 알았어. 그녀는 애니를 너무 많이 본 것 같아.";
}
if(idioma == "chino")
{
    textsp2 = "我就知道。她看动漫看得太多了。";
}
if(idioma == "ruso")
{
    textsp2 = "Я так и думал. Похоже, она слишком много смотрела аниме.";
}
}

if(option == "D")
{
    if(opi2 == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz2");
    opi2 = true;
    }
seller += 1f;
if(idioma == "ingles")
{
    textsp2 = "Me? Really? Isn't she still attached to her mother? Maybe I was looking at it the wrong way.";
}
if(idioma == "español")
{
    textsp2 = "Yo? En serio? No sigue anclada a su madre? Tal vez lo estaba enfocando mal.";
}
if(idioma == "frances")
{
    textsp2 = "Moi ? Vraiment ? Elle n'est pas encore attachee a sa mere ? Peut-etre que je voyais les choses de la mauvaise maniere.";
}
if(idioma == "aleman")
{
    textsp2 = "Ich? Ernsthaft? Hangt sie nicht immer noch an ihrer Mutter? Vielleicht habe ich es falsch gesehen.";
}
if(idioma == "italiano")
{
    textsp2 = "Io? Davvero? Non e ancora legata a sua madre? Forse lo stavo interpretando male.";
}
if(idioma == "portugues")
{
    textsp2 = "Eu? Serio? Ela nao continua apegada a mae? Talvez eu estivesse vendo isso da forma errada.";
}
if(idioma == "japones")
{
    textsp2 = "私？本当に？まだ母親に縛られていないの？もしかしたら、考え方を間違えていたのかも。";
}
if(idioma == "coreano")
{
    textsp2 = "나? 정말? 그녀가 아직 엄마에게 매여 있지 않아? 아마 내가 잘못 보고 있었던 걸지도 몰라.";
}
if(idioma == "chino")
{
    textsp2 = "我？真的吗？她不是还依恋她的母亲吗？也许我看错了方向。";
}
if(idioma == "ruso")
{
    textsp2 = "Я? Серьёзно? Она разве всё ещё привязана к матери? Может, я неправильно это воспринимал.";
}
}
opi = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 73 && writing == true)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz1");
    opi = true;
    }
seller += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Maybe you're right. Maybe I should put myself in her place. My wife was good at that.";
}
if(idioma == "español")
{
    textsp2 = "Tal vez tienes razon. Tal vez deberia ponerme en su lugar. A mi mujer se le daba bien eso.";
}
if(idioma == "frances")
{
    textsp2 = "Peut-etre que tu as raison. Peut-etre que je devrais me mettre a sa place. Ma femme etait douee pour ca.";
}
if(idioma == "aleman")
{
    textsp2 = "Vielleicht hast du recht. Vielleicht sollte ich mich in ihre Lage versetzen. Meine Frau war darin gut.";
}
if(idioma == "italiano")
{
    textsp2 = "Forse hai ragione. Forse dovrei mettermi nei suoi panni. A mia moglie riusciva bene.";
}
if(idioma == "portugues")
{
    textsp2 = "Talvez voce tenha razao. Talvez eu devesse me colocar no lugar dela. Minha esposa era boa nisso.";
}
if(idioma == "japones")
{
    textsp2 = "君の言う通りかもしれない。彼女の立場になって考えるべきかもしれない。妻はそれが得意だった。";
}
if(idioma == "coreano")
{
    textsp2 = "어쩌면 네 말이 맞아. 그녀의 입장에서 생각해봐야 할지도 몰라. 내 아내는 그걸 잘했어.";
}
if(idioma == "chino")
{
    textsp2 = "也许你是对的。也许我应该站在她的立场想一想。我妻子很擅长这一点。";
}
if(idioma == "ruso")
{
    textsp2 = "Возможно, ты прав. Возможно, мне стоит поставить себя на её место. Моей жене это хорошо удавалось.";
}
}

if(option == "B")
{
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz2");
    opi = true;
    }
seller += 1f;
if(idioma == "ingles")
{
    textsp2 = "I think you're right... Maybe I should stop treating her like a tadpole, and she should be more open and tell me how she feels. I think that's what my wife would do.";
}
if(idioma == "español")
{
    textsp2 = "Creo que tienes razon... Tal vez yo deberia dejar de tratarla como una renacuaja, y ella deberia ser mas abierta y contarme como se siente. Creo que eso es lo que haria mi mujer.";
}
if(idioma == "frances")
{
    textsp2 = "Je crois que tu as raison... Peut-etre que je devrais arreter de la traiter comme un tetard, et qu'elle devrait etre plus ouverte et me dire ce qu'elle ressent. Je pense que c'est ce que ferait ma femme.";
}
if(idioma == "aleman")
{
    textsp2 = "Ich glaube, du hast recht... Vielleicht sollte ich aufhoren, sie wie eine Kaulquappe zu behandeln, und sie sollte offener sein und mir sagen, wie sie sich fuhlt. Ich glaube, das würde meine Frau tun.";
}
if(idioma == "italiano")
{
    textsp2 = "Credo che tu abbia ragione... Forse dovrei smettere di trattarla come un girino, e lei dovrebbe essere piu aperta e dirmi come si sente. Credo che sia quello che farebbe mia moglie.";
}
if(idioma == "portugues")
{
    textsp2 = "Acho que voce tem razao... Talvez eu devesse parar de trata-la como um girino, e ela deveria ser mais aberta e me contar como se sente. Acho que e isso que minha esposa faria.";
}
if(idioma == "japones")
{
    textsp2 = "君の言う通りだと思う... たぶん、彼女をオタマジャクシみたいに扱うのをやめるべきなんだろう。彼女ももっと心を開いて、どう感じているか話してくれればいい。きっと、それが妻ならそうする。";
}
if(idioma == "coreano")
{
    textsp2 = "네 말이 맞는 것 같아... 아마도 그녀를 올챙이처럼 대하는 걸 그만두고, 그녀도 좀 더 솔직해져서 자기 마음을 말해줘야 할 거야. 그게 아내라면 했을 행동이야.";
}
if(idioma == "chino")
{
    textsp2 = "我觉得你是对的...也许我应该停止把她当成小蝌蚪一样对待，而她也应该更坦率，告诉我她的感受。我想这就是我妻子会做的事。";
}
if(idioma == "ruso")
{
    textsp2 = "Думаю, ты прав... Возможно, мне стоит перестать обращаться с ней как с головастиком, а ей — быть более открытой и рассказать мне, что она чувствует. Думаю, именно так поступила бы моя жена.";
}
}

if(option == "C")
{
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz2");
    opi = true;
    }
seller -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "That's what I thought. She should listen to the grown-up, shouldn't she? She would do that with her mother.";
}
if(idioma == "español")
{
    textsp2 = "Eso es lo que pensaba. Deberia escuchar al adulto, no? Ella haria eso con su madre.";
}
if(idioma == "frances")
{
    textsp2 = "C'est bien ce que je pensais. Elle devrait ecouter l'adulte, n'est-ce pas ? Elle ferait ca avec sa mere.";
}
if(idioma == "aleman")
{
    textsp2 = "Genau das dachte ich. Sie sollte dem Erwachsenen zuhoren, oder? Das wurde sie bei ihrer Mutter auch tun.";
}
if(idioma == "italiano")
{
    textsp2 = "E quello che pensavo. Dovrebbe ascoltare l'adulto, no? Lo farebbe con sua madre.";
}
if(idioma == "portugues")
{
    textsp2 = "Era isso que eu pensava. Ela deveria ouvir o adulto, nao deveria? Ela faria isso com a mae dela.";
}
if(idioma == "japones")
{
    textsp2 = "やっぱりそう思う。大人の言うことを聞くべきだろう？ 母親にならそうするはずだ。";
}
if(idioma == "coreano")
{
    textsp2 = "나도 그렇게 생각했어. 어른 말은 들어야 하지 않겠어? 엄마라면 그렇게 했을 거야.";
}
if(idioma == "chino")
{
    textsp2 = "我也是这么想的。她应该听大人的话，不是吗？她对她母亲也是这样的。";
}
if(idioma == "ruso")
{
    textsp2 = "Я так и думал. Она должна слушать взрослого, не так ли? Со своей матерью она бы так и поступила.";
}
}

if(option == "D")
{
    if(opi == false)
    {
    vanim.SetTrigger("sd2");
    vanim.SetTrigger("feliz2");
    opi = true;
    }
seller -= 1f;
if(idioma == "ingles")
{
    textsp2 = "You know what? You're right. I should show who’s in charge in this house. Or food truck. You know what I mean. I’m sure that’s what my wife would do.";
}
if(idioma == "español")
{
    textsp2 = "Sabes que? Tienes razon. Deberia demostrar quien manda en esta casa. O food truck. Ya me entiendes. Estoy seguro de que es lo que haria mi mujer.";
}
if(idioma == "frances")
{
    textsp2 = "Tu sais quoi ? Tu as raison. Je devrais montrer qui commande dans cette maison. Ou ce food truck. Tu vois ce que je veux dire. Je suis sur que c’est ce que ferait ma femme.";
}
if(idioma == "aleman")
{
    textsp2 = "Weißt du was? Du hast recht. Ich sollte zeigen, wer in diesem Haus das Sagen hat. Oder in diesem Foodtruck. Du weißt, was ich meine. Ich bin sicher, das ist es, was meine Frau tun wurde.";
}
if(idioma == "italiano")
{
    textsp2 = "Sai una cosa? Hai ragione. Dovrei dimostrare chi comanda in questa casa. O in questo food truck. Sai cosa intendo. Sono sicuro che e quello che farebbe mia moglie.";
}
if(idioma == "portugues")
{
    textsp2 = "Sabe de uma coisa? Voce tem razao. Eu deveria mostrar quem manda nesta casa. Ou neste food truck. Voce sabe o que eu quero dizer. Tenho certeza de que e isso que minha esposa faria.";
}
if(idioma == "japones")
{
    textsp2 = "そうだな...君の言う通りだ。ここで誰が仕切っているのか示すべきだ。家でも、フードトラックでもね。言いたいことは分かるだろ。きっと、それが妻ならそうする。";
}
if(idioma == "coreano")
{
    textsp2 = "있잖아, 네 말이 맞아. 이 집에서 누가 주인인지 보여줘야겠어. 아니면 이 푸드트럭에서 말이야. 무슨 말인지 알지? 분명 아내라면 그렇게 했을 거야.";
}
if(idioma == "chino")
{
    textsp2 = "你知道吗？你是对的。我应该证明在这个家里谁说了算。或者说，这辆餐车里。你懂我的意思。我敢肯定这就是我妻子会做的事。";
}
if(idioma == "ruso")
{
    textsp2 = "Знаешь что? Ты прав. Мне стоит показать, кто здесь главный. В этом доме. Или в этом фудтраке. Ты понимаешь, о чём я. Я уверен, именно так поступила бы моя жена.";
}
}
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 74 && writing == false)
             {
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
seller -= 1f;
if(idioma == "ingles")
{
    textsp2 = "Right. I must stop trying to act like her and start imposing order";
}
if(idioma == "español")
{
    textsp2 = "Cierto. Debo dejar de intentar actuar como ella y empezar a imponer orden";
}
if(idioma == "frances")
{
    textsp2 = "C'est vrai. Je dois arreter d'essayer d'agir comme elle et commencer a imposer l'ordre";
}
if(idioma == "aleman")
{
    textsp2 = "Richtig. Ich muss aufhoren, zu versuchen, wie sie zu handeln, und anfangen, Ordnung durchzusetzen";
}
if(idioma == "italiano")
{
    textsp2 = "Giusto. Devo smettere di cercare di agire come lei e iniziare a imporre ordine";
}
if(idioma == "portugues")
{
    textsp2 = "Certo. Devo parar de tentar agir como ela e comecar a impor ordem";
}
if(idioma == "japones")
{
    textsp2 = "そうだ。彼女のように振る舞おうとするのをやめ、秩序を強制し始めるべきだ";
}
if(idioma == "coreano")
{
    textsp2 = "맞아. 그녀처럼 행동하려는 시도를 멈추고 질서를 세우기 시작해야 해";
}
if(idioma == "chino")
{
    textsp2 = "没错。我必须停止试图像她一样行事，开始建立秩序";
}
if(idioma == "ruso")
{
    textsp2 = "Верно. Я должен перестать пытаться действовать как она и начать наводить порядок";
}
}

if(option == "B")
{
seller -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Right. I must stop trying to act like her and start imposing order";
}
if(idioma == "español")
{
    textsp2 = "Cierto. Debo dejar de intentar actuar como ella y empezar a imponer orden";
}
if(idioma == "frances")
{
    textsp2 = "C'est vrai. Je dois arreter d'essayer d'agir comme elle et commencer a imposer l'ordre";
}
if(idioma == "aleman")
{
    textsp2 = "Richtig. Ich muss aufhoren, zu versuchen, wie sie zu handeln, und anfangen, Ordnung durchzusetzen";
}
if(idioma == "italiano")
{
    textsp2 = "Giusto. Devo smettere di cercare di agire come lei e iniziare a imporre ordine";
}
if(idioma == "portugues")
{
    textsp2 = "Certo. Devo parar de tentar agir como ela e comecar a impor ordem";
}
if(idioma == "japones")
{
    textsp2 = "そうだ。彼女のように振る舞おうとするのをやめ、秩序を強制し始めるべきだ";
}
if(idioma == "coreano")
{
    textsp2 = "맞아. 그녀처럼 행동하려는 시도를 멈추고 질서를 세우기 시작해야 해";
}
if(idioma == "chino")
{
    textsp2 = "没错。我必须停止试图像她一样行事，开始建立秩序";
}
if(idioma == "ruso")
{
    textsp2 = "Верно. Я должен перестать пытаться действовать как она и начать наводить порядок";
}
}

if(option == "C")
{
seller += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Maybe I was wrong the whole time, it was just me who was stuck?";
}
if(idioma == "español")
{
    textsp2 = "Quizas estuve equivocado todo el tiempo, solo yo estaba atascado?";
}
if(idioma == "frances")
{
    textsp2 = "Peut-etre que j'avais tort tout le temps, est-ce que c'etait seulement moi qui etais coince ?";
}
if(idioma == "aleman")
{
    textsp2 = "Vielleicht lag ich die ganze Zeit falsch, war nur ich festgefahren?";
}
if(idioma == "italiano")
{
    textsp2 = "Forse mi sono sbagliato tutto il tempo, ero solo io bloccato?";
}
if(idioma == "portugues")
{
    textsp2 = "Talvez eu estivesse errado o tempo todo, fui so eu que fiquei preso?";
}
if(idioma == "japones")
{
    textsp2 = "もしかしてずっと間違っていたのは僕だけで、僕だけが立ち止まっていたのか？";
}
if(idioma == "coreano")
{
    textsp2 = "어쩌면 그동안 내가 틀렸던 걸까, 나만 갇혀 있었던 걸까?";
}
if(idioma == "chino")
{
    textsp2 = "也许我一直都错了，只有我自己被困住了吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Может быть, я всё это время ошибался, застрял только я?";
}
}

if(option == "D")
{
seller += 1f;
if(idioma == "ingles")
{
    textsp2 = "You're probably right. You shouldn't live through the eyes of a dead";
}
if(idioma == "español")
{
    textsp2 = "Probablemente tengas razon. No deberias vivir a traves de los ojos de un muerto";
}
if(idioma == "frances")
{
    textsp2 = "Tu as probablement raison. Tu ne devrais pas vivre a travers les yeux d'un mort";
}
if(idioma == "aleman")
{
    textsp2 = "Du hast wahrscheinlich recht. Du solltest nicht durch die Augen eines Toten leben";
}
if(idioma == "italiano")
{
    textsp2 = "Probabilmente hai ragione. Non dovresti vivere attraverso gli occhi di un morto";
}
if(idioma == "portugues")
{
    textsp2 = "Provavelmente voce esta certo. Nao deverias viver pelos olhos de um morto";
}
if(idioma == "japones")
{
    textsp2 = "たぶん君の言う通りだ。死者の目を通して生きるべきではない";
}
if(idioma == "coreano")
{
    textsp2 = "아마 네 말이 맞을 거야. 죽은 사람의 눈으로 살면 안 돼";
}
if(idioma == "chino")
{
    textsp2 = "你可能是对的。你不应该通过死者的眼睛生活";
}
if(idioma == "ruso")
{
    textsp2 = "Наверное, ты прав. Не стоит жить глазами умершего";
}
}
opi2 = false;
opi = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 75 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
seller += 1f;
if(idioma == "ingles")
{
    textsp2 = "One thing is certain. The answer won't come by saying it's my daughter's fault. I have to start to act like an adult";
}
if(idioma == "español")
{
    textsp2 = "Una cosa es segura. La respuesta no vendra diciendo que es culpa de mi hija. Debo empezar a actuar como un adulto";
}
if(idioma == "frances")
{
    textsp2 = "Une chose est certaine. La reponse ne viendra pas en disant que c'est la faute de ma fille. Je dois commencer a agir en adulte";
}
if(idioma == "aleman")
{
    textsp2 = "Eines ist sicher. Die Antwort wird nicht kommen, wenn ich sage, dass es die Schuld meiner Tochter ist. Ich muss anfangen, wie ein Erwachsener zu handeln";
}
if(idioma == "italiano")
{
    textsp2 = "Una cosa e certa. La risposta non arrivera dicendo che è colpa di mia figlia. Devo cominciare a comportarmi da adulto";
}
if(idioma == "portugues")
{
    textsp2 = "Uma coisa e certa. A resposta nao vira dizendo que e culpa da minha filha. Preciso começar a agir como um adulto";
}
if(idioma == "japones")
{
    textsp2 = "ひとつ確かなことは、娘のせいだと言っても答えは出ないということだ。大人のように行動し始めなければならない";
}
if(idioma == "coreano")
{
    textsp2 = "한 가지 확실한 것은, 딸의 잘못이라고 말한다고 해서 답이 나오지 않는다는 것이다. 나는 어른답게 행동하기 시작해야 한다";
}
if(idioma == "chino")
{
    textsp2 = "有一件事是肯定的。说是我女儿的错并不会带来答案。我必须开始像个成年人一样行动";
}
if(idioma == "ruso")
{
    textsp2 = "Одно можно сказать наверняка. Ответ не придёт, если винить в этом дочь. Я должен начать действовать как взрослый";
}
}

if(option == "B")
{
seller += 0.5f;
if(idioma == "ingles")
{
    textsp2 = "I should start changing. I can't expect a good example from her if I don't set one myself";
}
if(idioma == "español")
{
    textsp2 = "Deberia empezar a cambiar, no puedo esperar un buen ejemplo de ella si no lo doy yo";
}
if(idioma == "frances")
{
    textsp2 = "Je devrais commencer a changer. Je ne peux pas attendre un bon exemple d’elle si je ne le donne pas moi-meme";
}
if(idioma == "aleman")
{
    textsp2 = "Ich sollte anfangen, mich zu andern. Ich kann kein gutes Beispiel von ihr erwarten, wenn ich selbst keines gebe";
}
if(idioma == "italiano")
{
    textsp2 = "Dovrei iniziare a cambiare. Non posso aspettarmi un buon esempio da lei se non lo do io stesso";
}
if(idioma == "portugues")
{
    textsp2 = "Eu deveria comecar a mudar. Nao posso esperar um bom exemplo dela se eu mesmo nao o der";
}
if(idioma == "japones")
{
    textsp2 = "俺が変わり始めるべきだ。自分が手本を示さないのに、彼女に良い例を期待することはできない";
}
if(idioma == "coreano")
{
    textsp2 = "내가 먼저 변해야 해. 내가 모범을 보이지 않으면서 그녀에게 좋은 본보기를 기대할 수는 없어";
}
if(idioma == "chino")
{
    textsp2 = "我应该开始改变了。如果我自己不做出榜样，就不能指望她成为好榜样";
}
if(idioma == "ruso")
{
    textsp2 = "Мне стоит начать меняться. Я не могу ждать от неё хорошего примера, если сам его не подаю";
}
}

if(option == "C")
{
seller -= 0.5f;
if(idioma == "ingles")
{
    textsp2 = "Should I do it exactly as my wife would? That's what I assumed";
}
if(idioma == "español")
{
    textsp2 = "Debo hacerlo exactamente como lo haria mi esposa? Eso suponia";
}
if(idioma == "frances")
{
    textsp2 = "Dois-je le faire exactement comme ma femme le ferait ? C'est ce que je supposais";
}
if(idioma == "aleman")
{
    textsp2 = "Soll ich es genau so machen, wie es meine Frau tun wurde? Das nahm ich an";
}
if(idioma == "italiano")
{
    textsp2 = "Devo farlo esattamente come farebbe mia moglie? Questo presumevo";
}
if(idioma == "portugues")
{
    textsp2 = "Devo fazer exatamente como minha esposa faria? Era isso que eu supunha";
}
if(idioma == "japones")
{
    textsp2 = "私がそれを妻のやり方とまったく同じようにすべきだろうか？そう思っていた";
}
if(idioma == "coreano")
{
    textsp2 = "내가 그것을 아내가 하던 대로 정확히 해야 할까? 그렇게 생각했어";
}
if(idioma == "chino")
{
    textsp2 = "我应该完全按照我妻子的方式去做吗？我就是这么想的";
}
if(idioma == "ruso")
{
    textsp2 = "Должен ли я делать это точно так, как моя жена? Именно так я и думал";
}
}

if(option == "D")
{
seller -= 1f;
if(idioma == "ingles")
{
    textsp2 = "I am the man of the house, and I must show her who’s in charge. Now I see it.";
}
if(idioma == "español")
{
    textsp2 = "Yo soy el hombre de la casa, y debo mostrarle quien manda. Ahora lo veo.";
}
if(idioma == "frances")
{
    textsp2 = "Je suis l'homme de la maison, et je dois lui montrer qui commande. Maintenant je le vois.";
}
if(idioma == "aleman")
{
    textsp2 = "Ich bin der Mann im Haus, und ich muss ihr zeigen, wer das Sagen hat. Jetzt sehe ich es.";
}
if(idioma == "italiano")
{
    textsp2 = "Io sono l'uomo di casa, e devo mostrarle chi comanda. Ora lo vedo.";
}
if(idioma == "portugues")
{
    textsp2 = "Eu sou o homem da casa, e devo mostrar a ela quem manda. Agora vejo isso.";
}
if(idioma == "japones")
{
    textsp2 = "私は家の男であり、誰が仕切るかを彼女に教えなければならない。今、それが分かった。";
}
if(idioma == "coreano")
{
    textsp2 = "나는 집의 남자이고, 그녀에게 누가 주인인지 가르쳐야 해. 이제야 알겠다.";
}
if(idioma == "chino")
{
    textsp2 = "我是家里的男人，我必须让她知道谁说了算。现在我明白了。";
}
if(idioma == "ruso")
{
    textsp2 = "Я хозяин дома и должен показать ей, кто здесь главный. Теперь я это понимаю.";
}
}
opi2 = false;
opi = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 76 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I don't know how to thank you for what you've done. Could you come back tomorrow, please? I have a feeling Mirai likes you.";
}
if(idioma == "español")
{
    textsp2 = "No se como agradecer lo que has hecho, podrias volver la proxima noche por favor? Tengo la sensacion de que le caes bien a Mirai.";
}
if(idioma == "frances")
{
    textsp2 = "Je ne sais pas comment te remercier pour ce que tu as fait. Pourrais-tu revenir demain, s'il te plait ? J'ai l'impression que Mirai t'apprecie.";
}
if(idioma == "aleman")
{
    textsp2 = "Ich weiß nicht, wie ich dir fur das danken soll, was du getan hast. Konntest du morgen bitte wiederkommen? Ich habe das Gefuhl, Mirai mag dich.";
}
if(idioma == "italiano")
{
    textsp2 = "Non so come ringraziarti per quello che hai fatto. Potresti tornare domani, per favore? Ho la sensazione che Mirai ti apprezzi.";
}
if(idioma == "portugues")
{
    textsp2 = "Nao sei como agradecer pelo que voce fez. Voce poderia voltar amanha, por favor? Tenho a sensacao de que a Mirai gosta de voce.";
}
if(idioma == "japones")
{
    textsp2 = "あなたがしてくれたことに、どう感謝したらいいかわからない。明日また来てくれない？ミライはあなたのこと、気に入ってる気がする。";
}
if(idioma == "coreano")
{
    textsp2 = "네가 해준 일에 어떻게 감사해야 할지 모르겠어. 내일 다시 와줄 수 있을까? 미라이가 너를 마음에 들어 하는 것 같아.";
}
if(idioma == "chino")
{
    textsp2 = "我不知道该怎么感谢你所做的一切。你明天能再来吗？我感觉未来挺喜欢你的。";
}
if(idioma == "ruso")
{
    textsp2 = "Я не знаю, как отблагодарить тебя за то, что ты сделал. Не мог бы ты прийти завтра? У меня такое чувство, что Мирай ты нравишься.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 77 && writing == true)
             {
             armingg2 = false;
             nolevi.SetActive(true);
            freeze = false;
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = false;
         timestop = false;
             }

             if(textorder == 78 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
    if(opi == false)
    {
    vanim.SetTrigger("feliz1");
    opi = true;
    }
         shop1.SetActive(false);
         shop2.SetActive(true);
if(idioma == "ingles")
{
    textsp2 = "Hello again! It seems the ghost's energy is about to run out, I estimate one more night!";
}
if(idioma == "español")
{
    textsp2 = "Hola de nuevo! Parece que la energia del fantasma esta por agotarse, estimo que una noche mas!";
}
if(idioma == "frances")
{
    textsp2 = "Salut a nouveau ! Il semble que l'energie du fantome soit sur le point de s'epuiser, j'estime encore une nuit!";
}
if(idioma == "aleman")
{
    textsp2 = "Hallo nochmal! Es scheint, dass die Energie des Geistes fast aufgebraucht ist, ich schatze noch eine Nacht!";
}
if(idioma == "italiano")
{
    textsp2 = "Ciao di nuovo! Sembra che l'energia del fantasma stia per esaurirsi, direi ancora una notte!";
}
if(idioma == "portugues")
{
    textsp2 = "Ola de novo! Parece que a energia do fantasma esta prestes a acabar, estimo mais uma noite!";
}
if(idioma == "japones")
{
    textsp2 = "また会ったね！幽霊のエネルギーはもうすぐ尽きそうだ。あと一晩くらいだと思う！";
}
if(idioma == "coreano")
{
    textsp2 = "다시 만나네! 유령의 에너지가 거의 다 떨어진 것 같아. 아마 하룻밤 정도 더일 거야!";
}
if(idioma == "chino")
{
    textsp2 = "又见面了！看起来幽灵的能量快要耗尽了，我估计只剩下一晚！";
}
if(idioma == "ruso")
{
    textsp2 = "Снова привет! Похоже, энергия призрака почти иссякла, думаю, осталась еще одна ночь! ";
}

opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 79 && writing == true)
             {
answer = true;
ox1.SetActive(false);
ox2.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "We will leave once it is gone and we can no longer help you. I have the impression that you've wanted to ask me something for a long time, so go ahead, don't hold back!";
}
if(idioma == "español")
{
    textsp2 = "Nos iremos una vez se haya ido y no podamos ayudarte mas. Me da la impresion de que quieres preguntarme algo desde hace tiempo, asi que adelante, no te cortes!";
}
if(idioma == "frances")
{
    textsp2 = "Nous partirons une fois que ce sera termine et que nous ne pourrons plus t'aider. J'ai l'impression que tu veux me poser une question depuis longtemps, alors vas-y, ne te retiens pas!";
}
if(idioma == "aleman")
{
    textsp2 = "Wir werden gehen, sobald es vorbei ist und wir dir nicht mehr helfen konnen. Ich habe den Eindruck, dass du mich schon seit einiger Zeit etwas fragen möchtest, also nur zu, zogere nicht!";
}
if(idioma == "italiano")
{
    textsp2 = "Ce ne andremo una volta che sara finita e non potremo piu aiutarti. Ho l'impressione che tu voglia chiedermi qualcosa da tempo, quindi avanti, non trattenerti!";
}
if(idioma == "portugues")
{
    textsp2 = "Iremos embora quando tudo terminar e nao pudermos mais te ajudar. Tenho a impressao de que voce quer me perguntar algo ha muito tempo, entao va em frente, nao hesite!";
}
if(idioma == "japones")
{
    textsp2 = "それが終わって、もう助けられなくなったら私たちは去るよ。ずっと前から何か聞きたそうにしてた気がするから、遠慮せずに聞いて！";
}
if(idioma == "coreano")
{
    textsp2 = "그게 끝나고 더 이상 도와줄 수 없게 되면 우리는 떠날 거야. 오래전부터 나에게 뭔가 묻고 싶어 했던 것 같으니, 주저하지 말고 말해!";
}
if(idioma == "chino")
{
    textsp2 = "等这一切结束、我们无法再帮助你时就会离开。我感觉你很久以前就想问我些什么了，所以尽管问吧，别客气！";
}
if(idioma == "ruso")
{
    textsp2 = "Мы уйдем, как только все закончится и мы больше не сможем тебе помочь. У меня такое ощущение, что ты давно хотел меня о чем-то спросить, так что давай, не стесняйся!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }
             if(textorder == 80 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
    if(opi == false)
    {
    vanim.SetTrigger("feliz2");
    opi = true;
    }
if(option == "A")
{
seller -= 5f;
if(idioma == "ingles")
{
    textsp2 = "My wife? She was very kind. Sometimes she came home late with a faint smell of... blood? No, it must have been cinnamon.";
}
if(idioma == "español")
{
    textsp2 = "Mi esposa? Ella era muy amable. A veces volvia a casa tarde con un leve olor a... sangre? No, seguro que era canela.";
}
if(idioma == "frances")
{
    textsp2 = "Ma femme ? Elle etait tres gentille. Parfois, elle rentrait tard avec une legere odeur de... sang ? Non, ca devait etre de la cannelle.";
}
if(idioma == "aleman")
{
    textsp2 = "Meine Frau? Sie war sehr nett. Manchmal kam sie spat nach Hause mit einem leichten Geruch nach... Blut? Nein, es musste Zimt sein.";
}
if(idioma == "italiano")
{
    textsp2 = "Mia moglie? Era molto gentile. A volte tornava a casa tardi con un leggero odore di... sangue? No, dev'essere stata cannella.";
}
if(idioma == "portugues")
{
    textsp2 = "Minha esposa? Ela era muito amavel. As vezes voltava para casa tarde com um leve cheiro de... sangue? Nao, com certeza era canela.";
}
if(idioma == "japones")
{
    textsp2 = "妻？彼女はとても優しかった。時々、少し血のような匂いを漂わせて夜遅く帰ってきたこともあった...いや、きっとシナモンの匂いだったんだ。";
}
if(idioma == "coreano")
{
    textsp2 = "내 아내? 그녀는 매우 친절했어. 가끔 집에 늦게 돌아오면서 약간 피 냄새가 났을 때도 있었지... 아니, 분명 계피 냄새였어.";
}
if(idioma == "chino")
{
    textsp2 = "我妻子？她非常亲切。有时她很晚回家，身上带着一丝...血的味道？不，肯定是肉桂的味道。";
}
if(idioma == "ruso")
{
    textsp2 = "Моя жена? Она была очень добра. Иногда возвращалась домой поздно с легким запахом... крови? Нет, конечно, это была корица.";
}
}
if(option == "B")
{
seller += 5f;
if(idioma == "ingles")
{
    textsp2 = "My daughter? Although she may seem tough and cold, she is pleasant once you get to know her.";
}
if(idioma == "español")
{
    textsp2 = "Mi hija? Aunque pueda parecer dura y fria, es agradable una vez que la conoces.";
}
if(idioma == "frances")
{
    textsp2 = "Ma fille ? Bien qu'elle puisse sembler dure et froide, elle est agreable une fois qu'on la connait.";
}
if(idioma == "aleman")
{
    textsp2 = "Meine Tochter? Obwohl sie hart und kuhl wirken mag, ist sie angenehm, sobald man sie kennt.";
}
if(idioma == "italiano")
{
    textsp2 = "Mia figlia? Anche se puo sembrare dura e fredda, e piacevole una volta che la conosci.";
}
if(idioma == "portugues")
{
    textsp2 = "Minha filha? Embora possa parecer dura e fria, e agradavel uma vez que voce a conhece.";
}
if(idioma == "japones")
{
    textsp2 = "私の娘？冷たくて強そうに見えるかもしれませんが、知ればとても感じの良い子です。";
}
if(idioma == "coreano")
{
    textsp2 = "내 딸? 차갑고 강하게 보일 수 있지만, 한 번 알게 되면 다정한 아이야.";
}
if(idioma == "chino")
{
    textsp2 = "我的女儿？虽然她看起来坚强而冷漠，但一旦你了解她，她其实很可爱。";
}
if(idioma == "ruso")
{
    textsp2 = "Моя дочь? Хотя она может казаться суровой и холодной, она приятна, когда её узнаешь.";
}
}

opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 81 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
if(idioma == "ingles")
{
    textsp2 = "The thing is, my daughter always listened to her and obeyed, as she should with me.";
}
if(idioma == "español")
{
    textsp2 = "El caso es que mi hija siempre le hacia caso y la obedecia, como deberia hacerlo conmigo.";
}
if(idioma == "frances")
{
    textsp2 = "Le fait est que ma fille l'ecoutait toujours et lui obeissait, comme elle devrait le faire avec moi.";
}
if(idioma == "aleman")
{
    textsp2 = "Die Tatsache ist, dass meine Tochter ihr immer gehorchte, so wie sie es auch mir gegenüber tun sollte.";
}
if(idioma == "italiano")
{
    textsp2 = "Il fatto e che mia figlia le obbediva sempre, come dovrebbe fare con me.";
}
if(idioma == "portugues")
{
    textsp2 = "O fato e que minha filha sempre lhe obedecia, como deveria fazer comigo.";
}
if(idioma == "japones")
{
    textsp2 = "実は、私の娘はいつも彼女の言うことを聞いて従っていました。私に対してもそうするべきなのに。";
}
if(idioma == "coreano")
{
    textsp2 = "사실, 내 딸은 항상 그녀의 말을 듣고 따랐어. 나한테도 그래야 하는데 말이지.";
}
if(idioma == "chino")
{
    textsp2 = "事实是，我的女儿总是听她的话并服从她，就像她应该对我一样。";
}
if(idioma == "ruso")
{
    textsp2 = "Дело в том, что моя дочь всегда слушалась её и подчинялась, как должна была бы и мне.";
}
}
if(option == "B")
{
if(idioma == "ingles")
{
    textsp2 = "I wish she could always be like this, but... No, I have no right to turn her into something she's not.";
}
if(idioma == "español")
{
    textsp2 = "Me gustaria que ella siempre fuera asi, pero... No, no tengo derecho a convertirla en algo que no es.";
}
if(idioma == "frances")
{
    textsp2 = "J'aimerais qu'elle soit toujours comme ca, mais... Non, je n'ai pas le droit de la transformer en quelque chose qu'elle n'est pas.";
}
if(idioma == "aleman")
{
    textsp2 = "Ich wunschte, sie konnte immer so sein, aber... Nein, ich habe kein Recht, sie zu etwas zu machen, was sie nicht ist.";
}
if(idioma == "italiano")
{
    textsp2 = "Vorrei che fosse sempre cosi, ma... No, non ho il diritto di trasformarla in qualcosa che non e.";
}
if(idioma == "portugues")
{
    textsp2 = "Gostaria que ela fosse sempre assim, mas... Nao, nao tenho o direito de transforma-la em algo que ela nao e.";
}
if(idioma == "japones")
{
    textsp2 = "彼女がいつもこんなふうでいてくれたらいいのに...でも、いや、彼女をそうでないものに変える権利は私にはない。";
}
if(idioma == "coreano")
{
    textsp2 = "그녀가 항상 이렇게만 있어주길 바라지만... 아니, 그녀를 그녀가 아닌 무언가로 바꿀 권리는 나에게 없어.";
}
if(idioma == "chino")
{
    textsp2 = "我希望她永远能这样，但...不，我没有权利把她变成她不是的样子。";
}
if(idioma == "ruso")
{
    textsp2 = "Я бы хотел, чтобы она всегда была такой, но... Нет, у меня нет права превращать её во что-то, чем она не является.";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 82 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "You have opened my eyes, I thank you from the bottom of my heart. If one day I can repay you, I will. By the way, Mirai wants to see you.";
}
if(idioma == "español")
{
    textsp2 = "Me has abierto los ojos, te lo agradezco de corazon. Si algun dia puedo pagartelo, lo hare. Por cierto, Mirai quiere verte.";
}
if(idioma == "frances")
{
    textsp2 = "Tu m'as ouvert les yeux, je te remercie de tout coeur. Si un jour je peux te rendre la pareille, je le ferai. Au fait, Mirai veut te voir.";
}
if(idioma == "aleman")
{
    textsp2 = "Du hast mir die Augen geoffnet, ich danke dir von Herzen. Wenn ich dir eines Tages etwas zuruckzahlen kann, werde ich es tun. Ubrigens mochte Mirai dich sehen.";
}
if(idioma == "italiano")
{
    textsp2 = "Mi hai aperto gli occhi, ti ringrazio di cuore. Se un giorno potro ripagarti, lo faro. A proposito, Mirai vuole vederti.";
}
if(idioma == "portugues")
{
    textsp2 = "Voce me abriu os olhos, agradeço de coracao. Se algum dia eu puder retribuir, eu o farei. A proposito, Mirai quer te ver.";
}
if(idioma == "japones")
{
    textsp2 = "目を開かせてくれて、心から感謝しています。いつかお返しできるなら、必ずします。ところで、ミライがあなたに会いたがっています。";
}
if(idioma == "coreano")
{
    textsp2 = "눈을 뜨게 해줘서 진심으로 감사해. 언젠가 보답할 수 있다면 꼭 할게. 그런데 미라이가 너를 보고 싶어 해.";
}
if(idioma == "chino")
{
    textsp2 = "你让我开了眼界，我由衷地感谢你。如果有一天我能报答你，我一定会。对了，未来想见你。";
}
if(idioma == "ruso")
{
    textsp2 = "Ты открыл мне глаза, я благодарю тебя от всего сердца. Если однажды смогу отплатить тебе, я это сделаю. Кстати, Мирай хочет тебя видеть.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 83 && writing == true)
             {
             arming2 = false;
             nolevi.SetActive(true);
            freeze = false;
         fdt.clip = mxc;
         fdt.loop = true;
         fdt.Play();
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
         shop1.SetActive(false);
         shop2.SetActive(true);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = false;
         timestop = false;
             }

             if(textorder == 84 && writing == false)
             {
shop2.SetActive(false);
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
answer = true;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Ah- it's you... I understand we won't be seeing each other much longer... If you... want to tell me something... go ahead.";
}
if(idioma == "español")
{
    textsp2 = "Ah- eres tu... Tengo entendido que no nos veremos mucho mas... Si... quieres decirme algo... adelante.";
}
if(idioma == "frances")
{
    textsp2 = "Ah- c'est toi... J'ai compris que nous ne nous verrons plus beaucoup... Si tu... veux me dire quelque chose... vas-y.";
}
if(idioma == "aleman")
{
    textsp2 = "Ah- du bist es... Ich habe verstanden, dass wir uns nicht mehr oft sehen werden... Wenn du... mir etwas sagen willst... nur zu.";
}
if(idioma == "italiano")
{
    textsp2 = "Ah- sei tu... Ho capito che non ci vedremo ancora per molto... Se... vuoi dirmi qualcosa... dimmelo pure.";
}
if(idioma == "portugues")
{
    textsp2 = "Ah- e voce... Pelo que entendi, nao vamos nos ver por muito mais tempo... Se... quiser me dizer algo... fique a vontade.";
}
if(idioma == "japones")
{
    textsp2 = "ああ...君か。もうあまり会えなくなるって聞いている...もし...何か言いたいことがあるなら...どうぞ。";
}
if(idioma == "coreano")
{
    textsp2 = "아... 너구나. 이제 우리가 자주 만나지 못할 거라는 건 알고 있어... 만약... 하고 싶은 말이 있다면... 말해도 돼.";
}
if(idioma == "chino")
{
    textsp2 = "啊-是你啊...我听说我们以后不会再常见了...如果你...有什么想对我说的...请说吧。";
}
if(idioma == "ruso")
{
    textsp2 = "А... это ты. Я понимаю, что мы больше не будем часто видеться... Если ты... хочешь мне что-то сказать... говори.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 85 && writing == true)
             {
                shop3.SetActive(true);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
mirai += 5;
if(idioma == "ingles")
{
    textsp2 = "Eh? Dad? I thought you were going to propose... Ah! Never mind! Dad... He's overprotective, he never listens to me and always tells me what to do! But...";
}
if(idioma == "español")
{
    textsp2 = "Eh? Papa? Crei que me ibas a proponer... Ah! Nada! Papa... El es sobreprotector, nunca me escucha y siempre me dice lo que debo hacer! Pero...";
}
if(idioma == "frances")
{
    textsp2 = "Hein ? Papa ? Je pensais que tu allais me faire une proposition... Ah ! Ce n'est rien ! Papa... Il est surprotecteur, il ne m'ecoute jamais et me dit toujours ce que je dois faire ! Mais...";
}
if(idioma == "aleman")
{
    textsp2 = "Eh? Papa? Ich dachte, du wurdest mir einen Vorschlag machen... Ah! Nichts! Papa... Er ist uberfursorglich, hort mir nie zu und sagt mir immer, was ich tun soll! Aber...";
}
if(idioma == "italiano")
{
    textsp2 = "Eh? Papa? Pensavo che mi avresti fatto una proposta... Ah! Niente! Papa... E iperprotettivo, non mi ascolta mai e mi dice sempre cosa devo fare! Ma...";
}
if(idioma == "portugues")
{
    textsp2 = "Eh? Pai? Eu pensei que voce ia me propor... Ah! Nada! Pai... Ele e superprotetor, nunca me escuta e sempre me diz o que devo fazer! Mas...";
}
if(idioma == "japones")
{
    textsp2 = "え？お父さん？プロポーズしてくれると思ったのに...あ！なんでもない！お父さん...彼は過保護で、私の話を全然聞かないし、いつも私に何をすべきか言うの！でも...";
}
if(idioma == "coreano")
{
    textsp2 = "엥? 아빠? 나한테 청혼할 줄 알았는데... 아! 아무것도 아니야! 아빠... 그는 과보호적이고, 나 말을 절대 안 듣고 항상 내가 뭘 해야 하는지 말해! 하지만...";
}
if(idioma == "chino")
{
    textsp2 = "诶？爸爸？我还以为你会向我求婚...啊！没事！爸爸...他很溺爱，总是不听我的话，总是告诉我该做什么！但是...";
}
if(idioma == "ruso")
{
    textsp2 = "Э? Папа? Я думала, ты собирался сделать мне предложение... Ах! Ничего! Папа... Он чрезмерно опекает, никогда меня не слушает и всегда говорит, что я должна делать! Но...";
}
}
if(option == "B")
{
mirai -= 5;
if(idioma == "ingles")
{
    textsp2 = "Huh? Mom? I... don't remember much about her, but... she was very reasonable... Although when she came home late and I asked where she had been, she would just read me a story.";
}
if(idioma == "español")
{
    textsp2 = "Eh? Mama? Esto... no recuerdo mucho de ella, pero... era muy razonable... Aunque cuando volvia tarde y le preguntaba donde habia estado, solo me leia un cuento.";
}
if(idioma == "frances")
{
    textsp2 = "Hein ? Maman ? Je... ne me souviens pas beaucoup d'elle, mais... elle etait tres raisonnable... Meme si, quand elle rentrait tard et que je lui demandais ou elle etait allee, elle me lisait juste une histoire.";
}
if(idioma == "aleman")
{
    textsp2 = "Hm? Mama? Ich... erinnere mich nicht viel an sie, aber... sie war sehr vernunftig... Obwohl, wenn sie spat nach Hause kam und ich fragte, wo sie gewesen war, las sie mir einfach eine Geschichte vor.";
}
if(idioma == "italiano")
{
    textsp2 = "Eh? Mamma? Non... ricordo molto di lei, ma... era molto ragionevole... Anche se, quando tornava tardi e le chiedevo dove fosse stata, mi leggeva solo una storia.";
}
if(idioma == "portugues")
{
    textsp2 = "Eh? Mamae? Eu... nao lembro muito dela, mas... ela era muito sensata... Embora, quando voltava tarde e eu perguntava onde tinha estado, ela so me contava uma historia.";
}
if(idioma == "japones")
{
    textsp2 = "え？お母さん？あの...あまり覚えていないけど...とても理性的な人だった...でも、夜遅く帰ってきて、どこに行ってたのか聞くと、ただ物語を読んでくれたんだ。";
}
if(idioma == "coreano")
{
    textsp2 = "응? 엄마? 이... 그녀에 대해 많이 기억나진 않지만... 매우 이성적이었어... 하지만 늦게 집에 돌아왔을 때 어디 갔었냐고 물으면 그냥 이야기를 읽어주곤 했어.";
}
if(idioma == "chino")
{
    textsp2 = "嗯？妈妈？这个...我对她记得不多，但...她很理智...虽然当她晚回家，我问她去了哪里时，她只是给我讲个故事。";
}
if(idioma == "ruso")
{
    textsp2 = "А? Мама? Я... мало что о ней помню, но... она была очень разумной... Хотя, когда она возвращалась поздно и я спрашивал, где была, она просто читала мне сказку.";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 86 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(option == "A")
{
if(idioma == "ingles")
{
    textsp2 = "I guess... she does it for my own good... It's not fair for me to try to understand her if I don't understand him... Thank you... Thank you truly!";
}
if(idioma == "español")
{
    textsp2 = "Supongo... que lo hace por mi bien... No es justo que intente entenderle si yo no lo entiendo a el... Gracias... gracias de verdad!";
}
if(idioma == "frances")
{
    textsp2 = "Je suppose... qu'elle le fait pour mon bien... Ce n'est pas juste que j'essaie de la comprendre si je ne le comprends pas... Merci... merci vraiment !";
}
if(idioma == "aleman")
{
    textsp2 = "Ich nehme an... sie tut es zu meinem Besten... Es ist nicht fair, dass ich versuche, sie zu verstehen, wenn ich ihn nicht verstehe... Danke... wirklich danke!";
}
if(idioma == "italiano")
{
    textsp2 = "Suppongo... lo fa per il mio bene... Non e giusto che cerchi di capirla se io non lo capisco... Grazie... davvero grazie!";
}
if(idioma == "portugues")
{
    textsp2 = "Suponho... que ela faz isso pelo meu bem... Nao e justo tentar entende-la se eu nao o entendo... Obrigado... obrigado de verdade!";
}
if(idioma == "japones")
{
    textsp2 = "多分...私のためにやってくれているんだろう...私が彼を理解できないのに、彼女を理解しようとするのは不公平だ...ありがとう...本当にありがとう！";
}
if(idioma == "coreano")
{
    textsp2 = "아마... 내 이익을 위해 그러는 거겠지... 내가 그를 이해하지 못하는데 그녀를 이해하려고 하는 건 공평하지 않아... 고마워... 진심으로 고마워!";
}
if(idioma == "chino")
{
    textsp2 = "我想...她是为了我的好...如果我不理解他，就不公平去试着理解她...谢谢...真的谢谢你！";
}
if(idioma == "ruso")
{
    textsp2 = "Полагаю... она делает это ради моего блага... Нечестно пытаться понять её, если я не понимаю его... Спасибо... правда, спасибо!";
}
}
if(option == "B")
{
if(idioma == "ingles")
{
    textsp2 = "She let me do what I wanted... She would see if what I suggested made sense or not! Not like him! I’ll tell him a few things, now I see!";
}
if(idioma == "español")
{
    textsp2 = "Ella me dejaba hacer lo que queria... Veia si lo que proponia tenia sentido o no! No como el! Le dire un par de cosas, ahora lo veo!";
}
if(idioma == "frances")
{
    textsp2 = "Elle me laissait faire ce que je voulais... Elle voyait si ce que je proposais avait du sens ou non ! Pas comme lui ! Je vais lui dire quelques choses, maintenant je comprends !";
}
if(idioma == "aleman")
{
    textsp2 = "Sie ließ mich tun, was ich wollte... Sie sah, ob das, was ich vorschlug, Sinn machte oder nicht! Nicht wie er! Ich werde ihm ein paar Dinge sagen, jetzt sehe ich es!";
}
if(idioma == "italiano")
{
    textsp2 = "Lei mi lasciava fare quello che volevo... Verificava se cio che proponevo aveva senso o no! Non come lui! Gli diro un paio di cose, ora capisco!";
}
if(idioma == "portugues")
{
    textsp2 = "Ela me deixava fazer o que eu queria... Ela via se o que eu propunha fazia sentido ou nao! Nao como ele! Vou dizer umas coisas para ele, agora eu vejo!";
}
if(idioma == "japones")
{
    textsp2 = "彼女は私がやりたいことをさせてくれた...私の提案が意味があるかどうか見てくれたんだ！彼とは違う！今、彼にいくつか言うつもりだ、わかった！";
}
if(idioma == "coreano")
{
    textsp2 = "그녀는 내가 원하는 걸 하게 놔뒀어... 내가 제안한 것이 말이 되는지 아닌지 봐줬지! 그와는 달라! 지금 몇 가지 말해줄 거야, 이제 알겠어!";
}
if(idioma == "chino")
{
    textsp2 = "她让我做我想做的事...她会看我提的建议是否有道理！不像他！我会告诉他几件事，现在我明白了！";
}
if(idioma == "ruso")
{
    textsp2 = "Она позволяла мне делать то, что я хотел... Она смотрела, имеет ли смысл то, что я предлагаю, или нет! Не как он! Я скажу ему пару вещей, теперь я понимаю!";
}
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 87 && writing == true)
             {
             armingg = false;
             nolevi.SetActive(true);
            freeze = false;
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = false;
         timestop = false;
             }

             if(textorder == 88 && writing == false)
             {
shop1.SetActive(false);
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "A customer!";
}
if(idioma == "español")
{
    textsp2 = "Un cliente!";
}
if(idioma == "frances")
{
    textsp2 = "Un client !";
}
if(idioma == "aleman")
{
    textsp2 = "Ein Kunde!";
}
if(idioma == "italiano")
{
    textsp2 = "Un cliente!";
}
if(idioma == "portugues")
{
    textsp2 = "Um cliente!";
}
if(idioma == "japones")
{
    textsp2 = "お客さんだ！";
}
if(idioma == "coreano")
{
    textsp2 = "손님이다!";
}
if(idioma == "chino")
{
    textsp2 = "有客人！";
}
if(idioma == "ruso")
{
    textsp2 = "Клиент!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 89 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Both";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Deux";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Beide";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Entrambi";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "両方";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "둘 다";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "两者";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Оба";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Welcome to the Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "español")
{
    textsp2 = "Bienvenido al Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "frances")
{
    textsp2 = "Bienvenue au piment roulant! El chile mas picante de todo el infierno!";
}
if(idioma == "aleman")
{
    textsp2 = "Willkommen beim Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "italiano")
{
    textsp2 = "Benvenuto al Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "portugues")
{
    textsp2 = "Bem-vindo ao Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "japones")
{
    textsp2 = "ようこそ、Picante Rodante! El chile mas picante de todo el infierno!";
}
if(idioma == "coreano")
{
    textsp2 = "굴러가는 매운맛에 오신 것을 환영합니다! El chile mas picante de todo el infierno!";
}
if(idioma == "chino")
{
    textsp2 = "欢迎来到滚动的辣味！El chile mas picante de todo el infierno!";
}
if(idioma == "ruso")
{
    textsp2 = "Добро пожаловать в Picante Rodante! El chile mas picante de todo el infierno!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 90 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Are you going to use the slot machine, sir?";
}
if(idioma == "español")
{
    textsp2 = "Va a usar la maquina tragaperras, cliente?";
}
if(idioma == "frances")
{
    textsp2 = "Allez-vous utiliser la machine a sous, monsieur ?";
}
if(idioma == "aleman")
{
    textsp2 = "Werden Sie den Spielautomaten benutzen, mein Herr?";
}
if(idioma == "italiano")
{
    textsp2 = "Usera la slot machine, signore?";
}
if(idioma == "portugues")
{
    textsp2 = "Vai usar a maquina caca-niqueis, senhor?";
}
if(idioma == "japones")
{
    textsp2 = "スロットマシンを使いますか、旦那様？";
}
if(idioma == "coreano")
{
    textsp2 = "슬롯머신을 사용하시겠습니까, 손님?";
}
if(idioma == "chino")
{
    textsp2 = "先生，您要使用老虎机吗？";
}
if(idioma == "ruso")
{
    textsp2 = "Вы собираетесь воспользоваться игровым автоматом, сэр?";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 91 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Dad! The song!";
}
if(idioma == "español")
{
    textsp2 = "Papa! La cancion!";
}
if(idioma == "frances")
{
    textsp2 = "Papa ! La chanson !";
}
if(idioma == "aleman")
{
    textsp2 = "Papa! Das Lied!";
}
if(idioma == "italiano")
{
    textsp2 = "Papa! La canzone!";
}
if(idioma == "portugues")
{
    textsp2 = "Papai! A cancao!";
}
if(idioma == "japones")
{
    textsp2 = "パパ！あの歌！";
}
if(idioma == "coreano")
{
    textsp2 = "아빠! 그 노래!";
}
if(idioma == "chino")
{
    textsp2 = "爸爸！那首歌！";
}
if(idioma == "ruso")
{
    textsp2 = "Папа! Песня!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 92 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Um... I don't know if I'm ready to-";
}
if(idioma == "español")
{
    textsp2 = "Esto... no se si estoy listo para-";
}
if(idioma == "frances")
{
    textsp2 = "Euh... je ne sais pas si je suis pret a-";
}
if(idioma == "aleman")
{
    textsp2 = "Ahm... ich weiß nicht, ob ich bereit dafur bin-";
}
if(idioma == "italiano")
{
    textsp2 = "Ehm... non so se sono pronto a-";
}
if(idioma == "portugues")
{
    textsp2 = "Hum... nao sei se estou pronto para-";
}
if(idioma == "japones")
{
    textsp2 = "えっと...準備ができているかどうか-";
}
if(idioma == "coreano")
{
    textsp2 = "저기... 내가 준비가 됐는지 모르겠어-";
}
if(idioma == "chino")
{
    textsp2 = "这个...我不知道我是否准备好了-";
}
if(idioma == "ruso")
{
    textsp2 = "Эм... не знаю, готов ли я-";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 93 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Dad! I'm here! Come on, I know you can do it!";
}
if(idioma == "español")
{
    textsp2 = "Papa! Estoy aqui! Vamos, se que puedes!";
}
if(idioma == "frances")
{
    textsp2 = "Papa ! Je suis la ! Allez, je sais que tu peux le faire !";
}
if(idioma == "aleman")
{
    textsp2 = "Papa! Ich bin hier! Komm schon, ich weiß, dass du es kannst!";
}
if(idioma == "italiano")
{
    textsp2 = "Papa! Sono qui! Dai, so che puoi farcela!";
}
if(idioma == "portugues")
{
    textsp2 = "Papai! Estou aqui! Vamos, sei que voce consegue!";
}
if(idioma == "japones")
{
    textsp2 = "パパ！ここにいるよ！さあ、できるって知ってるよ！";
}
if(idioma == "coreano")
{
    textsp2 = "아빠! 나 여기 있어! 자, 할 수 있다는 거 알아!";
}
if(idioma == "chino")
{
    textsp2 = "爸爸！我在这里！来吧，我知道你能做到！";
}
if(idioma == "ruso")
{
    textsp2 = "Папа! Я здесь! Давай, я знаю, что ты сможешь!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 94 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "You know what? Alright! Here we go!";
}
if(idioma == "español")
{
    textsp2 = "Sabes que? De acuerdo! Alla vamos!";
}
if(idioma == "frances")
{
    textsp2 = "Tu sais quoi ? D'accord ! C'est parti !";
}
if(idioma == "aleman")
{
    textsp2 = "Weißt du was? In Ordnung! Los geht's!";
}
if(idioma == "italiano")
{
    textsp2 = "Sai una cosa? Va bene! Andiamo!";
}
if(idioma == "portugues")
{
    textsp2 = "Sabe de uma coisa? Tudo bem! La vamos nos!";
}
if(idioma == "japones")
{
    textsp2 = "そうだね？よし！行こう！";
}
if(idioma == "coreano")
{
    textsp2 = "있잖아? 좋아! 가자!";
}
if(idioma == "chino")
{
    textsp2 = "你知道吗？好！我们走吧！";
}
if(idioma == "ruso")
{
    textsp2 = "Знаешь что? Ладно! Поехали!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 95 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Both";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Deux";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Beide";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Entrambi";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "両方";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "둘 다";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "两者";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Оба";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Pull the lever now!";
}
if(idioma == "español")
{
    textsp2 = "Tira de la palanca ya!";
}
if(idioma == "frances")
{
    textsp2 = "Tire du levier maintenant !";
}
if(idioma == "aleman")
{
    textsp2 = "Zieh jetzt am Hebel!";
}
if(idioma == "italiano")
{
    textsp2 = "Tira subito la leva!";
}
if(idioma == "portugues")
{
    textsp2 = "Puxe a alavanca agora!";
}
if(idioma == "japones")
{
    textsp2 = "今すぐレバーを引いて！";
}
if(idioma == "coreano")
{
    textsp2 = "지금 레버를 당겨!";
}
if(idioma == "chino")
{
    textsp2 = "快拉杆！";
}
if(idioma == "ruso")
{
    textsp2 = "Тяни за рычаг прямо сейчас!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 96 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Both";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Deux";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Beide";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Entrambi";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "両方";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "둘 다";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "两者";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Оба";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Pull the lever now!";
}
if(idioma == "español")
{
    textsp2 = "Tira de la palanca ya!";
}
if(idioma == "frances")
{
    textsp2 = "Tire du levier maintenant !";
}
if(idioma == "aleman")
{
    textsp2 = "Zieh jetzt am Hebel!";
}
if(idioma == "italiano")
{
    textsp2 = "Tira subito la leva!";
}
if(idioma == "portugues")
{
    textsp2 = "Puxe a alavanca agora!";
}
if(idioma == "japones")
{
    textsp2 = "今すぐレバーを引いて！";
}
if(idioma == "coreano")
{
    textsp2 = "지금 레버를 당겨!";
}
if(idioma == "chino")
{
    textsp2 = "快拉杆！";
}
if(idioma == "ruso")
{
    textsp2 = "Тяни за рычаг прямо сейчас!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 97 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "If you have extra money!";
}
if(idioma == "español")
{
    textsp2 = "Si tienes dinero de mas!";
}
if(idioma == "frances")
{
    textsp2 = "Si vous avez de l'argent en trop !";
}
if(idioma == "aleman")
{
    textsp2 = "Wenn du zusatzliches Geld hast!";
}
if(idioma == "italiano")
{
    textsp2 = "Se hai soldi in piu!";
}
if(idioma == "portugues")
{
    textsp2 = "Se voce tiver dinheiro de sobra!";
}
if(idioma == "japones")
{
    textsp2 = "もしお金が余っているなら！";
}
if(idioma == "coreano")
{
    textsp2 = "돈이 남으면!";
}
if(idioma == "chino")
{
    textsp2 = "如果你有多余的钱！";
}
if(idioma == "ruso")
{
    textsp2 = "Если у тебя есть лишние деньги!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 98 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "And they can't stand you at home anymore!";
}
if(idioma == "español")
{
    textsp2 = "Y en casa no te aguantan ya!";
}
if(idioma == "frances")
{
    textsp2 = "Et a la maison, ils ne te supportent plus !";
}
if(idioma == "aleman")
{
    textsp2 = "Und zu Hause halten sie dich auch nicht mehr aus!";
}
if(idioma == "italiano")
{
    textsp2 = "E a casa non ti sopportano più!";
}
if(idioma == "portugues")
{
    textsp2 = "E em casa eles ja nao te suportam!";
}
if(idioma == "japones")
{
    textsp2 = "家ではもう我慢できないんだろう！";
}
if(idioma == "coreano")
{
    textsp2 = "집에서는 더 이상 너를 참지 못하겠지!";
}
if(idioma == "chino")
{
    textsp2 = "在家里你也受不了啦！";
}
if(idioma == "ruso")
{
    textsp2 = "А дома тебя уже не выносят!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 99 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "The jackpot will hit!";
}
if(idioma == "español")
{
    textsp2 = "El premio gordo tocara!";
}
if(idioma == "frances")
{
    textsp2 = "Le jackpot va tomber !";
}
if(idioma == "aleman")
{
    textsp2 = "Der Hauptgewinn wird fallen!";
}
if(idioma == "italiano")
{
    textsp2 = "Il jackpot colpira!";
}
if(idioma == "portugues")
{
    textsp2 = "O premio maximo vai sair!";
}
if(idioma == "japones")
{
    textsp2 = "ジャックポットが当たる！";
}
if(idioma == "coreano")
{
    textsp2 = "잭팟이 터질 거야!";
}
if(idioma == "chino")
{
    textsp2 = "头奖就要中了！";
}
if(idioma == "ruso")
{
    textsp2 = "Джекпот выпадет!";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 100 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Try your luck and you'll see!";
}
if(idioma == "español")
{
    textsp2 = "Prueba suerte y ya veras!";
}
if(idioma == "frances")
{
    textsp2 = "Tente ta chance et tu verras !";
}
if(idioma == "aleman")
{
    textsp2 = "Versuch dein Gluck und du wirst sehen!";
}
if(idioma == "italiano")
{
    textsp2 = "Prova fortuna e vedrai!";
}
if(idioma == "portugues")
{
    textsp2 = "Tente a sorte e voce vera!";
}
if(idioma == "japones")
{
    textsp2 = "運試ししてみて、すぐわかるよ！";
}
if(idioma == "coreano")
{
    textsp2 = "운을 시험해봐, 그러면 알게 될 거야!";
}
if(idioma == "chino")
{
    textsp2 = "试试运气，你就会看到！";
}
if(idioma == "ruso")
{
    textsp2 = "Попробуй удачу, и увидишь!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 101 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Both";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Deux";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Beide";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Entrambi";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Ambos";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "両方";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "둘 다";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "两者";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Оба";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Pull the lever now!";
}
if(idioma == "español")
{
    textsp2 = "Tira de la palanca ya!";
}
if(idioma == "frances")
{
    textsp2 = "Tire du levier maintenant !";
}
if(idioma == "aleman")
{
    textsp2 = "Zieh jetzt am Hebel!";
}
if(idioma == "italiano")
{
    textsp2 = "Tira subito la leva!";
}
if(idioma == "portugues")
{
    textsp2 = "Puxe a alavanca agora!";
}
if(idioma == "japones")
{
    textsp2 = "今すぐレバーを引いて！";
}
if(idioma == "coreano")
{
    textsp2 = "지금 레버를 당겨!";
}
if(idioma == "chino")
{
    textsp2 = "快拉杆！";
}
if(idioma == "ruso")
{
    textsp2 = "Тяни за рычаг прямо сейчас!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 102 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "To be honest, I never said it was a good song.";
}
if(idioma == "español")
{
    textsp2 = "Para ser honesta, nunca dije que fuera una buena cancion.";
}
if(idioma == "frances")
{
    textsp2 = "Pour etre honnete, je n'ai jamais dit que c'était une bonne chanson.";
}
if(idioma == "aleman")
{
    textsp2 = "Um ehrlich zu sein, habe ich nie gesagt, dass es ein gutes Lied ist.";
}
if(idioma == "italiano")
{
    textsp2 = "Ad essere onesta, non ho mai detto che fosse una buona canzone.";
}
if(idioma == "portugues")
{
    textsp2 = "Para ser honesta, nunca disse que fosse uma boa cancao.";
}
if(idioma == "japones")
{
    textsp2 = "正直に言うと、それが良い歌だとは一度も言ったことがない。";
}
if(idioma == "coreano")
{
    textsp2 = "솔직히 말하면, 내가 좋은 노래라고 한 적은 없어.";
}
if(idioma == "chino")
{
    textsp2 = "说实话，我从没说过这是首好歌。";
}
if(idioma == "ruso")
{
    textsp2 = "Если честно, я никогда не говорил, что это хорошая песня.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 103 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Anyway, have a good night and good luck with the ghost. Ah! And leave a good review on elpicanterodante.com";
}
if(idioma == "español")
{
    textsp2 = "En fin, ten una buena noche y suerte con el fantasma. Ah! Y pon un buen comentario en elpicanterodante.com";
}
if(idioma == "frances")
{
    textsp2 = "Bref, passe une bonne nuit et bonne chance avec le fantôme. Ah ! Et laisse un bon commentaire sur elpicanterodante.com";
}
if(idioma == "aleman")
{
    textsp2 = "Also, hab eine gute Nacht und viel Gluck mit dem Geist. Ah! Und hinterlasse eine gute Bewertung auf elpicanterodante.com";
}
if(idioma == "italiano")
{
    textsp2 = "Insomma, buona notte e buona fortuna con il fantasma. Ah! E lascia una buona recensione su elpicanterodante.com";
}
if(idioma == "portugues")
{
    textsp2 = "Enfim, tenha uma boa noite e boa sorte com o fantasma. Ah! E deixe um bom comentario em elpicanterodante.com";
}
if(idioma == "japones")
{
    textsp2 = "とにかく、おやすみなさい。幽霊に幸運を！あ！そして、elpicanterodante.comに良いコメントを残してね。";
}
if(idioma == "coreano")
{
    textsp2 = "어쨌든, 좋은 밤 보내고 유령에게 행운을 빌어! 아! 그리고 elpicanterodante.com에 좋은 댓글 남겨줘.";
}
if(idioma == "chino")
{
    textsp2 = "总之，晚安，祝你和幽灵好运。啊！别忘了在 elpicanterodante.com 留个好评。";
}
if(idioma == "ruso")
{
    textsp2 = "В общем, спокойной ночи и удачи с призраком. Ах! И оставь хороший отзыв на elpicanterodante.com.";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 104 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Psss... Dad... We don’t have a website...";
}
if(idioma == "español")
{
    textsp2 = "Psss... Papa... No tenemos pagina web...";
}
if(idioma == "frances")
{
    textsp2 = "Psss... Papa... Nous n'avons pas de site web...";
}
if(idioma == "aleman")
{
    textsp2 = "Psss... Papa... Wir haben keine Webseite...";
}
if(idioma == "italiano")
{
    textsp2 = "Psss... Papa... Non abbiamo un sito web...";
}
if(idioma == "portugues")
{
    textsp2 = "Psss... Papai... Nao temos um site...";
}
if(idioma == "japones")
{
    textsp2 = "シー...パパ...ウェブサイトはないよ...";
}
if(idioma == "coreano")
{
    textsp2 = "쉿... 아빠... 우리 웹사이트 없어...";
}
if(idioma == "chino")
{
    textsp2 = "嘘...爸爸...我们没有网站...";
}
if(idioma == "ruso")
{
    textsp2 = "Псс... Папа... У нас нет сайта...";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 105 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "It's called looking to the future, daughter. I thought you were an expert at that.";
}
if(idioma == "español")
{
    textsp2 = "Se llama mirar hacia el futuro, hija. Crei que eras experta en eso.";
}
if(idioma == "frances")
{
    textsp2 = "Ca s'appelle regarder vers l'avenir, ma fille. Je pensais que tu etais experte en ca.";
}
if(idioma == "aleman")
{
    textsp2 = "Es nennt sich in die Zukunft schauen, Tochter. Ich dachte, du wärst darin Expertin.";
}
if(idioma == "italiano")
{
    textsp2 = "Si chiama guardare al futuro, figlia. Credevo fossi esperta in questo.";
}
if(idioma == "portugues")
{
    textsp2 = "Chama-se olhar para o futuro, filha. Achei que voce fosse especialista nisso.";
}
if(idioma == "japones")
{
    textsp2 = "未来を見るっていうんだ、娘よ。君はその専門家だと思ってたのに。";
}
if(idioma == "coreano")
{
    textsp2 = "미래를 보는 거야, 딸아. 네가 그거에 전문가인 줄 알았는데.";
}
if(idioma == "chino")
{
    textsp2 = "这叫做展望未来，女儿。我以为你在这方面很擅长呢。";
}
if(idioma == "ruso")
{
    textsp2 = "Это называется смотреть в будущее, дочь. Я думал, ты в этом эксперт.";
}
opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 106 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Dad, that's not what I... Never mind.";
}
if(idioma == "español")
{
    textsp2 = "Papa, eso no es lo que yo... Da igual.";
}
if(idioma == "frances")
{
    textsp2 = "Papa, ce n'est pas ce que je... Peu importe.";
}
if(idioma == "aleman")
{
    textsp2 = "Papa, das ist nicht das, was ich... Egal.";
}
if(idioma == "italiano")
{
    textsp2 = "Papa, non e quello che io... Fa lo stesso.";
}
if(idioma == "portugues")
{
    textsp2 = "Papai, isso nao e o que eu... Tanto faz.";
}
if(idioma == "japones")
{
    textsp2 = "パパ、それは私が...まあいいや。";
}
if(idioma == "coreano")
{
    textsp2 = "아빠, 그건 내가... 괜찮아.";
}
if(idioma == "chino")
{
    textsp2 = "爸爸，那不是我想说的...算了。";
}
if(idioma == "ruso")
{
    textsp2 = "Папа, это не то, что я... Ладно.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 107 && writing == true)
             {
             arming2 = false;
             nolevi.SetActive(true);
            freeze = false;
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = false;
         timestop = false;
             }

             if(textorder == 108 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "We caught you, Llorona! Yace! We don't have much time!";
}
if(idioma == "español")
{
    textsp2 = "Te atrapamos, Llorona! Yace! No tenemos mucho tiempo!";
}
if(idioma == "frances")
{
    textsp2 = "On t'a attrapee, Llorona ! Yace ! Nous n'avons pas beaucoup de temps !";
}
if(idioma == "aleman")
{
    textsp2 = "Wir haben dich erwischt, Llorona! Yace! Wir haben nicht viel Zeit!";
}
if(idioma == "italiano")
{
    textsp2 = "Ti abbiamo presa, Llorona! Yace! Non abbiamo molto tempo!";
}
if(idioma == "portugues")
{
    textsp2 = "Nos te pegamos, Llorona! Yace! Nao temos muito tempo!";
}
if(idioma == "japones")
{
    textsp2 = "捕まえたぞ、ラ・ヨローナ！ヤセ！時間がない！";
}
if(idioma == "coreano")
{
    textsp2 = "잡았다, 요로로나! 야세! 시간이 많지 않아!";
}
if(idioma == "chino")
{
    textsp2 = "抓住你了，哭泣女妖！雅斯！我们时间不多了！";
}
if(idioma == "ruso")
{
    textsp2 = "Мы поймали тебя, Льорона! Ясе! У нас мало времени!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 109 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "After this humiliation, the Devil will not stand idly by! He will send spirit after spirit after you! You will never be safe!";
}
if(idioma == "español")
{
    textsp2 = "Tras esta humillacion, el diablo no se quedara de brazos cruzados! Mandara un espiritu tras otro a por ti! Jamas estaras a salvo!";
}
if(idioma == "frances")
{
    textsp2 = "Apres cette humiliation, le diable ne restera pas les bras croises ! Il enverra esprit apres esprit a tes trousses ! Tu ne seras jamais en securite !";
}
if(idioma == "aleman")
{
    textsp2 = "Nach dieser Demutigung wird der Teufel nicht untätig bleiben! Er wird einen Geist nach dem anderen auf dich hetzen! Du wirst niemals sicher sein!";
}
if(idioma == "italiano")
{
    textsp2 = "Dopo questa umiliazione, il diavolo non restera a guardare! Mandera uno spirito dopo l'altro contro di te! Non sarai mai al sicuro!";
}
if(idioma == "portugues")
{
    textsp2 = "Depois desta humilhacao, o diabo nao ficara de braços cruzados! Ele enviara espirito apos espirito atras de voce! Voce nunca estara seguro!";
}
if(idioma == "japones")
{
    textsp2 = "この屈辱の後、悪魔は黙ってはいない！次々と霊を送り込んでくるだろう！お前は決して安全ではいられない！";
}
if(idioma == "coreano")
{
    textsp2 = "이 굴욕 이후로 악마는 가만히 있지 않을 거야! 영혼을 하나씩 너에게 보낼 거다! 너는 결코 안전하지 못할 거야!";
}
if(idioma == "chino")
{
    textsp2 = "在这次羞辱之后，恶魔绝不会袖手旁观！他会一个接一个地派出幽灵来追杀你！你永远不会安全！";
}
if(idioma == "ruso")
{
    textsp2 = "После этого унижения дьявол не будет сидеть сложа руки! Он пошлёт за тобой дух за духом! Ты никогда не будешь в безопасности!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 110 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Not only that! You... you are a Medium, right?! We have run into a few during our journey, we know about your situation!";
}
if(idioma == "español")
{
    textsp2 = "No solo eso! Tu... eres un Medium, verdad?! Nos hemos topado con algunos en nuestro viaje, conocemos tu situacion!";
}
if(idioma == "frances")
{
    textsp2 = "Et ce n'est pas tout ! Toi... tu es un Medium, n'est-ce pas ?! Nous en avons rencontre quelques-uns durant notre voyage, nous connaissons ta situation !";
}
if(idioma == "aleman")
{
    textsp2 = "Nicht nur das! Du... du bist ein Medium, richtig?! Wir sind auf unserer Reise einigen begegnet, wir kennen deine Situation!";
}
if(idioma == "italiano")
{
    textsp2 = "Non solo questo! Tu... sei un Medium, vero?! Ne abbiamo incontrati alcuni durante il nostro viaggio, conosciamo la tua situazione!";
}
if(idioma == "portugues")
{
    textsp2 = "E nao e so isso! Voce... e um Medium, certo?! Encontramos alguns em nossa jornada, conhecemos a sua situacao!";
}
if(idioma == "japones")
{
    textsp2 = "それだけじゃない！お前は...ミディアムなんだろう？！旅の途中で何人か会った、事情は知っている！";
}
if(idioma == "coreano")
{
    textsp2 = "그것뿐만이 아니야! 너는... 미디엄이지?! 여행 중에 몇 명을 만났고, 네 상황도 알고 있어!";
}
if(idioma == "chino")
{
    textsp2 = "不仅如此！你...是个灵媒，对吧？！我们在旅途中遇到过一些，知道你的处境！";
}
if(idioma == "ruso")
{
    textsp2 = "И это ещё не всё! Ты... ты ведь Medium, верно?! Мы встречали таких в нашем путешествии и знаем о твоём положении!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 111 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Seeing ghosts has brought you nothing but loneliness, right?! Rejection! Pain! I know how it feels! Sometimes you want to see the world burn!";
}
if(idioma == "español")
{
    textsp2 = "Ver fantasmas no te ha traido mas que soledad, verdad?! Rechazo! Dolor! Se como se siente! A veces querrias ver el mundo arder!";
}
if(idioma == "frances")
{
    textsp2 = "Voir des fantomes ne t'a apporte que de la solitude, n'est-ce pas ?! Le rejet ! La douleur ! Je sais ce que ca fait ! Parfois, tu voudrais voir le monde bruler !";
}
if(idioma == "aleman")
{
    textsp2 = "Geister zu sehen hat dir nichts als Einsamkeit gebracht, oder?! Ablehnung! Schmerz! Ich weiß, wie sich das anfuhlt! Manchmal willst du die Welt brennen sehen!";
}
if(idioma == "italiano")
{
    textsp2 = "Vedere i fantasmi ti ha portato solo solitudine, vero?! Rifiuto! Dolore! So come ci si sente! A volte vorresti vedere il mondo bruciare!";
}
if(idioma == "portugues")
{
    textsp2 = "Ver fantasmas so te trouxe solidao, nao e?! Rejeicao! Dor! Eu sei como e! As vezes voce quer ver o mundo pegar fogo!";
}
if(idioma == "japones")
{
    textsp2 = "幽霊が見えるせいで、孤独しか得られなかったんだろう？！拒絶！痛み！その気持ちは分かる！時には世界が燃え落ちるのを見たくなる！";
}
if(idioma == "coreano")
{
    textsp2 = "유령을 보는 건 너에게 고독밖에 주지 않았지?! 거절! 고통! 그 기분 알아! 가끔은 세상이 불타는 걸 보고 싶어질 때도 있어!";
}
if(idioma == "chino")
{
    textsp2 = "能看见幽灵只给你带来了孤独，对吧？！排斥！痛苦！我知道那是什么感觉！有时候你甚至想看到整个世界燃烧！";
}
if(idioma == "ruso")
{
    textsp2 = "Видеть призраков — это принесло тебе лишь одиночество, верно?! Отвержение! Боль! Я знаю, каково это! Иногда хочется увидеть, как мир горит!";
}


opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 112 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "The fact that you can see us proves it! And what I see is someone just as lost as I am!";
}
if(idioma == "español")
{
    textsp2 = "El hecho de que puedas vernos lo demuestra! Y lo que yo veo es una persona tan perdida como yo!";
}
if(idioma == "frances")
{
    textsp2 = "Le fait que tu puisses nous voir le prouve ! Et ce que je vois, c'est une personne aussi perdue que moi !";
}
if(idioma == "aleman")
{
    textsp2 = "Die Tatsache, dass du uns sehen kannst, beweist es! Und was ich sehe, ist eine Person, die genauso verloren ist wie ich!";
}
if(idioma == "italiano")
{
    textsp2 = "Il fatto che tu possa vederci lo dimostra! E quello che vedo e una persona persa quanto me!";
}
if(idioma == "portugues")
{
    textsp2 = "O fato de voce conseguir nos ver prova isso! E o que eu vejo e uma pessoa tao perdida quanto eu!";
}
if(idioma == "japones")
{
    textsp2 = "俺たちが見えるという事実がそれを証明している！そして俺が見ているのは、俺と同じくらい迷っている人間だ！";
}
if(idioma == "coreano")
{
    textsp2 = "우리를 볼 수 있다는 사실이 그걸 증명해! 그리고 내가 보는 건 나만큼이나 길을 잃은 사람이야!";
}
if(idioma == "chino")
{
    textsp2 = "你能看见我们这一点就已经证明了一切！而我看到的，是一个和我一样迷失的人！";
}
if(idioma == "ruso")
{
    textsp2 = "То, что ты можешь видеть нас, уже это доказывает! А то, что я вижу, — это человек, такой же потерянный, как и я!";
}


opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 113 && writing == true)
             {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Mirai! As unbelievable as it is that you're opening up to someone, hurry up! I can't hold her much longer!";
}
if(idioma == "español")
{
    textsp2 = "Mirai! Por mucho que sea increible que te estes abriendo a alguien, date prisa! No puedo mantenerla mucho mas!";
}
if(idioma == "frances")
{
    textsp2 = "Mirai ! Aussi incroyable que ce soit que tu t'ouvres a quelqu'un, depeche-toi ! Je ne peux plus la retenir tres longtemps !";
}
if(idioma == "aleman")
{
    textsp2 = "Mirai! So unglaublich es auch ist, dass du dich jemandem offnest, beeil dich! Ich kann sie nicht mehr lange zuruckhalten!";
}
if(idioma == "italiano")
{
    textsp2 = "Mirai! Per quanto sia incredibile che tu ti stia aprendo a qualcuno, sbrigati! Non posso trattenerla ancora a lungo!";
}
if(idioma == "portugues")
{
    textsp2 = "Mirai! Por mais incrivel que seja você estar se abrindo com alguem, apresse-se! Nao posso segura-la por muito mais tempo!";
}
if(idioma == "japones")
{
    textsp2 = "ミライ！誰かに心を開いているなんて信じられないけど、急いで！もう長くは抑えられない！";
}
if(idioma == "coreano")
{
    textsp2 = "미라이! 누군가에게 마음을 열고 있다는 게 믿기지 않지만, 서둘러! 더는 오래 붙잡아 둘 수 없어!";
}
if(idioma == "chino")
{
    textsp2 = "未来！就算你愿意向别人敞开心扉这件事再不可思议，也快一点！我撑不了她多久了！";
}
if(idioma == "ruso")
{
    textsp2 = "Мирай! Как бы невероятно ни было, что ты открываешься кому-то, поторопись! Я больше не смогу долго её сдерживать!";
}


opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }


             if(textorder == 114 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Yace! If we're going to be alone forever, then at least I want us to be alone together! Come with us! You will never feel isolated again!";
}
if(idioma == "español")
{
    textsp2 = "Yace! Si vamos a estar solos para siempre, al menos quiero que estemos solos juntos! Ven con nosotros! Jamas volveras a sentirte aislado!";
}
if(idioma == "frances")
{
    textsp2 = "Yace ! Si nous devons etre seuls pour toujours, alors au moins soyons seuls ensemble ! Viens avec nous ! Tu ne te sentiras plus jamais isole !";
}
if(idioma == "aleman")
{
    textsp2 = "Yace! Wenn wir fur immer allein sein werden, dann wenigstens gemeinsam! Komm mit uns! Du wirst dich nie wieder isoliert fuhlen!";
}
if(idioma == "italiano")
{
    textsp2 = "Yace! Se dobbiamo restare soli per sempre, allora almeno restiamo soli insieme! Vieni con noi! Non ti sentirai mai piu isolato!";
}
if(idioma == "portugues")
{
    textsp2 = "Yace! Se vamos ficar sozinhos para sempre, entao pelo menos fiquemos sozinhos juntos! Venha conosco! Voce nunca mais se sentirá isolado!";
}
if(idioma == "japones")
{
    textsp2 = "ヤセ！もし永遠に孤独になるなら、せめて一緒に孤独でいよう！俺たちと来い！二度と孤独を感じさせない！";
}
if(idioma == "coreano")
{
    textsp2 = "야세! 우리가 영원히 혼자라면, 적어도 함께 혼자가 되자! 우리와 함께 가! 다시는 고립감을 느끼지 않게 해줄게!";
}
if(idioma == "chino")
{
    textsp2 = "雅斯！如果我们注定要永远孤独，那至少要一起孤独！跟我们走吧！你再也不会感到被孤立！";
}
if(idioma == "ruso")
{
    textsp2 = "Ясе! Если нам суждено быть одинокими навсегда, то хотя бы вместе! Пойди с нами! Ты больше никогда не почувствуешь себя изолированным!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 115 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Alright! And now, let's finish this!";
}
if(idioma == "español")
{
    textsp2 = "Bien! Y ahora acabemos con esto!";
}
if(idioma == "frances")
{
    textsp2 = "Bien ! Et maintenant, finissons-en !";
}
if(idioma == "aleman")
{
    textsp2 = "Gut! Und jetzt bringen wir das zu Ende!";
}
if(idioma == "italiano")
{
    textsp2 = "Bene! E ora finiamo con questo!";
}
if(idioma == "portugues")
{
    textsp2 = "Bem! E agora vamos acabar com isso!";
}
if(idioma == "japones")
{
    textsp2 = "よし！さあ、これを終わらせよう！";
}
if(idioma == "coreano")
{
    textsp2 = "좋아! 자, 이제 이걸 끝내자!";
}
if(idioma == "chino")
{
    textsp2 = "好！现在，我们结束这一切！";
}
if(idioma == "ruso")
{
    textsp2 = "Хорошо! А теперь давай покончим с этим!";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 116 && writing == false)
             {
        Invoke("cn3", 0.5f);
             arming2 = false;
             nolevi.SetActive(true);
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = true;
         timestop = false;
            freeze = false;
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
             }

             if(textorder == 117 && writing == false)
             {
         shop1.SetActive(false);
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Welcome. I'm sorry, but Mirai won't be able to see you today.";
}
if(idioma == "español")
{
    textsp2 = "Bienvenido. Lo siento, pero hoy no podra atenderte, Mirai.";
}
if(idioma == "frances")
{
    textsp2 = "Bienvenue. Je suis desole, mais Mirai ne pourra pas te recevoir aujourd'hui.";
}
if(idioma == "aleman")
{
    textsp2 = "Willkommen. Es tut mir leid, aber Mirai wird dich heute nicht empfangen konnen.";
}
if(idioma == "italiano")
{
    textsp2 = "Benvenuto. Mi dispiace, ma oggi Mirai non potra riceverti.";
}
if(idioma == "portugues")
{
    textsp2 = "Bem-vindo. Sinto muito, mas hoje Mirai nao podera atende-lo.";
}
if(idioma == "japones")
{
    textsp2 = "ようこそ。申し訳ありませんが、本日はミライがお会いできません。";
}
if(idioma == "coreano")
{
    textsp2 = "환영합니다. 죄송하지만 오늘은 미라이가 만나 드릴 수 없습니다.";
}
if(idioma == "chino")
{
    textsp2 = "欢迎。很抱歉，今天未来无法接待你。";
}
if(idioma == "ruso")
{
    textsp2 = "Добро пожаловать. Извините, но сегодня Мирай не сможет вас принять.";
}


opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 118 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I had to punish her in her room. She started saying I was a terrible father and that she hated me and... well... I had no other choice. I hope I didn't go too far with her.";
}
if(idioma == "español")
{
    textsp2 = "Tuve que castigarla en su cuarto. Empezo a decir que yo era un padre terrible y que me odiaba y... bueno... no me quedo mas remedio. Espero no haberme pasado con ella.";
}
if(idioma == "frances")
{
    textsp2 = "J'ai du la punir dans sa chambre. Elle a commence a dire que j'etais un pere horrible et qu'elle me detestait et... enfin... je n'avais pas d'autre choix. J'espere ne pas etre alle trop loin avec elle.";
}
if(idioma == "aleman")
{
    textsp2 = "Ich musste sie in ihrem Zimmer bestrafen. Sie fing an zu sagen, ich sei ein schrecklicher Vater und dass sie mich hasst und... na ja... ich hatte keine andere Wahl. Ich hoffe, ich bin nicht zu weit gegangen.";
}
if(idioma == "italiano")
{
    textsp2 = "Ho dovuto punirla nella sua stanza. Ha iniziato a dire che ero un pessimo padre e che mi odiava e... beh... non avevo altra scelta. Spero di non essere andato troppo oltre con lei.";
}
if(idioma == "portugues")
{
    textsp2 = "Tive que castiga-la no quarto dela. Ela comecou a dizer que eu era um pai terrivel e que me odiava e... bem... nao tive outra escolha. Espero nao ter ido longe demais com ela.";
}
if(idioma == "japones")
{
    textsp2 = "彼女を部屋で罰しなければならなかった。ひどい父親だ、嫌いだと言い始めて...まあ...他に選択肢がなかった。やり過ぎていなければいいが。";
}
if(idioma == "coreano")
{
    textsp2 = "나는 그녀를 방에 가둬 벌을 줘야 했어. 내가 형편없는 아버지라며 나를 미워한다고 말하기 시작했고... 뭐... 다른 선택지가 없었어. 너무 심하지 않았기를 바랄 뿐이야.";
}
if(idioma == "chino")
{
    textsp2 = "我不得不把她关在房间里惩罚她。她开始说我是个糟糕的父亲，说她恨我，然后...唉...我别无选择。希望我没有对她太过分。";
}
if(idioma == "ruso")
{
    textsp2 = "Мне пришлось наказать её в её комнате. Она начала говорить, что я ужасный отец и что она меня ненавидит и... ну... у меня не было другого выхода. Надеюсь, я не зашёл слишком далеко.";
}


opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 119 && writing == false)
             {
             arming2 = false;
         freeze = false;
         shop1.SetActive(false);
            freeze = false;
        rbd.constraints = RigidbodyConstraints.FreezeRotation;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         textorder = 0;
         timestop = false;
             }

             if(textorder == 120 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Sorry, but I love you";
}
if(idioma == "español")
{
    textsp2 = "Lo siento, pero te quiero";
}
if(idioma == "frances")
{
    textsp2 = "Desole, mais je t'aime";
}
if(idioma == "aleman")
{
    textsp2 = "Tut mir leid, aber ich liebe dich";
}
if(idioma == "italiano")
{
    textsp2 = "Mi dispiace, ma ti amo";
}
if(idioma == "portugues")
{
    textsp2 = "Desculpa, mas eu te amo";
}
if(idioma == "japones")
{
    textsp2 = "ごめん, でも、愛してる";
}
if(idioma == "coreano")
{
    textsp2 = "미안해, 하지만 사랑해";
}
if(idioma == "chino")
{
    textsp2 = "对不起，但我爱你";
}
if(idioma == "ruso")
{
    textsp2 = "Прости, но я люблю тебя";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 121 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Even if it was your fault, I love you";
}
if(idioma == "español")
{
    textsp2 = "Aunque haya sido culpa tuya, te quiero";
}
if(idioma == "frances")
{
    textsp2 = "Meme si c'etait ta faute, je t'aime";
}
if(idioma == "aleman")
{
    textsp2 = "Auch wenn es deine Schuld war, liebe ich dich";
}
if(idioma == "italiano")
{
    textsp2 = "Anche se e stata colpa tua, ti amo";
}
if(idioma == "portugues")
{
    textsp2 = "Mesmo que tenha sido culpa sua, eu te amo";
}
if(idioma == "japones")
{
    textsp2 = "たとえ君のせいだったとしても、愛してる";
}
if(idioma == "coreano")
{
    textsp2 = "네 잘못이었더라도, 난 널 사랑해";
}
if(idioma == "chino")
{
    textsp2 = "即使那是你的错，我也爱你";
}
if(idioma == "ruso")
{
    textsp2 = "Даже если это была твоя вина, я тебя люблю";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 122 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Even if none of this would have happened if you hadn't appeared, even if I would still be alive if you hadn't given me hope just to take it away... I love you.";
}
if(idioma == "español")
{
    textsp2 = "Aunque nada de esto habria pasado si no hubieras aparecido, aunque seguiria viva si no me hubieras dado esperanza solo para arrebatarmela... te quiero.";
}
if(idioma == "frances")
{
    textsp2 = "Meme si rien de tout cela ne serait arrive si tu n'etais pas apparu, meme si je serais encore vivante si tu ne m'avais pas donne de l'espoir pour me l'enlever... je t'aime.";
}
if(idioma == "aleman")
{
    textsp2 = "Auch wenn all das nicht passiert ware, wenn du nicht erschienen warst, auch wenn ich noch am Leben ware, wenn du mir nicht Hoffnung gegeben hattest, nur um sie mir wieder zu nehmen... ich liebe dich.";
}
if(idioma == "italiano")
{
    textsp2 = "Anche se nulla di tutto questo sarebbe successo se tu non fossi apparso, anche se sarei ancora viva se non mi avessi dato speranza solo per togliermela... ti amo.";
}
if(idioma == "portugues")
{
    textsp2 = "Mesmo que nada disso tivesse acontecido se voce nao tivesse aparecido, mesmo que eu ainda estivesse viva se nao tivesse me dado esperança apenas para tira-la de mim... eu te amo.";
}
if(idioma == "japones")
{
    textsp2 = "たとえ君が現れなければ何も起こらなかったとしても、希望を与えて奪わなければ今も生きていたとしても...それでも愛してる。";
}
if(idioma == "coreano")
{
    textsp2 = "네가 나타나지 않았다면 아무 일도 없었을지라도, 희망을 주었다가 빼앗지 않았다면 내가 아직 살아 있었을지라도... 그래도 널 사랑해.";
}
if(idioma == "chino")
{
    textsp2 = "即使如果你没有出现这一切都不会发生，即使如果你没有给我希望再将它夺走我现在还活着...我依然爱你。";
}
if(idioma == "ruso")
{
    textsp2 = "Даже если бы ничего этого не произошло, если бы ты не появился, даже если бы я была всё ещё жива, если бы ты дал мне надежду лишь затем, чтобы отнять её... я всё равно люблю тебя.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 123 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Even if I should hate you, I love you";
}
if(idioma == "español")
{
    textsp2 = "Aunque deberia odiarte, te quiero";
}
if(idioma == "frances")
{
    textsp2 = "Meme si je devrais te hair, je t'aime";
}
if(idioma == "aleman")
{
    textsp2 = "Auch wenn ich dich hassen sollte, liebe ich dich";
}
if(idioma == "italiano")
{
    textsp2 = "Anche se dovrei odiarti, ti amo";
}
if(idioma == "portugues")
{
    textsp2 = "Mesmo que eu devesse te odiar, eu te amo";
}
if(idioma == "japones")
{
    textsp2 = "本当は憎むべきなのに、それでも愛してる";
}
if(idioma == "coreano")
{
    textsp2 = "널 미워해야 할 텐데도, 난 널 사랑해";
}
if(idioma == "chino")
{
    textsp2 = "即使我应该恨你，我仍然爱你";
}
if(idioma == "ruso")
{
    textsp2 = "Даже если я должна тебя ненавидеть, я люблю тебя";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 124 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Being a fortune teller... It must seem amazing, right? You can know what the future holds for you, it's such a blessing... right?";
}
if(idioma == "español")
{
    textsp2 = "Ser una adivina... Debe parecer genial, verdad? Puedes saber lo que te depara el futuro, es toda una suerte... verdad?";
}
if(idioma == "frances")
{
    textsp2 = "Etre une voyante... Ca doit sembler génial, non ? Tu peux savoir ce que l'avenir te reserve, c'est une vraie chance... n'est-ce pas ?";
}
if(idioma == "aleman")
{
    textsp2 = "Eine Wahrsagerin zu sein... Das muss großartig wirken, oder? Du kannst wissen, was die Zukunft fur dich bereithalt, das ist ein echtes Gluck... oder?";
}
if(idioma == "italiano")
{
    textsp2 = "Essere una veggente... Deve sembrare fantastico, vero? Puoi sapere cosa ti riserva il futuro, e una vera fortuna... giusto?";
}
if(idioma == "portugues")
{
    textsp2 = "Ser uma vidente... Deve parecer incrivel, nao e? Voce pode saber o que o futuro reserva, e uma grande sorte... certo?";
}
if(idioma == "japones")
{
    textsp2 = "占い師になること...すごく素敵に見えるでしょ？未来がどうなるか分かるなんて、幸運そのもの...そう思うでしょ？";
}
if(idioma == "coreano")
{
    textsp2 = "점쟁이가 된다는 것... 멋져 보이겠지? 미래를 알 수 있다니, 정말 큰 행운처럼 보이잖아... 그렇지?";
}
if(idioma == "chino")
{
    textsp2 = "成为一名占卜师...听起来很棒，对吧？能知道未来会发生什么，简直是一种幸运...对吧？";
}
if(idioma == "ruso")
{
    textsp2 = "Быть гадалкой... Наверное, это кажется чем-то удивительным, да? Знать, что ждёт тебя в будущем — настоящая удача... правда?";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 125 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "It's a curse";
}
if(idioma == "español")
{
    textsp2 = "Es una maldicion";
}
if(idioma == "frances")
{
    textsp2 = "C'est une malediction";
}
if(idioma == "aleman")
{
    textsp2 = "Es ist ein Fluch";
}
if(idioma == "italiano")
{
    textsp2 = "E una maledizione";
}
if(idioma == "portugues")
{
    textsp2 = "E uma maldicao";
}
if(idioma == "japones")
{
    textsp2 = "これは呪いだ";
}
if(idioma == "coreano")
{
    textsp2 = "이건 저주야";
}
if(idioma == "chino")
{
    textsp2 = "这是一个诅咒";
}
if(idioma == "ruso")
{
    textsp2 = "Это проклятие";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 126 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Because even if you can see it, the future cannot be changed once it's written. It will happen one way or another.";
}
if(idioma == "español")
{
    textsp2 = "Porque aunque puedas verlo, el futuro no se puede cambiar una vez escrito. Pasara de una forma u otra.";
}
if(idioma == "frances")
{
    textsp2 = "Parce que meme si tu peux le voir, le futur ne peut pas etre changé une fois ecrit. Cela arrivera d'une maniere ou d'une autre.";
}
if(idioma == "aleman")
{
    textsp2 = "Denn selbst wenn du es sehen kannst, kann die Zukunft, sobald sie geschrieben ist, nicht verandert werden. Sie wird so oder so eintreten.";
}
if(idioma == "italiano")
{
    textsp2 = "Perche anche se puoi vederlo, il futuro non puo essere cambiato una volta scritto. Accadra in un modo o nell'altro.";
}
if(idioma == "portugues")
{
    textsp2 = "Porque mesmo que voce possa ve-lo, o futuro nao pode ser mudado uma vez escrito. Acontecera de um jeito ou de outro.";
}
if(idioma == "japones")
{
    textsp2 = "たとえそれが見えたとしても、未来は一度書かれたら変えられない。どのみち起こるんだ。";
}
if(idioma == "coreano")
{
    textsp2 = "설사 볼 수 있다 해도, 미래는 한 번 정해지면 바꿀 수 없어. 어쨌든 일어날 거야.";
}
if(idioma == "chino")
{
    textsp2 = "因为即使你能看到，未来一旦写下就无法改变。无论如何都会发生。";
}
if(idioma == "ruso")
{
    textsp2 = "Потому что даже если ты можешь это видеть, будущее нельзя изменить, как только оно написано. Оно произойдет так или иначе.";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 127 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "You just get the bad news before anyone else does";
}
if(idioma == "español")
{
    textsp2 = "Simplemente recibes las malas noticias antes que nadie";
}
if(idioma == "frances")
{
    textsp2 = "Tu recois juste les mauvaises nouvelles avant tout le monde";
}
if(idioma == "aleman")
{
    textsp2 = "Du bekommst einfach die schlechten Nachrichten vor allen anderen";
}
if(idioma == "italiano")
{
    textsp2 = "Ricevi solo le cattive notizie prima di chiunque altro";
}
if(idioma == "portugues")
{
    textsp2 = "Voce apenas recebe as mas noticias antes de qualquer outra pessoa";
}
if(idioma == "japones")
{
    textsp2 = "誰よりも先に悪い知らせを受け取るだけなんだ";
}
if(idioma == "coreano")
{
    textsp2 = "그냥 누구보다 먼저 나쁜 소식을 듣게 되는 거야";
}
if(idioma == "chino")
{
    textsp2 = "你只是比别人先收到坏消息而已";
}
if(idioma == "ruso")
{
    textsp2 = "Ты просто узнаешь плохие новости раньше всех";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 128 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Even if I knew I would kill myself... there wasn't much I could do about it";
}
if(idioma == "español")
{
    textsp2 = "Incluso si sabia que acabaria quitandome la vida... no habia mucho que pudiera hacer al respecto";
}
if(idioma == "frances")
{
    textsp2 = "Meme si je savais que je finirais par me suicider... je ne pouvais pas faire grand-chose pour l'eviter";
}
if(idioma == "aleman")
{
    textsp2 = "Selbst wenn ich wusste, dass ich mich umbringen wurde... konnte ich nicht viel dagegen tun";
}
if(idioma == "italiano")
{
    textsp2 = "Anche se sapevo che mi sarei tolta la vita... non c'era molto che potessi fare";
}
if(idioma == "portugues")
{
    textsp2 = "Mesmo sabendo que eu acabaria tirando a propria vida... nao havia muito que eu pudesse fazer";
}
if(idioma == "japones")
{
    textsp2 = "自分が自殺すると分かっていても...それを止める術はほとんどなかった";
}
if(idioma == "coreano")
{
    textsp2 = "내가 스스로 목숨을 끊게 될 걸 알고 있었어도... 내가 할 수 있는 건 거의 없었어";
}
if(idioma == "chino")
{
    textsp2 = "即使我知道自己最终会自杀...我也几乎无能为力";
}
if(idioma == "ruso")
{
    textsp2 = "Даже если я знала, что покончу с собой... я почти ничего не могла с этим сделать";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 129 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Even so, somehow... you made me happy";
}
if(idioma == "español")
{
    textsp2 = "Aun asi, de alguna forma... tu me hiciste feliz";
}
if(idioma == "frances")
{
    textsp2 = "Malgre tout, d'une certaine façon... tu m'as rendue heureuse";
}
if(idioma == "aleman")
{
    textsp2 = "Trotzdem hast du mich irgendwie... glucklich gemacht";
}
if(idioma == "italiano")
{
    textsp2 = "Eppure, in qualche modo... mi hai resa felice";
}
if(idioma == "portugues")
{
    textsp2 = "Mesmo assim, de alguma forma... voce me fez feliz";
}
if(idioma == "japones")
{
    textsp2 = "それでも、何らかの形で...あなたは私を幸せにしてくれた";
}
if(idioma == "coreano")
{
    textsp2 = "그래도, 어떤 식으로든... 넌 나를 행복하게 해줬어";
}
if(idioma == "chino")
{
    textsp2 = "即便如此，不知为何...你让我感到幸福";
}
if(idioma == "ruso")
{
    textsp2 = "И всё же, каким-то образом... ты сделал меня счастливой";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 130 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "You stopped to listen to me. No matter if what I had to say was good or bad. That was all I wanted";
}
if(idioma == "español")
{
    textsp2 = "Tu te detuviste a escucharme. Sin importar si lo que tenia que decir era bueno o malo. Eso era todo lo que quería";
}
if(idioma == "frances")
{
    textsp2 = "Tu t'es arretee pour m'ecouter. Peu importe que ce que j'avais a dire soit bon ou mauvais. C'etait tout ce que je voulais";
}
if(idioma == "aleman")
{
    textsp2 = "Du hast angehalten, um mir zuzuhoren. Egal, ob das, was ich zu sagen hatte, gut oder schlecht war. Das war alles, was ich wollte";
}
if(idioma == "italiano")
{
    textsp2 = "Ti sei fermata ad ascoltarmi. Non importava se cio che avevo da dire fosse buono o cattivo. Era tutto cio che volevo";
}
if(idioma == "portugues")
{
    textsp2 = "Voce parou para me ouvir. Nao importava se o que eu tinha a dizer era bom ou ruim. Era tudo o que eu queria";
}
if(idioma == "japones")
{
    textsp2 = "あなたは立ち止まって、私の話を聞いてくれた。良いことでも悪いことでも関係なかった。それだけで十分だった";
}
if(idioma == "coreano")
{
    textsp2 = "넌 잠시 멈춰서 내 이야기를 들어줬어. 내가 한 말이 좋든 나쁘든 상관없었어. 그게 내가 원한 전부였어";
}
if(idioma == "chino")
{
    textsp2 = "你停下来听我说话。不管我说的是好是坏。这就是我想要的一切";
}
if(idioma == "ruso")
{
    textsp2 = "Ты остановилась, чтобы выслушать меня. Не важно, было ли то, что я говорил, хорошим или плохим. Это было всё, чего я хотел";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 131 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I went to my dad with hope, to tell him how I felt about what he was doing";
}
if(idioma == "español")
{
    textsp2 = "Fui con esperanzas a decirle a papa lo que sentia sobre lo que estaba haciendo";
}
if(idioma == "frances")
{
    textsp2 = "Je suis allee voir mon père avec de l'espoir, pour lui dire ce que je ressentais a propos de ce qu'il faisait";
}
if(idioma == "aleman")
{
    textsp2 = "Ich ging mit Hoffnung zu meinem Vater, um ihm zu sagen, was ich über das dachte, was er tat";
}
if(idioma == "italiano")
{
    textsp2 = "Sono andata da mio padre con la speranza di dirgli come mi sentivo riguardo a cio che stava facendo";
}
if(idioma == "portugues")
{
    textsp2 = "Fui falar com meu pai cheia de esperanca, para dizer como eu me sentia sobre o que ele estava fazendo";
}
if(idioma == "japones")
{
    textsp2 = "私は希望を抱いて、父に自分の気持ちを伝えに行った";
}
if(idioma == "coreano")
{
    textsp2 = "나는 희망을 품고 아버지에게 그가 하고 있는 일에 대해 내 마음을 말하러 갔어";
}
if(idioma == "chino")
{
    textsp2 = "我满怀希望地去找爸爸，想告诉他我对他所做事情的感受";
}
if(idioma == "ruso")
{
    textsp2 = "Я с надеждой пошла к отцу, чтобы сказать ему, что чувствую по поводу того, что он делает";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 132 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "He yelled at me";
}
if(idioma == "español")
{
    textsp2 = "El me gritó";
}
if(idioma == "frances")
{
    textsp2 = "Il m'a crie dessus";
}
if(idioma == "aleman")
{
    textsp2 = "Er schrie mich an";
}
if(idioma == "italiano")
{
    textsp2 = "Mi ha urlato contro";
}
if(idioma == "portugues")
{
    textsp2 = "Ele gritou comigo";
}
if(idioma == "japones")
{
    textsp2 = "彼は私に怒鳴った";
}
if(idioma == "coreano")
{
    textsp2 = "그는 나에게 소리를 질렀어";
}
if(idioma == "chino")
{
    textsp2 = "他对我大喊";
}
if(idioma == "ruso")
{
    textsp2 = "Он накричал на меня";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 133 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "He told me that this new client had opened his eyes";
}
if(idioma == "español")
{
    textsp2 = "Me dijo que ese cliente nuevo le habia abierto los ojos";
}
if(idioma == "frances")
{
    textsp2 = "Il m'a dit que ce nouveau client lui avait ouvert les yeux";
}
if(idioma == "aleman")
{
    textsp2 = "Er sagte mir, dass dieser neue Kunde ihm die Augen geöffnet habe";
}
if(idioma == "italiano")
{
    textsp2 = "Mi disse che quel nuovo cliente gli aveva aperto gli occhi";
}
if(idioma == "portugues")
{
    textsp2 = "Ele me disse que esse novo cliente tinha aberto os olhos dele";
}
if(idioma == "japones")
{
    textsp2 = "その「新しい客」が目を覚ましてくれたと言われた";
}
if(idioma == "coreano")
{
    textsp2 = "그는 그 \"새 고객\"이 자신의 눈을 뜨게 해줬다고 말했어";
}
if(idioma == "chino")
{
    textsp2 = "他告诉我，那个“新客户”让他看清了一切";
}
if(idioma == "ruso")
{
    textsp2 = "Он сказал мне, что этот «новый клиент» открыл ему глаза";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 134 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "He told me I had to stop being immature and that he wished I were more like he wanted";
}
if(idioma == "español")
{
    textsp2 = "Me dijo que debia dejar de ser una inmadura y que ojala fuera mas como el queria";
}
if(idioma == "frances")
{
    textsp2 = "Il m'a dit que je devais arreter d'etre immature et qu'il souhaitait que je sois plus comme il le voulait";
}
if(idioma == "aleman")
{
    textsp2 = "Er sagte mir, ich musse aufhoren, unreif zu sein, und dass er sich wunschte, ich ware mehr so, wie er es wollte";
}
if(idioma == "italiano")
{
    textsp2 = "Mi disse che dovevo smettere di essere immatura e che avrebbe voluto che fossi piu come lui desiderava";
}
if(idioma == "portugues")
{
    textsp2 = "Ele me disse que eu devia parar de ser imatura e que queria que eu fosse mais como ele desejava";
}
if(idioma == "japones")
{
    textsp2 = "私は未熟をやめるべきだ、そしてもっと彼の望むようになればいいのにと言われた";
}
if(idioma == "coreano")
{
    textsp2 = "나는 더 이상 미성숙하지 말아야 하고, 그가 원하는 대로 더 되었으면 좋겠다고 말했어";
}
if(idioma == "chino")
{
    textsp2 = "他说我应该不再幼稚，希望我能更像他想要的样子";
}
if(idioma == "ruso")
{
    textsp2 = "Он сказал мне, что я должна перестать быть незрелой и что он хотел бы, чтобы я была больше такой, какой он хочет";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 135 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "In that moment, I understood";
}
if(idioma == "español")
{
    textsp2 = "En ese momento lo entendi";
}
if(idioma == "frances")
{
    textsp2 = "A ce moment-la, j'ai compris";
}
if(idioma == "aleman")
{
    textsp2 = "In diesem Moment habe ich es verstanden";
}
if(idioma == "italiano")
{
    textsp2 = "In quel momento ho capito";
}
if(idioma == "portugues")
{
    textsp2 = "Naquele momento eu entendi";
}
if(idioma == "japones")
{
    textsp2 = "その瞬間、私は理解した";
}
if(idioma == "coreano")
{
    textsp2 = "그 순간 나는 이해했어";
}
if(idioma == "chino")
{
    textsp2 = "就在那一刻，我明白了";
}
if(idioma == "ruso")
{
    textsp2 = "В тот момент я поняла";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 136 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "No matter what I did, I was always going to suffer, because that was written in destiny";
}
if(idioma == "español")
{
    textsp2 = "Hiciera lo que hiciera, siempre iba a sufrir, porque asi estaba escrito en el destino";
}
if(idioma == "frances")
{
    textsp2 = "Quoi que je fasse, j'étais destinee a souffrir, car c'etait ecrit dans le destin";
}
if(idioma == "aleman")
{
    textsp2 = "Egal was ich tat, ich wurde immer leiden, denn so stand es im Schicksal geschrieben";
}
if(idioma == "italiano")
{
    textsp2 = "Qualunque cosa facessi, ero destinata a soffrire, perche cosi era scritto nel destino";
}
if(idioma == "portugues")
{
    textsp2 = "Nao importava o que eu fizesse, eu sempre iria sofrer, porque assim estava escrito no destino";
}
if(idioma == "japones")
{
    textsp2 = "何をしても、運命にそう書かれていたから、私は苦しむことになる運命だった";
}
if(idioma == "coreano")
{
    textsp2 = "무엇을 하든, 운명에 그렇게 쓰여 있었기에 나는 결국 고통받게 될 운명이었어";
}
if(idioma == "chino")
{
    textsp2 = "无论我做什么，我都注定要受苦，因为命运早已写好了一切";
}
if(idioma == "ruso")
{
    textsp2 = "Что бы я ни делала, мне суждено было страдать, потому что так было написано в судьбе";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 137 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I was born with this curse, my mother died, and now the only person who understood me had betrayed me";
}
if(idioma == "español")
{
    textsp2 = "Naci con esta maldicion, mi madre murio y ahora la unica persona que me entendia me habia traicionado";
}
if(idioma == "frances")
{
    textsp2 = "Je suis née avec cette malediction, ma mere est morte, et maintenant la seule personne qui me comprenait m'avait trahie";
}
if(idioma == "aleman")
{
    textsp2 = "Ich wurde mit diesem Fluch geboren, meine Mutter starb, und nun hatte mich die einzige Person, die mich verstand, verraten";
}
if(idioma == "italiano")
{
    textsp2 = "Sono nata con questa maledizione, mia madre e morta, e ora l'unica persona che mi capiva mi aveva tradita";
}
if(idioma == "portugues")
{
    textsp2 = "Nasci com esta maldicao, minha mae morreu, e agora a única pessoa que me entendia tinha me traido";
}
if(idioma == "japones")
{
    textsp2 = "私はこの呪いと共に生まれた,母は亡くなり、そして私を理解してくれていた唯一の人にも裏切られた";
}
if(idioma == "coreano")
{
    textsp2 = "나는 이 저주와 함께 태어났어, 어머니는 돌아가셨고, 이제 나를 이해해 주던 유일한 사람마저 나를 배신했어";
}
if(idioma == "chino")
{
    textsp2 = "我生来就背负着这份诅咒, 母亲去世了，而现在，唯一理解我的人也背叛了我";
}
if(idioma == "ruso")
{
    textsp2 = "Я родилась с этим проклятием, Моя мать умерла, а теперь единственный человек, который меня понимал, предал меня";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 138 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "That was the moment I decided to end everything";
}
if(idioma == "español")
{
    textsp2 = "En ese momento fue cuando decidi acabar con todo";
}
if(idioma == "frances")
{
    textsp2 = "C'est a ce moment-la que j'ai decide d'en finir avec tout";
}
if(idioma == "aleman")
{
    textsp2 = "In diesem Moment beschloss ich, allem ein Ende zu setzen";
}
if(idioma == "italiano")
{
    textsp2 = "E stato in quel momento che ho deciso di farla finita con tutto";
}
if(idioma == "portugues")
{
    textsp2 = "Foi naquele momento que decidi acabar com tudo";
}
if(idioma == "japones")
{
    textsp2 = "その時、すべてを終わらせる決意をした";
}
if(idioma == "coreano")
{
    textsp2 = "그 순간, 나는 모든 걸 끝내기로 결심했어";
}
if(idioma == "chino")
{
    textsp2 = "就在那一刻，我决定结束一切";
}
if(idioma == "ruso")
{
    textsp2 = "Именно в тот момент я решила покончить со всем";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 139 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I should have hated you for what you did to me";
}
if(idioma == "español")
{
    textsp2 = "Debia odiarte por lo que me hiciste";
}
if(idioma == "frances")
{
    textsp2 = "J'aurais du te detester pour ce que tu m'as fait";
}
if(idioma == "aleman")
{
    textsp2 = "Ich hatte dich fur das, was du mir angetan hast, hassen sollen";
}
if(idioma == "italiano")
{
    textsp2 = "Avrei dovuto odiarti per quello che mi hai fatto";
}
if(idioma == "portugues")
{
    textsp2 = "Eu deveria ter te odiado pelo que voce me fez";
}
if(idioma == "japones")
{
    textsp2 = "あなたが私にしたことを、私は憎むべきだった";
}
if(idioma == "coreano")
{
    textsp2 = "네가 나에게 한 일 때문에 널 미워했어야 했어";
}
if(idioma == "chino")
{
    textsp2 = "我本该因为你对我所做的一切而恨你";
}
if(idioma == "ruso")
{
    textsp2 = "Я должна была ненавидеть тебя за то, что ты со мной сделал";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 140 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "But I couldn't";
}
if(idioma == "español")
{
    textsp2 = "Pero no pude";
}
if(idioma == "frances")
{
    textsp2 = "Mais je n'ai pas pu";
}
if(idioma == "aleman")
{
    textsp2 = "Aber ich konnte es nicht";
}
if(idioma == "italiano")
{
    textsp2 = "Ma non ci sono riuscita";
}
if(idioma == "portugues")
{
    textsp2 = "Mas eu nao consegui";
}
if(idioma == "japones")
{
    textsp2 = "でも、できなかった";
}
if(idioma == "coreano")
{
    textsp2 = "하지만 그럴 수 없었어";
}
if(idioma == "chino")
{
    textsp2 = "但我做不到";
}
if(idioma == "ruso")
{
    textsp2 = "Но я не смогла";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 141 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I couldn't hate the one who had made happy someone who was born to be sad";
}
if(idioma == "español")
{
    textsp2 = "No pude odiar a aquel que habia hecho feliz a quien nacio para estar triste";
}
if(idioma == "frances")
{
    textsp2 = "Je n'ai pas pu hair celui qui avait rendu heureuse celle qui etait nee pour etre triste";
}
if(idioma == "aleman")
{
    textsp2 = "Ich konnte denjenigen nicht hassen, der diejenige glücklich gemacht hatte, die zum Traurigsein geboren war";
}
if(idioma == "italiano")
{
    textsp2 = "Non sono riuscita a odiare colui che aveva reso felice chi era nata per essere triste";
}
if(idioma == "portugues")
{
    textsp2 = "Nao consegui odiar aquele que fez feliz quem nasceu para estar triste";
}
if(idioma == "japones")
{
    textsp2 = "悲しむために生まれた私を幸せにしてくれた人を、憎むことはできなかった";
}
if(idioma == "coreano")
{
    textsp2 = "슬픔을 안고 태어난 나를 행복하게 해준 사람을 미워할 수 없었어";
}
if(idioma == "chino")
{
    textsp2 = "我无法去恨那个让一个生来注定悲伤的人感到幸福的人";
}
if(idioma == "ruso")
{
    textsp2 = "Я не смогла возненавидеть того, кто сделал счастливой ту, что была рождена для грусти";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 142 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I couldn't hate the one who listened to my predictions just because it was me who spoke them";
}
if(idioma == "español")
{
    textsp2 = "No pude odiar a aquel que escuchaba mis predicciones solo porque era yo quien las decía";
}
if(idioma == "frances")
{
    textsp2 = "Je n'ai pas pu hair celui qui ecoutait mes predictions juste parce que c'etait moi qui les disais";
}
if(idioma == "aleman")
{
    textsp2 = "Ich konnte denjenigen nicht hassen, der meinen Vorhersagen zuhorte, nur weil ich es war, die sie aussprach";
}
if(idioma == "italiano")
{
    textsp2 = "Non sono riuscita a odiare colui che ascoltava le mie previsioni solo perche ero io a pronunciarle";
}
if(idioma == "portugues")
{
    textsp2 = "Nao consegui odiar aquele que ouvia minhas previsoes so porque era eu quem as dizia";
}
if(idioma == "japones")
{
    textsp2 = "私の予言を聞いてくれた人を、ただそれが私からの言葉だからといって憎むことはできなかった";
}
if(idioma == "coreano")
{
    textsp2 = "내가 말했기 때문에 내 예언을 들어주는 사람을 미워할 수 없었어";
}
if(idioma == "chino")
{
    textsp2 = "我无法去恨那个仅仅因为是我说的而听我的预言的人";
}
if(idioma == "ruso")
{
    textsp2 = "Я не смогла возненавидеть того, кто слушал мои предсказания только потому, что это была я, кто их говорила";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 143 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I couldn't hate the one who listened to my predictions just because it was me who spoke them";
}
if(idioma == "español")
{
    textsp2 = "No pude odiar a aquel que escuchaba mis predicciones solo porque era yo quien las decia";
}
if(idioma == "frances")
{
    textsp2 = "Je n'ai pas pu hair celui qui ecoutait mes predictions juste parce que c'etait moi qui les disais";
}
if(idioma == "aleman")
{
    textsp2 = "Ich konnte denjenigen nicht hassen, der meinen Vorhersagen zuhorte, nur weil ich es war, die sie aussprach";
}
if(idioma == "italiano")
{
    textsp2 = "Non sono riuscita a odiare colui che ascoltava le mie previsioni solo perche ero io a pronunciarle";
}
if(idioma == "portugues")
{
    textsp2 = "Nao consegui odiar aquele que ouvia minhas previsoes so porque era eu quem as dizia";
}
if(idioma == "japones")
{
    textsp2 = "私の予言を聞いてくれた人を、ただそれが私からの言葉だからといって憎むことはできなかった";
}
if(idioma == "coreano")
{
    textsp2 = "내가 말했기 때문에 내 예언을 들어주는 사람을 미워할 수 없었어";
}
if(idioma == "chino")
{
    textsp2 = "我无法去恨那个仅仅因为是我说的而听我的预言的人";
}
if(idioma == "ruso")
{
    textsp2 = "Я не смогла возненавидеть того, кто слушал мои предсказания только потому, что это была я, кто их говорила";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 144 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "And just as the future cannot change, neither can my feelings for you";
}
if(idioma == "español")
{
    textsp2 = "Y asi como el futuro no puede cambiar, mis sentimientos por ti tampoco";
}
if(idioma == "frances")
{
    textsp2 = "Et tout comme le futur ne peut pas changer, mes sentiments pour toi non plus";
}
if(idioma == "aleman")
{
    textsp2 = "Und genauso wie sich die Zukunft nicht ändern kann, konnen auch meine Gefuhle fur dich nicht";
}
if(idioma == "italiano")
{
    textsp2 = "E proprio come il futuro non puo cambiare, nemmeno i miei sentimenti per te";
}
if(idioma == "portugues")
{
    textsp2 = "E assim como o futuro nao pode mudar, meus sentimentos por voce também nao";
}
if(idioma == "japones")
{
    textsp2 = "未来が変えられないように、私のあなたへの気持ちも変わらない";
}
if(idioma == "coreano")
{
    textsp2 = "미래가 바뀔 수 없듯이, 나의 너에 대한 감정도 변하지 않아";
}
if(idioma == "chino")
{
    textsp2 = "就像未来无法改变，我对你的感情也无法改变";
}
if(idioma == "ruso")
{
    textsp2 = "И так же, как будущее нельзя изменить, мои чувства к тебе тоже не изменятся";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 145 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "So, sorry, but I love you";
}
if(idioma == "español")
{
    textsp2 = "Asi que, lo siento, pero te amo";
}
if(idioma == "frances")
{
    textsp2 = "Alors, desolee, mais je t'aime";
}
if(idioma == "aleman")
{
    textsp2 = "Also, es tut mir leid, aber ich liebe dich";
}
if(idioma == "italiano")
{
    textsp2 = "Quindi, mi dispiace, ma ti amo";
}
if(idioma == "portugues")
{
    textsp2 = "Entao, me desculpa, mas eu te amo";
}
if(idioma == "japones")
{
    textsp2 = "だから、ごめん...でも、愛してる";
}
if(idioma == "coreano")
{
    textsp2 = "그러니까, 미안하지만... 사랑해";
}
if(idioma == "chino")
{
    textsp2 = "所以，对不起，但我爱你";
}
if(idioma == "ruso")
{
    textsp2 = "Так что, прости... но я тебя люблю";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 146 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "-Mirai";
}
if(idioma == "español")
{
    textsp2 = "-Mirai";
}
if(idioma == "frances")
{
    textsp2 = "-Mirai";
}
if(idioma == "aleman")
{
    textsp2 = "-Mirai";
}
if(idioma == "italiano")
{
    textsp2 = "-Mirai";
}
if(idioma == "portugues")
{
    textsp2 = "-Mirai";
}
if(idioma == "japones")
{
    textsp2 = "－ミライ";
}
if(idioma == "coreano")
{
    textsp2 = "-미라이";
}
if(idioma == "chino")
{
    textsp2 = "-未来";
}
if(idioma == "ruso")
{
    textsp2 = "-Мираи";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 147 && writing == true)
             {
             freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
             arming2 = false;
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = false;
         timestop = false;
             }


             if(textorder == 148 && writing == false)
             {
if(idioma == "ingles")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Mirai";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "ミライ";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "미라이";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "未来";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Мирай";
}
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Yace... I'm so glad you're here...";
}

if(idioma == "español")
{
    textsp2 = "Yace... Menos mal que estas aqui...";
}

if(idioma == "frances")
{
    textsp2 = "Yace... Heureusement que tu es la...";
}

if(idioma == "aleman")
{
    textsp2 = "Yace... Zum Gluck bist du hier...";
}

if(idioma == "italiano")
{
    textsp2 = "Yace... Meno male che sei qui...";
}

if(idioma == "portugues")
{
    textsp2 = "Yace... Ainda bem que você está aqui...";
}

if(idioma == "japones")
{
    textsp2 = "ヤセ... 君がここにいてくれてよかった...";
}

if(idioma == "coreano")
{
    textsp2 = "야세... 네가 여기 있어서 다행이야...";
}

if(idioma == "chino")
{
    textsp2 = "雅斯... 幸好你在这里...";
}

if(idioma == "ruso")
{
    textsp2 = "Ясе... Хорошо, что ты здесь...";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 149 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Something is wrong... Very wrong... I can't find dad, and he never goes far from me...";
}

if(idioma == "español")
{
    textsp2 = "Algo va mal... Muy mal... No encuentro a papa, y el nunca se va muy lejos de mi...";
}

if(idioma == "frances")
{
    textsp2 = "Quelque chose ne va pas... Vraiment pas... Je ne trouve pas papa, et il ne s'eloigne jamais de moi...";
}

if(idioma == "aleman")
{
    textsp2 = "Irgendetwas stimmt nicht... Ganz und gar nicht... Ich finde Papa nicht, und er geht nie weit weg von mir...";
}

if(idioma == "italiano")
{
    textsp2 = "Qualcosa non va... Proprio per niente... Non trovo papa, e lui non si allontana mai da me...";
}

if(idioma == "portugues")
{
    textsp2 = "Algo esta errado... Muito errado... Nao encontro o papai, e ele nunca se afasta de mim...";
}

if(idioma == "japones")
{
    textsp2 = "何かがおかしい… とてもおかしい… パパが見つからない。彼は僕から離れることなんてないのに…";
}

if(idioma == "coreano")
{
    textsp2 = "뭔가 잘못됐어… 아주 심각해… 아빠가 안 보여. 아빠는 절대 내 곁을 떠나지 않는데…";
}

if(idioma == "chino")
{
    textsp2 = "有些不对劲…… 非常不对劲…… 我找不到爸爸，他从来不会离我太远的……";
}

if(idioma == "ruso")
{
    textsp2 = "Что-то не так… Очень не так… Я не могу найти папу, а он никогда не уходит далеко от меня…";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 150 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Yesterday I said terrible things to him, and I wanted to apologize...";
}

if(idioma == "español")
{
    textsp2 = "Ayer le dije cosas terribles y queria disculparme con el...";
}

if(idioma == "frances")
{
    textsp2 = "Hier, je lui ai dit des choses terribles et je voulais m'excuser aupres de lui...";
}

if(idioma == "aleman")
{
    textsp2 = "Gestern habe ich ihm schreckliche Dinge gesagt und wollte mich bei ihm entschuldigen...";
}

if(idioma == "italiano")
{
    textsp2 = "Ieri gli ho detto cose terribili e volevo scusarmi con lui...";
}

if(idioma == "portugues")
{
    textsp2 = "Ontem eu disse coisas terriveis para ele e queria me desculpar...";
}

if(idioma == "japones")
{
    textsp2 = "昨日、ひどいことを言ってしまって…謝りたかったのに…";
}

if(idioma == "coreano")
{
    textsp2 = "어제 그에게 끔찍한 말을 했어… 그래서 사과하고 싶었는데…";
}

if(idioma == "chino")
{
    textsp2 = "昨天我对他说了很过分的话，本来想向他道歉的……";
}

if(idioma == "ruso")
{
    textsp2 = "Вчера я сказал ему ужасные вещи и хотел извиниться перед ним…";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 151 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "I told him I hated him and that I'd be a thousand times better off without him...";
}

if(idioma == "español")
{
    textsp2 = "Le dije que le odiaba y que estaria mil veces mejor sin el...";
}

if(idioma == "frances")
{
    textsp2 = "Je lui ai dit que je le detestais et que je serais mille fois mieux sans lui...";
}

if(idioma == "aleman")
{
    textsp2 = "Ich sagte ihm, dass ich ihn hasse und dass es mir tausendmal besser ohne ihn gehen wurde...";
}

if(idioma == "italiano")
{
    textsp2 = "Gli ho detto che lo odiavo e che sarei stato mille volte meglio senza di lui...";
}

if(idioma == "portugues")
{
    textsp2 = "Eu disse que o odiava e que estaria mil vezes melhor sem ele...";
}

if(idioma == "japones")
{
    textsp2 = "彼に「嫌いだ」って言ってしまって…「君なんていなくても千倍マシだ」って…";
}

if(idioma == "coreano")
{
    textsp2 = "그에게 내가 그를 미워한다고, 그 없이도 천 배는 더 잘 지낼 수 있을 거라고 말해버렸어…";
}

if(idioma == "chino")
{
    textsp2 = "我对他说我恨他，说没有他我会好上一千倍……";
}

if(idioma == "ruso")
{
    textsp2 = "Я сказал ему, что ненавижу его и что мне было бы в тысячу раз лучше без него…";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 152 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "...";
}

if(idioma == "español")
{
    textsp2 = "...";
}

if(idioma == "frances")
{
    textsp2 = "...";
}

if(idioma == "aleman")
{
    textsp2 = "...";
}

if(idioma == "italiano")
{
    textsp2 = "...";
}

if(idioma == "portugues")
{
    textsp2 = "...";
}

if(idioma == "japones")
{
    textsp2 = "...";
}

if(idioma == "coreano")
{
    textsp2 = "...";
}

if(idioma == "chino")
{
    textsp2 = "...";
}

if(idioma == "ruso")
{
    textsp2 = "...";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 153 && writing == true)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Dad...";
}

if(idioma == "español")
{
    textsp2 = "Papa...";
}

if(idioma == "frances")
{
    textsp2 = "Papa...";
}

if(idioma == "aleman")
{
    textsp2 = "Papa...";
}

if(idioma == "italiano")
{
    textsp2 = "Papa...";
}

if(idioma == "portugues")
{
    textsp2 = "Papai...";
}

if(idioma == "japones")
{
    textsp2 = "パパ…";
}

if(idioma == "coreano")
{
    textsp2 = "아빠…";
}

if(idioma == "chino")
{
    textsp2 = "爸爸…";
}

if(idioma == "ruso")
{
    textsp2 = "Папа…";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = false;
             }

             if(textorder == 154 && writing == false)
             {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
if(idioma == "ingles")
{
    textsp2 = "Tell me you didn’t listen to me...";
}

if(idioma == "español")
{
    textsp2 = "Dime que no me hiciste caso...";
}

if(idioma == "frances")
{
    textsp2 = "Dis-moi que tu ne m’as pas ecoute...";
}

if(idioma == "aleman")
{
    textsp2 = "Sag mir, dass du nicht auf mich gehört hast...";
}

if(idioma == "italiano")
{
    textsp2 = "Dimmi che non mi hai ascoltato...";
}

if(idioma == "portugues")
{
    textsp2 = "Diz que voce nao me deu atencao...";
}

if(idioma == "japones")
{
    textsp2 = "私の言うことを聞かなかったって言って…";
}

if(idioma == "coreano")
{
    textsp2 = "내 말 안 들었다고 말해…";
}

if(idioma == "chino")
{
    textsp2 = "告诉我，你没有理我…";
}

if(idioma == "ruso")
{
    textsp2 = "Скажи, что ты меня не слушал…";
}

opi = false;
opi2 = false;
             StartCoroutine(writex());
             writing = true;
             }

             if(textorder == 155 && writing == true)
             {
             freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
             arming2 = false;
         shop1.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         texm = false;
         writing = false;
         timestop = false;
             }


        if (!bar.activeInHierarchy)
        {
           drain = false;
        }
        idioma = but.idioma;

        if(night == 1)
        {
        alphaStep = 6f / 255;
        }
        if(night == 2)
        {
        alphaStep = 5f / 255;
        }
        if(night == 3)
        {
        alphaStep = 4f / 255;
        }
        if(night == 4)
        {
        alphaStep = 3f / 255;
        }
        if(night == 5)
        {
        alphaStep = 2f / 255;
        }
        if(night == 6)
        {
        alphaStep = 1f / 255;
        }  

        if(pen.color.a <= 0)
        {
         if(ubi == "cocina")
         {
           blood1.SetActive(false);
         }
         if(ubi == "salon")
         {
           blood2.SetActive(false);
         }
         if(ubi == "baño1")
         {
           blood3.SetActive(false);
         }
         if(ubi == "baño2")
         {
           blood4.SetActive(false);
         }
         if(ubi == "oficina")
         {
           blood5.SetActive(false);
         }
         if(ubi == "micuarto")
         {
           blood6.SetActive(false);
         }
         if(ubi == "invitados")
         {
           blood7.SetActive(false);
         }
         if(ubi == "sotano")
         {
           blood8.SetActive(false);
         }
         Color c = pen.color;
         c.a = 1f;
         pen.color = c;
         penta.SetActive(false);
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        }
        if(playst == false && xbox == false)
        {
        if(Input.GetKeyUp(KeyCode.Q) || freeze == true)
        {
     audioSource3.clip = null;
        }
        if(purif == true && Input.GetKey(KeyCode.Q) && zx == false && freeze == false)
        {
        StartCoroutine(Purifying());
        }
        if(purif == true && (!Input.GetKey(KeyCode.Q) || freeze == true) && zx == false)
        {
        StartCoroutine(Purifyingx());
        }
        }
        if(playst == true || xbox == true)
        {
        if(Input.GetKeyUp(KeyCode.JoystickButton0) || freeze == true)
        {
     audioSource3.clip = null;
        }
        if(purif == true && Input.GetKey(KeyCode.JoystickButton0) && zx == false && freeze == false)
        {
        StartCoroutine(Purifying());
        }
        if(purif == true && (!Input.GetKey(KeyCode.JoystickButton0) || freeze == true) && zx == false)
        {
        StartCoroutine(Purifyingx());
        }
        }
        sound.transform.position = player.position;
        if(moving == false)
        {
        x2 = 2 * (1 - tam/10);
        y = 0.5f * (1 - tam/10);
        z = 2 * (1 - tam/10);
        }
        night = clock.night;

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        bool estaMoviendo = Mathf.Abs(moveX) > 0.1f || Mathf.Abs(moveZ) > 0.1f;

        if(freeze == false)
        {
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * speed * Time.deltaTime);
        }

        if (estaMoviendo && !stick)
        {
            stick = true;
            moving = true;
        }

        if (!estaMoviendo && stick)
        {
            stick = false;
            moving = false;
        }

        if(speedo == 5)
        {
     audioSource2.clip = wlk;
     audioSource2.loop = true;
        }
        if(speedo == 10)
        {
     audioSource2.clip = rn;
     audioSource2.loop = true;
        }
        if(speedo == 2)
        {
     if(nolev == false)
     {
     audioSource2.clip = wlk2;
     }
     if(nolev == true && speedo == 2)
     {
     audioSource2.clip = wlk22;
     }
     audioSource2.loop = true;
        }
        if(speedo == 0)
        {
           audioSource2.clip = null;
     audioSource2.loop = false;
        }

        if ((stick == true || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))  && ((!Input.GetKey(KeyCode.LeftShift) || !Input.GetKey(KeyCode.JoystickButton2)) && !Input.GetKey(KeyCode.C) && ((!Input.GetKey(KeyCode.JoystickButton1) && xbox == true) || (!Input.GetKey(KeyCode.JoystickButton2) && playst == true)) && freeze == false && !menu.activeInHierarchy))
        {
           moving = true;
           anim.SetTrigger("wlk");
           anim.SetTrigger("cr2");
           anim.SetTrigger("rn2");
        }
        if ((stick == true || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow)) && ((!Input.GetKey(KeyCode.LeftShift) || !Input.GetKey(KeyCode.JoystickButton2)) && !Input.GetKey(KeyCode.C) && ((!Input.GetKey(KeyCode.JoystickButton1) && xbox == true) || (!Input.GetKey(KeyCode.JoystickButton2) && playst == true)) && freeze == false && !menu.activeInHierarchy))
        {
           if(freeze == false)
           {
           moving = true;
           anim.SetTrigger("wlk");
           }
           anim.SetTrigger("cr2");
           anim.SetTrigger("rn2");
        }

        if ((stick == false && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.DownArrow)) && (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) || bar2.value == 0)
        {
           speed = 0;
           moving = false;
           anim.SetTrigger("wlk2");
           anim.SetTrigger("cr2");
           anim.SetTrigger("rn2");
        }
        if ((Input.GetKey(KeyCode.LeftShift) || (Input.GetKey(KeyCode.JoystickButton5) && (playst == true || xbox == true))) && drain == true && bar2.value == 0.999 && freeze == false)
        {
           bar.SetActive(false);
           smaller = true;
        }
        if ((!Input.GetKey(KeyCode.LeftShift) || (!Input.GetKey(KeyCode.JoystickButton5) && (playst == true || xbox == true))) || moving == false)
        {
           smaller = false;
        }

        if ((Input.GetKey(KeyCode.LeftShift) || (Input.GetKey(KeyCode.JoystickButton5) && (playst == true || xbox == true))) && drain == false && !Input.GetKey(KeyCode.C) && ((playst == false || xbox == false) || ((!Input.GetKey(KeyCode.JoystickButton1) && xbox == true) || (!Input.GetKey(KeyCode.JoystickButton2) && playst == true))) && freeze == false)
        {
        if(night == 1)
        {
        x2 = 10 * (1 - tam/10);
        y = 10 * (1 - tam/10);
        z = 10 * (1 - tam/10);
        }
        if(night == 2)
        {
        x2 = 11 * (1 - tam/10);
        y = 11 * (1 - tam/10);
        z = 11 * (1 - tam/10);
        }
        if(night == 3)
        {
        x2 = 12 * (1 - tam/10);
        y = 12 * (1 - tam/10);
        z = 12 * (1 - tam);
        }
        if(night == 4)
        {
        x2 = 13 * (1 - tam/10);
        y = 13 * (1 - tam/10);
        z = 13 * (1 - tam/10);
        }
        if(night == 5)
        {
        x2 = 14 * (1 - tam/10);
        y = 14 * (1 - tam/10);
        z = 14 * (1 - tam/10);
        }
        if(night == 6)
        {
        x2 = 15 * (1 - tam/10);
        y = 15 * (1 - tam/10);
        z = 15 * (1 - tam/10);
        }
           if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || stick == true)
           {
           if(nolev == false)
           {
           speed = 10f + taco;
           anim.SetTrigger("wlk2");
           anim.SetTrigger("cr2");
           anim.SetTrigger("rn");
           bar.SetActive(true);
           smaller = true;
           }
           }
        }
       if (drain == true)
        {
        if(night == 1)
        {
        x2 = 2 * (1 - tam/10);
        y = 2 * (1 - tam/10);
        z = 2 * (1 - tam/10);
        }
        if(night == 2)
        {
        x2 = 3 * (1 - tam/10);
        y = 3 * (1 - tam/10);
        z = 3 * (1 - tam/10);
        }
        if(night == 3)
        {
        x2 = 4 * (1 - tam/10);
        y = 4 * (1 - tam/10);
        z = 4 * (1 - tam/10);
        }
        if(night == 4)
        {
        x2 = 5 * (1 - tam/10);
        y = 5 * (1 - tam/10);
        z = 5 * (1 - tam/10);
        }
        if(night == 5)
        {
        x2 = 6 * (1 - tam/10);
        y = 6 * (1 - tam/10);
        z = 6 * (1 - tam/10);
        }
        if(night == 6)
        {
        x2 = 7 * (1 - tam/10);
        y = 7 * (1 - tam/10);
        z = 7 * (1 - tam/10);
        }
           if(stick == true || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
           {
           speed = 2f + taco;
           }
           anim.SetTrigger("wlk2");
           anim.SetTrigger("cr");
           anim.SetTrigger("rn2");
        }
        if(nolev == true)
        {
           speed = 2f + taco;
        }
        if (Input.GetKeyUp(KeyCode.C) || (Input.GetKeyUp(KeyCode.JoystickButton1) && xbox == true) || (Input.GetKeyUp(KeyCode.JoystickButton2) && playst == true))
        {
   
          lñ = false;
        }
        if((((Input.GetKeyDown(KeyCode.C) || (Input.GetKeyDown(KeyCode.JoystickButton1) && xbox == true)) || (Input.GetKeyDown(KeyCode.JoystickButton2) && playst == true)) && comp.activeInHierarchy))
        {
        noc = true;
        }
        if(((Input.GetKeyUp(KeyCode.C) || (Input.GetKeyUp(KeyCode.JoystickButton1) && xbox == true) || (Input.GetKeyUp(KeyCode.JoystickButton2) && playst == true))))
        {
        noc = false;
        }
        if ((Input.GetKey(KeyCode.C) || (Input.GetKey(KeyCode.JoystickButton1) && xbox == true) || (Input.GetKey(KeyCode.JoystickButton2) && playst == true)) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.JoystickButton5) && freeze == false && noc == false)
        {
        if(!comp.activeInHierarchy)
        {
           if(lñ == false)
           {
           Dwni();
           }
           if(controller.height > 0)
           {
           controller.height -= 0.01f;
           controller.center = new Vector3(0f, 0.2f, 0f);
           }
           controller.center = new Vector3(0f, 0.2f, 0f);
         }
        if(night == 1)
        {
        x2 = 2 * (1 - tam/10);
        y = 2 * (1 - tam/10);
        z = 2 * (1 - tam/10);
        }
        if(night == 2)
        {
        x2 = 3 * (1 - tam/10);
        y = 3 * (1 - tam/10);
        z = 3 * (1 - tam/10);
        }
        if(night == 3)
        {
        x2 = 4 * (1 - tam/10);
        y = 4 * (1 - tam/10);
        z = 4 * (1 - tam/10);
        }
        if(night == 4)
        {
        x2 = 5 * (1 - tam/10);
        y = 5 * (1 - tam/10);
        z = 5 * (1 - tam/10);
        }
        if(night == 5)
        {
        x2 = 6 * (1 - tam/10);
        y = 6 * (1 - tam/10);
        z = 6 * (1 - tam/10);
        }
        if(night == 6)
        {
        x2 = 7 * (1 - tam/10);
        y = 7 * (1 - tam/10);
        z = 7 * (1 - tam/10);
        }
           if(stick == true || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
           {
           speed = 2f + taco;
           }
           anim.SetTrigger("wlk2");
           anim.SetTrigger("cr");
           anim.SetTrigger("rn2");
        }
        if (nolev == false && !Input.GetKey(KeyCode.C) && ((xbox == false && playst == false) || ((!Input.GetKey(KeyCode.JoystickButton1) && xbox == true) || (!Input.GetKey(KeyCode.JoystickButton2) && playst == true))))
        {
           if(controller.height < 1)
           {
           controller.height += 0.1f;
           }

           controller.center = new Vector3(0f, 0f, 0f);
        }
        if (!Input.GetKey(KeyCode.JoystickButton5) && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.C) && drain == false && ((!Input.GetKey(KeyCode.JoystickButton1)) || (!Input.GetKey(KeyCode.JoystickButton2))))
        {
        if(moving == false && nolev == true)
        {
         speed = 0f;
        }
        if(moving == true)
        {
           if(nolev == false)
           {
           speed = 5f + taco;
           }
        if(night == 1)
        {
        x2 = 5 * (1 - tam/10);
        y = 5 * (1 - tam/10);
        z = 5 * (1 - tam/10);
        }
        if(night == 2)
        {
        x2 = 6 * (1 - tam/10);
        y = 6 * (1 - tam/10);
        z = 6 * (1 - tam/10);
        }
        if(night == 3)
        {
        x2 = 7 * (1 - tam/10);
        y = 7 * (1 - tam/10);
        z = 7 * (1 - tam/10);
        }
        if(night == 4)
        {
        x2 = 8 * (1 - tam/10);
        y = 8 * (1 - tam/10);
        z = 8 * (1 - tam/10);
        }
        if(night == 5)
        {
        x2 = 9 * (1 - tam/10);
        y = 9 * (1 - tam/10);
        z = 9 * (1 - tam/10);
        }
        if(night == 6)
        {
        x2 = 10 * (1 - tam/10);
        y = 10 * (1 - tam/10);
        z = 10 * (1 - tam/10);
        }
        }
        }

        if (!controller.isGrounded)
        {
            verticalVelocity += gravity * Time.deltaTime;
        }
        else
        {
            verticalVelocity = 0f;
        }

        if(bar2.value == 1 && smaller == false && rp3 == false && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.JoystickButton5)))
        {
         drain = true;
        }
        if(bar2.value == 1 && smaller == false && rp3 == false && (!Input.GetKey(KeyCode.LeftShift) || !Input.GetKey(KeyCode.JoystickButton5)))
        {
         Invoke("x", 0.2f);
             rp3 = true;
        }
        if(smaller == true && rp == false && drain == false)
        {
        InvokeRepeating("DecreaseSlider", 0.05f + (burr/100), 0.05f + (burr/100));
        rp = true;
        }
        if(smaller == false && rp1 == false)
        {
        InvokeRepeating("IncreaseSlider", 0.05f, 0.05f);
        rp1 = true;
        }
        if(bar2.value == 0)
        {
          drain = true;
        }
        if(bar2.value == 0.99f)
        {
          drain = false;
        }

        Vector3 move1 = new Vector3(0, verticalVelocity, 0);
        controller.Move(move1 * Time.deltaTime);
    }
    }
    void DecreaseSlider()
    {
        if (bar2.value > 0 && smaller == true && bar.activeInHierarchy)
        {
            bar2.value -= 0.01f;
            bar3.value -= 0.01f;
        }
    }
    void IncreaseSlider()
    {
        if (bar2.value >= 0 && smaller == false && bar.activeInHierarchy)
        {
            ques = but.ques;
            bar2.value += 0.01f + (ques / 200);
            bar3.value += 0.01f + (ques / 200);
        }
    }
    public System.Collections.IEnumerator Purifying()
    {
     audioSource3.clip = wh;
     audioSource3.loop = true;
            Color c = pen.color;
            c.a -= alphaStep;
            c.a = Mathf.Clamp01(c.a);
            pen.color = c;
            zx = true;
            yield return new WaitForSeconds(0.005f);
            zx = false;
    }
    public System.Collections.IEnumerator Purifyingx()
    {
            Color c = pen.color;
            c.a += alphaStep;
            c.a = Mathf.Clamp01(c.a);
            pen.color = c;
            zx = true;
            yield return new WaitForSeconds(0.005f);
            zx = false;
    }
    void x()
    {
      bar.SetActive(false);
      rp3 = false;
    }

    IEnumerator writex()
    {
name = true;
if ((idioma == "ingles") || (idioma == "español") || (idioma == "frances") || 
    (idioma == "aleman") || (idioma == "italiano") || (idioma == "portugues"))
{
    for (int i = 0; i < textsp2.Length; i++)
    {
        if (textsp2[i] == '<')
        {
            int finEtiqueta = textsp2.IndexOf('>', i);
            if (finEtiqueta != -1)
            {
                string etiqueta = textsp2.Substring(i, finEtiqueta - i + 1);
                textod.text += etiqueta;
                i = finEtiqueta;
                continue;
            }
        }

        textod.text += textsp2[i];
        if (textsp2[i] != ' ')
            yield return new WaitForSeconds(speed2);
    }
    name = false;
    audioSource2x.clip = null;
    }

if ((idioma == "japones"))
{
    for (int i = 0; i < textsp2.Length; i++)
    {
        if (textsp2[i] == '<')
        {
            int finEtiqueta = textsp2.IndexOf('>', i);
            if (finEtiqueta != -1)
            {
                string etiqueta = textsp2.Substring(i, finEtiqueta - i + 1);
                textojd.text += etiqueta;
                i = finEtiqueta;
                continue;
            }
        }

        textojd.text += textsp2[i];
        if (textsp2[i] != ' ')
            yield return new WaitForSeconds(speed2);
    }
    name = false;
    audioSource2x.clip = null;
    }
if ((idioma == "coreano"))
{
    for (int i = 0; i < textsp2.Length; i++)
    {
        if (textsp2[i] == '<')
        {
            int finEtiqueta = textsp2.IndexOf('>', i);
            if (finEtiqueta != -1)
            {
                string etiqueta = textsp2.Substring(i, finEtiqueta - i + 1);
                textokd.text += etiqueta;
                i = finEtiqueta;
                continue;
            }
        }

        textokd.text += textsp2[i];
        if (textsp2[i] != ' ')
            yield return new WaitForSeconds(speed2);
    }
    name = false;
    audioSource2x.clip = null;
    }
if ((idioma == "chino"))
{
    for (int i = 0; i < textsp2.Length; i++)
    {
        if (textsp2[i] == '<')
        {
            int finEtiqueta = textsp2.IndexOf('>', i);
            if (finEtiqueta != -1)
            {
                string etiqueta = textsp2.Substring(i, finEtiqueta - i + 1);
                textocd.text += etiqueta;
                i = finEtiqueta;
                continue;
            }
        }

        textocd.text += textsp2[i];
        if (textsp2[i] != ' ')
            yield return new WaitForSeconds(speed2);
    }
    name = false;
    audioSource2x.clip = null;
    }
if ((idioma == "ruso"))
{
    for (int i = 0; i < textsp2.Length; i++)
    {
        if (textsp2[i] == '<')
        {
            int finEtiqueta = textsp2.IndexOf('>', i);
            if (finEtiqueta != -1)
            {
                string etiqueta = textsp2.Substring(i, finEtiqueta - i + 1);
                textord.text += etiqueta;
                i = finEtiqueta;
                continue;
            }
        }

        textord.text += textsp2[i];
        if (textsp2[i] != ' ')
            yield return new WaitForSeconds(speed2);
    }
    name = false;
    audioSource2x.clip = null;
    }
    }
    void Dwni()
    {
    audioSource2.PlayOneShot(cr);
    lñ = true;
    }
    void p1()
    {
     audioSourcex.loop = true;
     audioSourcex.clip = ring;
     Invoke("p2", 4f);
    }
    void p2()
    {
     phone.SetActive(true);
     Invoke("p2b", 0.2f);
    }
    void p3()
    {
      nod = false;
      textorder += 1;
    }
    void p2y()
    {
     phone.SetActive(false);
           freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
    }
    void p2b()
    {
     anim2.SetTrigger("st");
     rsp = true;
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         textol.text = "Accept <sprite name=\"Z\"> Reject <sprite name=\"XXX\">";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "español")
         {
         textol.text = "Aceptar <sprite name=\"Z\"> Rechazar <sprite name=\"XXX\">";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "frances")
         {
         textol.text = "Accepter <sprite name=\"Z\"> Rejeter <sprite name=\"XXX\">";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "aleman")
         {
         textol.text = "Akzeptieren <sprite name=\"Z\"> Ablehnen <sprite name=\"XXX\">";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "italiano")
         {
         textol.text = "Accetta <sprite name=\"Z\"> Rifiuta <sprite name=\"XXX\">";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "portugues")
         {
         textol.text = "Aceitar <sprite name=\"Z\"> Rejeitar <sprite name=\"XXX\">";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "japones")
         {
         textol.text = "";
         textojl.text = "承認 <sprite name=\"Z\"> 拒否 <sprite name=\"XXX\">";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "coreano")
         {
         textol.text = "";
         textojl.text = "";
         textokl.text = "수락 <sprite name=\"Z\"> 거부 <sprite name=\"XXX\">";
         textocl.text = "";
         textorl.text = "";
         }
         if(idioma == "chino")
         {
         textol.text = "";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "接受 <sprite name=\"Z\"> 拒绝 <sprite name=\"XXX\">";
         textorl.text = "";
         }
         if(idioma == "ruso")
         {
         textol.text = "";
         textojl.text = "";
         textokl.text = "";
         textocl.text = "";
         textorl.text = "Принять <sprite name=\"Z\"> Отклонить <sprite name=\"XXX\">";
         }
         }
         if(xbox == true)
         {
if(idioma == "ingles")
{
    textol.text = "Accept <sprite name=\"A\"> Reject <sprite name=\"B\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "español")
{
    textol.text = "Aceptar <sprite name=\"A\"> Rechazar <sprite name=\"B\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "frances")
{
    textol.text = "Accepter <sprite name=\"A\"> Rejeter <sprite name=\"B\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "aleman")
{
    textol.text = "Akzeptieren <sprite name=\"A\"> Ablehnen <sprite name=\"B\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "italiano")
{
    textol.text = "Accetta <sprite name=\"A\"> Rifiuta <sprite name=\"B\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "portugues")
{
    textol.text = "Aceitar <sprite name=\"A\"> Rejeitar <sprite name=\"B\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "japones")
{
    textol.text = "";
    textojl.text = "承認 <sprite name=\"A\"> 拒否 <sprite name=\"B\">";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "coreano")
{
    textol.text = "";
    textojl.text = "";
    textokl.text = "수락 <sprite name=\"A\"> 거부 <sprite name=\"B\">";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "chino")
{
    textol.text = "";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "接受 <sprite name=\"A\"> 拒绝 <sprite name=\"B\">";
    textorl.text = "";
}
if(idioma == "ruso")
{
    textol.text = "";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "Принять <sprite name=\"A\"> Отклонить <sprite name=\"B\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    textol.text = "Accept <sprite name=\"pixel_art_small\"> Reject <sprite name=\"circle\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "español")
{
    textol.text = "Aceptar <sprite name=\"pixel_art_small\"> Rechazar <sprite name=\"circle\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "frances")
{
    textol.text = "Accepter <sprite name=\"pixel_art_small\"> Rejeter <sprite name=\"circle\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "aleman")
{
    textol.text = "Akzeptieren <sprite name=\"pixel_art_small\"> Ablehnen <sprite name=\"circle\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "italiano")
{
    textol.text = "Accetta <sprite name=\"pixel_art_small\"> Rifiuta <sprite name=\"circle\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "portugues")
{
    textol.text = "Aceitar <sprite name=\"pixel_art_small\"> Rejeitar <sprite name=\"circle\">";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "japones")
{
    textol.text = "";
    textojl.text = "承認 <sprite name=\"pixel_art_small\"> 拒否 <sprite name=\"circle\">";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "coreano")
{
    textol.text = "";
    textojl.text = "";
    textokl.text = "수락 <sprite name=\"pixel_art_small\"> 거부 <sprite name=\"circle\">";
    textocl.text = "";
    textorl.text = "";
}
if(idioma == "chino")
{
    textol.text = "";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "接受 <sprite name=\"pixel_art_small\"> 拒绝 <sprite name=\"circle\">";
    textorl.text = "";
}
if(idioma == "ruso")
{
    textol.text = "";
    textojl.text = "";
    textokl.text = "";
    textocl.text = "";
    textorl.text = "Принять <sprite name=\"pixel_art_small\"> Отклонить <sprite name=\"circle\">";
}
         }
    }

void OnTriggerEnter(Collider other2)
{
    if (other2.gameObject.CompareTag("interpay"))
    {
            freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            timestop = true;
        Invoke("pay1", 9f);
        writing = false;
     audioSource.clip = mxc2;
     audioSource.loop = true;
mexico = true;
     audioSource.Play();
    }
    if (other2.gameObject.CompareTag("shop2"))
    {
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            -90,
            0
        );
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        cc.enabled = true;
            nolevi.SetActive(false);
            freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            timestop = true;
armingg = true;
           if(controller.height < 1)
           {
           controller.height += 0.1f;
           }
           controller.center = new Vector3(0f, 0f, 0f);
        if(night == 6)
        {
            cardi.nrt = true;
         shop2.SetActive(false);
                 Invoke("shop4xxx", 0.5f);
        }
        if(night == 5)
        {
        Invoke("shop4xx", 0.5f);
        }
        if(night == 4)
        {
        Invoke("shop4x", 0.5f);
        lant.SetActive(true);
if(idioma == "ingles")
{
    textoq.text = "Edgy?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Edgy?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Edgy?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Edgy?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Edgy?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Edgy?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "エッジー?";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "에지?";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "前卫?";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Эджи?";
}
        }
    }
    if (other2.gameObject.CompareTag("shop3"))
    {
if(night == 5 && mirais == 1 && sellers == -1)
{
hng.SetActive(true);
cardi.pre = true;
shop3.SetActive(false);
}
if(night != 5)
{
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            0,
            0
        );
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        cc.enabled = true;
            nolevi.SetActive(false);
            nolev = false;
            freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            timestop = true;
armingg2 = true;
           if(controller.height < 1)
           {
           controller.height += 0.1f;
           }
           controller.center = new Vector3(0f, 0f, 0f);
        if(night == 2)
        {
        Invoke("shop5x", 1f);
        lant.SetActive(true);
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
        }
}
    }
    if (other2.gameObject.CompareTag("shop1"))
    {
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            -90,
            0
        );
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        cc.enabled = true;
            safe = true;
            freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
            timestop = true;
arming2 = true;
           if(controller.height < 1)
           {
           controller.height += 0.1f;
           }
           controller.center = new Vector3(0f, 0f, 0f);
           lant.SetActive(false);
        if(night == 4)
        {
        Invoke("shop3x", 2f);
        }
        if(night == 6)
        {
        if(mirais == 1 && sellers == 1)
        {
        Invoke("shoppx1", 2f);
        }
        if(mirais == 0 && sellers == -1)
        {
        Invoke("shopp2", 2f);
        }
        }
        if(night == 5)
        {
        Invoke("shoppx", 2f);
        }
        if(night == 2)
        {
        Invoke("shop1x", 5f);
        }
        if(night == 3)
        {
        Invoke("shop2x", 3f);
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
        }
    }
    if (other2.gameObject.CompareTag("Gravity5") && g5 == false)
    {
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        thg.SetActive(true);
if(idioma == "ingles")
{
    tx1.text = "My soul remained in hell, and my body, fueled by remorse, wanders to this day searching for my bloodline, because if I manage to recover my child, I will be redeemed from the sin of killing him... Right?";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Mi alma se quedo en el infierno, y mi cuerpo, alimentado por el remordimiento, vaga a dia de hoy buscando a mi descendencia, porque si logro recuperar a mi hijo, sere redimida del pecado de matarlo... Verdad?";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Mon ame est restee en enfer, et mon corps, nourri par le remords, erre encore aujourd hui a la recherche de ma descendance, car si je parviens à retrouver mon fils, je serai rachetee du peche de l avoir tue... N est-ce pas?";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Meine Seele blieb in der Holle zuruck, und mein Körper, genährt von Reue, wandert bis heute auf der Suche nach meiner Nachkommenschaft, denn wenn ich meinen Sohn wiederfinde, werde ich von der Sunde erlost, ihn getotet zu haben... Oder?";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "La mia anima e rimasta all inferno, e il mio corpo, alimentato dal rimorso, vaga ancora oggi in cerca della mia discendenza, perche se riusciro a recuperare mio figlio, saro redenta dal peccato di averlo ucciso... Giusto?";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Minha alma ficou no inferno, e meu corpo, alimentado pelo remorso, vagueia ate hoje em busca de minha descendencia, pois se eu conseguir recuperar meu filho, serei redimida do pecado de te lo matado... Nao e?";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "私の魂は地獄に残り、身体は後悔に駆られ、今でも子孫を探して彷徨っている。もし息子を取り戻すことができれば、彼を殺した罪から救われるはず...そうでしょう？";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "내 영혼은 지옥에 남았고, 내 몸은 후회에 이끌려 지금도 내 후손을 찾아 떠돌고 있다. 아들을 되찾기만 한다면, 내가 그를 죽인 죄에서 구원받을 수 있을 텐데... 그렇지?";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "我的灵魂留在了地狱，而我的身体因悔恨所驱，使我至今仍在寻找我的血脉，因为如果我能找回我的孩子，我就能被赎免杀死他的罪...对吗？";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Моя душа осталась в аду, а моё тело, питаемое раскаянием, до сих пор блуждает в поисках моего потомства, ведь если я сумею вернуть своего сына, я буду искуплена от греха его убийства... Верно?";
}
        Invoke("nullv", 11f);
        g5 = true;
    }
    if (other2.gameObject.CompareTag("Gravity4") && g4 == false)
    {
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        thg.SetActive(true);
if(idioma == "ingles")
{
    tx1.text = "When I asked him what he gained from this, he told me: 'I am evil incarnate; is there any greater evil than that which has no cause, no justification at all?'";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Cuando le pregunte que ganaba el con esto, me dijo: 'Soy la maldad encarnada, acaso hay mayor maldad que aquella que no tiene causa, aquella sin justificacion alguna?'";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Quand je lui ai demande ce qu il y gagnait, il m a repondu : 'Je suis le mal incarne ; y a-t-il pire mal que celui qui n a ni cause ni la moindre justification ?'";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Als ich ihn fragte, was er damit gewinne, sagte er: 'Ich bin das personifizierte Böse; gibt es ein großeres ubel als jenes, das keinen Grund hat, keinerlei Rechtfertigung?'";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Quando gli chiesi cosa ci guadagnasse, mi disse: 'Io sono il male incarnato; esiste forse un male più grande di quello che non ha causa, che non ha alcuna giustificazione?'";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Quando lhe perguntei o que ele ganhava com isso, ele me disse: 'Eu sou o mal encarnado; ha mal maior do que aquele que nao tem causa, que nao possui justificativa alguma?'";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "これで彼が何を得るのかと尋ねたとき、彼はこう言った――『私は悪そのものだ。原因も理由も持たない悪よりも大きな悪があるだろうか？』";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "내가 그에게 이것으로 무엇을 얻느냐고 묻자 그는 말했다: '나는 악 그 자체다. 원인도, 어떤 정당성도 없는 악보다 더 큰 악이 있을까?'";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "我问他这样做能得到什么，他回答：‘我是邪恶的化身；世上还有比无因之恶、无任何理由之恶更大的恶吗？’";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Когда я спросил его, что он получает от этого, он сказал: 'Я — воплощённое зло; разве есть зло больше, чем то, что не имеет причины, не имеет никакого оправдания?'";
}
        Invoke("nullv", 9f);
        g4 = true;
    }
    if (other2.gameObject.CompareTag("Gravity3") && g3 == false)
    {
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        thg.SetActive(true);
if(idioma == "ingles")
{
    tx1.text = "Because it is when you have lost everything, when only willpower remains, that the devil offers you a deal: the chance to redeem myself.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Porque es cuando lo has perdido todo, cuando solo la voluntad prevalece, que el diablo te ofrece un trato: la oportunidad de redimirme.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Car c est lorsque tu as tout perdu, lorsque seule la volonte subsiste, que le diable t offre un marche : l occasion de me racheter.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Denn erst wenn du alles verloren hast, wenn nur noch der Wille bleibt, bietet dir der Teufel einen Handel an: die Moglichkeit, mich zu erlosen.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Perche e quando hai perso tutto, quando solo la volontà rimane, che il diavolo ti offre un patto: l opportunità di redimermi.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Porque e quando voce perdeu tudo, quando apenas a vontade permanece, que o diabo lhe oferece um acordo: a oportunidade de me redimir.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "すべてを失い、意思だけが残ったその時、悪魔は取引を持ちかけてくる――それは、贖いの機会だ。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "모든 것을 잃고 오직 의지만이 남았을 때, 그때 악마가 거래를 제안한다: 나에게 주어진 속죄의 기회다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "当你失去了一切，只剩下意志时，魔鬼便会向你提出交易：赎回自己的机会。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Ведь именно когда ты потерял всё, когда лишь воля остаётся, дьявол предлагает тебе сделку: шанс искупить себя.";
}
        Invoke("nullv", 6f);
        g3 = true;
    }
    if (other2.gameObject.CompareTag("Gravity2") && g2 == false)
    {
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        thg.SetActive(true);
if(idioma == "ingles")
{
    tx1.text = "I caused the death of one of my two sons, I almost caused the death of the eldest, and I fled from it.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Yo provoque la muerte de uno de mis dos hijos, casi provoque la muerte del mayor y hui de la misma.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "J ai cause la mort de l un de mes deux fils, j ai failli causer la mort de l aine et j ai fui celle ci.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Ich verursachte den Tod eines meiner beiden Sohne, ich verursachte beinahe den Tod des altesten und ich floh davor.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Ho provocato la morte di uno dei miei due figli, ho quasi provocato la morte del maggiore e sono fuggito da essa.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Causei a morte de um dos meus dois filhos, quase causei a morte do mais velho e fugi dela.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "私は二人の息子のうち一人を死に至らしめ、長男も危うく死なせるところで、そしてその死から逃げました。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "나는 두 아들 중 한 명을 죽음에 이르게 했고, 큰아들도 거의 죽게 할 뻔했으며, 그 죽음에서 도망쳤다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "我导致了我两个儿子中的一个死亡，几乎让长子也丧命，并且我逃避了那场死亡。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Я вызвал смерть одного из моих двух сыновей, чуть не стал причиной смерти старшего и сбежал от неё.";
}
        Invoke("nullv", 6f);
        g2 = true;
    }
    if (other2.gameObject.CompareTag("Gravity") && g1 == false)
    {
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        thg.SetActive(true);
if(idioma == "ingles")
{
    tx1.text = "One hundred lustrums ago, I committed two sins.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Hace cien lustros, cometi dos pecados.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Il y a cent lustrums, jai commis deux peches.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Vor hundert Jahren beging ich zwei Sunden.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Cento lustri fa ho commesso due peccati.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Cem lustros atras, cometi dois pecados.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "百年前、私は二つの罪を犯しました";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "백 년 전, 나는 두 가지 죄를 지었습니다";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "一百年前，我犯了两桩罪过";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Сто люстров назад я совершил два греха";
}
        Invoke("nullv", 2f);
        g1 = true;
    }
    if (other2.gameObject.CompareTag("flip"))
    {
        float rng = Random.value;
        if(rng <= probabilidad)
        {
       flip = true;
        }
    }
    if (other2.gameObject.CompareTag("secret2"))
    {
     audioSourcex.clip = null;
         audioSource3x.clip = meet;
       secretend();
    }
    if (other2.gameObject.CompareTag("grav0"))
    {
        float rng = Random.value;
        if(rng <= probabilidad)
        {
       polt = true;
        }
    }
    if (other2.gameObject.CompareTag("trap"))
    {
        audioSource.PlayOneShot(trapsn);
    Animator animtrap = other2.GetComponentInParent<Animator>();
    animtrap.SetTrigger("anim1");
            StartCoroutine(DeactivateParentAfterDelay(other2.transform.parent.gameObject, 31.29f));
    }
    if (other2.gameObject.CompareTag("eye"))
    {
        audioSource.PlayOneShot(eyesn);
    watch.SetActive(true);
    }
    if (other2.CompareTag("Finish"))
    {
ef.enabled = true;
parm = true;
     freeze = true;
     rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
     Invoke("z1", 0.5f);
     Invoke("z2", 3f);
     trap.SetActive(false);
    }
    if (other2.CompareTag("portal2"))
    {
    parm = false;
       audioSource3x.clip = null;
    trans3.SetActive(true);
     Invoke("zz1", 0.5f);
     Invoke("zz2", 1f);
    }
    if (other2.CompareTag("portal3"))
    {
       paso1 = false;
       paso2x = false;
       paso2 = false;
       paso3x = false;
       paso3 = false;
       paso4 = false;
       msg1.SetActive(true);
       msg2.SetActive(false);
       msg3.SetActive(false);
       msg4.SetActive(false);
     secwall.SetActive(true);
    trans3.SetActive(true);
     Invoke("zz11", 0.5f);
     Invoke("zz22", 1f);
    }
    if (other2.CompareTag("portal"))
    {
     bjp = false;
     trap.SetActive(true);
         lant.SetActive(false);
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            90,
            0
        );
        Vector3 newPos = new Vector3(
            camp.position.x,
            exitPortal.position.y - 1,
            exitPortal.position.z
        );
        transform.position = newPos;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);

        cc.enabled = true;
    }
    if (other2.gameObject.CompareTag("secret1"))
    {
     secwall.SetActive(false);
    }
    if (other2.gameObject.CompareTag("kill"))
    {
    penta.SetActive(false);
arming2 = false;
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
        if(night != 6 && hour != 5)
        {
     audioSourcex.clip = null;
           blood1.SetActive(false);
           blood2.SetActive(false);
           blood3.SetActive(false);
           blood4.SetActive(false);
           blood5.SetActive(false);
           blood6.SetActive(false);
           blood7.SetActive(false);
           blood8.SetActive(false);
         audioSource3x.clip = jsc2;
        Invoke("gameover", 1f);
        }
        if(night == 6 && hour == 5)
        {
     audioSourcex.clip = null;
         audioSource3x.clip = meet;
        Badend();
        }
        llor.SetActive(false);
        copy.SetActive(false);
        lant.SetActive(false);
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        jmpscare.SetActive(true);
        transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
        camara.transform.rotation = Quaternion.Euler(camara.transform.rotation.x, 0f, camara.transform.rotation.z);
    }
    if (other2.gameObject.CompareTag("killx"))
    {
        Invoke("gameover", 0.01f);
    }
    if (other2.gameObject.CompareTag("end"))
    {
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            90,
            0
        );
        transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
        cc.enabled = true;
       end.SetActive(false);
       can.SetActive(false);
       freeze = true;
       rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
       runnx.SetActive(false);
       fls.SetActive(true);
       fls2.SetParent(null);
        Invoke("cn1", 2f);
        if(mirais == 1 && sellers == 1)
        {
trapspec.SetActive(true);
        Invoke("cn1b", 4.5f);
        Invoke("cn2b", 5f);
        Invoke("cn3b", 7f);
        Invoke("cn5b", 9f);
        }
        if(mirais != 1 || sellers != 1)
        {
        Invoke("cn2", 5f);
        Invoke("cn3", 7f);
        }
        if(klo == false)
        {
        klo = true;
        audioSource.PlayOneShot(sta);
        }
    }
}
void OnTriggerStay(Collider other2)
{
    if (other2.gameObject.CompareTag("xlight"))
    {
       lant.SetActive(false);
    }
    if (other2.gameObject.CompareTag("nolev"))
    {
       nolev = true;
    }
    if (other2.gameObject.CompareTag("notp"))
    {
       notp = true;
    }
    if (other2.gameObject.CompareTag("safezone"))
    {
       safe = true;
    }
    if (other2.gameObject.CompareTag("safe2"))
    {
       safe = false;
    }
    if (other2.gameObject.CompareTag("blood") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
         if(xbox == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "cocina";
    }
    if (other2.gameObject.CompareTag("blood2") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
          if(xbox == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "salon";
    }
    if (other2.gameObject.CompareTag("blood3") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
         if(xbox == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "baño1";
    }
    if (other2.gameObject.CompareTag("blood4") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
         if(xbox == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "baño2";
    }
    if (other2.gameObject.CompareTag("blood5") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
         if(xbox == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "oficina";
    }
    if (other2.gameObject.CompareTag("blood6") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
if(xbox == true)
{
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "micuarto";
    }
    if (other2.gameObject.CompareTag("blood7") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
if(xbox == true)
{
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "invitados";
    }
    if (other2.gameObject.CompareTag("blood8") && freeze == false)
    {
     audioSourcex.loop = true;
     audioSourcex.clip = dm;
if(xbox == true)
{
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"pixel_art_small\">";
}
         }
         if(playst == true)
         {
if(idioma == "ingles")
{
    texto.text = "Purify <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Purifier <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Reinigen <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Purificare <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Purificar <sprite name=\"Cuadrado\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "浄化する <sprite name=\"Cuadrado\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "정화하다 <sprite name=\"Cuadrado\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "净化 <sprite name=\"Cuadrado\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "очистить <sprite name=\"Cuadrado\">";
}
         }
         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Purify <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "purifier <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "reinigen <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "purificare <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "purificar <sprite name=\"Q\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "浄化する <sprite name=\"Q\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "정화하다 <sprite name=\"Q\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "净化 <sprite name=\"Q\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "очистить <sprite name=\"Q\">";
         }
         }
        penta.SetActive(true);
        purif = true;
        ubi = "sotano";
    }
}
void OnTriggerExit(Collider other2)
{
    if (other2.gameObject.CompareTag("nolev"))
    {
       nolev = false;
    }
    if (other2.gameObject.CompareTag("xlight"))
    {
       lant.SetActive(true);
    }
    if (other2.gameObject.CompareTag("notp"))
    {
       notp = false;
    }
    if (other2.gameObject.CompareTag("eye"))
    {
    watch.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood2"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood3"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood4"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood5"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood6"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood7"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
    if (other2.gameObject.CompareTag("blood8"))
    {
     audioSourcex.clip = null;
     audioSource3.clip = null;
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
        purif = false;
        penta.SetActive(false);
    }
}
void gameover()
{
        Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
 gameo.SetActive(true);
 audioSource2.clip = null;
 audioSource3.clip = null;
 home = true;
}
void sp()
{
interx.SetActive(false);
}
void cn1()
{
plax.SetTrigger("trn");
}
void cnx()
{
trans.SetActive(true);
Invoke("cnx2", 1f);
}
void cnx2()
{
trans.SetActive(false);
credits.SetActive(true);

Invoke("cnx3", 70f);
}
void cnx3()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
void cn2()
{
        animñ.SetTrigger("brn");
hell.SetActive(true);
hell2.SetActive(true);
filter.SetActive(false);
lant.SetActive(false);
     audioSourcex.clip = fire;
     audioSourcex.loop = true;
     audioSource2x.clip = dm;
     audioSource2x.loop = true;
     audioSource3x.clip = jsc;
     audioSource3x.loop = true;

}
void cn1b()
{
trapspec2.SetActive(true);
        tranimx.SetTrigger("anim1");
}
void cn2b()
{
        animñ.SetTrigger("brn");
lant.SetActive(false);
     audioSourcex.loop = true;
     audioSource2x.loop = true;
     audioSource3x.clip = jsc;
     audioSource3x.loop = true;

}
void cn3b()
{
interz.SetActive(true);
    Invoke("cn4b", 0.25f);
    Invoke("intf", 0.5f);
}

void cn4b()
{
     audioSourcex.clip = dm;
wallsp.SetActive(true);
mirend.SetTrigger("mir");
table.SetActive(false);
        tranimx.SetTrigger("ll2");
}

void cn5b()
{
texm = true;
textorder = 108;
}

void cn3()
{
         if(zxh == false)
         {

         if(xbox == false && playst == false)
         {
         if(idioma == "ingles")
         {
         texto.text = "Banish <sprite name=\"Q2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Desterrar <sprite name=\"Q2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "Bannir <sprite name=\"Q2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "verbannen <sprite name=\"Q2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "Bandire <sprite name=\"Q2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "Banir <sprite name=\"Q2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "追放する <sprite name=\"Q2\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "덜어 없애다 <sprite name=\"Q2\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "放逐 <sprite name=\"Q2\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "изгонять <sprite name=\"Q2\">";
         }
         }
         if(xbox == true)
         {
         if(idioma == "ingles")
         {
         texto.text = "Banish <sprite name=\"X2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Desterrar <sprite name=\"X2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "Bannir <sprite name=\"X2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "verbannen <sprite name=\"X2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "Bandire <sprite name=\"X2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "Banir <sprite name=\"X2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "追放する <sprite name=\"X2\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "덜어 없애다 <sprite name=\"X2\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "放逐 <sprite name=\"X2\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "изгонять <sprite name=\"X2\">";
         }
         }
         if(playst == true)
         {
         if(idioma == "ingles")
         {
         texto.text = "Banish <sprite name=\"Cuadrado2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "español")
         {
         texto.text = "Desterrar <sprite name=\"Cuadrado2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "frances")
         {
         texto.text = "Bannir <sprite name=\"Cuadrado2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "aleman")
         {
         texto.text = "verbannen <sprite name=\"Cuadrado2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "italiano")
         {
         texto.text = "Bandire <sprite name=\"Cuadrado2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "portugues")
         {
         texto.text = "Banir <sprite name=\"Cuadrado2\">";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "japones")
         {
         texto.text = "";
         textoj.text = "追放する <sprite name=\"Cuadrado2\">";
         textok.text = "";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "coreano")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "덜어 없애다 <sprite name=\"Cuadrado2\">";
         textoc.text = "";
         textor.text = "";
         }
         if(idioma == "chino")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "放逐 <sprite name=\"Cuadrado2\">";
         textor.text = "";
         }
         if(idioma == "ruso")
         {
         texto.text = "";
         textoj.text = "";
         textok.text = "";
         textoc.text = "";
         textor.text = "изгонять <sprite name=\"Cuadrado2\">";
         }
         }
        penta.SetActive(true);
        zxh = true;
        }
  }
    void cnxxx()
    {
            rawImage.enabled = false;
            if(wallsp.activeInHierarchy)
            {
credits.SetActive(true);
            }
    }
    private void OnVideoPrepared(VideoPlayer vp)
    {
        if (rawImage != null)
        {
            rawImage.enabled = true;
            vp.Play();
        }
    }
    public void z1()
    {
      plax.SetTrigger("trnx");
      Invoke("z111", 1f);
    }
    public void z111()
    {
        audioSource.PlayOneShot(jsc2);
       audioSource3x.clip = pers;
    }
    public void z2()
    {
      plax.SetTrigger("trnx2");
      freeze = false;
      rbd.constraints = RigidbodyConstraints.FreezeRotation;
      porm = true;
    }
    public void zz1()
    {
    porm = false;
    port.SetActive(false);
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        transform.position = kitsp.transform.position;
        cc.enabled = true;
         lant.SetActive(true);
         ef.enabled = false;
    }
    public void zz11()
    {
        CharacterController cc = GetComponent<CharacterController>();
        cc.enabled = false;
        transform.position = spawnr.transform.position;
        cc.enabled = true;
        ef.enabled = false;
    }
    public void zz2()
    {
     trans3.SetActive(false);
     trap.SetActive(true);
        par.transform.position = posicionOriginal;
        por.transform.position = posicionOriginal2;
    }
    public void zz22()
    {
     trans3.SetActive(false);
     portxxx.SetActive(false);
     lant.SetActive(true);
    }
    public void th2()
    {
flip = false;
interz.SetActive(true);
    Invoke("intf", 0.5f);
    }
    public void intf()
    {
     interz.SetActive(false);
    }
    public void th3()
    {
     polt = false;
    }
    IEnumerator ApplyRandomImpulses()
    {
if(polt == true)
{
            Vector3 randomDir = Random.onUnitSphere;
            rbd.AddForce(randomDir * 5f, ForceMode.Impulse);

            if (rbd.linearVelocity.magnitude > 10f)
                rbd.linearVelocity = rbd.linearVelocity.normalized * 10f;

            yield return new WaitForSeconds(3f);
kml = false;
}
    }
    IEnumerator ApplyRandomRotation()
    {
if(polt == true)
{
            Quaternion targetRotation = Random.rotation;
            float elapsed = 0f;
            Quaternion startRotation = transform.rotation;
            while (elapsed < 3f)
            {
                if(polt == true)
                {
                transform.rotation = Quaternion.Slerp(
                    startRotation,
                    targetRotation,
                    elapsed / 3f
                );
                }
                if(polt == false)
                {
rbd.linearVelocity = Vector3.zero;
 kml2 = false;
 rbd.useGravity = true;
        Quaternion currentRotation = transform.rotation;
        Quaternion targetRotation2 = Quaternion.Euler(0f, 0f, 0f);
        transform.rotation = Quaternion.RotateTowards(
            transform.rotation, 
            targetRotation2, 
            90 * Time.deltaTime
        );
 kml3 = true;
                }

                elapsed += Time.deltaTime * (1f);
                yield return null;
            }
            transform.rotation = targetRotation;
                if(polt == false)
                {
rbd.linearVelocity = Vector3.zero;
 kml2 = false;
 rbd.useGravity = true;
 transform.rotation = Quaternion.Euler(0f, 0f, 0f);
 kml3 = true;
                }
}
    }

    private IEnumerator DeactivateParentAfterDelay(GameObject parentObject, float delay)
    {
        yield return new WaitForSeconds(delay);
            parentObject.SetActive(false);
    }
    public void kill()
    {
audioSource.PlayOneShot(jsc2);
        flss.SetActive(false);
        imp.SetActive(false);
        llor.SetActive(false);
        lant.SetActive(false);
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        jmpscare.SetActive(true);
        transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
        camara.transform.rotation = Quaternion.Euler(camara.transform.rotation.x, 0f, camara.transform.rotation.z);
    }
    public void crs()
    {
Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
    }

    void ActualizarEstados(List<string> mandos)
    {
        playst = false;
        xbox = false;

        foreach (string nombre in mandos)
        {
            if (string.IsNullOrEmpty(nombre)) continue;

            string n = nombre.ToLower();
            if (n.Contains("dualshock") || n.Contains("dualsense") || n.Contains("playstation") || n.Contains("wireless controller"))
            {
               playst = true;
            }
            else
            {
              xbox = true;
            }
        }

        Debug.Log($"Estado mandos - PlayStation: {playst}, Xbox: {xbox}");
    }

    bool SonIguales(List<string> lista1, List<string> lista2)
    {
        if (lista1.Count != lista2.Count) return false;
        for (int i = 0; i < lista1.Count; i++)
        {
            if (lista1[i] != lista2[i]) return false;
        }
        return true;
    }
    private void UpdateSliderValue(Slider slider, Vector2 cursorPosition)
    {
        if (slider == null) return;

        RectTransform sliderRect = slider.GetComponent<RectTransform>();

        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(sliderRect, cursorPosition, null, out localPoint);

        float pct = 0f;
        if (slider.direction == Slider.Direction.LeftToRight || slider.direction == Slider.Direction.RightToLeft)
        {
            pct = Mathf.InverseLerp(sliderRect.rect.xMin, sliderRect.rect.xMax, localPoint.x);
        }
        else
        {
            pct = Mathf.InverseLerp(sliderRect.rect.yMin, sliderRect.rect.yMax, localPoint.y);
        }

        if (slider.direction == Slider.Direction.RightToLeft || slider.direction == Slider.Direction.TopToBottom)
            pct = 1f - pct;

        slider.value = Mathf.Lerp(slider.minValue, slider.maxValue, pct);
    }
    public void nullv()
    {
     if(!menu.activeInHierarchy)
     {
     freeze = false;
rbd.constraints = RigidbodyConstraints.FreezeRotation;
     }
      thg.SetActive(false);
    }
    public void Badend()
    {
     clock.power = pow;
     pow = 100;
           blood1.SetActive(false);
           blood2.SetActive(false);
           blood3.SetActive(false);
           blood4.SetActive(false);
           blood5.SetActive(false);
           blood6.SetActive(false);
           blood7.SetActive(false);
           blood8.SetActive(false);
     skip = true;
    scaryaf.SetActive(true);
        Invoke("Badend2", 9f);
    }
    public void Badend2()
    {
    scaryaf.SetActive(false);
      thg.SetActive(true);
if(idioma == "ingles")
{
    tx1.text = "I finally found you.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Al fin te encontre.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Je t ai enfin trouve.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Ich habe dich endlich gefunden.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Finalmente ti ho trovato.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Finalmente te encontrei.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "やっとあなたを見つけた。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "드디어 너를 찾았어.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "我终于找到你了。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Я наконец-то нашёл тебя.";
}
        Invoke("Badend3", 3f);
    }
    public void Badend3()
    {
if(idioma == "ingles")
{
    tx1.text = "Let s go back home... in hell.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Volvamos a casa... en el infierno.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Retournons a la maison... en enfer.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Lass uns nach Hause zuruckkehren... in der Holle.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Torniamo a casa... all inferno.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Vamos voltar para casa... no inferno.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "家に帰ろう... 地獄で。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "집으로 돌아가자... 지옥에서.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "回家吧...在地狱里。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Вернёмся домой... в аду.";
}
        Invoke("Badend4", 3f);
    }
    public void Badend4()
    {
if(idioma == "ingles")
{
    tx1.text = "- my vision is starting to blur... I can t think clearly... I was so close... -";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "- mi vista comienza a nublarse... no puedo pensar con claridad... estaba tan cerca... -";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "- ma vue commence a se brouiller... je n arrive plus a penser clairement... j etais si pres... -";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "- mein Blick beginnt zu verschwimmen... ich kann nicht klar denken... ich war so nah dran... -";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "- la mia vista inizia ad offuscarsi... non riesco a pensare lucidamente... ero cosi vicino... -";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "- minha visao esta comecando a ficar turva... nao consigo pensar claramente... eu estava tao perto... -";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "- 視界がかすんできた... はっきり考えられない... こんなに近かったのに... -";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "- 시야가 흐려지기 시작한다... 명확하게 생각할 수 없어... 이렇게 가까웠는데... -";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "- 我的视线开始模糊了... 我无法清晰思考... 我明明已经那么接近了... -";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "- мой взгляд начинает мутнеть... я не могу ясно мыслить... я был так близко... -";
}
        Invoke("Badend5", 5f);
    }
    public void Badend5()
    {
if(idioma == "ingles")
{
    tx1.text = "I ve missed you.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Te he echado de menos.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Tu m as manque.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Ich habe dich vermisst.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Mi sei mancata.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Senti sua falta.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "あなたがいなくて寂しかった。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "너가 너무 보고 싶었어.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "我很想你。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Я скучал по тебе.";
}
        Invoke("Badend6", 3f);
    }
    public void Badend6()
    {
if(idioma == "ingles")
{
    tx1.text = "son";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "hijo";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "fils";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Sohn";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "figlio";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "filho";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "息子";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "아들";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "儿子";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "сын";
}
        Invoke("Badend7", 5f);
    }
    public void Badend7()
    {
credits.SetActive(true);
     audioSource3x.clip = null;
Invoke("cnx3", 35f);
    }
    public void secretend()
    {
     clock.power = pow;
     pow = 100;
     skip = true;
    secr.SetActive(true);
        Invoke("secretend2", 9f);
    }
    public void secretend2()
    {
    secr.SetActive(false);
      thg.SetActive(true);
if(idioma == "ingles")
{
    tx1.text = "When the servants of the devil took my soul... they took something else.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Cuando los siervos del diablo se llevaron mi alma... se llevaron algo mas.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Quand les serviteurs du diable ont emporte mon ame... ils ont emporte quelque chose de plus.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Als die Diener des Teufels meine Seele nahmen... nahmen sie noch etwas anderes.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Quando i servi del diavolo portarono via la mia anima... portarono via qualcos'altro.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Quando os servos do diabo levaram minha alma... levaram algo mais.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "悪魔の僕たちが私の魂を奪ったとき... 彼らは他の何かも奪っていった。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "악마의 종들이 내 영혼을 가져갔을 때... 그들은 또 다른 무언가도 가져갔다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "当恶魔的仆从夺走我的灵魂时...他们还夺走了别的东西。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Когда слуги дьявола забрали мою душу... они забрали и кое-что ещё.";
}
        Invoke("secretend3", 4f);
    }
    public void secretend3()
    {
if(idioma == "ingles")
{
    tx1.text = "They tried to take the soul of my eldest son, for he seemed dead.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Intentaron llevarse el alma de mi hijo mayor, pues parecia muerto.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Ils ont essaye d emporter l ame de mon fils aine, car il semblait mort.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Sie versuchten, die Seele meines ältesten Sohnes mitzunehmen, denn er schien tot zu sein.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Hanno cercato di portare via l anima di mio figlio maggiore, perche sembrava morto.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Tentaram levar a alma do meu filho mais velho, pois ele parecia morto.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "長男が死んだように見えたため、彼らはその魂を奪おうとした。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "큰아들이 죽은 것처럼 보였기에, 그들은 그의 영혼을 데려가려고 했다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "他们试图带走我长子的灵魂，因为他看起来像死了一样。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Они попытались забрать душу моего старшего сына, ведь он казался мёртвым.";
}
        Invoke("secretend4", 4f);
    }
    public void secretend4()
    {
if(idioma == "ingles")
{
    tx1.text = "However, being right on the border between life and death, the servants only managed to take half of his soul.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Sin embargo, al estar justo en la frontera entre la vida y la muerte, los siervos solo lograron llevarse la mitad de su alma.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Cependant, etant juste a la frontiere entre la vie et la mort, les serviteurs ne purent emporter que la moitie de son ame.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Doch da er sich genau an der Grenze zwischen Leben und Tod befand, konnten die Diener nur die Halfte seiner Seele mitnehmen.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Tuttavia, essendo proprio al confine tra la vita e la morte, i servi riuscirono a portare via solo metà della sua anima.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "No entanto, por estar exatamente na fronteira entre a vida e a morte, os servos so conseguiram levar metade de sua alma.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "しかし、彼が生と死の境界にいたため、僕たちは彼の魂の半分しか奪うことができなかった。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "그러나 그는 삶과 죽음의 경계에 있었기에, 종들은 그의 영혼의 절반만 가져갈 수 있었다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "然而，因为他正处在生与死的边界，仆从们只能带走他一半的灵魂。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Однако, находясь на грани между жизнью и смертью, слуги смогли забрать лишь половину его души.";
}
        Invoke("secretend5", 6f);
    }
    public void secretend5()
    {
if(idioma == "ingles")
{
    tx1.text = "Thus, one half remained in hell, and the other in the original body.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Asi pues, una mitad se quedo en el infierno, y la otra en el cuerpo original.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Ainsi, une moitie est restee en enfer, et l autre dans le corps d origine.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "So blieb die eine Hälfte in der Holle, und die andere im ursprunglichen Korper.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Cosi, una meta rimase all inferno e l altra nel corpo originale.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Assim, uma metade ficou no inferno e a outra no corpo original.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "こうして片方は地獄に残り、もう片方は元の身体に留まった。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "그리하여 한쪽은 지옥에 남고, 다른 한쪽은 원래의 몸에 머물렀다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "因此，一半留在了地狱，而另一半留在了原本的身体里。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Так одна половина осталась в аду, а другая — в его настоящем теле.";
}
        Invoke("secretend6", 4f);
    }
    public void secretend6()
    {
if(idioma == "ingles")
{
    tx1.text = "Thus, one half remained in hell, and the other in the original body.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Asi pues, una mitad se quedo en el infierno, y la otra en el cuerpo original.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Ainsi, une moitie est restee en enfer, et l autre dans le corps d origine.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "So blieb die eine Halfte in der Holle, und die andere im ursprunglichen Korper.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Così, una metà rimase all inferno e l altra nel corpo originale.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Assim, uma metade ficou no inferno e a outra no corpo original.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "こうして片方は地獄に残り、もう片方は元の身体に留まった。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "그리하여 한쪽은 지옥에 남고, 다른 한쪽은 원래의 몸에 머물렀다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "因此，一半留在了地狱，而另一半留在了原本的身体里。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Так одна половина осталась в аду, а другая — в его настоящем теле.";
}
        Invoke("secretend7", 4f);
    }
    public void secretend7()
    {
if(idioma == "ingles")
{
    tx1.text = "As a natural consequence, all his descendants were born with half a soul, including you.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "A efecto natural, toda descendencia suya nacio con media alma, incluyendote a ti.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Par effet naturel, toute sa descendance est nee avec une demi-ame, y compris toi.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Als naturliche Folge wurde all seine Nachkommenschaft mit einer halben Seele geboren, dich eingeschlossen.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Per effetto naturale, tutta la sua discendenza nacque con mezza anima, te compreso.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Como efeito natural, toda a sua descendencia nasceu com meia alma, incluindo voce.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "その自然な影響として、彼の子孫は皆、あなたを含め半分の魂しか持って生まれなかった。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "그 자연적인 영향으로, 그의 모든 후손은 반쪽짜리 영혼을 가지고 태어났으며, 너도 그중 하나다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "因此，他的所有后代，包括你在内，都是带着半个灵魂出生的。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Вследствие этого все его потомки, включая тебя, родились лишь с половиной души.";
}
        Invoke("secretend8", 4f);
    }
    public void secretend8()
    {
if(idioma == "ingles")
{
    tx1.text = "This new race is called medium.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "A esta nueva raza se la llama medium.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Cette nouvelle race est appelee medium.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Diese neue Rasse wird Medium genannt.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Questa nuova razza e chiamata medium.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Esta nova raca e chamada medium.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "この新しい種族は霊媒師と呼ばれる。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "이 새로운 종족은 영매라고 불린다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "这个新种族被称作通灵者。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Эту новую расу называют медиумом.";
}
        Invoke("secretend9", 4f);
    }
    public void secretend9()
    {
if(idioma == "ingles")
{
    tx1.text = "Having one foot in the mortal plane and the other in the beyond, mediums possess unique spiritual abilities.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Al tener un pie en el plano mortal y otro en el mas alla, los mediums poseen habilidades espirituales unicas.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Ayant un pied dans le plan mortel et l autre dans l au-delà, les mediums possedent des capacites spirituelles uniques.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Da sie einen Fuß in der sterblichen Ebene und den anderen im Jenseits haben, besitzen Medien einzigartige spirituelle Fahigkeiten.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Avendo un piede nel piano mortale e l altro nell aldila, i medium possiedono abilita spirituali uniche.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Tendo um pe no plano mortal e outro no alem, os mediuns possuem habilidades espirituais unicas.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "現世に片足、あの世にもう片方の足を置くことで、霊媒師は独自の霊的能力を持つ。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "현세에 한 발을, 저세상에 다른 한 발을 두고 있기 때문에, 무당들은 독특한 영적 능력을 지니고 있다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "当脚踏凡间一端，另一脚踏入来世时，通灵者拥有独特的灵能力。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Имея одну ногу в смертной плоскости и другую в потустороннем мире, медиумы обладают уникальными духовными способностями.";
}
        Invoke("secretend10", 6f);
    }
    public void secretend10()
    {
if(idioma == "ingles")
{
    tx1.text = "Hence the ability of your family to purify curses.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "De ahi la habilidad de tu familia de purificar maldiciones.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "D ou vient la capacite de ta famille a purifier les maledictions.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Daher die Fähigkeit deiner Familie, Fluche zu reinigen.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Da qui la capacita della tua famiglia di purificare le maledizioni.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Dai a habilidade da sua familia de purificar maldicoes.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "ここから、あなたの家族が呪いを浄化する能力があるのです。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "그래서 너희 가족은 저주를 정화하는 능력을 가지게 된 것이다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "这就是你家族拥有净化诅咒的能力的原因。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Отсюда способность твоей семьи очищать проклятия.";
}
        Invoke("secretend11", 4f);
    }
    public void secretend11()
    {
if(idioma == "ingles")
{
    tx1.text = "Mediums, you bear the punishment despite having been the very victims of my sin; you bear the loneliness of not fitting into the human race.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Los mediums cargais con el castigo pese a haber sido la propia victima de mi pecado, cargais con la soledad de no encajar en la raza humana.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Vous, mediums, portez le chatiment malgre avoir ete les victimes memes de mon peche; vous portez la solitude de ne pas appartenir a la race humaine.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Medien, ihr tragt die Strafe, obwohl ihr selbst die Opfer meiner Sunde wart; ihr tragt die Einsamkeit, nicht in die Menschheit zu passen.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Medium, portate il castigo nonostante siate stati le stesse vittime del mio peccato; portate la solitudine di non appartenere alla razza umana.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Mediuns, carregais com o castigo apesar de ter sido a propria vitima do meu pecado; carregais com a solidao de nao se encaixar na raca humana.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "ミディアムの皆さん、私の罪の犠牲者であったにもかかわらず、罰を背負い、人間の種に馴染めない孤独を背負っています。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "무당들이여, 너희는 내 죄의 희생자가 되었음에도 벌을 짊어지고, 인간 사회에 맞지 않는 외로움을 지니고 있다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "通灵者们，尽管你们曾是我罪行的受害者，却仍承担着惩罚，承受着无法融入人类世界的孤独。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Медиумы, вы несёте наказание, несмотря на то, что были жертвами моего греха; вы несёте одиночество от того, что не вписываетесь в человеческую расу.";
}
        Invoke("secretend12", 7f);
    }
    public void secretend12()
    {
if(idioma == "ingles")
{
    tx1.text = "If it is revenge you long for, then go on—banish my body to the hell where it belongs, I dare you.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Si es venganza lo que anhelas, adelante, destierra mi cuerpo al infierno donde pertenece, te reto a ello.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Si c est la vengeance que tu desires, alors vas‑y — bannis mon corps en enfer, la ou il appartient, je te mets au defi.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Wenn es Rache ist, wonach du dich sehnst, dann nur zu — verbanne meinen Korper in die Holle, wo er hingehort. Ich fordere dich heraus.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Se e la vendetta cio che brami, avanti — esilia il mio corpo all inferno dove appartiene, ti sfido a farlo.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Se e vinganca o que desejas, entao va em frente — exile meu corpo ao inferno onde ele pertence, eu te desafio.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "もし復讐を望むのなら、さあ行け——私の身体を本来あるべき地獄へ追放するがいい。挑んでみろ。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "복수를 바란다면, 좋아 — 내 몸을 마땅히 있어야 할 지옥으로 추방해라. 너에게 도전한다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "如果你渴望的是复仇，那就来吧——把我的身体放逐到它本该所在的地狱。我向你挑战。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Если ты жаждешь мести — вперёд, низвергни моё тело в ад, где ему и место. Я бросаю тебе вызов.";
}
        Invoke("secretend13", 6f);
    }
    public void secretend13()
    {
if(idioma == "ingles")
{
    tx1.text = "I'll be waiting for you.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "español")
{
    tx1.text = "Te espero.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "frances")
{
    tx1.text = "Je t attendrai.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "aleman")
{
    tx1.text = "Ich werde auf dich warten.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "italiano")
{
    tx1.text = "Ti aspettero.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "portugues")
{
    tx1.text = "Eu vou te esperar.";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "japones")
{
    tx1.text = "";
    tx2.text = "待っている。";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "coreano")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "기다리고 있겠다.";
    tx4.text = "";
    tx5.text = "";
}
if(idioma == "chino")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "我会等你。";
    tx5.text = "";
}
if(idioma == "ruso")
{
    tx1.text = "";
    tx2.text = "";
    tx3.text = "";
    tx4.text = "";
    tx5.text = "Я буду ждать тебя.";
}
        Invoke("secretend14", 5f);
    }
    public void secretend14()
    {
      thg.SetActive(false);
credits.SetActive(true);
     audioSource3x.clip = null;
Invoke("cnx3", 35f);
    }
   public void pay1()
   {
        texm = true;
     textorder = -10;
   }
   public void pay2()
   {
    cer2.SetTrigger("ser2");
Invoke("Badend7", 5f);
   }
   public void shoppx1()
   {
    texm = true;
    textorder = 88;
   }
   public void shoppx()
   {
    texm = true;
    textorder = 78;
   }
   public void shopp2()
   {
    texm = true;
    textorder = 117;
   }
   public void shop1x()
   {
    texm = true;
    arming2 = false;
    if(opi == false)
    {
    vanim.SetTrigger("feliz1");
    opi = true;
    }
    textorder = 14;
if(idioma == "ingles")
{
    textoq.text = "Vendor?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor?";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手？";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자?";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家？";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец?";
}
   }
   public void shop2x()
   {
    texm = true;
    textorder = 35;
    arming2 = false;
   }
      public void shop4xxx()
   {
    texm = true;
    textorder = 84;
    armingg = false;
   }
   public void shop4xx()
   {
    texm = true;
    textorder = 84;
    armingg = false;
   }
      public void shop4x()
   {
    texm = true;
    textorder = 55;
    armingg = false;
   }
   public void shop5x()
   {
    texm = true;
    textorder = 70;
    armingg = false;
   }
   public void shop3x()
   {
if(idioma == "ingles")
{
    textoq.text = "Vendor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "español")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "frances")
{
    textoq.text = "Vendeur";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "aleman")
{
    textoq.text = "Verkaufer";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "italiano")
{
    textoq.text = "Venditore";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "portugues")
{
    textoq.text = "Vendedor";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "japones")
{
    textoq.text = "";
    textojq.text = "売り手";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "coreano")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "판매자";
    textocq.text = "";
    textorq.text = "";
}
if(idioma == "chino")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "卖家";
    textorq.text = "";
}
if(idioma == "ruso")
{
    textoq.text = "";
    textojq.text = "";
    textokq.text = "";
    textocq.text = "";
    textorq.text = "Продавец";
}
    texm = true;
    textorder = 45;
    arming2 = false;
   }
   public void sell2()
   {
    arming = false;
    arming2 = true;
        Invoke("sell3", 0.7f);
   }
   public void sell3()
   {
    arming2 = false;
    arm.SetActive(false);
   }
   public void in11()
   {
         fdt.clip = null;
        fdt.PlayOneShot(hit2);
   }
   public void in1()
   {
   arming = false;
   targetFOV = 60;
   arming3 = false;
   arming2 = true;
    if(opi == false)
    {
    vanim.SetTrigger("feliz2");
    opi = true;
    }
        Invoke("in2", 3f);
   }
   public void in2()
   {
   textorder = 39;
   cls = false;
   texm = true;
   invk.SetActive(false);
   traga.SetActive(true);
   arming2 = false;
   }
   public void in3()
   {
   arming = false;
   arming3 = false;
   arming2 = true;
        Invoke("in4", 3f);
   }
   public void in4()
   {
   arming2 = false;
      textorder = 41;
   texm = true;
   }
   public void sell4()
   {
   texm = true;
   textorder = 29;
   }
   public void sellx()
   {
        fdt.PlayOneShot(hit);
        imp2.SetActive(true);
   }
   public void O1()
   {
           crd2.SetTrigger("x1");
    audioSource.PlayOneShot(cardd);
   }
   public void O22()
   {
wtn = true;
         if(xbox == false && playst == false)
         {
if(idioma == "ingles")
{
    textoa.text = "Ready <sprite name=\"E\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "español")
{
    textoa.text = "Listo <sprite name=\"E\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "frances")
{
    textoa.text = "Pret <sprite name=\"E\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "aleman")
{
    textoa.text = "Bereit <sprite name=\"E\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "italiano")
{
    textoa.text = "Pronto <sprite name=\"E\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "portugues")
{
    textoa.text = "Pronto <sprite name=\"E\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "japones")
{
    textoa.text = "";
    textoja.text = "準備完了 <sprite name=\"E\">";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "coreano")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "준비 완료 <sprite name=\"E\">";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "chino")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "准备就绪 <sprite name=\"E\">";
    textora.text = "";
}
if(idioma == "ruso")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "Готово <sprite name=\"E\">";
}
         }

         if(xbox == true && playst == false)
         {
if(idioma == "ingles")
{
    textoa.text = "Ready <sprite name=\"A\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "español")
{
    textoa.text = "Listo <sprite name=\"A\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "frances")
{
    textoa.text = "Pret <sprite name=\"A\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "aleman")
{
    textoa.text = "Bereit <sprite name=\"A\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "italiano")
{
    textoa.text = "Pronto <sprite name=\"A\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "portugues")
{
    textoa.text = "Pronto <sprite name=\"A\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "japones")
{
    textoa.text = "";
    textoja.text = "準備完了 <sprite name=\"A\">";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "coreano")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "준비 완료 <sprite name=\"A\">";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "chino")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "准备就绪 <sprite name=\"A\">";
    textora.text = "";
}
if(idioma == "ruso")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "Готово <sprite name=\"A\">";
}
         }
         if(xbox == false && playst == true)
         {
if(idioma == "ingles")
{
    textoa.text = "Ready <sprite name=\"pixel_art_small\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "español")
{
    textoa.text = "Listo <sprite name=\"pixel_art_small\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "frances")
{
    textoa.text = "Pret <sprite name=\"pixel_art_small\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "aleman")
{
    textoa.text = "Bereit <sprite name=\"pixel_art_small\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "italiano")
{
    textoa.text = "Pronto <sprite name=\"pixel_art_small\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "portugues")
{
    textoa.text = "Pronto <sprite name=\"pixel_art_small\">";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "japones")
{
    textoa.text = "";
    textoja.text = "準備完了 <sprite name=\"pixel_art_small\">";
    textoka.text = "";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "coreano")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "준비 완료 <sprite name=\"pixel_art_small\">";
    textoca.text = "";
    textora.text = "";
}
if(idioma == "chino")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "准备就绪 <sprite name=\"pixel_art_small\">";
    textora.text = "";
}
if(idioma == "ruso")
{
    textoa.text = "";
    textoja.text = "";
    textoka.text = "";
    textoca.text = "";
    textora.text = "Готово <sprite name=\"pixel_art_small\">";
}
         }
   }
   public void O3()
   {
   freeze = false;
           rbd.constraints = RigidbodyConstraints.FreezeRotation;
cm.crd = false;
wtn = false;
   }
   public void O2()
   {
    audioSource.PlayOneShot(cardf);
           crd.SetTrigger("down");
   if(cardi.c1 != 22 && cardi.c2 != 22 && cardi.c3 != 22 && cardi.c4 != 22 && cardi.c5 != 22)
   {
        Invoke("O3", 1f);
   }
   if(cardi.c1 == 22 || cardi.c2 == 22 || cardi.c3 == 22 || cardi.c4 == 22 || cardi.c5 == 22)
   {
        Invoke("jdg", 5f);
   }

   }
   public void jdg()
   {
    penta.SetActive(false);
arming2 = false;
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
     audioSourcex.clip = null;
           blood1.SetActive(false);
           blood2.SetActive(false);
           blood3.SetActive(false);
           blood4.SetActive(false);
           blood5.SetActive(false);
           blood6.SetActive(false);
           blood7.SetActive(false);
           blood8.SetActive(false);
         audioSource3x.clip = jsc2;
        Invoke("gameover", 1f);
        llor.SetActive(false);
        copy.SetActive(false);
        lant.SetActive(false);
        freeze = true;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        jmpscare.SetActive(true);
        transform.rotation = Quaternion.Euler(transform.rotation.x, 0f, transform.rotation.z);
        camara.transform.rotation = Quaternion.Euler(camara.transform.rotation.x, 0f, camara.transform.rotation.z);
   }
   public void mus()
   {
  if(!gameo.activeInHierarchy && mexico == false)
  {
     audioSource.clip = tns;
     audioSource.loop = true;
  }
   }
}
