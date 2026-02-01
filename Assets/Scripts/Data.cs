using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Data : MonoBehaviour
{
public GameObject menu;
public int lang;
public float night;
public float games;
public string idioma;
public AudioSource audio;
public AudioSource audio2;
public AudioSource audio3;
public AudioSource audio4;
public AudioSource audio5;
public AudioSource audio6;
public AudioSource audio7;
public AudioSource audio8;
public AudioSource audio9;
public AudioSource audio10;
public AudioSource audio11;
public AudioSource audio12;
public AudioSource audio13;
public AudioSource audio14;
public AudioSource audio15;
public AudioSource audio16;
public AudioSource audio17;
public AudioSource audio18;
public bool z;
public SystemLanguage currentLanguage;
public int defaultt;
public TMP_Dropdown dpd;
public int skp;
public float tn;
public float rp;
public bool xcb;
public float sns;
public GameObject trans1;
public GameObject trans2;
public MovementCam camxy;
public float taco;
public float burr;
public float nach;
public float ques;
public float frij;
public float ench;
public float tam;
public float gua;
public float mir;
public float sel;
public GameObject wino;
public Player play;

    // Start is called before the first frame update
    void Start()
    {
//VELOCIDAD
taco = PlayerPrefs.GetInt("taco");
//STAMINA
burr = PlayerPrefs.GetInt("burr");
//LINTERNA
nach = PlayerPrefs.GetInt("nach");
//RECUPERACION STAMINA
ques = PlayerPrefs.GetInt("ques");
//ALCANCE LINTERNA
frij = PlayerPrefs.GetInt("frij");
//SILENCIO
ench = PlayerPrefs.GetInt("ench");
//SILENCIO PASOS
tam = PlayerPrefs.GetInt("tam");
//CEGUERA LLORONA
gua = PlayerPrefs.GetInt("gua");

mir = PlayerPrefs.GetInt("mir");
sel = PlayerPrefs.GetInt("sel");
    sns = PlayerPrefs.GetFloat("Sens", 100f);
    camxy.mouseSensitivity = sns;
         float savedVolume = PlayerPrefs.GetFloat("Volume", 0.5f);
         audio.volume = savedVolume;
         audio2.volume = savedVolume;
         audio3.volume = savedVolume;
         audio4.volume = savedVolume;
         audio5.volume = savedVolume;
         audio6.volume = savedVolume;
         audio7.volume = savedVolume;
         audio8.volume = savedVolume;
         audio9.volume = savedVolume;
         audio10.volume = savedVolume;
         audio11.volume = savedVolume;
         audio12.volume = savedVolume;
         audio13.volume = savedVolume;
         audio14.volume = savedVolume;
         audio15.volume = savedVolume;
         audio16.volume = savedVolume;
         audio17.volume = savedVolume;
                  audio18.volume = savedVolume;
         tn = audio.volume / 5;
    }

    // Update is called once per frame
    void Update()
    {
    mir = play.mirai;
    sel = play.seller;
    if(wino.activeInHierarchy)
    {
PlayerPrefs.SetFloat("taco", taco);
PlayerPrefs.SetFloat("burr", burr);
PlayerPrefs.SetFloat("nach", nach);
PlayerPrefs.SetFloat("ques", ques);
PlayerPrefs.SetFloat("frij", frij);
PlayerPrefs.SetFloat("ench", ench);
PlayerPrefs.SetFloat("tam", tam);
PlayerPrefs.SetFloat("gua", gua);
PlayerPrefs.SetFloat("mir", mir);
PlayerPrefs.SetFloat("sel", sel);
PlayerPrefs.Save();
    }
    if(taco < 0)
    {
     taco = 0;
    }
    if(burr < 0)
    {
     burr = 0;
    }
    if(nach < 0)
    {
     nach = 0;
    }
    if(ques < 0)
    {
     ques = 0;
    }
    if(frij < 0)
    {
     frij = 0;
    }
    if(ench < 0)
    {
     ench = 0;
    }
    if(tam < 0)
    {
     tam = 0;
    }
    if(gua < 0)
    {
     gua = 0;
    }



    if(ench > 10)
    {
     ench = 10;
    }
    if(tam > 5)
    {
     tam = 5;
    }
    if(gua > 5)
    {
     gua = 5;
    }
    if(!trans1.activeInHierarchy && !trans2.activeInHierarchy)
    {
     rp = 0;
     xcb = false;
    }
    if((trans1.activeInHierarchy || trans2.activeInHierarchy) && xcb == false)
    {
      if(trans1.activeInHierarchy)
      {
      InvokeRepeating("wk", 0.2f, 0.2f);
      }
      if(trans1.activeInHierarchy)
      {
      InvokeRepeating("wk", 0.4f, 0.4f);
      }
      xcb = true;
    }
    skp = PlayerPrefs.GetInt("Skp", 0);
    games = PlayerPrefs.GetFloat("Game", 0);
    night = PlayerPrefs.GetFloat("Night", 1);
    sns = PlayerPrefs.GetFloat("Sens", 100f);
    lang = PlayerPrefs.GetInt("Language", defaultt);
        currentLanguage = Application.systemLanguage;
        if(currentLanguage == SystemLanguage.English)
        {
        defaultt = 0;
        }
        if(currentLanguage == SystemLanguage.Spanish)
        {
        defaultt = 1;
        }
        if(currentLanguage == SystemLanguage.French)
        {
        defaultt = 2;
        }
        if(currentLanguage == SystemLanguage.German)
        {
        defaultt = 3;
        }
        if(currentLanguage == SystemLanguage.Japanese)
        {
        defaultt = 4;
        }
        if(currentLanguage == SystemLanguage.Portuguese)
        {
        defaultt = 5;
        }
        if(currentLanguage == SystemLanguage.Russian)
        {
        defaultt = 6;
        }
        if(currentLanguage == SystemLanguage.Italian)
        {
        defaultt = 7;
        }
        if(currentLanguage == SystemLanguage.Korean)
        {
        defaultt = 8;
        }
        if(currentLanguage == SystemLanguage.Chinese)
        {
        defaultt = 9;
        }
        if (currentLanguage != SystemLanguage.English &&
            currentLanguage != SystemLanguage.Spanish &&
            currentLanguage != SystemLanguage.French &&
            currentLanguage != SystemLanguage.German &&
            currentLanguage != SystemLanguage.Japanese &&
            currentLanguage != SystemLanguage.Portuguese &&
            currentLanguage != SystemLanguage.Russian &&
            currentLanguage != SystemLanguage.Chinese &&
            currentLanguage != SystemLanguage.Korean &&
            currentLanguage != SystemLanguage.Italian)
        {
            defaultt = 0;
        }

    if(!menu.activeInHierarchy && games < 5)
    {
    games += 1;
    PlayerPrefs.SetFloat("Game", games);
    PlayerPrefs.Save();
    }
        if (lang == 0)
        {
            idioma = "ingles";
        }
        if(lang == 1)
        {
            idioma = "español";
        }
        if(lang == 2)
        {
            idioma = "frances";
        }
        if(lang == 3)
        {
            idioma = "aleman";
        }
        if(lang == 4)
        {
            idioma = "japones";
        }
        if(lang == 5)
        {
            idioma = "portugues";
        }
        if(lang == 6)
        {
            idioma = "ruso";
        }
        if(lang == 7)
        {
            idioma = "italiano";
        }
        if(lang == 8)
        {
            idioma = "coreano";
        }
        if(lang == 9)
        {
            idioma = "chino";
        }        
    }
    void wk()
    {
    if(trans1.activeInHierarchy)
    {
      if(rp <= 5)
      {
    audio.volume -= tn;
    audio2.volume -= tn;
    audio3.volume -= tn;
    audio4.volume -= tn;
    audio5.volume -= tn;
    audio6.volume -= tn;
    audio7.volume -= tn;
    audio8.volume -= tn;
    audio9.volume -= tn;
    audio10.volume -= tn;
    audio11.volume -= tn;
    audio12.volume -= tn;
    audio13.volume -= tn;
    audio14.volume -= tn;
    audio15.volume -= tn;
    audio16.volume -= tn;
    audio17.volume -= tn;
        audio18.volume -= tn;
      }
      if(rp >= 6)
      {
    audio.volume += tn;
    audio2.volume += tn;
    audio3.volume += tn;
    audio4.volume += tn;
    audio5.volume += tn;
    audio6.volume += tn;
    audio7.volume += tn;
    audio8.volume += tn;
    audio9.volume += tn;
    audio10.volume += tn;
    audio11.volume += tn;
    audio12.volume += tn;
    audio13.volume += tn;
    audio14.volume += tn;
    audio15.volume += tn;
    audio16.volume += tn;
    audio17.volume += tn;
        audio18.volume += tn;
      }
    }

    rp += 1;
    }
}
