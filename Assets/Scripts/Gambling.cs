using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Gambling : MonoBehaviour
{
    public Rigidbody rbd;
    public Player play;
    public bool intering;
    public bool xbox;
    public bool dis;
    public bool playst;
    public string idioma;
public TMP_Text texto2;
public TMP_Text textoj2;
public TMP_Text textok2;
public TMP_Text textoc2;
public TMP_Text textor2;
public bool freeze;
public Clock cl;
public Camera cam;
public Camera cam2;
public float targetFOV;
public float speed = 5f;
public Animator r1;
public Animator r2;
public Animator r3;
public bool cls;
public Animator pal;
public float pow;
public string rueda1;
public string rueda2;
public string rueda3;
public float c1;
public float c2;
public float c3;
public float c4;
public float c5;
public float c6;
public float c7;
public GameObject ruedax;
public GameObject ruedaxx;
public GameObject ruedaxxx;
public float rng;
public string result;
public GameObject six;
public GameObject sixx;
public GameObject sixxx;
public GameObject L1;
public GameObject L2;
public GameObject L3;
public GameObject L4;
public GameObject L5;
public GameObject L6;
public GameObject L7;
public GameObject L8;
public GameObject L9;
public GameObject L10;
public GameObject L11;
public GameObject L12;
public GameObject L13;
public bool rd1;
public bool rd2;
public bool rd3;
public int rng2;
public Animator mach;
public Animator lz;
public bool dere;
public GameObject player;
public bool izq;
public bool cent;
public bool up;
public GameObject kill;
public GameObject pay1;
public GameObject pay2;
public GameObject pay3;
public GameObject floor;
public bool upup;
public Animator cer;
public float velocidad = 1000f;
public AudioClip pl;
public AudioClip spn;
public AudioClip jck;
public AudioClip chs;
public AudioSource audioSource;
public AudioSource audioSource2;
public GameObject vnd;
public AudioClip hit;
public AudioClip lg;
public AudioClip imp;
public AudioClip trb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    pow = cl.power;
    idioma = play.idioma;
    xbox = play.xbox;
    playst = play.playst;
freeze = play.freeze;
    if(cls == true)
    {
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, targetFOV, Time.deltaTime * speed);
        cam2.fieldOfView = Mathf.Lerp(cam.fieldOfView, targetFOV, Time.deltaTime * speed);
    }
    if(dere == true)
    {
        float speedz = 4;
        Quaternion targetRotation = Quaternion.Euler(0, 45, 0);

        player.transform.rotation = Quaternion.Lerp(
            player.transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
    }
    if(izq == true)
    {
        float speedz = 4;
        Quaternion targetRotation = Quaternion.Euler(0, -45, 0);

        player.transform.rotation = Quaternion.Lerp(
            player.transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
    }
    if(cent == true)
    {
        float speedz = 4;
        Quaternion targetRotation = Quaternion.Euler(0, 0, 0);

        player.transform.rotation = Quaternion.Lerp(
            player.transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
    }
    if(up == true)
    {
        float speedz = 2;
        Quaternion targetRotation = Quaternion.Euler(-10, 0, 0);

        player.transform.rotation = Quaternion.Lerp(
            player.transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
    }
    if(upup == true)
    {
        float speedz = 2;
        Quaternion targetRotation = Quaternion.Euler(-90, 0, 0);

        player.transform.rotation = Quaternion.Lerp(
            player.transform.rotation,
            targetRotation,
            Time.deltaTime * speedz
        );
    }
    if(rd1 == true)
    {
        ruedax.transform.Rotate(velocidad * Time.deltaTime, 0f, 0f);
    }
    if(rd2 == true)
    {
        ruedaxx.transform.Rotate(velocidad * Time.deltaTime, 0f, 0f);
    }
    if(rd3 == true)
    {
        ruedaxxx.transform.Rotate(velocidad * Time.deltaTime, 0f, 0f);
    }
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && dis == false && freeze == false)
              {
           r1.SetTrigger("st2");
           r2.SetTrigger("st2");
           r3.SetTrigger("st2");
                 c1 = 0;
                 c2 = 0;
                 c3 = 0;
                 c4 = 0;
                 c5 = 0;
                 c6 = 0;
                 c7 = 0;
                 dis = true;
                 targetFOV = 30;
        audioSource.PlayOneShot(pl);
                  cl.power = cl.power - 2;
                  freeze = true;
                  play.freeze = freeze;
           pal.SetTrigger("p1");
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
        Invoke("sp", 0.5f);
        Invoke("s", 0.4f);
              }
    if(intering == true && dis == false)
    {
if(playst == true)
{
if(idioma == "ingles")
{
    texto2.text = "pull the lever <sprite name=\"pixel_art_small\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "español")
{
    texto2.text = "tirar de la palanca <sprite name=\"pixel_art_small\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "frances")
{
    texto2.text = "tirer la levier <sprite name=\"pixel_art_small\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "aleman")
{
    texto2.text = "den Hebel ziehen <sprite name=\"pixel_art_small\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "italiano")
{
    texto2.text = "tirare la leva <sprite name=\"pixel_art_small\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "portugues")
{
    texto2.text = "puxar a alavanca <sprite name=\"pixel_art_small\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "japones")
{
    texto2.text = "";
    textoj2.text = "レバーを引く <sprite name=\"pixel_art_small\">";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "coreano")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "레버를 당기기  <sprite name=\"pixel_art_small\">";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "chino")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "拉下拉杆 <sprite name=\"pixel_art_small\">";
    textor2.text = "";
}
if(idioma == "ruso")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "дернуть рычаг <sprite name=\"pixel_art_small\">";
}
}
if(xbox == true)
{
if(idioma == "ingles")
{
    texto2.text = "pull the lever <sprite name=\"A\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "español")
{
    texto2.text = "tirar de la palanca <sprite name=\"A\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "frances")
{
    texto2.text = "tirer la levier <sprite name=\"A\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "aleman")
{
    texto2.text = "den Hebel ziehen <sprite name=\"A\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "italiano")
{
    texto2.text = "tirare la leva <sprite name=\"A\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "portugues")
{
    texto2.text = "puxar a alavanca <sprite name=\"A\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "japones")
{
    texto2.text = "";
    textoj2.text = "レバーを引く <sprite name=\"A\">";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "coreano")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "레버를 당기기  <sprite name=\"A\">";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "chino")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "拉下拉杆 <sprite name=\"A\">";
    textor2.text = "";
}
if(idioma == "ruso")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "дернуть рычаг <sprite name=\"A\">";
}
}
if(playst == false && xbox == false)
{
if(idioma == "ingles")
{
    texto2.text = "pull the lever <sprite name=\"E\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "español")
{
    texto2.text = "tirar de la palanca <sprite name=\"E\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "frances")
{
    texto2.text = "tirer la levier <sprite name=\"E\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "aleman")
{
    texto2.text = "den Hebel ziehen <sprite name=\"E\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "italiano")
{
    texto2.text = "tirare la leva <sprite name=\"E\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "portugues")
{
    texto2.text = "puxar a alavanca <sprite name=\"E\">";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "japones")
{
    texto2.text = "";
    textoj2.text = "レバーを引く <sprite name=\"E\">";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "coreano")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "레버를 당기기  <sprite name=\"E\">";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "chino")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "拉下拉杆 <sprite name=\"E\">";
    textor2.text = "";
}
if(idioma == "ruso")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "дернуть рычаг <sprite name=\"E\">";
}
}
    }
    }
void sp()
{
        cls = true;
}
void s()
{
     audioSource.clip = spn;
     audioSource.loop = true;
     audioSource.Play();
           pal.SetTrigger("p2");
           lz.SetTrigger("spin");
           rd1 = true;
           rd2 = true;
           rd3 = true;
        if(pow >= 1)
        {
        Invoke("w1", 1f);
        }
        if(pow <= 0)
        {
        Invoke("wp1", 1f);
        }
}
public void wp1()
{
        audioSource.PlayOneShot(chs);
           lz.SetTrigger("spin2");
rd1 = false;
ruedax.transform.eulerAngles = new Vector3(640f, -180f, 0f);
six.SetActive(false);
pay1.SetActive(true);
        Invoke("wp2", 0.5f);
}
public void wp2()
{
        audioSource.PlayOneShot(chs);
rd2 = false;
ruedaxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
sixx.SetActive(false);
pay2.SetActive(true);
        Invoke("wp3", 0.5f);
}
public void wp3()
{
        audioSource.PlayOneShot(chs);
rd3 = false;
ruedaxxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
sixxx.SetActive(false);
pay3.SetActive(true);
        Invoke("wp4", 1f);
     audioSource.clip = null;
}
public void wp4()
{
speed = 10;
targetFOV = 60;
play.verticalVelocity = 0;
upup = true;
floor.SetActive(false);
        Invoke("wp5", 1.5f);
}
public void wp5()
{
           cer.SetTrigger("ser");
}
public void w1()
{
        audioSource.PlayOneShot(chs);
           lz.SetTrigger("spin2");
           lz.SetTrigger("chos");
rd1 = false;
rng = Random.value;
if(rng <= 0.3f)
{
rueda1 = "pent";
ruedax.transform.eulerAngles = new Vector3(490f, -180f, 0f);
}
if(rng >= 0.31f && rng <= 0.52f)
{
rueda1 = "dem";
ruedax.transform.eulerAngles = new Vector3(370f, -180f, 0f);
}
if(rng >= 0.53f && rng <= 0.69f)
{
rueda1 = "murc";
ruedax.transform.eulerAngles = new Vector3(180f, -180f, 0f);
}
if(rng >= 0.7f && rng <= 0.82f)
{
rueda1 = "ara";
ruedax.transform.eulerAngles = new Vector3(330f, -180f, 0f);
}
if(rng >= 0.83f && rng <= 0.89f)
{
rueda1 = "ojo";
ruedax.transform.eulerAngles = new Vector3(70f, -180f, 0f);
}
if(rng >= 0.9f && rng <= 0.95f)
{
rueda1 = "mort";
ruedax.transform.eulerAngles = new Vector3(230f, -180f, 0f);
}
if(rng >= 0.96f && rng <= 1)
{
rueda1 = "jack";
ruedax.transform.eulerAngles = new Vector3(640f, -180f, 0f);
}
        Invoke("w2", 0.5f);
}




public void w2()
{
        audioSource.PlayOneShot(chs);
rd2 = false;
rng = Random.value;
rng2 = Random.Range(1, 5);
if(rng2 == 1)
{
if(rueda1 == "pent")
{
rueda2 = "pent";
ruedax.transform.eulerAngles = new Vector3(490f, -180f, 0f);
}
if(rueda1 == "dem")
{
rueda2 = "dem";
ruedaxx.transform.eulerAngles = new Vector3(370f, -180f, 0f);
}
if(rueda1 == "murc")
{
rueda2 = "murc";
ruedaxx.transform.eulerAngles = new Vector3(180f, -180f, 0f);
}
if(rueda1 == "ara")
{
rueda2 = "ara";
ruedaxx.transform.eulerAngles = new Vector3(330f, -180f, 0f);
}
if(rueda1 == "ojo")
{
rueda2 = "ojo";
ruedaxx.transform.eulerAngles = new Vector3(70f, -180f, 0f);
}
if(rueda1 == "mort")
{
rueda2 = "mort";
ruedaxx.transform.eulerAngles = new Vector3(230f, -180f, 0f);
}
if(rueda1 == "jack")
{
rueda2 = "jack";
ruedaxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
}
}
if(rng2 == 2 || rng2 == 3 || rng2 == 4)
{
if(rng <= 0.3f)
{
rueda2 = "pent";
ruedaxx.transform.eulerAngles = new Vector3(490f, -180f, 0f);
}
if(rng >= 0.31f && rng <= 0.52f)
{
rueda2 = "dem";
ruedaxx.transform.eulerAngles = new Vector3(370f, -180f, 0f);
}
if(rng >= 0.53f && rng <= 0.69f)
{
rueda2 = "murc";
ruedaxx.transform.eulerAngles = new Vector3(180f, -180f, 0f);
}
if(rng >= 0.7f && rng <= 0.82f)
{
rueda2 = "ara";
ruedaxx.transform.eulerAngles = new Vector3(330f, -180f, 0f);
}
if(rng >= 0.83f && rng <= 0.89f)
{
rueda2 = "ojo";
ruedaxx.transform.eulerAngles = new Vector3(70f, -180f, 0f);
}
if(rng >= 0.9f && rng <= 0.95f)
{
rueda2 = "mort";
ruedaxx.transform.eulerAngles = new Vector3(230f, -180f, 0f);
}
if(rng >= 0.96f && rng <= 1)
{
rueda2 = "jack";
ruedaxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
}
}
        Invoke("w3", 0.5f);
}


public void w3()
{
        audioSource.PlayOneShot(chs);
rd3 = false;
rng = Random.value;
if(rng <= 0.3f)
{
rueda3 = "pent";
ruedaxxx.transform.eulerAngles = new Vector3(490f, -180f, 0f);
}
if(rng >= 0.31f && rng <= 0.52f)
{
rueda3 = "dem";
ruedaxxx.transform.eulerAngles = new Vector3(370f, -180f, 0f);
}
if(rng >= 0.53f && rng <= 0.69f)
{
rueda3 = "murc";
ruedaxxx.transform.eulerAngles = new Vector3(180f, -180f, 0f);
}
if(rng >= 0.7f && rng <= 0.82f)
{
rueda3 = "ara";
ruedaxxx.transform.eulerAngles = new Vector3(330f, -180f, 0f);
}
if(rng >= 0.83f && rng <= 0.89f)
{
rueda3 = "ojo";
ruedaxxx.transform.eulerAngles = new Vector3(70f, -180f, 0f);
}
if(rng >= 0.9f && rng <= 0.95f)
{
rueda3 = "mort";
ruedaxxx.transform.eulerAngles = new Vector3(230f, -180f, 0f);
}
if(rng >= 0.96f && rng <= 1)
{
rueda3 = "jack";
ruedaxxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
}
        Invoke("w4", 0.5f);
     audioSource.clip = null;
}
public void w4()
{
     audioSource.clip = spn;
     audioSource.loop = true;
     audioSource.Play();
           lz.SetTrigger("chos2");
           lz.SetTrigger("spin");
           rd1 = true;
           rd2 = true;
           rd3 = true;
if((rueda1 != rueda2) || (rueda2 != rueda3))
{
result = "lost";
}

if(rueda1 == "pent" && rueda2 == "pent" && rueda3 == "pent")
{
result = "pent";
cl.power = cl.power + 5;
}
if(rueda1 == "murc" && rueda2 == "murc" && rueda3 == "murc")
{
result = "murc";
cl.power = cl.power + 15;
}
if(rueda1 == "ojo" && rueda2 == "ojo" && rueda3 == "ojo")
{
result = "ojo";
cl.power = cl.power + 25;
}
if(rueda1 == "ara" && rueda2 == "ara" && rueda3 == "ara")
{
result = "ara";
cl.power = cl.power + 20;
}
if(rueda1 == "dem" && rueda2 == "dem" && rueda3 == "dem")
{
result = "dem";
cl.power = cl.power + 10;
}
if(rueda1 == "mort" && rueda2 == "mort" && rueda3 == "mort")
{
result = "mort";
}
if(rueda1 == "jack" && rueda2 == "jack" && rueda3 == "jack")
{
result = "jack";
cl.power = cl.power + 50;
}
        Invoke("w5", 1f);
}
public void w5()
{
           lz.SetTrigger("spin2");
        audioSource.PlayOneShot(chs);
rd1 = false;
ruedax.transform.eulerAngles = new Vector3(640f, -180f, 0f);
six.SetActive(false);
if(result == "lost")
{
L1.SetActive(true);
}
if(result == "pent")
{
L2.SetActive(true);
}
if(result == "jack")
{
L2.SetActive(true);
}
if(result == "ojo")
{
L2.SetActive(true);
}
if(result == "murc")
{
L2.SetActive(true);
}
if(result == "ara")
{
L2.SetActive(true);
}
if(result == "dem")
{
L2.SetActive(true);
}
if(result == "mort")
{
L3.SetActive(true);
}
        Invoke("w6", 0.5f);
}
public void w6()
{
        audioSource.PlayOneShot(chs);
rd2 = false;
ruedaxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
sixx.SetActive(false);
if(result == "lost")
{
L4.SetActive(true);
}
if(result == "pent")
{
L5.SetActive(true);
}
if(result == "jack")
{
L8.SetActive(true);
}
if(result == "ojo")
{
L7.SetActive(true);
}
if(result == "murc")
{
L6.SetActive(true);
}
if(result == "ara")
{
L7.SetActive(true);
}
if(result == "dem")
{
L6.SetActive(true);
}
if(result == "mort")
{
L9.SetActive(true);
}
        Invoke("w7", 0.5f);
}
public void w7()
{
        audioSource.PlayOneShot(chs);
rd3 = false;
           r3.SetTrigger("sp2");
ruedaxxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
sixxx.SetActive(false);
if(result == "lost")
{
L10.SetActive(true);
}
if(result == "pent")
{
L11.SetActive(true);
}
if(result == "jack")
{
L12.SetActive(true);
}
if(result == "ojo")
{
L11.SetActive(true);
}
if(result == "murc")
{
L11.SetActive(true);
}
if(result == "ara")
{
L12.SetActive(true);
}
if(result == "dem")
{
L12.SetActive(true);
}
if(result == "mort")
{
L13.SetActive(true);
}
      if(result != "mort")
      {
        Invoke("w8", 0.5f);
      }
      if(result == "mort")
      {
        Invoke("wmort", 2f);
      }
     audioSource.clip = null;
     audioSource2.clip = jck;
     audioSource2.loop = false;
     audioSource2.Play();
}
public void wmort()
{
        audioSource.PlayOneShot(trb);
           mach.SetTrigger("mons");
                 targetFOV = 60;
vnd.SetActive(false);
        Invoke("wmort2", 2.5f);
}
public void wmort2()
{
        audioSource.PlayOneShot(hit);
dere = true;
        Invoke("wmort3", 0.33f);
}
public void wmort3()
{
        audioSource.PlayOneShot(hit);
dere = false;
izq = true;
        Invoke("wmort4", 0.5f);

}
public void wmort4()
{
        audioSource.PlayOneShot(lg);
izq = false;
cent = true;
        Invoke("wmort5", 0.5f);

}
public void wmort5()
{
        audioSource.PlayOneShot(imp);
cent = false;
up = true;
        Invoke("wmort6", 3.4f);
}
public void wmort6()
{
    kill.SetActive(true);
}
public void w8()
{
     audioSource.clip = spn;
     audioSource.loop = true;
     audioSource.Play();
           lz.SetTrigger("spin");
           pal.SetTrigger("p3");
                 targetFOV = 60;
           rd1 = true;
           rd2 = true;
           rd3 = true;
        Invoke("w9", 0.5f);
        Invoke("w10", 1f);
}
public void w9()
{
           pal.SetTrigger("p4");
}
public void w10()
{
           rd1 = false;
           rd2 = false;
           rd3 = false;
           lz.SetTrigger("spin2");
ruedaxxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
ruedax.transform.eulerAngles = new Vector3(640f, -180f, 0f);
ruedaxx.transform.eulerAngles = new Vector3(640f, -180f, 0f);
six.SetActive(true);
sixx.SetActive(true);
sixxx.SetActive(true);
L1.SetActive(false);
L2.SetActive(false);
L3.SetActive(false);
L4.SetActive(false);
L5.SetActive(false);
L6.SetActive(false);
L7.SetActive(false);
L8.SetActive(false);
L9.SetActive(false);
L10.SetActive(false);
L11.SetActive(false);
L12.SetActive(false);
L13.SetActive(false);
                  freeze = false;
                  play.freeze = freeze;
        rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
cls = false;
dis = false;
     audioSource.clip = null;
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
    intering = false;
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
}
