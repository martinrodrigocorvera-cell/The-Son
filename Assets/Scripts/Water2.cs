using UnityEngine;

public class Water2 : MonoBehaviour
{
    public Transform thr;
    public GameObject thr2;
    public Transform hly;
    public Transform rtn;
        public Transform rtn2;
    public GameObject part;
    public Transform part2;
    public GameObject hly2;
    public GameObject hly3;
    public AudioSource audio;
    public AudioClip gls;
    public AudioClip eff;
    public Clock cl;
    public Llorona llor;
    public GameObject event1;
    public GameObject event2;
public GameObject event3;
public GameObject event4;
public GameObject event5;
public GameObject event6;
public GameObject event7;
public GameObject event8;
public Player play;
public string impc;
public GameObject chase;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
void OnCollisionStay(Collision collision)
{
    part2.SetParent(null);
part2.position = rtn2.transform.position;
    part.SetActive(true);
    part2.SetParent(null);
  Invoke("x1", 0.5f);
    thr2.SetActive(false);
    audio.PlayOneShot(gls);
          thr.SetParent(hly);
    hly2.SetActive(false);
    hly3.SetActive(true);
}

void OnCollisionEnter(Collision collision)
{

    if (collision.gameObject.CompareTag("candles"))
    {
    audio.PlayOneShot(eff);
    cl.power += 3;
    }
    if (collision.gameObject.CompareTag("chase"))
    {
    audio.PlayOneShot(eff);
    chase.SetActive(false);
    }
    if (collision.gameObject.CompareTag("falsona"))
    {
    audio.PlayOneShot(eff);
    play.falsy = true;
    }
    if (collision.gameObject.CompareTag("trapy2"))
    {
    audio.PlayOneShot(eff);
    play.falsy2 = true;
    }
    if (collision.gameObject.CompareTag("llorona"))
    {
    llor = collision.gameObject.GetComponent<Llorona>();
    audio.PlayOneShot(eff);
    llor.prf = true;
    }
    if (collision.gameObject.CompareTag("trapp"))
    {
    audio.PlayOneShot(eff);
if (collision.transform.parent.CompareTag("trapp"))
{
    collision.transform.parent.parent.gameObject.SetActive(false);
}
if (collision.transform.parent.CompareTag("Untagged"))
{
    collision.gameObject.SetActive(false);
}
    }
    if (collision.gameObject.CompareTag("porty"))
    {
    audio.PlayOneShot(eff);
    collision.transform.parent.gameObject.SetActive(false);
    }
    if (collision.gameObject.CompareTag("tragy"))
    {
    audio.PlayOneShot(eff);
    collision.transform.gameObject.SetActive(false);
            PlayerPrefs.SetFloat("Slot", 1f);
            PlayerPrefs.Save();
    play.btl4 = true;
    }
    if (collision.gameObject.CompareTag("miray2"))
    {
    play.freeze = true;
    play.rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
    play.texm = true;
        play.textorder = 174;
    }
    if (collision.gameObject.CompareTag("miray"))
    {
    play.freeze = true;
    play.rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
    play.texm = true;
        play.textorder = 178;
    }

    if (collision.gameObject.CompareTag("vendy2"))
    {
    play.freeze = true;
    play.rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
    play.texm = true;
        play.textorder = 176;
    }

    if (collision.gameObject.CompareTag("vendy"))
    {
    play.freeze = true;
    play.rbd.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
    play.texm = true;
    if(play.night == 2)
    {
        play.textorder = 162;
    }
    if(play.night == 3)
    {
        if(play.slot == 0)
        {
        play.textorder = 164;
        }
        if(play.slot == 1)
        {
        play.textorder = 166;
        }
    }
    if(play.night == 4)
    {
    play.textorder = 168;
    }
    if(play.night == 5)
    {
    play.textorder = 170;
    }
    if(play.night == 6)
    {
    play.textorder = 172;
    }
    }
    if (collision.gameObject.CompareTag("porty2"))
    {
    audio.PlayOneShot(eff);
    collision.transform.parent.gameObject.SetActive(false);
    play.btl2 = true;
    }
    if (collision.gameObject.CompareTag("ojjo"))
    {
    audio.PlayOneShot(eff);
    collision.gameObject.SetActive(false);
    }
    if (collision.gameObject.CompareTag("kitchen"))
    {
if(event1.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "cocina";
    play.btl = true;
    event1.SetActive(false);
}
    }
        if (collision.gameObject.CompareTag("basement"))
    {
if(event2.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "sotano";
    play.btl = true;
    event2.SetActive(false);
}
    }
        if (collision.gameObject.CompareTag("bath1"))
    {
if(event3.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "baño1";
    play.btl = true;
    event3.SetActive(false);
}
    }
        if (collision.gameObject.CompareTag("bath2"))
    {
if(event4.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "baño2";
    play.btl = true;
    event4.SetActive(false);
}
    }
        if (collision.gameObject.CompareTag("office"))
    {
if(event5.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "oficina";
    play.btl = true;
    event5.SetActive(false);
}
    }
        if (collision.gameObject.CompareTag("mine"))
    {
if(event6.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "micuarto";
    play.btl = true;
    event6.SetActive(false);
}
    }
        if (collision.gameObject.CompareTag("guest"))
    {
if(event7.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "invitados";
    play.btl = true;
    event7.SetActive(false);
}
    }
        if (collision.gameObject.CompareTag("salon"))
    {
if(event8.activeInHierarchy)
{
    audio.PlayOneShot(eff);
    impc = "salon";
    play.btl = true;
    event8.SetActive(false);
}
    }
}
public void x1()
{
    transform.position = rtn.transform.position;
    part.SetActive(false);
    part2.SetParent(thr);
}
}
