using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.Video;

public class Llorona : MonoBehaviour
{
[Range(0f, 1f)] public float probabilidad = 0.1f;
[Range(0f, 1f)] public float probabilidad2 = 0.15f;
[Range(0f, 1f)] public float probabilidad3 = 0.2f;
    public CharacterController cc;
    public GameObject e1;
    public bool ññk;
    public bool ñas;
    public bool ññp;
    public bool hgu;
    public bool idk;
    public GameObject e2;
    public GameObject e3;
    public GameObject e4;
    public GameObject e5;
    public GameObject e6;
    public GameObject e7;
    public GameObject e8;
    public GameObject intx;
    public float hour;
    public GameObject playerxxx;
    public Transform player;
    public float visionDistance = 100f;
    public LayerMask obstructionMask;
    public float forceStrength;
    public Rigidbody rb;
    private Vector3 lastPosition;
    public float stillThreshold = 0.05f; 
    public float wanderRadius = 10f;
    public float wanderTimer;
    public Vector3 destino;
    public NavMeshAgent agent;
    public float timer;
    public int mode;
    public Clock clock;
    public Player play;
    public bool safe;
    public float night;
    public string d2;
    public int rng;
    public string loc;
    public Transform sal;
    public Transform ba1;
    public Transform coc;
    public Transform sot;
    public Transform inv;
    public Transform ba2;
    public Transform of;
    public Transform mi;
    public string spawn;
    public bool x;
    public bool y;
    public bool hear;
    public bool see;
    public GameObject lightx;
    public string ubi;
    public GameObject blood1;
    public GameObject blood2;
    public GameObject blood3;
    public GameObject blood4;
    public GameObject blood5;
    public GameObject blood6;
    public GameObject blood7;
    public GameObject blood8;
    public float events;
    public bool tut;
    public float jkl;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioClip wlk;
    public AudioClip wlk2;
    public AudioClip scr;
    public AudioClip pers;
    public bool hj;
    public GameObject cam;
    public GameObject stat;
    public bool spawned;
    public EffectFeature ef;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public bool idk2;
    public GameObject t5;
    public GameObject t6;
    public GameObject t7;
    public GameObject t8;
    public Animator anim;
    public bool ñññ;
    public float modef;
    public bool noc;

    public Camera cam2;
    public Transform target;
    public LayerMask obstructionMask2 = Physics.DefaultRaycastLayers;
    public float maxDistance;
    public bool copy;
    public bool timestop;
    public float gua;
    public Data dt;
    public bool sdlx;
Vector3 targetPosition;
bool destinationSet = false;
public bool seee;
public Image pen;
public float lastSeenTime = -Mathf.Infinity;
public float loseSightDelay = 2f;
public bool zmm;
    void Start()
    {

    }
    // Update is called once per frame
void OnEnable()
{
spawned = false;
blood1.SetActive(false);
blood2.SetActive(false);
blood3.SetActive(false);
blood4.SetActive(false);
blood5.SetActive(false);
blood6.SetActive(false);
blood7.SetActive(false);
blood8.SetActive(false);
events = 0;
}
    void Update()
    {
timestop = play.timestop;
gua = dt.gua;
   loseSightDelay = (night * 1.5f);
        safe = play.safe;
if(timestop == false)
{
if(seee == true && mode == 3)
{
        agent.SetDestination(player.position);
}
if(mode == 2 && zmm == false)
{
seee = false;
zmm = true;
}
if(mode == 1 || mode == 3)
{
zmm = false;
}
noc = play.noc;

        if(noc == false)
        {
        if(night == 1)
        {
        maxDistance = 10f;
        }
        if(night == 2)
        {
        maxDistance = 11f;
        }
        if(night == 3)
        {
        maxDistance = 12f;
        }
        if(night == 4)
        {
        maxDistance = 13f;
        }
        if(night == 5)
        {
        maxDistance = 14f * (1 - gua/10);
        }
        if(night == 6)
        {
        maxDistance = 15f * (1 - gua/10);
        }
        }
        if(noc == true)
        {
        maxDistance = 3f * (1 - gua/10);
        }
    if(seee == true)
    {
    Debug.Log("TE VEO!");
    }

//VISION
Vector3 vp = cam2.WorldToViewportPoint(target.position);
bool insideFrustum = vp.z > 0f && vp.x >= 0f && vp.x <= 1f && vp.y >= 0f && vp.y <= 1f;

Vector3 origin = cam2.transform.position;
Vector3 direction = (target.position - origin).normalized;
float distance = (maxDistance > 0f) ? maxDistance : Vector3.Distance(origin, target.position);

RaycastHit hit;
bool canSeeTarget = false;

if (insideFrustum &&
    Physics.Raycast(origin, direction, out hit, distance, obstructionMask2))
{
    if (hit.transform == target || hit.transform.root == target.root)
    {
if (safe == false)
{
    lastSeenTime = Time.time;
    seee = true;
    mode = 3;

    if (!audioSource3.isPlaying)
    {
        audioSource3.PlayOneShot(scr);
        audioSource3.clip = pers;
        audioSource3.Play();
    }
}
    }
}
else
{
    if (Time.time - lastSeenTime >= loseSightDelay)
    {
        seee = false;
    }
}


if(modef == 2 && ñas == false)
{
//Desbugueate por dios
 Invoke("st2", 20f);
ñas = true;
}
if(e1.activeInHierarchy)
{
        Invoke("ex1", 30f);
}
if(e2.activeInHierarchy)
{
        Invoke("ex2", 30f);
}
if(e3.activeInHierarchy)
{
        Invoke("ex3", 30f);
}
if(e4.activeInHierarchy)
{
        Invoke("ex4", 30f);
}
if(e5.activeInHierarchy)
{
        Invoke("ex5", 30f);
}
if(e6.activeInHierarchy)
{
        Invoke("ex6", 30f);
}
if(e7.activeInHierarchy)
{
        Invoke("ex7", 30f);
}
if(e8.activeInHierarchy)
{
        Invoke("ex8", 30f);
}

hour = clock.hour;
        tut = play.tut;
if (!audioSource.isPlaying)
{
 audioSource.Play();
}
if (!audioSource2.isPlaying)
{
 audioSource2.Play();
}
if(tut == false)
{
     audioSource.clip = null;
}
if(night > 1)
{
tut = false;
}
        if(night == 1 && tut == false)
        {
          mode = 69;
        }
        if(safe == true && mode == 3)
        {
          mode = 1;
       audioSource3.clip = null;
     audioSource.clip = wlk;
     audioSource.loop = true;
        Debug.Log("safe");
     audioSource.clip = wlk;
        }

        if(tut == true && jkl == 0)
        {
     if(tut == true)
     {
     audioSource.clip = wlk;
     audioSource.loop = true;
     }
          mode = 1;
       audioSource3.clip = null;
          jkl += 1;
        }
        if(pen.color.a <= 0)
        {
         events -= 1;
         Color c = pen.color;
         pen.color = c;
         c.a = 1f;
        }
      if(modef == 1 && mode == 2)
      {
        
        mode = 1;
       audioSource3.clip = null;
     audioSource.clip = wlk;
     audioSource.loop = true;
        ñas = false;
        hgu = false;
      }
      if(modef == 2)
      {
        if(copy == false)
        {
        mode = 2;
     audioSource.clip = wlk;
     audioSource.loop = true;
       audioSource3.clip = null;
        }
      }
        safe = play.safe;
        clock.events = events;
        Vector3 directionToPlayer = player.position - transform.position;
        float distanceToPlayer = directionToPlayer.magnitude;

        if(ubi == spawn && copy == false)
        {
         if(ññp == false)
         {
         if(ubi == "cocina")
         {
         if(blood1.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood1.activeInHierarchy)
         {
         event1();
         }
         }
         if(ubi == "salon")
         {
         if(blood2.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood2.activeInHierarchy)
         {
         event2();
         }
         }
         if(ubi == "baño1")
         {
         if(blood3.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood3.activeInHierarchy)
         {
         event3();
         }
         }
         if(ubi == "baño2")
         {
         if(blood4.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood4.activeInHierarchy)
         {
         event4();
         }
         }
         if(ubi == "oficina")
         {
         if(blood5.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood5.activeInHierarchy)
         {
         event5();
         }
         }
         if(ubi == "micuarto")
         {
         if(blood6.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood6.activeInHierarchy)
         {
         event6();
         }
         }
         if(ubi == "invitados")
         {
         if(blood7.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood7.activeInHierarchy)
         {
         event7();
         }
         }
         if(ubi == "sotano")
         {
         if(blood8.activeInHierarchy)
         {
         x = false;
         ññp = true;
         modef = 1;
         }
         if(!blood8.activeInHierarchy)
         {
         event8();
         }
         }
         }
        }
      if(mode == 1)
      {
       ññp = false;
      }
if (mode == 3)
{
    if (!destinationSet)
    {
        targetPosition = player.position;
        agent.SetDestination(targetPosition);
        destinationSet = true;
    }

    anim.SetTrigger("rn1");
    agent.speed = 8;

    if (hj == false)
    {
        audioSource3.PlayOneShot(scr);
        audioSource.clip = wlk2;
        audioSource.loop = true;
        audioSource.Play();
        hj = true;
    }
    if(seee == false)
    {
    if (!agent.pathPending &&
        agent.remainingDistance <= agent.stoppingDistance)
    {
        if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
        {
            mode = 1;
            destinationSet = false;
        }
    }
    }
}
else
{
    destinationSet = false;
}

      if(mode == 1)
      {
        anim.SetTrigger("rn2");
      agent.speed = 1;
      hj = false;
      }

      if(mode == 2)
      {
        anim.SetTrigger("rn2");
        hj = false;
        if(seee == false)
        {
        agent.speed = 6;
        }
      }
      if(y == true)
      {
      y = true;
      }
      if (hear == true && mode == 3)
      {
        anim.SetTrigger("rn1"); 
        agent.speed = 8;
       agent.SetDestination(player.position);
      }
      if (see == true && mode == 3)
      {
        anim.SetTrigger("rn1"); 
        agent.speed = 8;
       agent.SetDestination(player.position);
      }
    if(!spawned)
    {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
         agent.Warp(sal.position);
         spawn = "salon";
        }
        if (rng == 2)
        {
         agent.Warp(ba1.position);
         spawn = "baño1";
        }
        if (rng == 3)
        {
         agent.Warp(coc.position);
         spawn = "cocina";
        }
        if (rng == 4)
        {
         agent.Warp(sot.position);
         spawn = "sotano";
        }
        if (rng == 5)
        {
         agent.Warp(ba2.position);
         spawn = "baño2";
        }
        if (rng == 6)
        {
         agent.Warp(mi.position);
         spawn = "micuarto";
        }
        if (rng == 7)
        {
         agent.Warp(of.position);
         spawn = "oficina";
        }
        if (rng == 8)
        {
         agent.Warp(inv.position);
         spawn = "invitados";
        }

        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
        random();
        spawned = true;
        }
    night = clock.night;
    if(mode == 1 || mode == 3)
    {
     audioSource.clip = wlk;
     audioSource.loop = true;
        timer += Time.deltaTime;
        if (timer >= wanderTimer && mode == 1)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }

        if(ñññ == false && tut == true)
        {
        if(night == 1)
        {
        InvokeRepeating("move", 40f, 40f);
        }
        if(night == 2)
        {
        InvokeRepeating("move", 38f, 38f);
        }
        if(night == 3)
        {
        InvokeRepeating("move", 36f, 36f);
        }
        if(night == 4)
        {
        InvokeRepeating("move", 34f, 34f);
        }
        if(night == 5)
        {
        InvokeRepeating("move", 32f, 32f);
        }
        if(night == 6)
        {
        InvokeRepeating("move", 30f, 30f);
        }
        ñññ = true;
        lastPosition = transform.position;
        }
    }
    }
    }


    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;
        randDirection += origin;

        NavMeshHit navHit;
        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }
    void random()
    {
        mode = 1;
     audioSource.clip = wlk;
     audioSource.loop = true;
       audioSource3.clip = null;
        Debug.Log("EL PROBLEMA ES RANDOM!");
     if(tut == true)
     {
     audioSource.clip = wlk;
     audioSource.loop = true;
     }
    }
    void random2()
    {
     if(safe == false)
     {
        mode = 3;
     }
    }
    void move()
    {
    if(hgu == false)
    {
//MODEF ADJ
    modef = 2;
    hgu = true;
    }
     if(idk == false)
     {
        ñññ = true;
        if(ññp == false && modef == 2)
        {
        if(copy == false)
        {
        mode = 2;
     audioSource.clip = wlk;
     audioSource.loop = true;
       audioSource3.clip = null;
        }
        }
        idk = true;
     }
     if(tut == true)
     {
     audioSource.clip = wlk;
     audioSource.loop = true;
     }
        if(mode == 2 && x == false)
        {
         x = true;
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
         ññk = true;
         agent.SetDestination(sal.position);
         spawn = "salon";
        }
        if (rng == 2)
        {
         ññk = true;
         agent.SetDestination(ba1.position);
         spawn = "baño1";
        }
        if (rng == 3)
        {
         ññk = true;
         agent.SetDestination(coc.position);
         spawn = "cocina";
        }
        if (rng == 4)
        {
         ññk = true;
         agent.SetDestination(sot.position);
         spawn = "sotano";
        }
        if (rng == 5)
        {
         ññk = true;
         agent.SetDestination(inv.position);
         spawn = "invitados";
        }
        if (rng == 6)
        {
         ññk = true;
         agent.SetDestination(ba2.position);
         spawn = "baño2";
        }
        if (rng == 7)
        {
         ññk = true;
         agent.SetDestination(of.position);
         spawn = "oficina";
        }
        if (rng == 8)
        {
         ññk = true;
         agent.SetDestination(mi.position);
         spawn = "micuarto";
        }
        x = true;
        }
    }
    void zxc()
    {
     stat.SetActive(false);
    }


    void event1()
    {
     if (!blood1.activeInHierarchy)
     {
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
ñññ = false;
     blood1.SetActive(true);
     spawn = null;
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1 && play.notp == false && play.timestop == false)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        }
                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }
     }
    }
    void event2()
    {
     if (!blood2.activeInHierarchy)
     {
     spawn = null;
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
ñññ = false;
     blood2.SetActive(true);
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }

                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
        }
     }
    }
    void event3()
    {
     if (!blood3.activeInHierarchy)
     {
     spawn = null;
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
ñññ = false;
     blood3.SetActive(true);
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }
                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
     }
    }
    void event4()
    {
     if (!blood4.activeInHierarchy)
     {
     spawn = null;
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
ñññ = false;
     blood4.SetActive(true);
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }
                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
     }
    }
    void event5()
    {
     if (!blood5.activeInHierarchy)
     {
     spawn = null;
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
ñññ = false;
     blood5.SetActive(true);
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }
                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
     }
    }
    void event6()
    {
     if (!blood6.activeInHierarchy)
     {
     spawn = null;
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
ñññ = false;
     blood6.SetActive(true);
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }
                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
     }
    }
    void event7()
    {
     if (!blood7.activeInHierarchy)
     {
     spawn = null;
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
     ñññ = false;
     blood7.SetActive(true);
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }
                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
     }
    }
    void event8()
    {
     if (!blood8.activeInHierarchy)
     {
     spawn = null;
        if(night == 1)
        {
        Invoke("st", 40f);
        }
        if(night == 2)
        {
        Invoke("st", 38f);
        }
        if(night == 3)
        {
        Invoke("st", 36f);
        }
        if(night == 4)
        {
        Invoke("st", 34f);
        }
        if(night == 5)
        {
        Invoke("st", 32f);
        }
        if(night == 6)
        {
        Invoke("st", 30f);
        }
     idk2 = false;
ñññ = false;
     blood8.SetActive(true);
     events += 1;
     if(cam.activeInHierarchy)
     {
     stat.SetActive(true);
     Invoke("zxc", 0.5f);
     }
                float rng2 = Random.value;
        if(rng2 <= probabilidad && night >= 2 && ef.enabled == false && hour >= 1)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sal.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 2)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba1.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 3)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = coc.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 4)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = sot.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 5)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = ba2.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 6)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = mi.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 7)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = of.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        if (rng == 8)
        {
        intx.SetActive(true);
        cc.enabled = false;
        playerxxx.transform.position = inv.transform.position;
        cc.enabled = true;
        Invoke("th", 0.5f);
        }
        }
                float rng4 = Random.value;
        if(rng4 <= probabilidad3 && night >= 4 && ef.enabled == false)
        {
        int rngx2 = Random.Range(1, 9);
        if (rngx2 == 1)
        {
        t1.SetActive(true);
        }
        if (rngx2 == 2)
        {
        t2.SetActive(true);
        }
        if (rngx2 == 3)
        {
        t3.SetActive(true);
        }
        if (rngx2 == 4)
        {
        t4.SetActive(true);
        }
        if (rngx2 == 5)
        {
        t5.SetActive(true);
        }
        if (rngx2 == 6)
        {
        t6.SetActive(true);
        }
        if (rngx2 == 7)
        {
        t7.SetActive(true);
        }
        if (rngx2 == 8)
        {
        t8.SetActive(true);
        }
        }
                float rng3 = Random.value;
        if(rng3 <= probabilidad2 && night >= 3 && ef.enabled == false)
        {
        int rngx = Random.Range(1, 9);
        if (rngx == 1)
        {
        e1.SetActive(true);
        }
        if (rngx == 2)
        {
        e2.SetActive(true);
        }
        if (rngx == 3)
        {
        e3.SetActive(true);
        }
        if (rngx == 4)
        {
        e4.SetActive(true);
        }
        if (rngx == 5)
        {
        e5.SetActive(true);
        }
        if (rngx == 6)
        {
        e6.SetActive(true);
        }
        if (rngx == 7)
        {
        e7.SetActive(true);
        }
        if (rngx == 8)
        {
        e8.SetActive(true);
        }
        }
     }
    }

void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("calm"))
    {
     if(mode == 3)
     {
     mode = 1;
     audioSource.clip = wlk;
     audioSource.loop = true;
       audioSource3.clip = null;
        Debug.Log("EL PROBLEMA ES CALM");
     }
    }
    if (other.CompareTag("sound") && safe == false)
    {
       mode = 3;
if (!audioSource3.isPlaying)
{
      audioSource3.PlayOneShot(scr);
       audioSource3.clip = pers;
 audioSource3.Play();
}
       hear = true;
    }
    if (other.CompareTag("sound2") && safe == false)
    {
    agent.SetDestination(other.transform.position);
    }
}
void OnCollisionEnter(Collision other)
{
    if (other.gameObject.CompareTag("kitchen"))
    {
       ubi = "cocina";
    }
    if (other.gameObject.CompareTag("salon"))
    {
       ubi = "salon";
    }
    if (other.gameObject.CompareTag("bath1"))
    {
       ubi = "baño1";
    }
    if (other.gameObject.CompareTag("bath2"))
    {
       ubi = "baño2";
    }
    if (other.gameObject.CompareTag("guest"))
    {
       ubi = "invitados";
    }
    if (other.gameObject.CompareTag("mine"))
    {
       ubi = "micuarto";
    }
    if (other.gameObject.CompareTag("office"))
    {
       ubi = "oficina";
    }
    if (other.gameObject.CompareTag("basement"))
    {
       ubi = "sotano";
    }
}
void OnTriggerExit(Collider other)
{
    if (other.CompareTag("sound"))
    {
       hear = false;
    }
}
void th()
{
intx.SetActive(false);
}
void ex1()
{
e1.SetActive(false);
}
void ex2()
{
e2.SetActive(false);
}
void ex3()
{
e3.SetActive(false);
}
void ex4()
{
e4.SetActive(false);
}
void ex5()
{
e5.SetActive(false);
}
void ex6()
{
e6.SetActive(false);
}
void ex7()
{
e7.SetActive(false);
}
void ex8()
{
e8.SetActive(false);
}
void st()
{
idk = false;
}
void st2()
{
if(modef == 2)
{
modef = 1;
        Debug.Log("EL PROBLEMA ES EL DE SIEMPRE!");
}
}
}
