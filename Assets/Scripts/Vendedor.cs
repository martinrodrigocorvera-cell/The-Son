using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Vendedor : MonoBehaviour
{
public Transform player;
    public float offsetZ = 0f;
    public float suavizado = 1.5f;
    public Transform limiteIzquierdo;
    public Transform limiteDerecho;
    float xInicial;
    float yInicial;
    public bool food;
    public Data dt;
    public Player play;
    public bool xbox;
    public bool playst;
    public string idioma;
    public bool intering;
public TMP_Text texto;
public TMP_Text textoj;
public TMP_Text textok;
public TMP_Text textoc;
public TMP_Text textor;
public bool dis;
public bool ring;
public bool freeze;
public GameObject spawn1;
public GameObject spawn2;
public GameObject spawn3;
public GameObject spawn4;
public GameObject spawn5;
public TMP_Text texto2;
public TMP_Text textoj2;
public TMP_Text textok2;
public TMP_Text textoc2;
public TMP_Text textor2;
public TMP_Text texto3;
public TMP_Text textoj3;
public TMP_Text textok3;
public TMP_Text textoc3;
public TMP_Text textor3;
public TMP_Text texto4;
public TMP_Text textoj4;
public TMP_Text textok4;
public TMP_Text textoc4;
public TMP_Text textor4;
public Clock cl;
public float pw;
public AudioClip mig;
public AudioClip fire;
public AudioSource van;
public GameObject eat;
public string foodx;
public GameObject tacox;
public GameObject burritox;
public GameObject msg;
public bool jing;
public Vendedor sh1;
public Vendedor sh2;
public Vendedor sh3;
public Vendedor sh4;
public Vendedor sh5;
public bool dis1;
public bool dis2;
public bool dis3;
public bool dis4;
public bool dis5;
public bool jing1;
public bool jing2;
public bool jing3;
public bool jing4;
public bool jing5;
public Animator anim;
public AudioClip ringx;
public GameObject mer;
public GameObject nachosx;
public GameObject quesadillax;
public GameObject frijolesx;
public GameObject chilex;
public Transform cmx;
public float night;
public GameObject enchiladax;
public GameObject tamalesx;
public GameObject guacamolex;
public GameObject diablox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xInicial = transform.position.x;
        yInicial = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {

    if(jing == false && food == true)
    {
        if(night == 2)
        {
        int rng = Random.Range(1, 7);
        if (rng == 1)
        {
        foodx = "taco";
        tacox.SetActive(true);
        }
        if (rng == 2)
        {
        foodx = "burrito";
        burritox.SetActive(true);
        }
        if (rng == 3)
        {
        foodx = "nachos";
        nachosx.SetActive(true);
        }
        if (rng == 4)
        {
        foodx = "quesadilla";
        quesadillax.SetActive(true);
        }
        if (rng == 5)
        {
        foodx = "frijoles";
        frijolesx.SetActive(true);
        }
        if (rng == 6)
        {
        foodx = "chile";
        chilex.SetActive(true);
        }
    jing = true;
        }



        if(night == 3)
        {
        int rng = Random.Range(1, 8);
        if (rng == 1)
        {
        foodx = "taco";
        tacox.SetActive(true);
        }
        if (rng == 2)
        {
        foodx = "burrito";
        burritox.SetActive(true);
        }
        if (rng == 3)
        {
        foodx = "nachos";
        nachosx.SetActive(true);
        }
        if (rng == 4)
        {
        foodx = "quesadilla";
        quesadillax.SetActive(true);
        }
        if (rng == 5)
        {
        foodx = "frijoles";
        frijolesx.SetActive(true);
        }
        if (rng == 6)
        {
        foodx = "chile";
        chilex.SetActive(true);
        }
        if (rng == 7)
        {
        foodx = "enchilada";
        enchiladax.SetActive(true);
        }
    jing = true;
        }

        if(night == 4)
        {
        int rng = Random.Range(1, 9);
        if (rng == 1)
        {
        foodx = "taco";
        tacox.SetActive(true);
        }
        if (rng == 2)
        {
        foodx = "burrito";
        burritox.SetActive(true);
        }
        if (rng == 3)
        {
        foodx = "nachos";
        nachosx.SetActive(true);
        }
        if (rng == 4)
        {
        foodx = "quesadilla";
        quesadillax.SetActive(true);
        }
        if (rng == 5)
        {
        foodx = "frijoles";
        frijolesx.SetActive(true);
        }
        if (rng == 6)
        {
        foodx = "chile";
        chilex.SetActive(true);
        }
        if (rng == 7)
        {
        foodx = "enchilada";
        enchiladax.SetActive(true);
        }
        if (rng == 8)
        {
        foodx = "tamales";
        tamalesx.SetActive(true);
        }
    jing = true;
        }

        if(night == 5)
        {
        int rng = Random.Range(1, 10);
        if (rng == 1)
        {
        foodx = "taco";
        tacox.SetActive(true);
        }
        if (rng == 2)
        {
        foodx = "burrito";
        burritox.SetActive(true);
        }
        if (rng == 3)
        {
        foodx = "nachos";
        nachosx.SetActive(true);
        }
        if (rng == 4)
        {
        foodx = "quesadilla";
        quesadillax.SetActive(true);
        }
        if (rng == 5)
        {
        foodx = "frijoles";
        frijolesx.SetActive(true);
        }
        if (rng == 6)
        {
        foodx = "chile";
        chilex.SetActive(true);
        }
        if (rng == 7)
        {
        foodx = "enchilada";
        enchiladax.SetActive(true);
        }
        if (rng == 8)
        {
        foodx = "tamales";
        tamalesx.SetActive(true);
        }
        if (rng == 9)
        {
        foodx = "guacamole";
        guacamolex.SetActive(true);
        }
    jing = true;
        }


        if(night == 6)
        {
        int rng = Random.Range(1, 11);
        if (rng == 1)
        {
        foodx = "taco";
        tacox.SetActive(true);
        }
        if (rng == 2)
        {
        foodx = "burrito";
        burritox.SetActive(true);
        }
        if (rng == 3)
        {
        foodx = "nachos";
        nachosx.SetActive(true);
        }
        if (rng == 4)
        {
        foodx = "quesadilla";
        quesadillax.SetActive(true);
        }
        if (rng == 5)
        {
        foodx = "frijoles";
        frijolesx.SetActive(true);
        }
        if (rng == 6)
        {
        foodx = "chile";
        chilex.SetActive(true);
        }
        if (rng == 7)
        {
        foodx = "enchilada";
        enchiladax.SetActive(true);
        }
        if (rng == 8)
        {
        foodx = "tamales";
        tamalesx.SetActive(true);
        }
        if (rng == 9)
        {
        foodx = "guacamole";
        guacamolex.SetActive(true);
        }
        if (rng == 10)
        {
        foodx = "diablo";
        diablox.SetActive(true);
        }
    jing = true;
        }


    van.PlayOneShot(fire);
    dis = false;
    }
freeze = play.freeze;
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && ring == true && freeze == false)
              {
                anim.SetTrigger("ring");
                van.PlayOneShot(ringx);
                Invoke("ringxx", 0.5f);
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
              }
    night = dt.night;
              if ((Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton1)) && intering == true && dis == false && ring == false && freeze == false)
              {
                  van.PlayOneShot(mig);
                  if(foodx == "taco")
                  {
                  dt.taco += 1;
                  cl.power = cl.power - 4;
                  tacox.SetActive(false);
                  }
                  if(foodx == "burrito")
                  {
                  dt.burr += 1;
                  cl.power = cl.power - 2;
                  burritox.SetActive(false);
                  }
                  if(foodx == "nachos")
                  {
                  dt.nach += 1;
                  cl.power = cl.power - 3;
                  nachosx.SetActive(false);
                  }
                  if(foodx == "quesadilla")
                  {
                  dt.ques += 1;
                  cl.power = cl.power - 2;
                  quesadillax.SetActive(false);
                  }
                  if(foodx == "frijoles")
                  {
                  dt.frij += 1;
                  cl.power = cl.power - 3;
                  frijolesx.SetActive(false);
                  }
                  if(foodx == "chile")
                  {
                  cl.power = cl.power - 5;
                  chilex.SetActive(false);
                Invoke("ringxx2", 0.5f);
                  }
                  if(foodx == "enchilada")
                  {
                  dt.ench += 1;
                  cl.power = cl.power - 4;
                  enchiladax.SetActive(false);
                  }
                  if(foodx == "tamales")
                  {
                  dt.tam += 1;
                  cl.power = cl.power - 3;
                  tamalesx.SetActive(false);
                  }
                  if(foodx == "guacamole")
                  {
                  dt.gua += 1;
                  cl.power = cl.power - 4;
                  guacamolex.SetActive(false);
                  }
                  if(foodx == "diablo")
                  {
                  dt.gua += 1;
                  dt.tam += 1;
                  dt.ench += 1;
                  dt.frij += 1;
                  dt.ques += 1;
                  dt.nach += 1;
                  dt.burr += 1;
                  dt.taco += 1;
                  cl.power = cl.power - 10;
                  diablox.SetActive(false);
                  }
                  eat.SetActive(true);
        spawn1.SetActive(true);
        spawn2.SetActive(true);
        spawn3.SetActive(true);
        spawn4.SetActive(true);
        spawn5.SetActive(true);
        mer.SetActive(true);
                  Invoke("eaten", 0.3f);
                  dis = true;
msg.SetActive(false);
        intering = false;
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
              }
    if(food == true || ring == true)
    {
    idioma = dt.idioma;
    xbox = play.xbox;
    playst = play.playst;
    }
    
    if(intering == true && (food == true || ring == true) && dis == false)
    {
    if(ring == false)
    {
    msg.SetActive(true);
    }
if(foodx == "diablo")
{
    if(idioma == "ingles")
    {
        texto2.text = "El Diablo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "EL DIABLO";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "El Diablo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "El Diablo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "El Diablo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "El Diablo";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "エル・ディアブロ";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "엘 디아블로";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "埃尔·迪亚布罗";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "Эль Диабло";
    }
    if(idioma == "ingles")
    {
        texto3.text = "All effects";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Todos los efectos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Tous les effets";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Alle Effekte";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Tutti gli effetti";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Todos os efeitos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "すべての効果";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "모든 효과";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "所有效果";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "Все эффекты";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 10";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 10";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 10";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 10";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 10";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 10";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 10";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 10";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 10";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 10";
}
}
if(foodx == "guacamole")
{
    if(idioma == "ingles")
    {
        texto2.text = "Guacamole";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "Guacamole";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "Guacamole";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "Guacamole";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "Guacamole";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "Guacamole";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "ワカモレ";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "과카몰리";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "酪梨醬";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "гуакамоле";
    }
    if(idioma == "ingles")
    {
        texto3.text = "Reduce the visibility of La Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Reduce la visibilidad de La Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Reduit la visibilite de La Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Verringert die Sichtbarkeit von La Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Riduce la visibilita di La Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Reduz a visibilidade de La Llorona";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "ラ・ジョロナの視認性を下げる";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "라 요로나의 가시성을 낮춘다";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "降低拉洛罗娜的可见度";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "уменьшает видимость Ла Йороны";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 4";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 4";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 4";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 4";
}
}
if(foodx == "tamales")
{
    if(idioma == "ingles")
    {
        texto2.text = "Tamales";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "Tamales";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "Tamales";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "Tamales";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "Tamales";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "Tamales";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "タマレス";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "타말레스";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "塔馬利";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "тамалес";
    }
    if(idioma == "ingles")
    {
        texto3.text = "Reduce footstep sound";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Reduce el sonido de los pasos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Reduit le bruit des pas";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Reduziert das Geräusch von Schritten";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Riduce il rumore dei passi";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Reduz o som dos passos";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "足音を小さくする";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "발소리를 줄입니다";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "减少脚步声";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "уменьшает звук шагов";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 3";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 3";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 3";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 3";
}
}
if(foodx == "enchilada")
{
    if(idioma == "ingles")
    {
        texto2.text = "Enchilada";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "Enchilada";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "Enchilada";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "Enchilada";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "Enchilada";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "Enchilada";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "エンチラーダ";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "엔칠라다";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "玉米饼卷";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "энчилада";
    }
    if(idioma == "ingles")
    {
        texto3.text = "Reduce the microphone volume";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Reduce el sonido del microfono";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Reduire le son du micro";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Reduziere den Mikrofonlautstarke";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Riduci il volume del microfono";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Reduz o som do microfone";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "マイクの音量を下げる";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "마이크 소리를 줄입니다";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "降低麥克風音量";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "Уменьшить звук микрофона";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 4";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 4";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 4";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 4";
}
}
if(foodx == "chile")
{
    if(idioma == "ingles")
    {
        texto2.text = "Chili";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "Chile";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "Chili";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "Chili";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "Chili";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "Chili";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "チリスープ";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "칠리 수프";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "辣味炖肉湯";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "чили";
    }
    if(idioma == "ingles")
    {
        texto3.text = "Changes the shop items";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Cambia los items de la tienda";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Change les items du magasin";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Andert die Shop-Items";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Cambia gli items del negozio";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Altera os items da loja";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "ショップのアイテムを変更する";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "상점의 아이템을 변경합니다";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "更换商店的物品";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "Меняет items магазина";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 5";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 5";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 5";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 5";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 5";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 5";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 5";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 5";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 5";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 5";
}
}
if(foodx == "frijoles")
{
    if(idioma == "ingles")
    {
        texto2.text = "Beans";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "Frijoles";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "Haricots";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "Bohnen";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "Fagioli";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "Feijoes";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "豆";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "콩";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "豆子";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "фасоль";
    }
    if(idioma == "ingles")
    {
        texto3.text = "Increases the flashlight range";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Aumenta el alcance de la linterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Augmente la portee de la lampe torche";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Erhoht die Reichweite der Taschenlampe";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Aumenta la portata della torcia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Aumenta o alcance da lanterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "懐中電灯の照射距離が伸びる";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "손전등의 범위가 증가합니다";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "增加手电筒的照射范围";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "Увеличивает дальность фонарика";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 3";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 3";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 3";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 3";
}
}
if(foodx == "quesadilla")
{
    if(idioma == "ingles")
    {
        texto2.text = "Quesadilla";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "Quesadilla";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "Quesadilla";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "Quesadilla";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "Quesadilla";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "Quesadilla";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "ケサディーヤ";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "케사디야";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "奶酪薄饼";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "кесадилья";
    }
    if(idioma == "ingles")
    {
        texto3.text = "Increases stamina recovery";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Aumenta la recuperacion de la estamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Augmente la récupération d’endurance";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Erhoht die Ausdauerregeneration";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Aumenta il recupero della stamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Aumenta a recuperaçao de estamina";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "スタミナ回復量が増加する";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "스태미나 회복이 증가합니다";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "提升体力恢复速度";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "Увеличивает восстановление выносливости";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 2";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 2";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 2";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 2";
}
}
if(foodx == "burrito")
{
if(idioma == "ingles")
{
    texto2.text = "Burrito";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "español")
{
    texto2.text = "Burrito";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "frances")
{
    texto2.text = "Burrito";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "aleman")
{
    texto2.text = "Burrito";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "italiano")
{
    texto2.text = "Burrito";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "portugues")
{
    texto2.text = "Burrito";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "japones")
{
    texto2.text = "";
    textoj2.text = "ブリトー";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "coreano")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "부리토";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "chino")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "墨西哥卷餅";
    textor2.text = "";
}
if(idioma == "ruso")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "буррито";
}
if(idioma == "ingles")
{
    texto3.text = "Increases stamina";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "español")
{
    texto3.text = "Aumenta la estamina";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "frances")
{
    texto3.text = "Augmente l endurance";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "aleman")
{
    texto3.text = "Erhoht die Ausdauer";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "italiano")
{
    texto3.text = "Aumenta la resistenza";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "portugues")
{
    texto3.text = "Aumenta a resistencia";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "japones")
{
    texto3.text = "";
    textoj3.text = "スタミナが増加する";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "coreano")
{
    texto3.text = "";
    textoj3.text = "";
    textok3.text = "스태미나가 증가합니다";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "chino")
{
    texto3.text = "";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "增加耐力";
    textor3.text = "";
}
if(idioma == "ruso")
{
    texto3.text = "";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "Повышает выносливость";
}
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 2";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 2";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 2";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 2";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 2";
}
}
if(foodx == "nachos")
{
    if(idioma == "ingles")
    {
        texto2.text = "Nachos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "español")
    {
        texto2.text = "Nachos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "frances")
    {
        texto2.text = "Nachos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "aleman")
    {
        texto2.text = "Nachos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "italiano")
    {
        texto2.text = "Nachos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "portugues")
    {
        texto2.text = "Nachos";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "japones")
    {
        texto2.text = "";
        textoj2.text = "ナチョス";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "coreano")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "나초";
        textoc2.text = "";
        textor2.text = "";
    }
    if(idioma == "chino")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "玉米片";
        textor2.text = "";
    }
    if(idioma == "ruso")
    {
        texto2.text = "";
        textoj2.text = "";
        textok2.text = "";
        textoc2.text = "";
        textor2.text = "начос";
    }

    if(idioma == "ingles")
    {
        texto3.text = "Increase the flashlight size";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "español")
    {
        texto3.text = "Aumenta el tamano de la linterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "frances")
    {
        texto3.text = "Augmente la taille de la lampe de poche";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "aleman")
    {
        texto3.text = "Vergrossert die Taschenlampe";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "italiano")
    {
        texto3.text = "Aumenta le dimensioni della torcia";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "portugues")
    {
        texto3.text = "Aumenta o tamanho da lanterna";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "japones")
    {
        texto3.text = "";
        textoj3.text = "懐中電灯のサイズを大きくします";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "coreano")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "손전등 크기를 늘립니다";
        textoc3.text = "";
        textor3.text = "";
    }
    if(idioma == "chino")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "增大手电筒的尺寸";
        textor3.text = "";
    }
    if(idioma == "ruso")
    {
        texto3.text = "";
        textoj3.text = "";
        textok3.text = "";
        textoc3.text = "";
        textor3.text = "увеличивает размер фонарика";
    }
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 3";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 3";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 3";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 3";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 3";
}
}



if(foodx == "taco")
{
if(idioma == "ingles")
{
    texto2.text = "Taco";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "español")
{
    texto2.text = "Taco";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "frances")
{
    texto2.text = "Taco";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "aleman")
{
    texto2.text = "Taco";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "italiano")
{
    texto2.text = "Taco";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "portugues")
{
    texto2.text = "Taco";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "japones")
{
    texto2.text = "";
    textoj2.text = "タコス";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "coreano")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "타코";
    textoc2.text = "";
    textor2.text = "";
}
if(idioma == "chino")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "塔可";
    textor2.text = "";
}
if(idioma == "ruso")
{
    texto2.text = "";
    textoj2.text = "";
    textok2.text = "";
    textoc2.text = "";
    textor2.text = "тако";
}
if(idioma == "ingles")
{
    texto3.text = "Increases speed";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "español")
{
    texto3.text = "Aumenta la velocidad";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "frances")
{
    texto3.text = "Augmente la vitesse";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "aleman")
{
    texto3.text = "Erhoht die geschwindigkeit";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "italiano")
{
    texto3.text = "Aumenta la velocita";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "portugues")
{
    texto3.text = "Aumenta a velocidade";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "japones")
{
    texto3.text = "";
    textoj3.text = "速度が上昇する";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "coreano")
{
    texto3.text = "";
    textoj3.text = "";
    textok3.text = "속도가 증가함";
    textoc3.text = "";
    textor3.text = "";
}
if(idioma == "chino")
{
    texto3.text = "";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "提升速度";
    textor3.text = "";
}
if(idioma == "ruso")
{
    texto3.text = "";
    textoj3.text = "";
    textok3.text = "";
    textoc3.text = "";
    textor3.text = "повышает скорость";
}
if(idioma == "ingles")
{
    texto4.text = "Energy cost: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "español")
{
    texto4.text = "Coste de energia: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "frances")
{
    texto4.text = "Cout en energie: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "aleman")
{
    texto4.text = "Energiekosten: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "italiano")
{
    texto4.text = "Costo energetico: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "portugues")
{
    texto4.text = "Custo de energia: 4";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "japones")
{
    texto4.text = "";
    textoj4.text = "エネルギーコスト: 4";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "coreano")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "에너지 비용: 4";
    textoc4.text = "";
    textor4.text = "";
}
if(idioma == "chino")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "能量消耗: 4";
    textor4.text = "";
}
if(idioma == "ruso")
{
    texto4.text = "";
    textoj4.text = "";
    textok4.text = "";
    textoc4.text = "";
    textor4.text = "стоимость энергии: 4";
}
}

if(food == false && ring == true && intering == true)
{
if(playst == true)
{
if(idioma == "ingles")
{
    texto.text = "Ring the Doorbell <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Tocar timbre <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Sonner a la porte <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "An der Tur klingeln <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Suonare il campanello <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Tocar a campainha <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "インターホンを押す <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "초인종을 누르다 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "按門鈴 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "позвонить в дверь <sprite name=\"pixel_art_small\">";
}
}

if(xbox == true)
{
if(idioma == "ingles")
{
    texto.text = "Ring the Doorbell <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Tocar timbre <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Sonner a la porte <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "An der Tur klingeln <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Suonare il campanello <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Tocar a campainha <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "インターホンを押す <sprite name=\"A\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "초인종을 누르다 <sprite name=\"A\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "按門鈴 <sprite name=\"A\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "позвонить в дверь <sprite name=\"A\">";
}
}

if(xbox == false && playst == false)
{
if(idioma == "ingles")
{
    texto.text = "Ring the Doorbell <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Tocar timbre <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Sonner a la porte <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "An der Tur klingeln <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Suonare il campanello <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Tocar a campainha <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "インターホンを押す <sprite name=\"E\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "초인종을 누르다 <sprite name=\"E\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "按門鈴 <sprite name=\"E\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "позвонить в дверь <sprite name=\"E\">";
}
}
}

if(food == true && ring == false)
{
if(playst == true)
{
if(idioma == "ingles")
{
    texto.text = "Eat <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Comer <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Manger <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Essen <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Mangiare <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Comer <sprite name=\"pixel_art_small\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "食べる <sprite name=\"pixel_art_small\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "먹기 <sprite name=\"pixel_art_small\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "吃 <sprite name=\"pixel_art_small\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "есть <sprite name=\"pixel_art_small\">";
}
}

if(xbox == true)
{
if(idioma == "ingles")
{
    texto.text = "Eat <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Comer <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Manger <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Essen <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Mangiare <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Comer <sprite name=\"A\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "食べる <sprite name=\"A\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "먹기 <sprite name=\"A\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "吃 <sprite name=\"A\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "есть <sprite name=\"A\">";
}
}

if(xbox == false && playst == false)
{
if(idioma == "ingles")
{
    texto.text = "Eat <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "español")
{
    texto.text = "Comer <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "frances")
{
    texto.text = "Manger <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "aleman")
{
    texto.text = "Essen <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "italiano")
{
    texto.text = "Mangiare <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "portugues")
{
    texto.text = "Comer <sprite name=\"E\">";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "japones")
{
    texto.text = "";
    textoj.text = "食べる <sprite name=\"E\">";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "coreano")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "먹기 <sprite name=\"E\">";
    textoc.text = "";
    textor.text = "";
}
if(idioma == "chino")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "吃 <sprite name=\"E\">";
    textor.text = "";
}
if(idioma == "ruso")
{
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "есть <sprite name=\"E\">";
}
}
}
    }

    if(food == false && ring == false)
    {
            transform.LookAt(player);
            Vector3 lookPos = player.position - transform.position;
            lookPos.y = 0;
            transform.rotation = Quaternion.LookRotation(lookPos);
        float targetZ = player.position.z + offsetZ;
        float newZ = Mathf.Lerp(transform.position.z, targetZ, Time.deltaTime * suavizado);
        newZ = Mathf.Clamp(newZ, limiteIzquierdo.position.z, limiteDerecho.position.z);
        transform.position = new Vector3(
            xInicial,
            yInicial,
            newZ
        );
    }

    }
void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player") && (food == true || ring == true))
    {
        intering = true;
        if(ring == false)
        {
        spawn1.SetActive(true);
        spawn2.SetActive(false);
        spawn3.SetActive(false);
        spawn4.SetActive(false);
        spawn5.SetActive(false);
        }
    }
}
void OnTriggerExit(Collider other)
{
msg.SetActive(false);
        intering = false;
    texto.text = "";
    textoj.text = "";
    textok.text = "";
    textoc.text = "";
    textor.text = "";
        spawn1.SetActive(true);
        spawn2.SetActive(true);
        spawn3.SetActive(true);
        spawn4.SetActive(true);
        spawn5.SetActive(true);
        mer.SetActive(true);
}
public void eaten()
{
eat.SetActive(false);
}
public void ringxx()
{
                dis1 = sh1.dis;
                dis2 = sh2.dis;
                dis3 = sh3.dis;
                dis4 = sh4.dis;
                dis5 = sh5.dis;
                if(dis1 == true)
                {
                jing1 = false;
                sh1.jing = jing1;
                }
                if(dis2 == true)
                {
                jing2 = false;
                sh2.jing = jing2;
                }
                if(dis3 == true)
                {
                jing3 = false;
                sh3.jing = jing3;
                }
                if(dis4 == true)
                {
                jing4 = false;
                sh4.jing = jing4;
                }
                if(dis5 == true)
                {
                jing5 = false;
                sh5.jing = jing5;
                }
}
public void ringxx2()
{
                sh1.dis = true;
                sh2.dis = true;
                sh3.dis = true;
                sh4.dis = true;
                sh5.dis = true;
                dis1 = sh1.dis;
                dis2 = sh2.dis;
                dis3 = sh3.dis;
                dis4 = sh4.dis;
                dis5 = sh5.dis;
    foreach (Transform hijo in cmx.transform)
    {
        hijo.gameObject.SetActive(false);
    }
                if(dis1 == true)
                {
                jing1 = false;
                sh1.jing = jing1;
                }
                if(dis2 == true)
                {
                jing2 = false;
                sh2.jing = jing2;
                }
                if(dis3 == true)
                {
                jing3 = false;
                sh3.jing = jing3;
                }
                if(dis4 == true)
                {
                jing4 = false;
                sh4.jing = jing4;
                }
                if(dis5 == true)
                {
                jing5 = false;
                sh5.jing = jing5;
                }
}
}
