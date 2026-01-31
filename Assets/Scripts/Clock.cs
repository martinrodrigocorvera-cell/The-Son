using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Text.RegularExpressions;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class Clock : MonoBehaviour
{
[Range(0f, 1f)] public float probabilidad = 0.2f;
public Transform spawnpl;
public GameObject spawnxx;
public bool demo;
public bool dm2;
public GameObject ndem;
public GameObject dem;
public GameObject wl1;
public GameObject flp;
public GameObject inter;
public GameObject portxx;
public GameObject portxxx;
public TMP_Text texto;
public Rigidbody rbd;
public GameObject texti;
public float hour;
public bool nightend;
public float night;
public GameObject c1;
public GameObject c2;
public GameObject c3;
public GameObject c4;
public GameObject c5;
public float events;
public float power;
public bool er;
public float diff;
public Player player;
public Image pen;
public bool tut;
public bool home;
public Data dt;
public bool zxc;
public GameObject gamo;
public Transform part;
public GameObject part2;
public GameObject llor;
public GameObject trans;
public GameObject wino;
public GameObject run;
public GameObject end;
public GameObject bl1;
public GameObject bl2;
public GameObject bl3;
public GameObject bl4;
public GameObject bl5;
public GameObject bl6;
public GameObject bl7;
public GameObject bl8;
public GameObject wl2;
public GameObject e1;
public GameObject e2;
public GameObject e3;
public GameObject e4;
public GameObject e5;
public GameObject e6;
public GameObject e7;
public GameObject e8;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject t5;
    public GameObject t6;
    public GameObject t7;
    public GameObject t8;

public Transform partx;
public GameObject llorx;
public GameObject part2x;

public Transform partxx;
public GameObject llorxx;
public GameObject part2xx;

public bool zxz;
public bool vcn2;
public bool vcn;
public float rng;
public GameObject playerx;
public CharacterController cc;
public EffectFeature ef;
public bool zxkl;
public GameObject filter1;
public GameObject filter2;
public bool timestop;
public AudioSource audio;
public AudioClip hoursn;
    public ParticleSystem particulas;
    public int skip;
    public Transform spawnxx2;
    public GameObject copy;
public bool xs;
public bool xs2;
public float timet;
public bool ttt;
public bool ndx1;
public bool ndx2;

    // Start is called before the first frame update
    void Start()
    {
       hour = 0;
       texto.text = "0:00";
       power = 100;
    }
void OnEnable()
{
hour = 0;
texto.text = "0:00";
power = 100;
night = PlayerPrefs.GetFloat("Night", 1);
}

    // Update is called once per frame
    void Update()
    {
timestop = player.timestop;
     if(ttt == false)
     {
        Invoke("time", 1f);
       ttt = true;
     }
if(night == 6 && hour == 5)
{
copy.SetActive(true);
filter1.SetActive(false);
filter2.SetActive(true);
}
if(!llor.activeInHierarchy)
{
power = 100;
}
if (gamo.activeInHierarchy)
{
hour = 0;
power = 100;
}
if (wino.activeInHierarchy)
{
hour = 0;
power = 100;
}
home = player.home;
     if(home == false)
     {
       tut = player.tut;
        if(pen.color.a <= 0)
        {
         events -= 1;
         Color c = pen.color;
         pen.color = c;
         c.a = 1f;
        }
    if(night == 0)
    {
     night = 1;
    }
    if(timestop == false)
    {
    if (night == 1 && er == false && tut == true)
    {
      power -= 1f + ((events/1.5f) * diff);
      diff = 1.6f;
      er = true;
      if(zxkl == false)
      {
      Invoke("weaker", 20f);
      zxkl = true;
      }
    }
    if (night == 2 && er == false)
    {
      power -= 1f + ((events/1.5f) * diff);
      diff = 1.5f;
      er = true;
      if(zxkl == false)
      {
      Invoke("weaker", 18f);
      zxkl = true;
      }
    }
    if (night == 3 && er == false)
    {
      power -= 1f + ((events/1.5f) * diff);
      diff = 1.4f;
      er = true;
      if(zxkl == false)
      {
      Invoke("weaker", 16f);
      zxkl = true;
      }
    }
    if (night == 4 && er == false)
    {
      power -= 1f + ((events/1.5f) * diff);
      diff = 1.2f;
      er = true;
      if(zxkl == false)
      {
      Invoke("weaker", 14f);
      zxkl = true;
      }
    }
    if (night == 5 && er == false)
    {
      power -= 1f + ((events/1.5f) * diff);
      diff = 1f;
      er = true;
      if(zxkl == false)
      {
      Invoke("weaker", 12f);
      zxkl = true;
      }
    }
    if (night == 6 && er == false)
    {
      power -= 1f + ((events/1.5f) * diff);
      diff = 0.8f;
      er = true;
      if(zxkl == false)
      {
      Invoke("weaker", 10f);
      zxkl = true;
      }
    }
    }
    if(power > 100)
    {
    power = 100;
    }
    if(power <= 80)
    {
c1.SetActive(false);
c2.SetActive(true);
c3.SetActive(true);
c4.SetActive(true);
c5.SetActive(true);
    }
    if(power <= 60)
    {
c1.SetActive(false);
c2.SetActive(false);
c3.SetActive(true);
c4.SetActive(true);
c5.SetActive(true);
    }
    if(power <= 40)
    {
c1.SetActive(false);
c2.SetActive(false);
c3.SetActive(false);
c4.SetActive(true);
c5.SetActive(true);
    }
    if(power <= 20)
    {
c1.SetActive(false);
c2.SetActive(false);
c3.SetActive(false);
c4.SetActive(false);
c5.SetActive(true);
    }
    if(power <= 0)
    {
c1.SetActive(false);
c2.SetActive(false);
c3.SetActive(false);
c4.SetActive(false);
c5.SetActive(false);
    }

        if(hour == 5 && night == 5 && ef.enabled == false && vcn == false)
        {
        inter.SetActive(true);
        cc.enabled = false;
        playerx.transform.position = spawnxx2.transform.position;
        cc.enabled = true;
        Invoke("sp2", 1f);
        vcn = true;
ef.enabled = true;
        }

        if(tut == true)
        {
        if(timet == 60 && ndx1 == false)
        {
        if(vcn2 == false)
        {
                rng = Random.value;
                vcn2 = true;
        }
         Invoke("x1", 0.01f);
         ndx1 = true;
        }
        if(timet == 120 && ndx2 == false)
        {
         vcn = false;
         Invoke("x2", 0.01f);
         vcn2 = false;
         ndx2 = true;
         ndx1 = false;
        }
        if(timet == 180 && ndx1 == false)
        {
        if(vcn2 == false)
        {
                rng = Random.value;
                vcn2 = true;
        }
        if(rng <= probabilidad && night == 6 && ef.enabled == false && vcn == false)
        {
        portxxx.SetActive(true);
        inter.SetActive(true);
        cc.enabled = false;
        playerx.transform.position = spawnxx.transform.position;
        cc.enabled = true;
        Invoke("sp", 1f);
        vcn = true;
ef.enabled = true;
        }
         Invoke("x3", 0.01f);
         ndx2 = false;
         ndx1 = true;
        }
        if(timet == 240 && ndx2 == false)
        {
         vcn = false;
         Invoke("x4", 0.01f);
         vcn2 = false;
         ndx2 = true;
         ndx1 = false;
        }
        if(timet == 300 && ndx1 == false)
        {
        if(vcn2 == false)
        {
                rng = Random.value;
                vcn2 = true;
        }
        if(rng <= probabilidad && night == 6 && ef.enabled == false && vcn == false)
        {
        portxxx.SetActive(true);
        inter.SetActive(true);
        cc.enabled = false;
        playerx.transform.position = spawnxx.transform.position;
        cc.enabled = true;
        Invoke("sp", 1f);
        vcn = true;
ef.enabled = true;
        }
         Invoke("x5", 0.01f);
         ndx2 = false;
         ndx1 = true;
        }
        if(timet == 360 && ndx2 == false)
        {
         Invoke("x6", 0.01f);
         if(zxz == false)
         {
         trans.SetActive(true);
         zxz = true;
         }
         Invoke("xf2", 2f);
         Invoke("xf", 1f);
         ndx2 = true;
         ndx1 = false;
        }
        }
        }
    }
  void x1()
  {
      if(xs == false)
      {
      audio.PlayOneShot(hoursn);
      xs = true;
      }
   hour = 1;
   texto.text = "1:00";
  }
  void x2()
  {
      if(xs2 == false)
      {
      audio.PlayOneShot(hoursn);
      xs2 = true;
      xs = false;
      }
   hour = 2;
   texto.text = "2:00";
  }
  void x3()
  {
      if(xs == false)
      {
      audio.PlayOneShot(hoursn);
      xs = true;
      xs2 = false;
      }
   hour = 3;
   texto.text = "3:00";
  }
  void x4()
  {
      if(xs2 == false)
      {
      audio.PlayOneShot(hoursn);
      xs2 = true;
      xs = false;
      }
   hour = 4;
   texto.text = "4:00";
  }
  void x5()
  {
      if(xs == false)
      {
      audio.PlayOneShot(hoursn);
      xs = true;
      xs2 = false;
      }
   hour = 5;
   texto.text = "5:00";
  }
  void x6()
  {
      if(xs2 == false)
      {
      audio.PlayOneShot(hoursn);
      xs2 = true;
      xs = false;
      }
   hour = 6;
   texto.text = "6:00";
  }
  void xf2()
  {
  trans.SetActive(false);
  }
  void xf()
  {
    nightend = true;

    part.SetParent(null);
    llor.SetActive(false);
    part2.SetActive(true);

    partx.SetParent(null);
    llorx.SetActive(false);
    part2x.SetActive(true);

    partxx.SetParent(null);
    llorxx.SetActive(false);
    part2xx.SetActive(true);

    if(zxc == false && night <= 5)
    {
    particulas.Play();
    wino.SetActive(true);
    if(demo == true && dm2 == false)
    {
    if(night == 3)
    {
    ndem.SetActive(false);
    dem.SetActive(true);
    }
    dm2 = true;
    }
    night = PlayerPrefs.GetFloat("Night", 1);
        Invoke("nigc", 0.01f);
    PlayerPrefs.SetFloat("Night", night);
    PlayerPrefs.Save();
    zxc = true;
    }
    if(zxc == false && night == 6)
    {
     run.SetActive(true);
     end.SetActive(true);
filter1.SetActive(true);
filter2.SetActive(false);
     zxc = true;
     bl1.SetActive(false);
     bl2.SetActive(false);
     bl3.SetActive(false);
     bl4.SetActive(false);
     bl5.SetActive(false);
     bl6.SetActive(false);
     bl7.SetActive(false);
     bl8.SetActive(false);
     wl1.SetActive(false);
     wl2.SetActive(false);
     flp.SetActive(false);
     e1.SetActive(false);
     e2.SetActive(false);
     e3.SetActive(false);
     e4.SetActive(false);
     e5.SetActive(false);
     e6.SetActive(false);
     e7.SetActive(false);
     e8.SetActive(false);
     t1.SetActive(false);
     t2.SetActive(false);
     t3.SetActive(false);
     t4.SetActive(false);
     t5.SetActive(false);
     t6.SetActive(false);
     t7.SetActive(false);
     t8.SetActive(false);
        cc.enabled = false;
        playerx.transform.position = spawnpl.transform.position;
        cc.enabled = true;
    }
  }
void time()
{
ttt = false;
if(timestop == false)
{
timet += 1;
}
}
void nigc()
{
    night += 1;
}
void weaker()
{
  er = false;
if(night == 1)
{
Invoke("weaker", 20f);
}
if(night == 2)
{
Invoke("weaker", 18f);
}
if(night == 3)
{
Invoke("weaker", 16f);
}
if(night == 4)
{
Invoke("weaker", 14f);
}
if(night == 5)
{
Invoke("weaker", 12f);
}
if(night == 6)
{
Invoke("weaker", 10f);
}
}
void sp()
{
inter.SetActive(false);
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            -90,
            0
        );
        playerx.transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
}
void sp2()
{
inter.SetActive(false);
        Quaternion desiredRotation = Quaternion.Euler(
            0,
            -90,
            0
        );
        playerx.transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 360f);
}
}
